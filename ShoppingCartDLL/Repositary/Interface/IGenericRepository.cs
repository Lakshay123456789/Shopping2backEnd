namespace ShoppingCartDLL.Repositary.Interface
{
    public interface IGenericRepository<T>
    {
        Task Delete(Guid id);
        Task<IEnumerable<T>> GetAll();
        Task<T> GetById(Guid id);
        Task Insert(T obj);
        Task Save();
        Task Update(T obj);
    }
}