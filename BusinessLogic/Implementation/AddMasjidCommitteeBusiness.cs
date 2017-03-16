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
using System.Transactions;

namespace BusinessLogic.Implementation
{
   public class AddMasjidCommitteeBusiness : IAddMasjidCommittee
    {
        private readonly IGenericPattern<tbl_AddMasjidCommittee> _tbl_AddMasjidCommittee;
        private AddMasjidCommittee _AddMasjidCommittee;
        public AddMasjidCommitteeBusiness()
        {
            _tbl_AddMasjidCommittee = new GenericPattern<tbl_AddMasjidCommittee>();
            _AddMasjidCommittee = new AddMasjidCommittee();
        }

        public List<AddMasjidCommittee> MasjidCommitteeList()
        {
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
            List<AddMasjid> _AddmasjidList = new List<AddMasjid>();
            GenericPattern<tbl_AddMasjid> _tbl_AddMasjid = new GenericPattern<tbl_AddMasjid>();
            var AddmasjidData = _tbl_AddMasjid.GetAll().ToList();
            _AddmasjidList = (from item in AddmasjidData
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
            return _AddmasjidList;
        }

       

        public AddMasjidCommittee GetCategoryDetails(AddMasjidCommittee model)
        {
            model = model ?? new AddMasjidCommittee();
            if (model.Id != 0)
            {
                model.AddMasjidCummitteList = MasjidCommitteeList();
                model.AddMasjidList = MasjidList();
                
            }
            model.AddMasjidCummitteList = MasjidCommitteeList();

            return model;

        }

        public int SaveMasjidCommittee(AddMasjidCommittee model)
        {
            tbl_AddMasjidCommittee _tbl_addMasjidCommittee = new tbl_AddMasjidCommittee(model);
            if (model.Id != null && model.Id != 0)
            {
                _tbl_addMasjidCommittee.Status = true;
                _tbl_AddMasjidCommittee.Update(_tbl_addMasjidCommittee);

            }
            else
            {
                _tbl_addMasjidCommittee.CreatedBy = 1;
                _tbl_addMasjidCommittee.CreatedDate = System.DateTime.Now;
                _tbl_addMasjidCommittee.Status = true;
                _tbl_addMasjidCommittee = _tbl_AddMasjidCommittee.Insert(_tbl_addMasjidCommittee);
            }

            return _tbl_addMasjidCommittee.Id;
        }

        public AddMasjidCommittee GetById(int id)
        {
            AddMasjidCommittee _AddMasjidCommittee = new AddMasjidCommittee();
            var MasjidCommitteebyId = _tbl_AddMasjidCommittee.GetById(id);
            MasjidCommitteebyId = MasjidCommitteebyId ?? new tbl_AddMasjidCommittee();
            _AddMasjidCommittee = new AddMasjidCommittee
            {
                Id = MasjidCommitteebyId.Id,
                CommitteeName = MasjidCommitteebyId.CommitteeName,
                MasjidId = MasjidCommitteebyId.MasjidId,
                MasjidName = (MasjidCommitteebyId.tbl_AddMasjid != null) ? MasjidCommitteebyId.tbl_AddMasjid.MasjidName : string.Empty,
                CreatedDate = MasjidCommitteebyId.CreatedDate,
                CreatedBy = MasjidCommitteebyId.CreatedBy,
                Status = MasjidCommitteebyId.Status
            };
            return _AddMasjidCommittee;
        }

        public void Delete(AddMasjidCommittee entity)
        {

            tbl_AddMasjidCommittee AddMasjidCommitteeData = new tbl_AddMasjidCommittee(entity);
            using (System.Transactions.TransactionScope scope = new System.Transactions.TransactionScope())
            {
                if (entity.Id != null && entity.Id != 0)
                {
                    AddMasjidCommitteeData.Id = entity.Id;
                    AddMasjidCommitteeData.Status = false;
                    _tbl_AddMasjidCommittee.Update(AddMasjidCommitteeData);

                }
                scope.Complete();
            }

        }

    }
}
