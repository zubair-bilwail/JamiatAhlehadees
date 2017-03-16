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
   public class AddMadarsaCommitteeBusiness : IAddMadarsaCommittee
    {
        private readonly IGenericPattern<tbl_AddMadarsaCommittee> _tbl_AddMadarsaCommittee;
        private AddMadarsaCommittee _AddMadarsaCommittee;
        public AddMadarsaCommitteeBusiness()
        {
            _tbl_AddMadarsaCommittee = new GenericPattern<tbl_AddMadarsaCommittee>();
            _AddMadarsaCommittee = new AddMadarsaCommittee();
        }

        public List<AddMadarsaCommittee> MadarsaCommitteeList()
        {
            List<AddMadarsaCommittee> _AddMadarsaCommitteeList = new List<AddMadarsaCommittee>();
            var AddMadarsaCommitteeData = _tbl_AddMadarsaCommittee.GetAll().ToList();
            _AddMadarsaCommitteeList = (from item in AddMadarsaCommitteeData
                                       select new AddMadarsaCommittee
                                       {
                                           Id = item.Id,
                                           CommitteeName = item.CommitteeName,
                                           MadarsaId = item.MadarsaId,
                                           MadarsaName = (item.tbl_AddMadarsa != null) ? item.tbl_AddMadarsa.MadarsaName : string.Empty,
                                           CreatedDate = item.CreatedDate,
                                           CreatedBy = item.CreatedBy,
                                           Status = item.Status
                                       }).OrderByDescending(x => x.Id).ToList();
            return _AddMadarsaCommitteeList;
        }
        public List<AddMadarsa> MadarsaList()
        {
            GenericPattern<tbl_AddMadarsa> _tbl_AddMadarsa = new GenericPattern<tbl_AddMadarsa>();
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



        public AddMadarsaCommittee GetCategoryDetails(AddMadarsaCommittee model)
        {
            model = model ?? new AddMadarsaCommittee();
            if (model.Id != 0)
            {
                model.AddMadarsaCommitteeList = MadarsaCommitteeList();
                model.AddMadarsaList = MadarsaList();

            }
            model.AddMadarsaCommitteeList = MadarsaCommitteeList();

            return model;

        }

        public int SaveMadarsaCommittee(AddMadarsaCommittee model)
        {
             tbl_AddMadarsaCommittee _AddMadarsaCommittee = new tbl_AddMadarsaCommittee(model);
            if (model.Id != null && model.Id != 0)
            {
                _AddMadarsaCommittee.Status = true;
                _tbl_AddMadarsaCommittee.Update(_AddMadarsaCommittee);
            }
            else
            {
                _AddMadarsaCommittee.CreatedBy = 1;
                _AddMadarsaCommittee.CreatedDate = System.DateTime.Now;
                _AddMadarsaCommittee.Status = true;
                _tbl_AddMadarsaCommittee.Insert(_AddMadarsaCommittee);
            }

            return _AddMadarsaCommittee.Id;
        }

        public AddMadarsaCommittee GetById(int id)
        {
            _AddMadarsaCommittee = new AddMadarsaCommittee();
            var MadarsaCommitteebyId = _tbl_AddMadarsaCommittee.GetById(id);
            MadarsaCommitteebyId = MadarsaCommitteebyId ?? new tbl_AddMadarsaCommittee();
            _AddMadarsaCommittee = new AddMadarsaCommittee
            { 
                Id = MadarsaCommitteebyId.Id,
                CommitteeName = MadarsaCommitteebyId.CommitteeName,
                MadarsaId = MadarsaCommitteebyId.MadarsaId,
                MadarsaName = (MadarsaCommitteebyId.tbl_AddMadarsa != null) ? MadarsaCommitteebyId.tbl_AddMadarsa.MadarsaName : string.Empty,
                CreatedDate = MadarsaCommitteebyId.CreatedDate,
                CreatedBy = MadarsaCommitteebyId.CreatedBy,
                Status = MadarsaCommitteebyId.Status
            };
            return _AddMadarsaCommittee;
        }

        public void Delete(AddMadarsaCommittee entity)
        {

            tbl_AddMadarsaCommittee AddMadarsaCommitteeData = new tbl_AddMadarsaCommittee(entity);
            using (System.Transactions.TransactionScope scope = new System.Transactions.TransactionScope())
            {
                if (entity.Id != null && entity.Id != 0)
                {
                    AddMadarsaCommitteeData.Id = entity.Id;
                    AddMadarsaCommitteeData.Status = false;
                    _tbl_AddMadarsaCommittee.Update(AddMadarsaCommitteeData);

                }
                scope.Complete();
            }

        }
    }
}
