namespace DataAcessLayer.DataModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tbl_AddMadarsa
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tbl_AddMadarsa()
        {
            tbl_AddMadarsaCommittee = new HashSet<tbl_AddMadarsaCommittee>();
            tbl_MadarsaLandRequest = new HashSet<tbl_MadarsaLandRequest>();
        }

        public int Id { get; set; }

        [StringLength(50)]
        public string MadarsaName { get; set; }

        public int? HeadUserId { get; set; }

        public int? HalqaId { get; set; }

        [StringLength(50)]
        public string Latitude { get; set; }

        [StringLength(50)]
        public string Longitude { get; set; }

        [Column(TypeName = "date")]
        public DateTime? CreatedDate { get; set; }

        public int? CreatedBy { get; set; }

        public bool? Status { get; set; }

        public virtual tbl_AddHalqa tbl_AddHalqa { get; set; }

        public virtual tbl_User tbl_User { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_AddMadarsaCommittee> tbl_AddMadarsaCommittee { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_MadarsaLandRequest> tbl_MadarsaLandRequest { get; set; }
    }
}
