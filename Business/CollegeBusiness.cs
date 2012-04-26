using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Model;
using Service;

namespace Business
{
    public class CollegeBusiness
    {
        public CollegeBusiness()
        {

        }
        public DataTable getAllCollege()
        {
            return new CollegeService().getAllCollege();
        }
    }
}
