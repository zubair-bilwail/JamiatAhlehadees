using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonLayer.CommonModels
{
    public class MadarsaLandRequest
    {
        public int Id { get; set; }

        public int? MadarsaId { get; set; }

        public int? UserId { get; set; }

        public string Location { get; set; }

        public int? LandArea { get; set; }

        public int? LandPrice { get; set; }

        public int? TotalLandValue { get; set; }

        public string PurchasingFrom { get; set; }

        public int? AmountPaid { get; set; }

        public int? AmountNeeded { get; set; }

        public string TimePeriod { get; set; }

        public int? CommitteId { get; set; }

        public int? CommitteHead { get; set; }

        public string Picture1 { get; set; }

        public string Picture2 { get; set; }

        public string Picture3 { get; set; }

        public string Picture4 { get; set; }

        public bool? ReligiouPlaces { get; set; }

        public string ReligiousPlaceDetails { get; set; }

        public string ReligiousPlaceHowFar { get; set; }

        public DateTime? CreatedDate { get; set; }

        public int? CreatedBy { get; set; }

        public bool? Status { get; set; }

        public virtual List<AddMadarsa> AddMadarsaList { get; set; }

        public virtual List<AddMadarsaCommittee> AddMadarsaCommitteeList { get; set; }

        public virtual List<User> UserList { get; set; }
    }
}
