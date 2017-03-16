namespace DataAcessLayer.DataModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tbl_MadarsaLandRequest
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tbl_MadarsaLandRequest()
        {
            tbl_Approval = new HashSet<tbl_Approval>();
        }

        public int Id { get; set; }

        public int? MadarsaId { get; set; }

        public int? UserId { get; set; }

        [StringLength(50)]
        public string Location { get; set; }

        public int? LandArea { get; set; }

        public int? LandPrice { get; set; }

        public int? TotalLandValue { get; set; }

        [StringLength(50)]
        public string PurchasingFrom { get; set; }

        public int? AmountPaid { get; set; }

        public int? AmountNeeded { get; set; }

        [StringLength(50)]
        public string TimePeriod { get; set; }

        public int? CommitteId { get; set; }

        public int? CommitteHead { get; set; }

        [StringLength(200)]
        public string Picture1 { get; set; }

        [StringLength(200)]
        public string Picture2 { get; set; }

        [StringLength(200)]
        public string Picture3 { get; set; }

        [StringLength(200)]
        public string Picture4 { get; set; }

        public bool? ReligiouPlaces { get; set; }

        [StringLength(100)]
        public string ReligiousPlaceDetails { get; set; }

        [StringLength(50)]
        public string ReligiousPlaceHowFar { get; set; }

        [Column(TypeName = "date")]
        public DateTime? CreatedDate { get; set; }

        public int? CreatedBy { get; set; }

        public bool? Status { get; set; }

        public int? RequestId { get; set; }

        public virtual tbl_AddMadarsa tbl_AddMadarsa { get; set; }

        public virtual tbl_AddMadarsaCommittee tbl_AddMadarsaCommittee { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_Approval> tbl_Approval { get; set; }

        public virtual tbl_Request tbl_Request { get; set; }

        public virtual tbl_User tbl_User { get; set; }
    }
}
