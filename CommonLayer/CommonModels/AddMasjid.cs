using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonLayer.CommonModels
{
    public class AddMasjid
    {
        public int Id { get; set; }

        public string MasjidName { get; set; }

        public int? SadarUserId { get; set; }

        public string SadarUserName { get; set; }

        public int? HalqaId { get; set; }

        public string HalqaName { get; set; }

        public string Lattitude { get; set; }

        public string Longitude { get; set; }

        public DateTime? CreatedDate { get; set; }

        public int? CreatedBy { get; set; }

        public bool? Status { get; set; }

        public List<User> UserList { get; set; }

        public List<AddHalqa> AddHalqaList { get; set; }

        public List<AddMasjid> AddMasjidList { get; set; }

    }
}
