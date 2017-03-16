using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonLayer.CommonModels
{
    public class UserRole
    {
        public int Id { get; set; }

        public string Role { get; set; }

        public string Name { get; set; }

        public int? CreatedBy { get; set; }

        public DateTime? CreatedDate { get; set; }

        public bool? Status { get; set; }

        public List<UserRole> UserRoleList { get; set; }
    }
}
