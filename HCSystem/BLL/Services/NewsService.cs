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
    public class NewsService
    {
        public static NewsDTO GetNews(string title)
        {
            var dbnews = new NewsRepo().Get(title);
            if (dbnews != null)
            {
                var news = new NewsDTO()
                {
                    id = dbnews.id,
                    categoryId = dbnews.categoryId,
                    Category = dbnews.Category,
                    title = dbnews.title
                };
                return news;
            }
            return null;
        }

        public static List<NewsDTO> GetNews()
        {
            var dbnews = new NewsRepo().Get().ToList();
            List<NewsDTO> news = new List<NewsDTO>();

            foreach (var n in dbnews)
            {
                news.Add(new NewsDTO()
                {
                    id = n.id,
                    title = n.title,
                    categoryId = n.categoryId
                });
            }

            return news;
        }

        public static void CreateNews(NewsDTO news)
        {
            News n = new News() {
                title = news.title,
                categoryId = news.categoryId,
            };

            new NewsRepo().Add(n);
        }
        public static void EditNews(NewsDTO news)
        {
            var n = new NewsRepo().Get(news.title);
            if (n != null)
            {
                n.id = news.id;
                n.title = news.title;
                n.categoryId = news.categoryId;
            }

            new NewsRepo().Edit(n);
        }
        public static void DeleteNews(NewsDTO news)
        {
            new NewsRepo().Delete(news.id);
        }
    }
}
