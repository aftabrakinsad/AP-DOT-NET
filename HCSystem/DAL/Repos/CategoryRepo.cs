using DAL.HCS_EF_DF;
using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    public class CategoryRepo : IRepo<Category, int>
    {
        public HCSystemEntities db = new HCSystemEntities();
        public void Add(Category obj)
        {
            db.Categories.Add(obj);
            db.SaveChanges();
        }

        public void Delete(int id)
        {
            var cat = db.Categories.Find(id);
            db.Categories.Remove(cat);
            db.SaveChanges();
        }

        public void Edit(Category obj)
        {
            var cat = db.Categories.Find(obj.id);
            cat.name = obj.name;
            db.SaveChanges();
        }

        public List<Category> Get()
        {
            return db.Categories.ToList();
        }

        public Category Get(string name)
        {
            return db.Categories.FirstOrDefault(u => u.name.Equals(name));
        }

        public Category Get(int id)
        {
            throw new NotImplementedException();
        }
    }
}
