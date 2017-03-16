namespace DataAcessLayer.DataModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tbl_User
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tbl_User()
        {
            tbl_AddMadarsa = new HashSet<tbl_AddMadarsa>();
            tbl_AddMasjid = new HashSet<tbl_AddMasjid>();
            tbl_AddMasjidCommitteeMember = new HashSet<tbl_AddMasjidCommitteeMember>();
            tbl_Login = new HashSet<tbl_Login>();
            tbl_MadarsaLandRequest = new HashSet<tbl_MadarsaLandRequest>();
            tbl_MasjidConstruction = new HashSet<tbl_MasjidConstruction>();
            tbl_MasjidExtension = new HashSet<tbl_MasjidExtension>();
            tbl_MasjidLandRequest = new HashSet<tbl_MasjidLandRequest>();
            tbl_MasjidRenovation = new HashSet<tbl_MasjidRenovation>();
            tbl_NewMadarsaOperations = new HashSet<tbl_NewMadarsaOperations>();
        }

        public int Id { get; set; }

        [StringLength(50)]
        public string Name { get; set; }

        [Required]
        [StringLength(50)]
        public string Mobile { get; set; }

        [StringLength(50)]
        public string Email { get; set; }

        [Required]
        [StringLength(50)]
        public string Password { get; set; }

        [StringLength(50)]
        public string Area { get; set; }

        public int RoleId { get; set; }

        public int? CreatedBy { get; set; }

        [Column(TypeName = "date")]
        public DateTime? CreatedDate { get; set; }

        public bool? Status { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_AddMadarsa> tbl_AddMadarsa { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_AddMasjid> tbl_AddMasjid { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_AddMasjidCommitteeMember> tbl_AddMasjidCommitteeMember { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_Login> tbl_Login { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_MadarsaLandRequest> tbl_MadarsaLandRequest { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_MasjidConstruction> tbl_MasjidConstruction { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_MasjidExtension> tbl_MasjidExtension { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_MasjidLandRequest> tbl_MasjidLandRequest { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_MasjidRenovation> tbl_MasjidRenovation { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_NewMadarsaOperations> tbl_NewMadarsaOperations { get; set; }

        public virtual tbl_UserRole tbl_UserRole { get; set; }
    }
}
