using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShoppingCartModels.EntityModels;

namespace ShoppingCartDLL.DbContext
{
   public class AppDbContext : IdentityDbContext<User>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            this.SeedUsers(builder);
            this.SeedRoles(builder);
            this.SeedUserRoles(builder);
        }
        public DbSet<Product> Products { get; set; }

        public DbSet<Post> Posts { get; set; }
        private void SeedUsers(ModelBuilder builder)
        {
            PasswordHasher<User> passwordHasher = new PasswordHasher<User>();

            User user = new User()
            {
                FirstName = "Admin",
                Id = "b74ddd14-6340-4840-95c2-db12554843e5",
                UserName = "Admin",
                Email = "admin@gmail.com",
                NormalizedUserName= "Admin",
                NormalizedEmail= "admin@gmail.com",
                LockoutEnabled = false,
                PhoneNumber = "1234567890"
            };
            user.PasswordHash = passwordHasher.HashPassword(user, "Admin@123");

            builder.Entity<User>().HasData(user);

            User user1 = new User()
            {
                FirstName = "User",
                Id = "F7A13C3E-EB62-4193-9653-CB3BB571DADF",
                UserName = "User",
                Email = "user@gmail.com",
                NormalizedUserName = "User",
                NormalizedEmail = "user@gmail.com",
                LockoutEnabled = false,
                PhoneNumber = "1234567890"
            };
            user1.PasswordHash = passwordHasher.HashPassword(user1, "User@123");

            builder.Entity<User>().HasData(user1);
        }

        private void SeedRoles(ModelBuilder builder)
        {
            builder.Entity<IdentityRole>().HasData(
                new IdentityRole() { Id = "fab4fac1-c546-41de-aebc-a14da6895711", Name = "Admin", ConcurrencyStamp = "1", NormalizedName = "Admin" },
                new IdentityRole() { Id = "c7b013f0-5201-4317-abd8-c211f91b7330", Name = "User", ConcurrencyStamp = "2", NormalizedName = "User" }
                );
        }

        private void SeedUserRoles(ModelBuilder builder)
        {
            builder.Entity<IdentityUserRole<string>>().HasData(
              new IdentityUserRole<string>() { RoleId = "fab4fac1-c546-41de-aebc-a14da6895711", UserId = "b74ddd14-6340-4840-95c2-db12554843e5" },
              new IdentityUserRole<string>() { RoleId= "c7b013f0-5201-4317-abd8-c211f91b7330", UserId= "F7A13C3E-EB62-4193-9653-CB3BB571DADF" }
            );
        }


    }
}
