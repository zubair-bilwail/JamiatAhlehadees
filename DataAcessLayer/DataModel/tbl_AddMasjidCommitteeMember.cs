namespace DataAcessLayer.DataModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tbl_AddMasjidCommitteeMember
    {
        public int Id { get; set; }

        public int CommitteeId { get; set; }

        public int? UserID { get; set; }

        public int? CreatedBy { get; set; }

        [Column(TypeName = "date")]
        public DateTime? CreateDate { get; set; }

        public bool? Status { get; set; }

        public virtual tbl_AddMasjidCommittee tbl_AddMasjidCommittee { get; set; }

        public virtual tbl_User tbl_User { get; set; }
    }
}
