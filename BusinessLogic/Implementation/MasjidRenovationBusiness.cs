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
    public class MasjidRenovationBusiness : IMasjidRenovation
    {
        private readonly IGenericPattern<tbl_MasjidRenovation> _tbl_MasjidRenovation;
        public MasjidRenovationBusiness()
        {
            _tbl_MasjidRenovation = new GenericPattern<tbl_MasjidRenovation>();
        }
        public List<MasjidRenovation> MasjidRenovationList()
        {
            List<MasjidRenovation> _MasjidReno_localVar = new List<MasjidRenovation>();

            var var_Ren = _tbl_MasjidRenovation.FindBy(x => x.Status == true).ToList();
            _MasjidReno_localVar = (from _Exvar in var_Ren
                                    select new MasjidRenovation
                                    {
                                        Id = _Exvar.Id,
                                        Area = _Exvar.Area,
                                        Head = _Exvar.Head,
                                        ConstructionCost = _Exvar.ConstructionCost,
                                        Floors = _Exvar.Floors,
                                        AmountCollected = _Exvar.AmountCollected,
                                        EngineerName = _Exvar.EngineerName,
                                        EngineerContact = _Exvar.EngineerContact,
                                        PlanImg = _Exvar.PlanImg,
                                        ElevationImg = _Exvar.ElevationImg,
                                        ConstructionImg1 = _Exvar.ConstructionImg1,
                                        Location = _Exvar.Location,
                                        ConstructionImg2 = _Exvar.ConstructionImg2,
                                        ConstructionImg3 = _Exvar.ConstructionImg3,
                                        Status = _Exvar.Status,
                                        UserId = _Exvar.UserId,
                                        MasjidId = _Exvar.MasjidId,
                                        Name = (_Exvar.tbl_User != null) ? _Exvar.tbl_User.Name : string.Empty,
                                        MasjidName = (_Exvar.tbl_AddMasjid != null) ? _Exvar.tbl_AddMasjid.MasjidName : string.Empty,
                                       
                                       


                                    }).OrderByDescending(x => x.Id).ToList();
            return _MasjidReno_localVar;

        }


        public List<AddMasjidCommittee> AddMasjidCommitteeList()
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


        public List<AddMasjid> AddMasjidList()
        {
            GenericPattern<tbl_AddMasjid> _tbl_AddMasjid = new GenericPattern<tbl_AddMasjid>();
            List<AddMasjid> _AddMasjidList = new List<AddMasjid>();
            var Varial = _tbl_AddMasjid.GetAll().ToList();
            _AddMasjidList = (from item in Varial
                                        select new AddMasjid
                                        {
                                            Id = item.Id,
                                            MasjidName = item.MasjidName,

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
                           
                         }).OrderByDescending(x => x.Id).ToList();
            return _UserList;
        }

       

        public MasjidRenovation GetById(int id)
        {
            MasjidRenovation _MasjidReno_localVar = new MasjidRenovation();
            var _Exvar = _tbl_MasjidRenovation.GetById(id);
            _Exvar = _Exvar ?? new tbl_MasjidRenovation();
            _MasjidReno_localVar = new MasjidRenovation


                                    {
                                        Id = _Exvar.Id,
                                        Area = _Exvar.Area,
                                        Head = _Exvar.Head,
                                        ConstructionCost = _Exvar.ConstructionCost,
                                        Floors = _Exvar.Floors,
                                        AmountCollected = _Exvar.AmountCollected,
                                        EngineerName = _Exvar.EngineerName,
                                        EngineerContact = _Exvar.EngineerContact,
                                        PlanImg = _Exvar.PlanImg,
                                        ElevationImg = _Exvar.ElevationImg,
                                        ConstructionImg1 = _Exvar.ConstructionImg1,
                                        Location = _Exvar.Location,
                                        ConstructionImg2 = _Exvar.ConstructionImg2,
                                        ConstructionImg3 = _Exvar.ConstructionImg3,
                                        Status = _Exvar.Status,
                                        UserId = _Exvar.UserId,
                                        MasjidId = _Exvar.MasjidId,
                                        Name = (_Exvar.tbl_User != null) ? _Exvar.tbl_User.Name : string.Empty,
                                        MasjidName = (_Exvar.tbl_AddMasjid != null) ? _Exvar.tbl_AddMasjid.MasjidName : string.Empty,
                                   
                                    };
            return _MasjidReno_localVar;

        }
      
        public int SaveMasjidRenovation(MasjidRenovation model)
        {
            tbl_MasjidRenovation _MasjidReno_localVar = new tbl_MasjidRenovation(model);
            if (model.Id != null && model.Id != 0)
            {
                _MasjidReno_localVar.Status = true;
                _tbl_MasjidRenovation.Update(_MasjidReno_localVar);

            }
            else
            {
                _MasjidReno_localVar.CreatedDate = System.DateTime.Now;
                _MasjidReno_localVar.CreatedBy = 1;
                _MasjidReno_localVar.Status = true;
                _MasjidReno_localVar = _tbl_MasjidRenovation.Insert(_MasjidReno_localVar);
            }

            return _MasjidReno_localVar.Id;
        }
        public void Delete(MasjidRenovation entity)
        {
            throw new NotImplementedException();
        }






        public MasjidRenovation GetMasjidMasjidRenovationDetails(MasjidRenovation model)
        {
            model = model ?? new MasjidRenovation();
            if (model.Id != 0)
            {
                model.MasjidRenovationList = MasjidRenovationList();
                model.UserList = UserList();
                model.AddMasjidCommitteeList = AddMasjidCommitteeList();
            }
            model.MasjidRenovationList = MasjidRenovationList();

            return model;
        }
    }
}
