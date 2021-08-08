using OOP_Test4.Entity;
using OOP_Test4.Dal;

namespace OOP_Test4.Dal
{
    public interface ICategoryRepository : IRepository<Category>
    {

        Category[] GetCategories();
    }
}