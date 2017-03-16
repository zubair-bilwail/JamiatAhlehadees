namespace DataAcessLayer.DataModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tbl_Approval
    {
        public int Id { get; set; }

        public int? RequestType { get; set; }

        public int? RequestId { get; set; }

        [StringLength(200)]
        public string Comment { get; set; }

        public bool? Status { get; set; }

        public virtual tbl_ExistingMadarsaOperations tbl_ExistingMadarsaOperations { get; set; }

        public virtual tbl_MadarsaLandRequest tbl_MadarsaLandRequest { get; set; }

        public virtual tbl_MasjidConstruction tbl_MasjidConstruction { get; set; }

        public virtual tbl_MasjidExtension tbl_MasjidExtension { get; set; }

        public virtual tbl_MasjidLandRequest tbl_MasjidLandRequest { get; set; }

        public virtual tbl_MasjidRenovation tbl_MasjidRenovation { get; set; }

        public virtual tbl_NewMadarsaOperations tbl_NewMadarsaOperations { get; set; }

        public virtual tbl_Request tbl_Request { get; set; }
    }
}
