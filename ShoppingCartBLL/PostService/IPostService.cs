using ShoppingCartModels.EntityModels;
using ShoppingCartModels.EntityModels.ModelDto;

namespace ShoppingCartBLL.PostService
{
    public interface IPostService
    {
        Task InsertPost(PostDto postDto);
        Task<IEnumerable<Post>> GetAllMethod();
    }
}