using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_ApartmentsManagement.BLL
{
    internal class ApartmentBLL
    {
        public int id { get; set; }
        public String name { get; set; }

        public String location { get; set; }

        public String floarArea { get; set; }

        public String apartmentStates { get; set; }

        public int buildingId { get; set; }

        public int parkingSpaceId { get; set; }

        public int classTypeId { get; set; }


        public String description { get; set; }
        public Boolean active_state { get; set; }
        public DateTime added_date { get; set; }

        public int added_by { get; set; }

        public DateTime available_date { get; set; }
    }
}
