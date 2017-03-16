namespace DataAcessLayer.DataModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tbl_UserRole
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tbl_UserRole()
        {
            tbl_Login = new HashSet<tbl_Login>();
            tbl_User = new HashSet<tbl_User>();
        }

        public int Id { get; set; }

        [StringLength(10)]
        public string Role { get; set; }

        [StringLength(50)]
        public string Name { get; set; }

        public int? CreatedBy { get; set; }

        [Column(TypeName = "date")]
        public DateTime? CreatedDate { get; set; }

        public bool? Status { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_Login> tbl_Login { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_User> tbl_User { get; set; }
    }
}
