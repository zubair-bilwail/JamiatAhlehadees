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
    public class AddMasjidBusiness : IAddMasjid
    {
        private readonly IGenericPattern<tbl_AddMasjid> _tbl_AddMasjid;
        private AddMasjid _AddMasjid;
        public AddMasjidBusiness()
        {
            _tbl_AddMasjid = new GenericPattern<tbl_AddMasjid>();
            _AddMasjid = new AddMasjid();
        }


        public List<AddMasjid> MasjidList()
        {
            List<AddMasjid> _AddMasjidList = new List<AddMasjid>();
            var AddMasjidData = _tbl_AddMasjid.GetAll().ToList();
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

        public List<AddHalqa> HalqaList()
        {
            GenericPattern<tbl_AddHalqa> _tbl_AddHalqa = new GenericPattern<tbl_AddHalqa>();
            List<AddHalqa> _AddHalqaList = new List<AddHalqa>();
            var AddHalqaData = _tbl_AddHalqa.GetAll().ToList();
            _AddHalqaList = (from item in AddHalqaData
                             select new AddHalqa
                             {
                                 Id = item.Id,
                                 HalqaName = item.HalqaName,
                                 Area = item.Area,
                                 CreatedDate = item.CreatedDate,
                                 CreatedBy = item.CreatedBy,
                                 Status = item.Status,
                             }).OrderByDescending(x => x.Id).ToList();
            return _AddHalqaList;
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

        public AddMasjid GetMasjidDetails(AddMasjid model)
        {
            model = model ?? new AddMasjid();
            if (model.Id != 0)
            {
                model.AddMasjidList = MasjidList();
                model.AddHalqaList = HalqaList();
                model.UserList = UserList();
            }
            model.AddMasjidList = MasjidList();

            return model;

        }

        public int SaveMasjid(AddMasjid model)
        {
            tbl_AddMasjid _tbl_addmasjid = new tbl_AddMasjid(model);
            if (model.Id != null && model.Id != 0)
            {
                _tbl_addmasjid.Status = true;
                _tbl_AddMasjid.Update(_tbl_addmasjid);

            }
            else
            {
                _tbl_addmasjid.CreatedBy = 1;
                _tbl_addmasjid.CreatedDate = System.DateTime.Now;
                _tbl_addmasjid.Status = true;
                _tbl_addmasjid = _tbl_AddMasjid.Insert(_tbl_addmasjid);
            }

            return _tbl_addmasjid.Id;
        }

        public AddMasjid GetById(int id)
        {
            AddMasjid _AddMasjid = new AddMasjid();
            var MasjidbyId = _tbl_AddMasjid.GetById(id);
            MasjidbyId = MasjidbyId ?? new tbl_AddMasjid();
            _AddMasjid = new AddMasjid
            {
                Id = MasjidbyId.Id,
                MasjidName = MasjidbyId.MasjidName,
                SadarUserId = MasjidbyId.SadarUserId,
                SadarUserName = (MasjidbyId.tbl_User != null) ? MasjidbyId.tbl_User.Name : string.Empty,
                HalqaId = MasjidbyId.HalqaId,
                HalqaName = (MasjidbyId.tbl_AddHalqa != null) ? MasjidbyId.tbl_AddHalqa.HalqaName : string.Empty,
                Lattitude = MasjidbyId.Lattitude,
                Longitude = MasjidbyId.Longitude,
                CreatedBy = MasjidbyId.CreatedBy,
                CreatedDate = MasjidbyId.CreatedDate,
                Status = MasjidbyId.Status
            };
            return _AddMasjid;
        }

        public void Delete(AddMasjid entity)
        {

            tbl_AddMasjid AddMasjidData = new tbl_AddMasjid(entity);
            using (System.Transactions.TransactionScope scope = new System.Transactions.TransactionScope())
            {
                if (entity.Id != null && entity.Id != 0)
                {
                    _tbl_AddMasjid.Delete(AddMasjidData.Id);

                }
                scope.Complete();
            }
        }
    }
}
