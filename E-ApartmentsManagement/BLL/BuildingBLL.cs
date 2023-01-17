using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_ApartmentsManagement.BLL
{
    internal class BuildingBLL
    {
        public int id { get; set; }
        public String name { get; set; }
        public String city { get; set; }

        public String address { get; set; }

        public String contact { get; set; }

        public DateTime added_date { get; set; }

        public int added_by { get; set; }
    }
}
