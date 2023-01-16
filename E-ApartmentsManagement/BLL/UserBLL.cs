using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_ApartmentsManagement.BLL
{
    internal class UserBLL
    {
        public int userId { get; set; }
        public String firstName { get; set; }
        public String lastName { get; set; }

        public String role { get; set; }

        public String nic { get; set; }

        public String address { get; set; }

        public String contact { get; set; }

        public String gender { get; set; }

        public string email { get; set; }
        public string username { get; set; }
        public string password { get; set; }

        public DateTime added_date { get; set; }
    }
}
