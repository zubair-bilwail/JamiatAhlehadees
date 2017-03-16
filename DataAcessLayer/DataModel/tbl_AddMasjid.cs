namespace DataAcessLayer.DataModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tbl_AddMasjid
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tbl_AddMasjid()
        {
            tbl_AddMasjidCommittee = new HashSet<tbl_AddMasjidCommittee>();
            tbl_MasjidExtension = new HashSet<tbl_MasjidExtension>();
            tbl_MasjidLandRequest = new HashSet<tbl_MasjidLandRequest>();
            tbl_MasjidRenovation = new HashSet<tbl_MasjidRenovation>();
        }

        public int Id { get; set; }

        [StringLength(50)]
        public string MasjidName { get; set; }

        public int? SadarUserId { get; set; }

        public int? HalqaId { get; set; }

        [StringLength(50)]
        public string Lattitude { get; set; }

        [StringLength(50)]
        public string Longitude { get; set; }

        [Column(TypeName = "date")]
        public DateTime? CreatedDate { get; set; }

        public int? CreatedBy { get; set; }

        public bool? Status { get; set; }

        public virtual tbl_AddHalqa tbl_AddHalqa { get; set; }

        public virtual tbl_User tbl_User { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_AddMasjidCommittee> tbl_AddMasjidCommittee { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_MasjidExtension> tbl_MasjidExtension { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_MasjidLandRequest> tbl_MasjidLandRequest { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_MasjidRenovation> tbl_MasjidRenovation { get; set; }
    }
}
