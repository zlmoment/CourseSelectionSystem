using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Model;
using System.Data;
using Service;

namespace Business
{
    public class StudentBusiness
    {
        public StudentBusiness()
        {
        }
        public DataTable getAllStudent()
        {
            StudentService stuService = new StudentService();
            return stuService.getAllStudent();
        }
    }
}
