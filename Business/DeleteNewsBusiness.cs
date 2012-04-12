using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Model;
using Service;


namespace Business
{
    public class DeleteNewsBusiness
    {
        public DeleteNewsBusiness()
        {
        }

        public bool delete(int[] toBeDeleted)
        {
            NewsService newsService = new NewsService();
            return (newsService.delete(toBeDeleted) == true);
        }
    }
}
