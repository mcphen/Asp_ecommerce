using ProjectCore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectCore.Repository
{
    public class MookCategoryRepository : ICategoryRepository
    {
        public IEnumerable<Category> GetAllCategories()
        {
            return new List<Category>()
            {
                new Category{CategoryId=1, CategoryName="Big Data", Description="cours sur le big data"},
                new Category{CategoryId=2, CategoryName="Database", Description="cours sur les bases de donnees"},
                new Category{CategoryId=3, CategoryName="Front-End", Description="cours sur le front-end"},
                new Category{CategoryId=4, CategoryName="Bacj-End", Description="cours sur le back-end"}
            };
        }

        public Category GetCategoryById(int id)
        {
            return GetAllCategories().FirstOrDefault(c => c.CategoryId == id);
        }
    }
}
