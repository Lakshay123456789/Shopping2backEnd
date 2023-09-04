using ShoppingCartModels.EntityModels;
using ShoppingCartModels.ModelDto;

namespace ShoppingCartBLL.ProductServices
{
    public interface IProductService
    {
        Task DeleteMethod(Guid obj);
        Task<IEnumerable<Product>> GetAllMethod();
        Task<Product> GetByIdMethod(Guid id);
        Task InsertMethod(ProductDto obj);
        Task UpdateMethod(ProductDto obj, Guid Id);
    }
}