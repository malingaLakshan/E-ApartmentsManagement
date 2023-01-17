using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_ApartmentsManagement.BLL
{
    internal class ParkingBLL
    {
        public int id { get; set; }
        public String name { get; set; }
        public String description { get; set; }

        public Boolean active_state { get; set; }


        public DateTime added_date { get; set; }

        public int added_by { get; set; }
    }
}
