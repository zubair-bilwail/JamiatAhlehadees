using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonLayer.CommonModels
{
    public class AddMadarsa
    {
        public int Id { get; set; }

        public string MadarsaName { get; set; }

        public int? HeadUserId { get; set; }

        public string HeadUserName { get; set; }

        public int? HalqaId { get; set; }

        public string HalqaName { get; set; }

        public string Latitude { get; set; }

        public string Longitude { get; set; }

        public DateTime? CreatedDate { get; set; }

        public int? CreatedBy { get; set; }

        public bool? Status { get; set; }

        public List<User> UserList { get; set; }

        public List<AddHalqa> AddHAlqaList { get; set; }

        public List<AddMadarsa> AddMadarsaList { get; set; }

    }
}
