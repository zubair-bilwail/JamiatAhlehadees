using CommonLayer.CommonModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAcessLayer.DataModel
{
    class PartialClass
    {

    }

    //-- New Madarsa Operations -- //
    public partial class tbl_NewMadarsaOperations
    {
        
        public tbl_NewMadarsaOperations(NewMadarsaOperation _obj)
        {
            Id = _obj.Id;
            HeadMasterName = _obj.HeadMasterName;
            Head = _obj.Head;
            ExpectedStudents = _obj.ExpectedStudents;
            Boys = _obj.Boys;
            Girls = _obj.Girls;
            Teachers = _obj.Teachers;
            Residential = _obj.Residential;
            MonthlyCost = _obj.MonthlyCost;
            PerStudentCost = _obj.PerStudentCost;
            SourceofRevenue = _obj.SourceofRevenue;
            Location = _obj.Location;
            Address = _obj.Address;
            OwnRented = _obj.OwnRented;
            TotalLandArea = _obj.TotalLandArea;
            ConstructedArea = _obj.ConstructedArea;
            ChargingStudent = _obj.ChargingStudent;
            Howmuch = _obj.Howmuch;
            Picture1 = _obj.Picture1;
            Picture2 = _obj.Picture2;
            Picture3 = _obj.Picture3;
            Picture4 = _obj.Picture4;
            Status = _obj.Status;
            UserId = _obj.UserId;
            CommitteeId = Convert.ToInt32(_obj.CommitteeId);
        }
    }

    //-- Request Approval -- //
    public partial class tbl_Approval
    {
        public tbl_Approval()
        {

        }
        public tbl_Approval(Approval _obj)
        {
            Id = _obj.Id;
            RequestType = _obj.RequestType;
            RequestId = _obj.RequestId;
            Comment = _obj.Comment;
            Status = _obj.Status;
        }
    }

    //-- Masjid Extension -- //
    public partial class tbl_MasjidExtension
    {
        

        public tbl_MasjidExtension(MasjidExtension _obj)
        {
            Id = _obj.Id;
            Location = _obj.Location;
            MasjidId = _obj.MasjidId;
            Area = _obj.Area;
            
            ConstructionCost = _obj.ConstructionCost;
            ExistingFloors = _obj.ExistingFloors;
            AmountCollected = _obj.AmountCollected;
            CommitteeId = _obj.CommitteeId;
            UserId = _obj.UserId;
            Head = _obj.Head;
            EngineerName = _obj.EngineerName;
            EngineerContact = _obj.EngineerContact;
            ElevationImg = _obj.ElevationImg;
            PlanImg = _obj.PlanImg;
            ConstructionImg1 = _obj.ConstructionImg1;
            ConstructionImg2 = _obj.ConstructionImg2;
            ConstructionImg3 = _obj.ConstructionImg3;
            CreatedDate = _obj.CreatedDate;
            CreatedBy= _obj.CreatedBy;
            Status = _obj.Status;

        }

        

    }

    //-- Masjid Renovation -- //
    public partial class tbl_MasjidRenovation
    {
        public tbl_MasjidRenovation(MasjidRenovation _obj)
        {
            Id = _obj.Id;
            Location = _obj.Location;
            Area = _obj.Area;
            Head = _obj.Head;
            ConstructionCost = _obj.ConstructionCost;
            Floors = _obj.Floors;
            AmountCollected = _obj.AmountCollected;
            EngineerName = _obj.EngineerName;
            EngineerContact = _obj.EngineerContact;
            PlanImg = _obj.PlanImg;
            ElevationImg = _obj.ElevationImg;
            ConstructionImg1 = _obj.ConstructionImg1;
            ConstructionImg2 = _obj.ConstructionImg2;
            ConstructionImg3 = _obj.ConstructionImg3;
            Status = _obj.Status;
            UserId = _obj.UserId;
            MasjidId = _obj.MasjidId;
            CommitteeId = _obj.CommitteeId;
            
        }

        


    }

    //-- Existing Madarsa Operations -- //
    public partial class tbl_ExistingMadarsaOperations
    {
        

        public tbl_ExistingMadarsaOperations(ExistingMadarsaOperations _obj)
        {
            Id = _obj.Id;
            HeadMasterName = _obj.HeadMasterName;
            Head = _obj.Head;
            ExpectedStudents = _obj.ExpectedStudents;
            Boys = _obj.Boys;
            Girls = _obj.Girls;
            Teachers = _obj.Teachers;
            Residential = _obj.Residential;
            MonthlyCost = _obj.MonthlyCost;
            PerStudentCost = _obj.PerStudentCost;
            SourceofRevenue = _obj.SourceofRevenue;
            Location = _obj.Location;
            Address = _obj.Address;
            OwnRented = _obj.OwnRented;
            TotalLandArea = _obj.TotalLandArea;
            ConstructedArea = _obj.ConstructedArea;
            ChargingStudent = _obj.ChargingStudent;
            Howmuch = _obj.Howmuch;
            Picture1 = _obj.Picture1;
            Picture2 = _obj.Picture2;
            Picture3 = _obj.Picture3;
            Picture4 = _obj.Picture4;
            Status = _obj.Status;
            CommitteeId = Convert.ToInt32(_obj.CommitteeId);

        }  
    }

    //-- Masjid Construction -- //
    public partial class tbl_MasjidConstruction
    {
        
        public tbl_MasjidConstruction(MasjidConstruction _obj)
        {
            Id = _obj.Id;
            Area = _obj.Area;
            Head = _obj.Head;
            ConstructionCost = _obj.ConstructionCost;
            Floors = _obj.Floors;
            AmountCollected = _obj.AmountCollected;
            EngineerName = _obj.EngineerName;
            EngineerContact = _obj.EngineerContact;
            PlanImg = _obj.PlanImg;
            //ElevationImg = _obj.ElevationImg;
            ConstructionImg1 = _obj.ConstructionImg1;
            Location = _obj.Location;
            ConstructionImg2 = _obj.ConstructionImg2;
            ConstructionImg3 = _obj.ConstructionImg3;
            Status = _obj.Status;
            UserId = _obj.UserId;
            CommitteeId = _obj.CommitteeId;
            CreatedDate = _obj.CreatedDate;
            CreatedBy = _obj.CreatedBy;



        }
    }

    //-- Add Madarsa -- //
    public partial class tbl_AddMadarsa
    {
        public tbl_AddMadarsa(AddMadarsa _obj)
        {
            Id = _obj.Id;
            MadarsaName = _obj.MadarsaName;
            HeadUserId = _obj.HeadUserId;
            HalqaId = _obj.HalqaId;
            Latitude = _obj.Latitude;
            Longitude = _obj.Longitude;
            CreatedDate = _obj.CreatedDate;
            CreatedBy = _obj.CreatedBy;
            Status = _obj.Status;

        }
    }

    //-- Add Halqa -- //
    public partial class tbl_AddHalqa
    {
        public tbl_AddHalqa(AddHalqa _obj)
        {
            Id = _obj.Id;
            HalqaName = _obj.HalqaName;
            Area = _obj.Area;
            CreatedBy = _obj.CreatedBy;
            CreatedDate = _obj.CreatedDate;
            Status = _obj.Status;
        }
    }

    //-- Add Masjid -- //
    public partial class tbl_AddMasjid
    {
        public tbl_AddMasjid(AddMasjid _obj)
        {
            Id = _obj.Id;
            MasjidName = _obj.MasjidName;
            SadarUserId = _obj.SadarUserId;
            HalqaId = _obj.HalqaId;
            Lattitude = _obj.Lattitude;
            Longitude = _obj.Longitude;
            CreatedBy = _obj.CreatedBy;
            CreatedDate = _obj.CreatedDate;
            Status = _obj.Status;
        }
    }

    //-- Add Masjid Committee -- //
    public partial class tbl_AddMasjidCommittee
    {
        public tbl_AddMasjidCommittee(AddMasjidCommittee _obj)
        {
            Id = _obj.Id;
            CommitteeName = _obj.CommitteeName;
            MasjidId = _obj.MasjidId;
            CreatedBy = _obj.CreatedBy;
            CreatedDate = _obj.CreatedDate;
            Status = _obj.Status;
        }
    }

    //-- Add Masjid Committee Member -- //
    public partial class tbl_AddMasjidCommitteeMember
    {
        public tbl_AddMasjidCommitteeMember()
        {

        }
        public tbl_AddMasjidCommitteeMember(AddMasjidCommitteeMember _obj)
        {
            Id = _obj.Id;
            CommitteeId = _obj.CommitteeId;
            UserID = _obj.UserID;
            CreatedBy = _obj.CreatedBy;
            CreateDate = _obj.CreateDate;
            Status = _obj.Status;
        }
    }

    //-- Add Madarsa Committee -- //
    public partial class tbl_AddMadarsaCommittee
    {
        public tbl_AddMadarsaCommittee(AddMadarsaCommittee obj)
        {
            Id = obj.Id;
            CommitteeName = obj.CommitteeName;
            MadarsaId = obj.MadarsaId;
            CreatedDate = obj.CreatedDate;
            CreatedBy = obj.CreatedBy;
            Status = obj.Status;
        }
    }

    //-- Madarsa Land Request -- //
    public partial class tbl_MadarsaLandRequest
    {
        

        public tbl_MadarsaLandRequest(MadarsaLandRequest obj)
        {
            Id = obj.Id;
            MadarsaId = obj.MadarsaId;
            UserId = obj.UserId;
            Location = obj.Location;
            LandArea = obj.LandArea;
            LandPrice = obj.LandPrice;
            TotalLandValue = obj.TotalLandValue;
            PurchasingFrom = obj.PurchasingFrom;
            AmountPaid = obj.AmountPaid;
            AmountNeeded = obj.AmountNeeded;
            TimePeriod = obj.TimePeriod;
            CommitteId = obj.CommitteId;
            CommitteHead = obj.CommitteHead;
            Picture1 = obj.Picture1;
            Picture2 = obj.Picture2;
            Picture3 = obj.Picture3;
            Picture4 = obj.Picture4;
            ReligiouPlaces = obj.ReligiouPlaces;
            ReligiousPlaceDetails = obj.ReligiousPlaceDetails;
            ReligiousPlaceHowFar = obj.ReligiousPlaceHowFar;
            CreatedDate = obj.CreatedDate;
            CreatedBy = obj.CreatedBy;
            Status = obj.Status;
        }

    }

    //-- Masjid Land Request -- //
    public partial class tbl_MasjidLandRequest
    {
        
        public tbl_MasjidLandRequest(MasjidLandRequest item)
        {
            Id = item.Id;
            MasjidId = item.MasjidId;
            UserId = item.UserId;
            Location = item.Location;
            LandArea = item.LandArea;
            LandPrice = item.LandPrice;
            TotalLandValue = item.TotalLandValue;
            PurchasingFrom = item.PurchasingFrom;
            AmountPaid = item.AmountPaid;
            AmountNeeded = item.AmountNeeded;
            TimePeriod = item.TimePeriod;
            CommitteId = item.CommitteId;
            CommitteHead = item.CommitteHead;
            Picture1 = item.Picture1;
            Picture2 = item.Picture2;
            Picture3 = item.Picture3;
            Picture4 = item.Picture4;
            ReligiouPlaces = item.ReligiouPlaces;
            ReligiousPlaceDetails = item.ReligiousPlaceDetails;
            ReligiousPlaceHowFar = item.ReligiousPlaceHowFar;
            CreatedDate = item.CreatedDate;
            CreatedBy = item.CreatedBy;
            Status = item.Status;


        }
    }

    //-- User -- //
    public partial class tbl_User
    {
        public tbl_User(User _obj)
        {
            Id = _obj.Id;
            Name = _obj.Name;
            Mobile = _obj.Mobile;
            Email = _obj.Email;
            Password = _obj.Password;
            Area = _obj.Area;
            RoleId = _obj.RoleId;
            CreatedBy = _obj.CreatedBy;
            CreatedDate = _obj.CreatedDate;
            Status = _obj.Status;
        }
    }
}
