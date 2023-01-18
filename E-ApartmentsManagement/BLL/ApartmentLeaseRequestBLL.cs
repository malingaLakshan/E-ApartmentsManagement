using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_ApartmentsManagement.BLL
{
    internal class ApartmentLeaseRequestBLL
    {
        public int id { get; set; }

        public String location { get; set; }


        public int apartmentId { get; set; }

        public int buildingId { get; set; }

        public int parkingSpaceId { get; set; }

        public int classTypeId { get; set; }

        public String leasingPieriod { get; set; }

        public String leasingStatus { get; set; }


        public String approvalStatus { get; set; }
        public Boolean approveState { get; set; }
        public DateTime added_date { get; set; }

        public int added_by { get; set; }

        public DateTime required_date { get; set; }

        public int addedUserId { get; set; }

        public String addedUserName { get; set; }

        public int approvedUserId { get; set; }

        public String approvedUserName { get; set; }
    }
}
