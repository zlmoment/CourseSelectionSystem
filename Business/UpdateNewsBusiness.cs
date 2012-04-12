using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Service;
using Model;

namespace Business
{
    public class UpdateNewsBusiness
    {
        public UpdateNewsBusiness()
        {
        }
        public bool updateNewsBusiness(NewsModel newsModel)
        {
            return new NewsService().update(newsModel);
        }
    }
}
