using OOP_Test4.Entity;
using OOP_Test4.Dal;

namespace OOP_Test4.Dal
{
    public class EfCategoryDal : ICategoryRepository
    {
        public Category GetById(int id){
            throw new System.NotImplementedException();
        }
        public void Create(Category p){
            System.Console.WriteLine("EfCategory created.");
        }
        public void Update(Category p){
            throw new System.NotImplementedException();
        }
        public void Delete(int id){
            throw new System.NotImplementedException();
        }

        public Category[] GetCategories(){
            throw new System.NotImplementedException();
        }
    }
}