using DLL.Database;
using DLL.Inferface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLL.Repos
{
    class NewsRepo : IREPO<News, int>
    {
        public void Create(News item)
        {
            var db = new FT_LAB_ONEEntities();
            db.News.Add(item);
            db.SaveChanges();
        }

        public void Delete(int id)
        {
            var db = new FT_LAB_ONEEntities();
            var news = (from cd in db.News
                        where cd.Id == id
                        select cd).SingleOrDefault();
        }

        public List<News> Get()
        {
            var db = new FT_LAB_ONEEntities();
            var get = db.News.ToList();
            return get;
        }

        public News Get(int id)
        {
            var db = new FT_LAB_ONEEntities();
            var neww = (from cd in db.News
                       where cd.Id == id
                       select cd).SingleOrDefault();
            return neww;
        }

        public void Update(News obj)
        {
            var db = new FT_LAB_ONEEntities();
            var emp = (from ed in db.News
                       where ed.Id == obj.Id
                       select ed).SingleOrDefault();
            emp.Title= obj.Title;
            emp.Category = obj.Category;
            emp.Date = obj.Date;
            db.SaveChanges();
        }
    }
}
