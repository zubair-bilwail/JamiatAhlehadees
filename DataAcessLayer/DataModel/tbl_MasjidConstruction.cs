namespace DataAcessLayer.DataModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tbl_MasjidConstruction
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tbl_MasjidConstruction()
        {
            tbl_Approval = new HashSet<tbl_Approval>();
        }

        public int Id { get; set; }

        [StringLength(50)]
        public string Location { get; set; }

        public int? Area { get; set; }

        public int? ConstructionCost { get; set; }

        public int? Floors { get; set; }

        public int? AmountCollected { get; set; }

        public int? UserId { get; set; }

        public int? CommitteeId { get; set; }

        public int? Head { get; set; }

        [StringLength(50)]
        public string EngineerName { get; set; }

        [StringLength(50)]
        public string EngineerContact { get; set; }

        [MaxLength(200)]
        public byte[] ElevationImg { get; set; }

        [StringLength(200)]
        public string PlanImg { get; set; }

        [StringLength(200)]
        public string ConstructionImg1 { get; set; }

        [StringLength(200)]
        public string ConstructionImg2 { get; set; }

        [StringLength(200)]
        public string ConstructionImg3 { get; set; }

        [Column(TypeName = "date")]
        public DateTime? CreatedDate { get; set; }

        public int? CreatedBy { get; set; }

        public bool? Status { get; set; }

        public int? RequestId { get; set; }

        public virtual tbl_AddMasjidCommittee tbl_AddMasjidCommittee { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_Approval> tbl_Approval { get; set; }

        public virtual tbl_Request tbl_Request { get; set; }

        public virtual tbl_User tbl_User { get; set; }
    }
}
