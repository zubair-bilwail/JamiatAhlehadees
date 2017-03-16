namespace DataAcessLayer.DataModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tbl_AddMasjidCommittee
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tbl_AddMasjidCommittee()
        {
            tbl_AddMasjidCommitteeMember = new HashSet<tbl_AddMasjidCommitteeMember>();
            tbl_MasjidConstruction = new HashSet<tbl_MasjidConstruction>();
            tbl_MasjidExtension = new HashSet<tbl_MasjidExtension>();
            tbl_MasjidLandRequest = new HashSet<tbl_MasjidLandRequest>();
        }

        public int Id { get; set; }

        [StringLength(50)]
        public string CommitteeName { get; set; }

        public int? MasjidId { get; set; }

        [Column(TypeName = "date")]
        public DateTime? CreatedDate { get; set; }

        public int? CreatedBy { get; set; }

        public bool? Status { get; set; }

        public virtual tbl_AddMasjid tbl_AddMasjid { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_AddMasjidCommitteeMember> tbl_AddMasjidCommitteeMember { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_MasjidConstruction> tbl_MasjidConstruction { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_MasjidExtension> tbl_MasjidExtension { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_MasjidLandRequest> tbl_MasjidLandRequest { get; set; }
    }
}
