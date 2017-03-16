namespace DataAcessLayer.DataModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tbl_AddHalqa
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tbl_AddHalqa()
        {
            tbl_AddMadarsa = new HashSet<tbl_AddMadarsa>();
            tbl_AddMasjid = new HashSet<tbl_AddMasjid>();
        }

        public int Id { get; set; }

        [StringLength(50)]
        public string HalqaName { get; set; }

        [StringLength(50)]
        public string Area { get; set; }

        public int? CreatedBy { get; set; }

        [Column(TypeName = "date")]
        public DateTime? CreatedDate { get; set; }

        public bool? Status { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_AddMadarsa> tbl_AddMadarsa { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_AddMasjid> tbl_AddMasjid { get; set; }
    }
}
