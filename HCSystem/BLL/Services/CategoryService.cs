using BLL.DTOs;
using DAL.HCS_EF_DF;
using DAL.Repos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class CategoryService
    {
        public static CatrgoryDTO GetCategory(string name)
        {
            var dbcategory = new CategoryRepo().Get(name);
            if (dbcategory != null)
            {
                var category = new CatrgoryDTO()
                {
                    name = dbcategory.name,
                    id = dbcategory.id,
                };
                return category;
            }
            return null;
        }
        public static List<CatrgoryDTO> GetCategory()
        {
            var dbcategory = new CategoryRepo().Get().ToList();
            List<CatrgoryDTO> category = new List<CatrgoryDTO>();

            foreach (var cat in dbcategory)
            {
                category.Add(new CatrgoryDTO() { 
                    id = cat.id,
                    name = cat.name
                });
            }

            return category;
        }

        public static void CreateCategory(CatrgoryDTO news)
        {
            Category n = new Category()
            {
                name = news.name,
            };

            new CategoryRepo().Add(n);
        }
        public static void EditCategory(CatrgoryDTO category)
        {
            var cat = new CategoryRepo().Get(category.name);
            if (cat != null)
            {
                cat.id = category.id;
                cat.name = category.name;
            }

            new CategoryRepo().Edit(cat);
        }
        public static void DeleteCategory(CatrgoryDTO category)
        {
            new CategoryRepo().Delete(category.id);
        }
    }
}
