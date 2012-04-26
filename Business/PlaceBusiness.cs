using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Model;
using System.Data;
using Service;

namespace Business
{
    public class PlaceBusiness
    {
        public PlaceBusiness()
        {

        }
        public DataTable getAllPlace()
        {
            return new PlaceService().getAllPlace();
        }
    }
}
