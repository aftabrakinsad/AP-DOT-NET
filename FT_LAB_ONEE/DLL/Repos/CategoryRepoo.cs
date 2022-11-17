using DLL.Database;
using DLL.Inferface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLL.Repos
{
    class CategoryRepoo : IREPO<Category, int>
    {
        public void Create(Category item)
        {
            var db = new FT_LAB_ONEEntities();
            db.Categories.Add(item);
            db.SaveChanges();
        }

        public void Delete(int id)
        {
            var db = new FT_LAB_ONEEntities();
            var category = (from cd in db.Categories
                         where cd.Id == id
                         select cd).SingleOrDefault();
        }

        public List<Category> Get()
        {
            var db = new FT_LAB_ONEEntities();
            var get = db.Categories.ToList();
            return get;
        }

        public Category Get(int id)
        {
            var db = new FT_LAB_ONEEntities();
            var cat = (from cd in db.Categories
                            where cd.Id == id
                            select cd).SingleOrDefault();
            return cat;
        }

        public void Update(Category obj)
        {
            var db = new FT_LAB_ONEEntities();
            var emp = (from ed in db.Categories
                       where ed.Id == obj.Id
                       select ed).SingleOrDefault();
            emp.Name = obj.Name;
            db.SaveChanges();
        }
    }
}
