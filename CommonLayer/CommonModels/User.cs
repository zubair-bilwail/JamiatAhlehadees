using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonLayer.CommonModels
{
    public class User
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Mobile { get; set; }

        public string Email { get; set; }

        public string Password { get; set; }

        public string Area { get; set; }

        public int RoleId { get; set; }

        public int? RoleName { get; set; }

        public int? CreatedBy { get; set; }

        public DateTime? CreatedDate { get; set; }

        public bool? Status { get; set; }

        public virtual List<UserRole> UserRoleList { get; set; }

        public List<User> UserList { get; set; }
    }
}
