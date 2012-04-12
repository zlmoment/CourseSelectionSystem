using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Service;
using Model;

namespace Business
{
    public class AddNewsBusiness
    {
        public bool addnews(NewsModel newsModel)
        {
            NewsService newsService = new NewsService();
            int nid = 0;
            nid = newsService.insert(newsModel);
            if (nid == 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
