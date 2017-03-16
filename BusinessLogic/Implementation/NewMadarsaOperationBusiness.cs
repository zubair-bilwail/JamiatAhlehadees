using BusinessLogic.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommonLayer.CommonModels;
using DataAcessLayer.DataModel;
using DataAcessLayer.Generic_Pattern.Interface;
using DataAcessLayer.Generic_Pattern.Implementation;

namespace BusinessLogic.Implementation
{
    public class NewMadarsaOperationBusiness : INewMadarsaOperation
    {
        private readonly IGenericPattern<tbl_NewMadarsaOperations> _tbl_NewMadarsaOperations;
        public NewMadarsaOperationBusiness()
        {
            _tbl_NewMadarsaOperations = new GenericPattern<tbl_NewMadarsaOperations>();
        }
        public List<NewMadarsaOperation> NewMadarsaOperationList()
        {
            List<NewMadarsaOperation> _NewMadOp_LV = new List<NewMadarsaOperation>();
            var var_LV = _tbl_NewMadarsaOperations.FindBy(x => x.Status == true);
            _NewMadOp_LV = (from item in var_LV
                            select new NewMadarsaOperation
                            {
                                Id = item.Id,
                                HeadMasterName = item.HeadMasterName,
                                Head = item.Head,
                                ExpectedStudents = item.ExpectedStudents,
                                Boys = item.Boys,
                                Girls = item.Girls,
                                Teachers = item.Teachers,
                                Residential = item.Residential,
                                MonthlyCost = item.MonthlyCost,
                                PerStudentCost = item.PerStudentCost,
                                SourceofRevenue = item.SourceofRevenue,
                                Location = item.Location,
                                Address = item.Address,
                                OwnRented = item.OwnRented,
                                TotalLandArea = item.TotalLandArea,
                                ConstructedArea = item.ConstructedArea,
                                ChargingStudent = item.ChargingStudent,
                                Howmuch = item.Howmuch,
                                Picture1 = item.Picture1,
                                Picture2 = item.Picture2,
                                Picture3 = item.Picture3,
                                Picture4 = item.Picture4,
                                Status = item.Status,
                                UserId=item.UserId,
                                Name = (item.tbl_User != null) ? item.tbl_User.Name : string.Empty,
                                CommitteeId = item.CommitteeId,
                                CommitteeName = (item.tbl_AddMadarsaCommittee != null) ? item.tbl_AddMadarsaCommittee.CommitteeName : string.Empty,
                                Contact = (item.tbl_User != null) ? item.tbl_User.Mobile : string.Empty,
                                RequestId = item.RequestId,
                            }).OrderByDescending(x=>x.Id).ToList();
            return _NewMadOp_LV;


        }
       
        public List<AddMadarsaCommittee> AddMadarsaCommitteeList()
        {
           
            GenericPattern<tbl_AddMadarsaCommittee> _tbl_AddMadarsaCommittee = new GenericPattern<tbl_AddMadarsaCommittee>();
            List<AddMadarsaCommittee> _AddMadarsaCommitteeList = new List<AddMadarsaCommittee>();
            var Varial = _tbl_AddMadarsaCommittee.GetAll().ToList();
            _AddMadarsaCommitteeList = (from item in Varial
                                       select new AddMadarsaCommittee
                                       {
                                           Id = item.Id,
                                           CommitteeName = item.CommitteeName,

                                       }).OrderByDescending(x => x.Id).ToList();
            return _AddMadarsaCommitteeList;
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

                         }).OrderByDescending(x => x.Id).ToList();
            return _UserList;
        }


        public int Save(NewMadarsaOperation model)
        {
            tbl_NewMadarsaOperations _tbl_EMO_LocalVar = new tbl_NewMadarsaOperations(model);
            if (model.Id != null && model.Id != 0)
            {
                _tbl_EMO_LocalVar.Status = true;
                _tbl_NewMadarsaOperations.Update(_tbl_EMO_LocalVar);

            }
            else
            {
                _tbl_EMO_LocalVar.CreateDate = System.DateTime.Now;
                _tbl_EMO_LocalVar.CreatedBy = 1;
                _tbl_EMO_LocalVar.Status = true;
                _tbl_EMO_LocalVar = _tbl_NewMadarsaOperations.Insert(_tbl_EMO_LocalVar);
            }

            return _tbl_EMO_LocalVar.Id;
        }

        public void Delete(NewMadarsaOperation entity)
        {
            tbl_NewMadarsaOperations _tbl_EMO_LocalVar = new tbl_NewMadarsaOperations(entity);
            using (System.Transactions.TransactionScope scope = new System.Transactions.TransactionScope())
            {
                if (entity.Id != null && entity.Id != 0)
                {
                    _tbl_EMO_LocalVar.Id = entity.Id;
                    _tbl_EMO_LocalVar.Status = false;
                    _tbl_NewMadarsaOperations.Update(_tbl_EMO_LocalVar);

                }
                scope.Complete();
            }

        }

        public NewMadarsaOperation GetById(int id)
        {
            NewMadarsaOperation _NewMadOp_LV = new NewMadarsaOperation();
            var item = _tbl_NewMadarsaOperations.GetById(id);
            item = item ?? new tbl_NewMadarsaOperations();
            _NewMadOp_LV = new NewMadarsaOperation
            {
                Id = item.Id,
                HeadMasterName = item.HeadMasterName,
                Head = item.Head,
                ExpectedStudents = item.ExpectedStudents,
                Boys = item.Boys,
                Girls = item.Girls,
                Teachers = item.Teachers,
                Residential = item.Residential,
                MonthlyCost = item.MonthlyCost,
                PerStudentCost = item.PerStudentCost,
                SourceofRevenue = item.SourceofRevenue,
                Location = item.Location,
                Address = item.Address,
                OwnRented = item.OwnRented,
                TotalLandArea = item.TotalLandArea,
                ConstructedArea = item.ConstructedArea,
                ChargingStudent = item.ChargingStudent,
                Howmuch = item.Howmuch,
                Picture1 = item.Picture1,
                Picture2 = item.Picture2,
                Picture3 = item.Picture3,
                Picture4 = item.Picture4,
                Status = item.Status,
                UserId = item.UserId,
                Name = (item.tbl_User != null) ? item.tbl_User.Name : string.Empty,
                CommitteeId = item.CommitteeId,
                CommitteeName = (item.tbl_AddMadarsaCommittee != null) ? item.tbl_AddMadarsaCommittee.CommitteeName : string.Empty,


            };
            return _NewMadOp_LV;
        }

        public NewMadarsaOperation GetDetails(NewMadarsaOperation model)
        {
            model = model ?? new NewMadarsaOperation();
            if (model.Id != 0)
            {
                model.AddMadarsaCommitteeList = AddMadarsaCommitteeList();
                model.NewMadarsaOperationList = NewMadarsaOperationList();
                model.UserList1 = UserList();
            }
            model.NewMadarsaOperationList = NewMadarsaOperationList();

            return model;
        }

    }
}
