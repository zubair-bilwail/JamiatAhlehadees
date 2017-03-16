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
    public class MasjidConstructionBusiness : IMasjidConstruction
    {
        private readonly IGenericPattern<tbl_MasjidConstruction> _tbl_MasjidConstruction;

        public MasjidConstructionBusiness()
        {
            _tbl_MasjidConstruction = new GenericPattern<tbl_MasjidConstruction>();

        }
        public List<MasjidConstruction> MasjidConstructionList()
        {
            List<MasjidConstruction> _masjidconst_localVar = new List<MasjidConstruction>();
            var var_masjidconst = _tbl_MasjidConstruction.FindBy(x=>x.Status==true).ToList();
            _masjidconst_localVar = (from _Exvar in var_masjidconst
                                     select new MasjidConstruction
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
                                       //  ElevationImg = _Exvar.ElevationImg,
                                         ConstructionImg1 = _Exvar.ConstructionImg1,
                                         Location = _Exvar.Location,
                                         ConstructionImg2 = _Exvar.ConstructionImg2,
                                         ConstructionImg3 = _Exvar.ConstructionImg3,
                                         Status = _Exvar.Status,
                                         UserId = _Exvar.UserId,
                                         Name = (_Exvar.tbl_User != null) ? _Exvar.tbl_User.Name : string.Empty,
                                         //CommitteeId = _Exvar.CommitteeId,
                                         //CommitteeName = (_Exvar.tbl_AddMasjidCommittee != null) ? _Exvar.tbl_AddMasjidCommittee.CommitteeName : string.Empty,


                                     }).OrderByDescending(x => x.Id).ToList();
            return _masjidconst_localVar;

        }

        public MasjidConstruction GetById(int id)
        {
            MasjidConstruction _masjidconst_localVar = new MasjidConstruction();
            var masjidById = _tbl_MasjidConstruction.GetById(id);
            masjidById = masjidById ?? new tbl_MasjidConstruction();
            _masjidconst_localVar = new MasjidConstruction
            {
                Id = masjidById.Id,
                Area = masjidById.Area,
                Head = masjidById.Head,
                ConstructionCost = masjidById.ConstructionCost,
                Floors = masjidById.Floors,
                AmountCollected = masjidById.AmountCollected,
                EngineerName = masjidById.EngineerName,
                EngineerContact = masjidById.EngineerContact,
                PlanImg = masjidById.PlanImg,
               // ElevationImg = masjidById.ElevationImg,
                ConstructionImg1 = masjidById.ConstructionImg1,
                Location = masjidById.Location,
                ConstructionImg2 = masjidById.ConstructionImg2,
                ConstructionImg3 = masjidById.ConstructionImg3,
                Status = masjidById.Status,
                UserId = masjidById.UserId,
                Name = (masjidById.tbl_User != null) ? masjidById.tbl_User.Name : string.Empty,
                //CommitteeId = masjidById.CommitteeId,
                //CommitteeName = (masjidById.tbl_AddMasjidCommittee != null) ? masjidById.tbl_AddMasjidCommittee.CommitteeName : string.Empty,
            };
            return _masjidconst_localVar;
        }

        public MasjidConstruction GetMasjidConstructionDetails(MasjidConstruction model)
        {
            model = model ?? new MasjidConstruction();
            if (model.Id != 0)
            {
                model.MasjidConstructionList = MasjidConstructionList();
                model.UserList = UserList();
                model.AddMasjidCommitteeList = AddMasjidCommitteeList();
            }
            model.MasjidConstructionList = MasjidConstructionList();

            return model;
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


        public int SaveMasjidConstruction(MasjidConstruction model)
        {
            {
                tbl_MasjidConstruction _tbl_MasjidConstruction_LocalVar = new tbl_MasjidConstruction(model);
                if (model.Id != null && model.Id != 0)
                {
                    _tbl_MasjidConstruction_LocalVar.Status = true;
                    _tbl_MasjidConstruction.Update(_tbl_MasjidConstruction_LocalVar);

                }
                else
                {
                    _tbl_MasjidConstruction_LocalVar.CreatedDate = System.DateTime.Now;
                    _tbl_MasjidConstruction_LocalVar.CreatedBy = 1;
                    _tbl_MasjidConstruction_LocalVar.Status =true;
                    _tbl_MasjidConstruction_LocalVar = _tbl_MasjidConstruction.Insert(_tbl_MasjidConstruction_LocalVar);
                }

                return _tbl_MasjidConstruction_LocalVar.Id;
            }

        }

        public void Delete(MasjidConstruction entity)
        {
            tbl_MasjidConstruction _tbl_MasjidConstruction_LocalVar = new tbl_MasjidConstruction(entity);
            using (System.Transactions.TransactionScope scope = new System.Transactions.TransactionScope())
            {
                if (entity.Id != null && entity.Id != 0)
                {
                    _tbl_MasjidConstruction_LocalVar = _tbl_MasjidConstruction.FindBy(x => x.Id == entity.Id).FirstOrDefault();
                    _tbl_MasjidConstruction_LocalVar.Status = false;
                    _tbl_MasjidConstruction.Update(_tbl_MasjidConstruction_LocalVar);

                }
                scope.Complete();
            }
        }
    }

}