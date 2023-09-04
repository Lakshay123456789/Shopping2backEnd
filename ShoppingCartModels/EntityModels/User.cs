using Microsoft.EntityFrameworkCore.ChangeTracking.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IdentityModel;
using Microsoft.AspNetCore.Identity;

namespace ShoppingCartModels.EntityModels
{
    public class User : IdentityUser
    {
        [Required]
        public string? FirstName { get; set; }
        public string? LastName { get; set; }

    }
}
