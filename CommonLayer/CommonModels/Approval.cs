using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonLayer.CommonModels
{
    public class Approval
    {
        public int Id { get; set; }

        public int? RequestType { get; set; }

        public string RequestTypeName { get; set; }

        public int? RequestId { get; set; }

        public string Comment { get; set; }

        public bool? Status { get; set; }

        public virtual List<ExistingMadarsaOperations> tbl_ExistingMadarsaOperations { get; set; }

        public virtual List<MadarsaLandRequest> tbl_MadarsaLandRequest { get; set; }

        public virtual List<MasjidConstruction> tbl_MasjidConstruction { get; set; }

        public virtual List<MasjidExtension> tbl_MasjidExtension { get; set; }

        public virtual List<MasjidLandRequest> tbl_MasjidLandRequest { get; set; }

        public virtual List<MasjidRenovation> tbl_MasjidRenovation { get; set; }

        public virtual List<NewMadarsaOperation> tbl_NewMadarsaOperations { get; set; }

        public virtual List<Request> tbl_Request { get; set; }
    }
}
