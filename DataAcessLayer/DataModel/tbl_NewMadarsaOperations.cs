namespace DataAcessLayer.DataModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tbl_NewMadarsaOperations
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tbl_NewMadarsaOperations()
        {
            tbl_Approval = new HashSet<tbl_Approval>();
        }

        public int Id { get; set; }

        public int? UserId { get; set; }

        public int? CommitteeId { get; set; }

        public int? HeadMasterName { get; set; }

        public int? Head { get; set; }

        public int? ExpectedStudents { get; set; }

        public int? Boys { get; set; }

        public int? Girls { get; set; }

        public int? Teachers { get; set; }

        public bool? Residential { get; set; }

        public int? MonthlyCost { get; set; }

        public int? PerStudentCost { get; set; }

        [StringLength(50)]
        public string SourceofRevenue { get; set; }

        [StringLength(50)]
        public string Location { get; set; }

        [StringLength(50)]
        public string Address { get; set; }

        public bool? OwnRented { get; set; }

        public int? TotalLandArea { get; set; }

        public int? ConstructedArea { get; set; }

        [StringLength(200)]
        public string Picture1 { get; set; }

        [StringLength(250)]
        public string Picture2 { get; set; }

        [StringLength(250)]
        public string Picture3 { get; set; }

        [StringLength(250)]
        public string Picture4 { get; set; }

        public bool? ChargingStudent { get; set; }

        public int? Howmuch { get; set; }

        [Column(TypeName = "date")]
        public DateTime? CreateDate { get; set; }

        public int? CreatedBy { get; set; }

        public bool? Status { get; set; }

        public int? RequestId { get; set; }

        public virtual tbl_AddMadarsaCommittee tbl_AddMadarsaCommittee { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_Approval> tbl_Approval { get; set; }

        public virtual tbl_Request tbl_Request { get; set; }

        public virtual tbl_User tbl_User { get; set; }
    }
}
