namespace DataAcessLayer.DataModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tbl_Login
    {
        public int Id { get; set; }

        public int UserId { get; set; }

        [Required]
        [StringLength(50)]
        public string Mobile { get; set; }

        [Required]
        [StringLength(50)]
        public string Password { get; set; }

        public int RoleId { get; set; }

        public bool Status { get; set; }

        public int? CreatedBy { get; set; }

        [Column(TypeName = "date")]
        public DateTime? CreatedDate { get; set; }

        public virtual tbl_User tbl_User { get; set; }

        public virtual tbl_UserRole tbl_UserRole { get; set; }
    }
}
