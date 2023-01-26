using DAL.HCS_EF_DF;
using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    public class NewsRepo : IRepo<News, int>
    {
        HCSystemEntities db = new HCSystemEntities();
        public void Add(News obj)
        {
            db.News.Add(obj);
            db.SaveChanges();
        }

        public void Delete(int id)
        {
            var n = db.News.Find(id);
            db.News.Remove(n);
            db.SaveChanges();
        }

        public void Edit(News obj)
        {
            var n = db.News.Find(obj.id);
            n.title = obj.title;
            n.date = obj.date;
            n.categoryId = obj.categoryId;
            
            db.SaveChanges();
        }

        public List<News> Get()
        {
            return db.News.ToList();
        }

        public News Get(string title)
        {
            return db.News.FirstOrDefault(u => u.title.Equals(title));
        }

        public News Get(int id)
        {
            throw new NotImplementedException();
        }
    }
}
