namespace DataAcessLayer.DataModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tbl_AddMadarsaCommittee
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tbl_AddMadarsaCommittee()
        {
            tbl_ExistingMadarsaOperations = new HashSet<tbl_ExistingMadarsaOperations>();
            tbl_MadarsaLandRequest = new HashSet<tbl_MadarsaLandRequest>();
            tbl_NewMadarsaOperations = new HashSet<tbl_NewMadarsaOperations>();
        }

        public int Id { get; set; }

        [StringLength(50)]
        public string CommitteeName { get; set; }

        public int? MadarsaId { get; set; }

        [Column(TypeName = "date")]
        public DateTime? CreatedDate { get; set; }

        public int? CreatedBy { get; set; }

        public bool? Status { get; set; }

        public virtual tbl_AddMadarsa tbl_AddMadarsa { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_ExistingMadarsaOperations> tbl_ExistingMadarsaOperations { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_MadarsaLandRequest> tbl_MadarsaLandRequest { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_NewMadarsaOperations> tbl_NewMadarsaOperations { get; set; }
    }
}
