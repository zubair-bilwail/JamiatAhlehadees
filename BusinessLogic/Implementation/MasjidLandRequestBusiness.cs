using BusinessLogic.Interface;
using CommonLayer.CommonModels;
using DataAcessLayer.DataModel;
using DataAcessLayer.Generic_Pattern.Implementation;
using DataAcessLayer.Generic_Pattern.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Implementation
{
    public class MasjidLandRequestBusiness : IMasjidLandRequest
    {
        //public class AddHalqaBusiness : IAddHalqa

        private readonly IGenericPattern<tbl_MasjidLandRequest> _tbl_MasjidLandRequest;
        private readonly MasjidLandRequest _MasjidLandRequest;
        public MasjidLandRequestBusiness()
        {
            _tbl_MasjidLandRequest = new GenericPattern<tbl_MasjidLandRequest>();
            _MasjidLandRequest = new MasjidLandRequest();
        }


        public List<MasjidLandRequest> LandRequestList()
        {
            List<MasjidLandRequest> _MasjidLandRequest = new List<MasjidLandRequest>();

            var AddMasjidLandData = _tbl_MasjidLandRequest.GetAll().ToList();
            _MasjidLandRequest = (from item in AddMasjidLandData
                                  select new MasjidLandRequest
                                  {
                                      Id = item.Id,
                                      MasjidId = item.MasjidId,
                                      MasjidName = (item.tbl_AddMasjid != null)? item.tbl_AddMasjid.MasjidName : string.Empty,
                                      UserId = item.UserId,
                                      UserName = (item.tbl_User != null) ? item.tbl_User.Name : string.Empty,
                                      Location = item.Location,
                                      LandArea = item.LandArea,
                                      LandPrice = item.LandPrice,
                                      TotalLandValue = item.TotalLandValue,
                                      PurchasingFrom = item.PurchasingFrom,
                                      AmountPaid = item.AmountPaid,
                                      AmountNeeded = item.AmountNeeded,
                                      TimePeriod = item.TimePeriod,
                                      CommitteId = item.CommitteId,
                                      CommitteeName = (item.tbl_AddMasjidCommittee != null) ? item.tbl_AddMasjidCommittee.CommitteeName : string.Empty,
                                      CommitteHead = item.CommitteHead,
                                      CommitteHeadName = (item.tbl_User != null) ? item.tbl_User.Name : string.Empty,
                                      Picture1 = item.Picture1,
                                      Picture2 = item.Picture2,
                                      Picture3 = item.Picture3,
                                      Picture4 = item.Picture4,
                                      ReligiouPlaces = item.ReligiouPlaces,
                                      ReligiousPlaceDetails = item.ReligiousPlaceDetails,
                                      ReligiousPlaceHowFar = item.ReligiousPlaceHowFar,
                                      CreatedDate = item.CreatedDate,
                                      CreatedBy = item.CreatedBy,
                                      Status = item.Status

                                  }).OrderByDescending(x => x.Id).ToList();
            return _MasjidLandRequest;
        }

        public List<AddMasjidCommittee> MasjidCommitteeList()
        {
            GenericPattern<tbl_AddMasjidCommittee> _tbl_AddMasjidCommittee = new GenericPattern<tbl_AddMasjidCommittee>();
            List<AddMasjidCommittee> _AddMasjidCommitteeList = new List<AddMasjidCommittee>();
            var AddMasjidCommitteeData = _tbl_AddMasjidCommittee.GetAll().ToList();
            _AddMasjidCommitteeList = (from item in AddMasjidCommitteeData
                                       select new AddMasjidCommittee
                                       {
                                           Id = item.Id,
                                           CommitteeName = item.CommitteeName,
                                           MasjidId = item.MasjidId,
                                           MasjidName = (item.tbl_AddMasjid != null) ? item.tbl_AddMasjid.MasjidName : string.Empty,
                                           CreatedDate = item.CreatedDate,
                                           CreatedBy = item.CreatedBy,
                                           Status = item.Status
                                       }).OrderByDescending(x => x.Id).ToList();
            return _AddMasjidCommitteeList;
        }

        public List<AddMasjid> MasjidList()
        {
            GenericPattern<tbl_AddMasjid> _tbl_AddMasjid = new GenericPattern<tbl_AddMasjid>();
            List<AddMasjid> _AddMasjidList = new List<AddMasjid>();
            var AddMasjidData = _tbl_AddMasjid.FindBy(x => x.Status == true).ToList();
            _AddMasjidList = (from item in AddMasjidData
                              select new AddMasjid
                              {
                                  Id = item.Id,
                                  MasjidName = item.MasjidName,
                                  SadarUserId = item.SadarUserId,
                                  SadarUserName = (item.tbl_User != null) ? item.tbl_User.Name : string.Empty,
                                  HalqaId = item.HalqaId,
                                  HalqaName = (item.tbl_AddHalqa != null) ? item.tbl_AddHalqa.HalqaName : string.Empty,
                                  Lattitude = item.Lattitude,
                                  Longitude = item.Longitude,
                                  CreatedBy = item.CreatedBy,
                                  CreatedDate = item.CreatedDate,
                                  Status = item.Status
                              }).OrderByDescending(x => x.Id).ToList();
            return _AddMasjidList;
        }

        public List<User> UserList()
        {
            GenericPattern<tbl_User> _tbl_User = new GenericPattern<tbl_User>();
            List<User> _UserList = new List<User>();
            var UserData = _tbl_User.GetAll().ToList();
            _UserList = (from item in UserData
                         select new User
                         {
                             Id = item.Id,
                             Name = item.Name,
                             Mobile = item.Mobile,
                             Email = item.Email,
                             Password = item.Password,
                             Area = item.Area,
                             CreatedDate = item.CreatedDate,
                             CreatedBy = item.CreatedBy,
                             Status = item.Status
                         }).OrderByDescending(x => x.Id).ToList();
            return _UserList;
        }

        public MasjidLandRequest GetMasjidLandRequestDetails(MasjidLandRequest model)
        {
            model = model ?? new MasjidLandRequest();
            if (model.Id != 0)
            {
                model.MasjidLandRequestList = LandRequestList();
                model.AddMasjidList = MasjidList();
                model.UserList = UserList();
            }
            model.MasjidLandRequestList = LandRequestList();

            return model;

        }

        public int SaveMasjidLandRequest(MasjidLandRequest model)
        {
            tbl_MasjidLandRequest _tbl_masjidLandRequest = new tbl_MasjidLandRequest(model);
#pragma warning disable CS0472 // The result of the expression is always the same since a value of this type is never equal to 'null'
            if (model.Id != null && model.Id != 0)
#pragma warning restore CS0472 // The result of the expression is always the same since a value of this type is never equal to 'null'
            {
                _tbl_masjidLandRequest.Status = true;
                _tbl_MasjidLandRequest.Update(_tbl_masjidLandRequest);

            }
            else
            {
                _tbl_masjidLandRequest.CreatedBy = 1;
                _tbl_masjidLandRequest.CreatedDate = System.DateTime.Now;
                _tbl_masjidLandRequest.Status = true;
                _tbl_masjidLandRequest = _tbl_MasjidLandRequest.Insert(_tbl_masjidLandRequest);
            }

            return _tbl_masjidLandRequest.Id;
        }

        public MasjidLandRequest GetById(int id)
        {
            MasjidLandRequest _masjidLandRequest = new MasjidLandRequest();
            var item = _tbl_MasjidLandRequest.GetById(id);
            item = item ?? new tbl_MasjidLandRequest();
            _masjidLandRequest = new MasjidLandRequest
            {
                Id = item.Id,
                MasjidId = item.MasjidId,
                MasjidName = (item.tbl_AddMasjid != null) ? item.tbl_AddMasjid.MasjidName : string.Empty,
                UserId = item.UserId,
                UserName = (item.tbl_User != null) ? item.tbl_User.Name : string.Empty,
                Location = item.Location,
                LandArea = item.LandArea,
                LandPrice = item.LandPrice,
                TotalLandValue = item.TotalLandValue,
                PurchasingFrom = item.PurchasingFrom,
                AmountPaid = item.AmountPaid,
                AmountNeeded = item.AmountNeeded,
                TimePeriod = item.TimePeriod,
                CommitteId = item.CommitteId,
                CommitteeName = (item.tbl_AddMasjidCommittee != null) ? item.tbl_AddMasjidCommittee.CommitteeName : string.Empty,
                CommitteHead = item.CommitteHead,
                CommitteHeadName = (item.tbl_User != null) ? item.tbl_User.Name : string.Empty,
                Picture1 = item.Picture1,
                Picture2 = item.Picture2,
                Picture3 = item.Picture3,
                Picture4 = item.Picture4,
                ReligiouPlaces = item.ReligiouPlaces,
                ReligiousPlaceDetails = item.ReligiousPlaceDetails,
                ReligiousPlaceHowFar = item.ReligiousPlaceHowFar,
                CreatedDate = item.CreatedDate,
                CreatedBy = item.CreatedBy,
                Status = item.Status
            };
            return _masjidLandRequest;
        }

        public void Delete(MasjidLandRequest entity)
        {

            tbl_MasjidLandRequest AddMasjidLandRequestData = new tbl_MasjidLandRequest(entity);
            using (System.Transactions.TransactionScope scope = new System.Transactions.TransactionScope())
            {
                if (entity.Id != null && entity.Id != 0)
                {
                    AddMasjidLandRequestData.Id = entity.Id;
                    AddMasjidLandRequestData.Status = false;
                    _tbl_MasjidLandRequest.Update(AddMasjidLandRequestData);

                }
                scope.Complete();
            }

        }
    }
}
