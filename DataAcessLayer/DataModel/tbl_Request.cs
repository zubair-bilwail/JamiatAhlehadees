namespace DataAcessLayer.DataModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tbl_Request
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tbl_Request()
        {
            tbl_Approval = new HashSet<tbl_Approval>();
            tbl_ExistingMadarsaOperations = new HashSet<tbl_ExistingMadarsaOperations>();
            tbl_ExistingMadarsaOperations1 = new HashSet<tbl_ExistingMadarsaOperations>();
            tbl_MadarsaLandRequest = new HashSet<tbl_MadarsaLandRequest>();
            tbl_MasjidConstruction = new HashSet<tbl_MasjidConstruction>();
            tbl_MasjidExtension = new HashSet<tbl_MasjidExtension>();
            tbl_MasjidRenovation = new HashSet<tbl_MasjidRenovation>();
            tbl_NewMadarsaOperations = new HashSet<tbl_NewMadarsaOperations>();
        }

        public int Id { get; set; }

        [StringLength(50)]
        public string tblRequestType { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_Approval> tbl_Approval { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_ExistingMadarsaOperations> tbl_ExistingMadarsaOperations { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_ExistingMadarsaOperations> tbl_ExistingMadarsaOperations1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_MadarsaLandRequest> tbl_MadarsaLandRequest { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_MasjidConstruction> tbl_MasjidConstruction { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_MasjidExtension> tbl_MasjidExtension { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_MasjidRenovation> tbl_MasjidRenovation { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_NewMadarsaOperations> tbl_NewMadarsaOperations { get; set; }
    }
}
