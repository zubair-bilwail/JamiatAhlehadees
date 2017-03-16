using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonLayer.CommonModels
{
    public class AddMasjidCommittee
    {
        public int Id { get; set; }

        public string CommitteeName { get; set; }

        public int? MasjidId { get; set; }

        public string MasjidName { get; set; }

        public DateTime? CreatedDate { get; set; }

        public int? CreatedBy { get; set; }

        public bool? Status { get; set; }

        public List<AddMasjid> AddMasjidList { get; set; }

        public List<User> UserList{ get; set; }

        public List<AddMasjidCommittee> AddMasjidCummitteList { get; set; }
    }
}
