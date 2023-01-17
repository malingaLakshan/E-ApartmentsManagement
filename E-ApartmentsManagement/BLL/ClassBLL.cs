using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_ApartmentsManagement.BLL
{
    internal class ClassBLL
    {
        public int id { get; set; }
        public String name { get; set; }

        public double monthly_rent { get; set; }

        public double max_occupent { get; set; }

        public double reservation_fee { get; set; }

        public double refundable_amount { get; set; }

        public double bedroom_count { get; set; }

        public double common_bathroom_count { get; set; }

        public double attached_bathroom_count { get; set; }

        public double servant_room_count { get; set; }

        public double servant_toilet_count { get; set; }

        public String description { get; set; }
        public Boolean active_state { get; set; }
        public DateTime added_date { get; set; }

       public int added_by { get; set; }

 }
}
