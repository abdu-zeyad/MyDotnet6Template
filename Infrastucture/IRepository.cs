namespace Template.Infrastucture
{
    public interface IRepository<T> where T : class
    {
        Task<T> Create(T entity);

        // GET ALL

        Task<List<T>> GetAll();

        // GET ONE BY ID
        Task<T> GetById(int id);

        // UPDATE
        Task<T> Update(int id, T entity);

        // DELETE
        Task Delete(int id);
    }
}
