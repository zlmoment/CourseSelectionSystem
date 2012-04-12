using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Model;
using Service;

namespace Business
{
    public class GetAllNewsListBusiness
    {
        public GetAllNewsListBusiness()
        {
        }
        public NewsModel[] getAllNewsList()
        {
            NewsModel[] newsModelList;
            newsModelList = new NewsService().getAllNews();
            return newsModelList;
        }
    }
}
