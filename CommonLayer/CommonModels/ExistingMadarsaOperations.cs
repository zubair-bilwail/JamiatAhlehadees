using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonLayer.CommonModels
{
   public class ExistingMadarsaOperations
    {
        public int Id { get; set; }

        public int? CommitteeId { get; set; }


        public string HeadMasterName { get; set; }

        public string CommitteeName { get; set; }
        public string Head { get; set; }
        public string ImageBase64 { get; set; }
        public int? ExpectedStudents { get; set; }

        public int? Boys { get; set; }

        public int? Girls { get; set; }

        public int? Teachers { get; set; }

        public bool? Residential { get; set; }

        public int? MonthlyCost { get; set; }

        public int? PerStudentCost { get; set; }


        public string SourceofRevenue { get; set; }


        public string Location { get; set; }


        public string Address { get; set; }

        public bool? OwnRented { get; set; }

        public int? TotalLandArea { get; set; }

        public int? ConstructedArea { get; set; }


        public string Picture1 { get; set; }


        public string Picture2 { get; set; }

        public string Picture3 { get; set; }


        public string Picture4 { get; set; }

        public bool? ChargingStudent { get; set; }

        public int? Howmuch { get; set; }


        public DateTime? CreateDate { get; set; }

        public int? CreatedBy { get; set; }

        public bool? Status { get; set; }

        public List<ExistingMadarsaOperations> _ExistingMadarsaOperarionList { get; set; }

        public List<AddMasjidCommittee> _AddMasjidCommitteeList { get; set; }

        public List<AddMadarsaCommittee> _AddMadarsaCommitteeList { get; set; }
    }
}
