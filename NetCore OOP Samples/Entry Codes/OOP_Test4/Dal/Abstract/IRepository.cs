

namespace OOP_Test4.Dal
{
    public interface IRepository<TEntity>
    {
        TEntity GetById(int id);
        void Create(TEntity p);
        void Update(TEntity p);
        void Delete(int id);
    }
}