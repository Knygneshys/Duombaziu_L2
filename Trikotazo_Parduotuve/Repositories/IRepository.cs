namespace Trikotazo_Parduotuve.Repositories
{
    using Trikotazo_Parduotuve.Entities;
    public interface IRepository<T> where T : class
    {
        public Task<List<T>> GetAllAsync();
    }
}
