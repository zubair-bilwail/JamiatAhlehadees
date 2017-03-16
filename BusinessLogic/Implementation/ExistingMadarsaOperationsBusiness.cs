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
    public class ExistingMadarsaOperationsBusiness : IExistingMadarsaOperations
    {


        private readonly IGenericPattern<tbl_ExistingMadarsaOperations> _tbl_ExistingMadarsaOperations;
        public ExistingMadarsaOperationsBusiness()
        {
            _tbl_ExistingMadarsaOperations = new GenericPattern<tbl_ExistingMadarsaOperations>();
        }
        public List<ExistingMadarsaOperations> _ExistingMadarsaOperarionList()
        {
           List<ExistingMadarsaOperations> _EMO_localVar = new List<ExistingMadarsaOperations>();
        
           var var_EMO = _tbl_ExistingMadarsaOperations.FindBy(x => x.Status == true).ToList();
            _EMO_localVar = (from _Exvar in var_EMO
                             select new ExistingMadarsaOperations
                             {
                                 Id = _Exvar.Id,
                                 HeadMasterName = _Exvar.HeadMasterName,
                                 Head = _Exvar.Head,
                                 ExpectedStudents = _Exvar.ExpectedStudents,
                                 Boys = _Exvar.Boys,
                                 Girls = _Exvar.Girls,
                                 Teachers = _Exvar.Teachers,
                                 Residential = _Exvar.Residential,
                                 MonthlyCost = _Exvar.MonthlyCost,
                                 PerStudentCost = _Exvar.PerStudentCost,
                                 SourceofRevenue = _Exvar.SourceofRevenue,
                                 Location = _Exvar.Location,
                                 Address = _Exvar.Address,
                                 OwnRented = _Exvar.OwnRented,
                                 TotalLandArea = _Exvar.TotalLandArea,
                                 ConstructedArea = _Exvar.ConstructedArea,
                                 ChargingStudent = _Exvar.ChargingStudent,
                                 Howmuch = _Exvar.Howmuch,
                                 Picture1 = _Exvar.Picture1,
                                 Picture2 = _Exvar.Picture2,
                                 Picture3 = _Exvar.Picture3,
                                 Picture4 = _Exvar.Picture4,
                                 Status = _Exvar.Status,
                                 CommitteeId = _Exvar.CommitteeId,
                                 CommitteeName = (_Exvar.tbl_AddMadarsaCommittee != null) ? _Exvar.tbl_AddMadarsaCommittee.CommitteeName : string.Empty,


                             }).OrderByDescending(x => x.Id).ToList();
            return _EMO_localVar;

        }

        public List<AddMasjidCommittee> _AddMasjidCommitteeList()
        {
            GenericPattern<tbl_AddMasjidCommittee> _tbl_AddMasjidCommittee = new GenericPattern<tbl_AddMasjidCommittee>();
            List<AddMasjidCommittee> _AddMasjidCommitteeList = new List<AddMasjidCommittee>();
            var Varial = _tbl_AddMasjidCommittee.GetAll().ToList();
            _AddMasjidCommitteeList = (from item in Varial
                                       select new AddMasjidCommittee
                                       {
                                           Id = item.Id,
                                           CommitteeName = item.CommitteeName,
                                          
                                       }).OrderByDescending(x => x.Id).ToList();
            return _AddMasjidCommitteeList;
        }


        public List<AddMadarsaCommittee> _AddMadarsaCommitteeList()
        {
            GenericPattern<tbl_AddMadarsaCommittee> _tbl_AddMasjidCommittee = new GenericPattern<tbl_AddMadarsaCommittee>();
            List<AddMadarsaCommittee> _AddMadarsaCommitteeList = new List<AddMadarsaCommittee>();
            var Varial = _tbl_AddMasjidCommittee.GetAll().ToList();
            _AddMadarsaCommitteeList = (from item in Varial
                                        select new AddMadarsaCommittee
                                        {
                                            Id = item.Id,
                                            CommitteeName = item.CommitteeName,

                                        }).OrderByDescending(x => x.Id).ToList();
            return _AddMadarsaCommitteeList;
        }




        public ExistingMadarsaOperations GetById(int id)
        {
            ExistingMadarsaOperations _EMO_localVar = new ExistingMadarsaOperations();
            var _Exvar = _tbl_ExistingMadarsaOperations.GetById(id);
            _Exvar = _Exvar ?? new tbl_ExistingMadarsaOperations();
            _EMO_localVar = new ExistingMadarsaOperations
            {
                Id = _Exvar.Id,
                HeadMasterName = _Exvar.HeadMasterName,
                Head = _Exvar.Head,
                ExpectedStudents = _Exvar.ExpectedStudents,
                Boys = _Exvar.Boys,
                Girls = _Exvar.Girls,
                Teachers = _Exvar.Teachers,
                Residential = _Exvar.Residential,
                MonthlyCost = _Exvar.MonthlyCost,
                PerStudentCost = _Exvar.PerStudentCost,
                SourceofRevenue = _Exvar.SourceofRevenue,
                Location = _Exvar.Location,
                Address = _Exvar.Address,
                OwnRented = _Exvar.OwnRented,
                TotalLandArea = _Exvar.TotalLandArea,
                ConstructedArea = _Exvar.ConstructedArea,
                ChargingStudent = _Exvar.ChargingStudent,
                Howmuch = _Exvar.Howmuch,
                Picture1 = _Exvar.Picture1,
                Picture2 = _Exvar.Picture2,
                Picture3 = _Exvar.Picture3,
                Picture4 = _Exvar.Picture4,
                Status = _Exvar.Status,

                CommitteeId = _Exvar.CommitteeId,

                CommitteeName = (_Exvar.tbl_AddMadarsaCommittee != null) ? _Exvar.tbl_AddMadarsaCommittee.CommitteeName : string.Empty,

            };
            return _EMO_localVar;
        }
        public ExistingMadarsaOperations Get_EMO_Details(ExistingMadarsaOperations model)
        {
            model = model ?? new ExistingMadarsaOperations();
            if (model.Id != 0)
            {
                model._ExistingMadarsaOperarionList = _ExistingMadarsaOperarionList();
                model._AddMadarsaCommitteeList = _AddMadarsaCommitteeList();
                model._AddMasjidCommitteeList = _AddMasjidCommitteeList();
            }
            model._ExistingMadarsaOperarionList = _ExistingMadarsaOperarionList();

            return model;
        }

        public int Save_EMO(ExistingMadarsaOperations model)
        {
            tbl_ExistingMadarsaOperations _tbl_EMO_LocalVar = new tbl_ExistingMadarsaOperations(model);
            if (model.Id != null && model.Id != 0)
            {
                _tbl_EMO_LocalVar.Status = true;
                _tbl_ExistingMadarsaOperations.Update(_tbl_EMO_LocalVar);

            }
            else
            {
                _tbl_EMO_LocalVar.CreateDate = System.DateTime.Now;
                _tbl_EMO_LocalVar.CreatedBy = 1;
                _tbl_EMO_LocalVar.Status = true;
                _tbl_EMO_LocalVar = _tbl_ExistingMadarsaOperations.Insert(_tbl_EMO_LocalVar);
            }

            return _tbl_EMO_LocalVar.Id;
        }
        public void Delete(ExistingMadarsaOperations entity)
        {
            throw new NotImplementedException();
        }
    }
}
