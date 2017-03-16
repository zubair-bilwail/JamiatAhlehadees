using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonLayer.CommonModels
{
    public class AddMadarsaCommittee
    {
        public int Id { get; set; }

        public string CommitteeName { get; set; }

        public int? MadarsaId { get; set; }

        public string MadarsaName { get; set; }

        public DateTime? CreatedDate { get; set; }

        public int? CreatedBy { get; set; }

        public bool? Status { get; set; }

        public virtual List<AddMadarsa> AddMadarsaList { get; set; }

        public List<AddMadarsaCommittee> AddMadarsaCommitteeList { get; set; }
    }
}
