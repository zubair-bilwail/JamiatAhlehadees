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
    public class AddMadarsaBusiness : IAddMadarsa
    {
        private readonly IGenericPattern<tbl_AddMadarsa> _tbl_AddMadarsa;
        private readonly AddMadarsa _AddMadarsa;
        public AddMadarsaBusiness()
        {
            _tbl_AddMadarsa = new GenericPattern<tbl_AddMadarsa>();
            _AddMadarsa = new AddMadarsa();
        }


        public List<AddMadarsa> MadarsaList()
        {
            List<AddMadarsa> _AddMadarsaList = new List<AddMadarsa>();
            var AddMadarsaData = _tbl_AddMadarsa.GetAll().ToList();
            _AddMadarsaList = (from item in AddMadarsaData
                               select new AddMadarsa
                               {
                                   Id = item.Id,
                                   MadarsaName = item.MadarsaName,
                                   HeadUserId = item.HeadUserId,
                                   HeadUserName = (item.tbl_User != null) ? item.tbl_User.Name : string.Empty,
                                   HalqaId = item.HalqaId,
                                   HalqaName = (item.tbl_AddHalqa != null) ? item.tbl_AddHalqa.HalqaName : string.Empty,
                                   Latitude = item.Latitude,
                                   Longitude = item.Longitude,
                                   CreatedDate = item.CreatedDate,
                                   CreatedBy = item.CreatedBy,
                                   Status = item.Status
                               }).OrderByDescending(x => x.Id).ToList();
            return _AddMadarsaList;
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
                                 Status = item.Status
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

        public AddMadarsa GetMadarsaDetails(AddMadarsa model)
        {
            model = model ?? new AddMadarsa();
            if (model.Id != 0)
            {
                model.AddMadarsaList = MadarsaList();
                model.UserList = UserList();
                model.AddHAlqaList = HalqaList();
            }
            model.AddMadarsaList = MadarsaList();

            return model;
        }

        public int SaveMadarsa(AddMadarsa model)
        {
            tbl_AddMadarsa _tbl_addMadarsa = new tbl_AddMadarsa(model);
            if (model.Id != null && model.Id != 0)
            {
                _tbl_addMadarsa.Status = true;
                _tbl_AddMadarsa.Update(_tbl_addMadarsa);

            }
            else
            {
                _tbl_addMadarsa.CreatedDate = System.DateTime.Now;
                _tbl_addMadarsa.CreatedBy = 1;
                _tbl_addMadarsa.Status = true;
                _tbl_addMadarsa = _tbl_AddMadarsa.Insert(_tbl_addMadarsa);
            }

            return _tbl_addMadarsa.Id;
        }

        public AddMadarsa GetById(int id)
        {
            AddMadarsa _AddMadarsa = new AddMadarsa();
            var MadarsabyId = _tbl_AddMadarsa.GetById(id);
            MadarsabyId = MadarsabyId ?? new tbl_AddMadarsa();
            _AddMadarsa = new AddMadarsa
            {
                Id = MadarsabyId.Id,
                MadarsaName = MadarsabyId.MadarsaName,
                HeadUserId = MadarsabyId.HeadUserId,
                HeadUserName = (MadarsabyId.tbl_User != null) ? MadarsabyId.tbl_User.Name : string.Empty,
                HalqaId = MadarsabyId.HalqaId,
                HalqaName = (MadarsabyId.tbl_AddHalqa != null) ? MadarsabyId.tbl_AddHalqa.HalqaName : string.Empty,
                Latitude = MadarsabyId.Latitude,
                Longitude = MadarsabyId.Longitude,
                CreatedDate = MadarsabyId.CreatedDate,
                CreatedBy = MadarsabyId.CreatedBy,
                Status = MadarsabyId.Status
            };
            return _AddMadarsa;
        }

        public void Delete(AddMadarsa entity)
        {

            tbl_AddMadarsa AddMadarsaData = new tbl_AddMadarsa(entity);
            using (System.Transactions.TransactionScope scope = new System.Transactions.TransactionScope())
            {
                if (entity.Id != null && entity.Id != 0)
                {
                    _tbl_AddMadarsa.Delete(AddMadarsaData.Id);

                }
                scope.Complete();
            }
        }
    }
}