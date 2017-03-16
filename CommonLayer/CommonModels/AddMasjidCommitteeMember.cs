using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonLayer.CommonModels
{
   public class AddMasjidCommitteeMember
    {
        public int Id { get; set; }

        public int CommitteeId { get; set; }

        public string CommitteeName { get; set; }

        public int? UserID { get; set; }

        public string UserName { get; set; }

        public int? CreatedBy { get; set; }

        public DateTime? CreateDate { get; set; }

        public bool? Status { get; set; }

        public virtual List<AddMasjidCommittee> AddMasjidCommitteeList { get; set; }

        public virtual List<User> UserList { get; set; }

        public List<AddMasjidCommitteeMember> AddMasjidCommitteeMemberList { get; set; }
    }
}
