namespace DataAcessLayer.DataModel
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class JamiatDb : DbContext
    {
        public JamiatDb()
            : base("name=JamiatDb")
        {
        }

        public virtual DbSet<tbl_AddHalqa> tbl_AddHalqa { get; set; }
        public virtual DbSet<tbl_AddMadarsa> tbl_AddMadarsa { get; set; }
        public virtual DbSet<tbl_AddMadarsaCommittee> tbl_AddMadarsaCommittee { get; set; }
        public virtual DbSet<tbl_AddMasjid> tbl_AddMasjid { get; set; }
        public virtual DbSet<tbl_AddMasjidCommittee> tbl_AddMasjidCommittee { get; set; }
        public virtual DbSet<tbl_AddMasjidCommitteeMember> tbl_AddMasjidCommitteeMember { get; set; }
        public virtual DbSet<tbl_Approval> tbl_Approval { get; set; }
        public virtual DbSet<tbl_ExistingMadarsaOperations> tbl_ExistingMadarsaOperations { get; set; }
        public virtual DbSet<tbl_Login> tbl_Login { get; set; }
        public virtual DbSet<tbl_MadarsaLandRequest> tbl_MadarsaLandRequest { get; set; }
        public virtual DbSet<tbl_MasjidConstruction> tbl_MasjidConstruction { get; set; }
        public virtual DbSet<tbl_MasjidExtension> tbl_MasjidExtension { get; set; }
        public virtual DbSet<tbl_MasjidLandRequest> tbl_MasjidLandRequest { get; set; }
        public virtual DbSet<tbl_MasjidRenovation> tbl_MasjidRenovation { get; set; }
        public virtual DbSet<tbl_NewMadarsaOperations> tbl_NewMadarsaOperations { get; set; }
        public virtual DbSet<tbl_Request> tbl_Request { get; set; }
        public virtual DbSet<tbl_User> tbl_User { get; set; }
        public virtual DbSet<tbl_UserRole> tbl_UserRole { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<tbl_AddHalqa>()
                .Property(e => e.HalqaName)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_AddHalqa>()
                .Property(e => e.Area)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_AddHalqa>()
                .HasMany(e => e.tbl_AddMadarsa)
                .WithOptional(e => e.tbl_AddHalqa)
                .HasForeignKey(e => e.HalqaId);

            modelBuilder.Entity<tbl_AddHalqa>()
                .HasMany(e => e.tbl_AddMasjid)
                .WithOptional(e => e.tbl_AddHalqa)
                .HasForeignKey(e => e.HalqaId);

            modelBuilder.Entity<tbl_AddMadarsa>()
                .Property(e => e.MadarsaName)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_AddMadarsa>()
                .Property(e => e.Latitude)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_AddMadarsa>()
                .Property(e => e.Longitude)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_AddMadarsa>()
                .HasMany(e => e.tbl_AddMadarsaCommittee)
                .WithOptional(e => e.tbl_AddMadarsa)
                .HasForeignKey(e => e.MadarsaId);

            modelBuilder.Entity<tbl_AddMadarsa>()
                .HasMany(e => e.tbl_MadarsaLandRequest)
                .WithOptional(e => e.tbl_AddMadarsa)
                .HasForeignKey(e => e.MadarsaId);

            modelBuilder.Entity<tbl_AddMadarsaCommittee>()
                .Property(e => e.CommitteeName)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_AddMadarsaCommittee>()
                .HasMany(e => e.tbl_ExistingMadarsaOperations)
                .WithOptional(e => e.tbl_AddMadarsaCommittee)
                .HasForeignKey(e => e.CommitteeId);

            modelBuilder.Entity<tbl_AddMadarsaCommittee>()
                .HasMany(e => e.tbl_MadarsaLandRequest)
                .WithOptional(e => e.tbl_AddMadarsaCommittee)
                .HasForeignKey(e => e.CommitteId);

            modelBuilder.Entity<tbl_AddMadarsaCommittee>()
                .HasMany(e => e.tbl_NewMadarsaOperations)
                .WithOptional(e => e.tbl_AddMadarsaCommittee)
                .HasForeignKey(e => e.CommitteeId);

            modelBuilder.Entity<tbl_AddMasjid>()
                .Property(e => e.MasjidName)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_AddMasjid>()
                .Property(e => e.Lattitude)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_AddMasjid>()
                .Property(e => e.Longitude)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_AddMasjid>()
                .HasMany(e => e.tbl_AddMasjidCommittee)
                .WithOptional(e => e.tbl_AddMasjid)
                .HasForeignKey(e => e.MasjidId);

            modelBuilder.Entity<tbl_AddMasjid>()
                .HasMany(e => e.tbl_MasjidExtension)
                .WithOptional(e => e.tbl_AddMasjid)
                .HasForeignKey(e => e.MasjidId);

            modelBuilder.Entity<tbl_AddMasjid>()
                .HasMany(e => e.tbl_MasjidLandRequest)
                .WithOptional(e => e.tbl_AddMasjid)
                .HasForeignKey(e => e.MasjidId);

            modelBuilder.Entity<tbl_AddMasjid>()
                .HasMany(e => e.tbl_MasjidRenovation)
                .WithOptional(e => e.tbl_AddMasjid)
                .HasForeignKey(e => e.MasjidId);

            modelBuilder.Entity<tbl_AddMasjidCommittee>()
                .Property(e => e.CommitteeName)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_AddMasjidCommittee>()
                .HasMany(e => e.tbl_AddMasjidCommitteeMember)
                .WithRequired(e => e.tbl_AddMasjidCommittee)
                .HasForeignKey(e => e.CommitteeId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tbl_AddMasjidCommittee>()
                .HasMany(e => e.tbl_MasjidConstruction)
                .WithOptional(e => e.tbl_AddMasjidCommittee)
                .HasForeignKey(e => e.CommitteeId);

            modelBuilder.Entity<tbl_AddMasjidCommittee>()
                .HasMany(e => e.tbl_MasjidExtension)
                .WithOptional(e => e.tbl_AddMasjidCommittee)
                .HasForeignKey(e => e.CommitteeId);

            modelBuilder.Entity<tbl_AddMasjidCommittee>()
                .HasMany(e => e.tbl_MasjidLandRequest)
                .WithOptional(e => e.tbl_AddMasjidCommittee)
                .HasForeignKey(e => e.CommitteId);

            modelBuilder.Entity<tbl_Approval>()
                .Property(e => e.Comment)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_ExistingMadarsaOperations>()
                .Property(e => e.HeadMasterName)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_ExistingMadarsaOperations>()
                .Property(e => e.Head)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_ExistingMadarsaOperations>()
                .Property(e => e.SourceofRevenue)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_ExistingMadarsaOperations>()
                .Property(e => e.Location)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_ExistingMadarsaOperations>()
                .Property(e => e.Address)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_ExistingMadarsaOperations>()
                .Property(e => e.Picture1)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_ExistingMadarsaOperations>()
                .Property(e => e.Picture2)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_ExistingMadarsaOperations>()
                .Property(e => e.Picture3)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_ExistingMadarsaOperations>()
                .Property(e => e.Picture4)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_ExistingMadarsaOperations>()
                .HasMany(e => e.tbl_Approval)
                .WithOptional(e => e.tbl_ExistingMadarsaOperations)
                .HasForeignKey(e => e.RequestId);

            modelBuilder.Entity<tbl_Login>()
                .Property(e => e.Mobile)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_Login>()
                .Property(e => e.Password)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_MadarsaLandRequest>()
                .Property(e => e.Location)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_MadarsaLandRequest>()
                .Property(e => e.PurchasingFrom)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_MadarsaLandRequest>()
                .Property(e => e.TimePeriod)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_MadarsaLandRequest>()
                .Property(e => e.Picture1)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_MadarsaLandRequest>()
                .Property(e => e.Picture2)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_MadarsaLandRequest>()
                .Property(e => e.Picture3)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_MadarsaLandRequest>()
                .Property(e => e.Picture4)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_MadarsaLandRequest>()
                .Property(e => e.ReligiousPlaceDetails)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_MadarsaLandRequest>()
                .Property(e => e.ReligiousPlaceHowFar)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_MadarsaLandRequest>()
                .HasMany(e => e.tbl_Approval)
                .WithOptional(e => e.tbl_MadarsaLandRequest)
                .HasForeignKey(e => e.RequestId);

            modelBuilder.Entity<tbl_MasjidConstruction>()
                .Property(e => e.Location)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_MasjidConstruction>()
                .Property(e => e.EngineerName)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_MasjidConstruction>()
                .Property(e => e.EngineerContact)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_MasjidConstruction>()
                .Property(e => e.PlanImg)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_MasjidConstruction>()
                .Property(e => e.ConstructionImg1)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_MasjidConstruction>()
                .Property(e => e.ConstructionImg2)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_MasjidConstruction>()
                .Property(e => e.ConstructionImg3)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_MasjidConstruction>()
                .HasMany(e => e.tbl_Approval)
                .WithOptional(e => e.tbl_MasjidConstruction)
                .HasForeignKey(e => e.RequestId);

            modelBuilder.Entity<tbl_MasjidExtension>()
                .Property(e => e.Location)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_MasjidExtension>()
                .Property(e => e.EngineerName)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_MasjidExtension>()
                .Property(e => e.EngineerContact)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_MasjidExtension>()
                .Property(e => e.PlanImg)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_MasjidExtension>()
                .Property(e => e.ConstructionImg1)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_MasjidExtension>()
                .Property(e => e.ConstructionImg2)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_MasjidExtension>()
                .Property(e => e.ConstructionImg3)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_MasjidExtension>()
                .HasMany(e => e.tbl_Approval)
                .WithOptional(e => e.tbl_MasjidExtension)
                .HasForeignKey(e => e.RequestId);

            modelBuilder.Entity<tbl_MasjidLandRequest>()
                .Property(e => e.Location)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_MasjidLandRequest>()
                .Property(e => e.PurchasingFrom)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_MasjidLandRequest>()
                .Property(e => e.TimePeriod)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_MasjidLandRequest>()
                .Property(e => e.Picture1)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_MasjidLandRequest>()
                .Property(e => e.Picture2)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_MasjidLandRequest>()
                .Property(e => e.Picture3)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_MasjidLandRequest>()
                .Property(e => e.Picture4)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_MasjidLandRequest>()
                .Property(e => e.ReligiousPlaceDetails)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_MasjidLandRequest>()
                .Property(e => e.ReligiousPlaceHowFar)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_MasjidLandRequest>()
                .HasMany(e => e.tbl_Approval)
                .WithOptional(e => e.tbl_MasjidLandRequest)
                .HasForeignKey(e => e.RequestId);

            modelBuilder.Entity<tbl_MasjidRenovation>()
                .Property(e => e.Location)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_MasjidRenovation>()
                .Property(e => e.EngineerName)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_MasjidRenovation>()
                .Property(e => e.EngineerContact)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_MasjidRenovation>()
                .Property(e => e.PlanImg)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_MasjidRenovation>()
                .Property(e => e.ConstructionImg1)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_MasjidRenovation>()
                .Property(e => e.ConstructionImg2)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_MasjidRenovation>()
                .Property(e => e.ConstructionImg3)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_MasjidRenovation>()
                .HasMany(e => e.tbl_Approval)
                .WithOptional(e => e.tbl_MasjidRenovation)
                .HasForeignKey(e => e.RequestId);

            modelBuilder.Entity<tbl_NewMadarsaOperations>()
                .Property(e => e.SourceofRevenue)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_NewMadarsaOperations>()
                .Property(e => e.Location)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_NewMadarsaOperations>()
                .Property(e => e.Address)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_NewMadarsaOperations>()
                .Property(e => e.Picture1)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_NewMadarsaOperations>()
                .Property(e => e.Picture2)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_NewMadarsaOperations>()
                .Property(e => e.Picture3)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_NewMadarsaOperations>()
                .Property(e => e.Picture4)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_NewMadarsaOperations>()
                .HasMany(e => e.tbl_Approval)
                .WithOptional(e => e.tbl_NewMadarsaOperations)
                .HasForeignKey(e => e.RequestId);

            modelBuilder.Entity<tbl_Request>()
                .Property(e => e.tblRequestType)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_Request>()
                .HasMany(e => e.tbl_Approval)
                .WithOptional(e => e.tbl_Request)
                .HasForeignKey(e => e.RequestType);

            modelBuilder.Entity<tbl_Request>()
                .HasMany(e => e.tbl_ExistingMadarsaOperations)
                .WithOptional(e => e.tbl_Request)
                .HasForeignKey(e => e.RequestId);

            modelBuilder.Entity<tbl_Request>()
                .HasMany(e => e.tbl_ExistingMadarsaOperations1)
                .WithOptional(e => e.tbl_Request1)
                .HasForeignKey(e => e.RequestId);

            modelBuilder.Entity<tbl_Request>()
                .HasMany(e => e.tbl_MadarsaLandRequest)
                .WithOptional(e => e.tbl_Request)
                .HasForeignKey(e => e.RequestId);

            modelBuilder.Entity<tbl_Request>()
                .HasMany(e => e.tbl_MasjidConstruction)
                .WithOptional(e => e.tbl_Request)
                .HasForeignKey(e => e.RequestId);

            modelBuilder.Entity<tbl_Request>()
                .HasMany(e => e.tbl_MasjidExtension)
                .WithOptional(e => e.tbl_Request)
                .HasForeignKey(e => e.RequestId);

            modelBuilder.Entity<tbl_Request>()
                .HasMany(e => e.tbl_MasjidRenovation)
                .WithOptional(e => e.tbl_Request)
                .HasForeignKey(e => e.RequestId);

            modelBuilder.Entity<tbl_Request>()
                .HasMany(e => e.tbl_NewMadarsaOperations)
                .WithOptional(e => e.tbl_Request)
                .HasForeignKey(e => e.RequestId);

            modelBuilder.Entity<tbl_User>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_User>()
                .Property(e => e.Mobile)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_User>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_User>()
                .Property(e => e.Password)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_User>()
                .Property(e => e.Area)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_User>()
                .HasMany(e => e.tbl_AddMadarsa)
                .WithOptional(e => e.tbl_User)
                .HasForeignKey(e => e.HeadUserId);

            modelBuilder.Entity<tbl_User>()
                .HasMany(e => e.tbl_AddMasjid)
                .WithOptional(e => e.tbl_User)
                .HasForeignKey(e => e.SadarUserId);

            modelBuilder.Entity<tbl_User>()
                .HasMany(e => e.tbl_AddMasjidCommitteeMember)
                .WithOptional(e => e.tbl_User)
                .HasForeignKey(e => e.UserID);

            modelBuilder.Entity<tbl_User>()
                .HasMany(e => e.tbl_Login)
                .WithRequired(e => e.tbl_User)
                .HasForeignKey(e => e.UserId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tbl_User>()
                .HasMany(e => e.tbl_MadarsaLandRequest)
                .WithOptional(e => e.tbl_User)
                .HasForeignKey(e => e.UserId);

            modelBuilder.Entity<tbl_User>()
                .HasMany(e => e.tbl_MasjidConstruction)
                .WithOptional(e => e.tbl_User)
                .HasForeignKey(e => e.UserId);

            modelBuilder.Entity<tbl_User>()
                .HasMany(e => e.tbl_MasjidExtension)
                .WithOptional(e => e.tbl_User)
                .HasForeignKey(e => e.UserId);

            modelBuilder.Entity<tbl_User>()
                .HasMany(e => e.tbl_MasjidLandRequest)
                .WithOptional(e => e.tbl_User)
                .HasForeignKey(e => e.UserId);

            modelBuilder.Entity<tbl_User>()
                .HasMany(e => e.tbl_MasjidRenovation)
                .WithOptional(e => e.tbl_User)
                .HasForeignKey(e => e.UserId);

            modelBuilder.Entity<tbl_User>()
                .HasMany(e => e.tbl_NewMadarsaOperations)
                .WithOptional(e => e.tbl_User)
                .HasForeignKey(e => e.UserId);

            modelBuilder.Entity<tbl_UserRole>()
                .Property(e => e.Role)
                .IsFixedLength();

            modelBuilder.Entity<tbl_UserRole>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_UserRole>()
                .HasMany(e => e.tbl_Login)
                .WithRequired(e => e.tbl_UserRole)
                .HasForeignKey(e => e.RoleId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tbl_UserRole>()
                .HasMany(e => e.tbl_User)
                .WithRequired(e => e.tbl_UserRole)
                .HasForeignKey(e => e.RoleId)
                .WillCascadeOnDelete(false);
        }
    }
}
