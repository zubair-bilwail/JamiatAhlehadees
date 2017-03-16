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
    public class MasjidExtensionBs : IMasjidExtension
    {
        private readonly IGenericPattern<tbl_MasjidExtension> _tbl_MasjidExtension;
        private readonly MasjidExtension _MasjidExtension;


        public MasjidExtensionBs()
        {
            _tbl_MasjidExtension = new GenericPattern<tbl_MasjidExtension>();
            _MasjidExtension = new MasjidExtension();
        }

        public List<MasjidExtension> MasjidExtensionListf()
        {
            List<MasjidExtension> _MasjidExtensionList = new List<MasjidExtension>();
            var MasjidExtensionData = _tbl_MasjidExtension.GetAll().ToList();
            _MasjidExtensionList = (from item in MasjidExtensionData
                                    select new MasjidExtension
                                    {
                                        Id = item.Id,
                                        Location = item.Location,
                                        MasjidName = item.tbl_AddMasjid.MasjidName,
                                        Area = item.Area,
                                        ConstructionCost = item.ConstructionCost,
                                        ExistingFloors = item.ExistingFloors,
                                        AmountCollected = item.AmountCollected,
                                        CommitteeName = item.tbl_AddMasjidCommittee.CommitteeName,
                                        Name = item.tbl_User.Name,
                                        Head = item.Head,
                                        EngineerName = item.EngineerName,
                                        EngineerContact = item.EngineerContact,
                                        ElevationImg = item.ElevationImg,
                                        PlanImg = item.PlanImg,
                                        ConstructionImg1 = item.ConstructionImg1,
                                        ConstructionImg2 = item.ConstructionImg2,
                                        ConstructionImg3 = item.ConstructionImg3,
                                        CreatedDate = item.CreatedDate,
                                        CreatedBy = item.CreatedBy,
                                        Status = item.Status

                                    }).OrderBy(x => x.Id).ToList();
            return _MasjidExtensionList;

        }


        public MasjidExtension GetMasjidExtensionDetails(MasjidExtension model)
        {
            model = model ?? new MasjidExtension();
            if (model.Id != 0)
            {
                model.MasjidExtensionList = MasjidExtensionListf();

            }
            model.MasjidExtensionList = MasjidExtensionListf();

            return model;

        }

        public int SaveMasjidExtension(MasjidExtension model)
        {
            tbl_MasjidExtension _tbl_masjidExtension = new tbl_MasjidExtension(model);

            if (model.Id != null && model.Id != 0)

            {
                _tbl_masjidExtension.Status = true;
                _tbl_MasjidExtension.Update(_tbl_masjidExtension);

            }
            else
            {
                _tbl_masjidExtension.CreatedBy = 1;
                _tbl_masjidExtension.CreatedDate = System.DateTime.Now;
                _tbl_masjidExtension.Status = true;
                _tbl_masjidExtension = _tbl_MasjidExtension.Insert(_tbl_masjidExtension);
            }

            return _tbl_masjidExtension.Id;
        }

        public MasjidExtension GetById(int id)
        {
            MasjidExtension _MasjidExtension = new MasjidExtension();
            var MasjidExtensionbyId = _tbl_MasjidExtension.GetById(id);
            MasjidExtensionbyId = MasjidExtensionbyId ?? new tbl_MasjidExtension();
            _MasjidExtension = new MasjidExtension
            {
                Id = MasjidExtensionbyId.Id,
                UserId = MasjidExtensionbyId.UserId,
                UserContact = (MasjidExtensionbyId.tbl_User != null) ? MasjidExtensionbyId.tbl_User.Mobile : string.Empty,
                SadrEMasjid = (MasjidExtensionbyId.tbl_AddMasjid.tbl_User != null) ? MasjidExtensionbyId.tbl_AddMasjid.tbl_User.Name : string.Empty,
                Location = MasjidExtensionbyId.Location,
                MasjidName = MasjidExtensionbyId.tbl_AddMasjid.MasjidName,
                Area = MasjidExtensionbyId.Area,
                ConstructionCost = MasjidExtensionbyId.ConstructionCost,
                ExistingFloors = MasjidExtensionbyId.ExistingFloors,
                AmountCollected = MasjidExtensionbyId.AmountCollected,
                CommitteeName = MasjidExtensionbyId.tbl_AddMasjidCommittee.CommitteeName,
                Name = MasjidExtensionbyId.tbl_User.Name,
                Head = MasjidExtensionbyId.Head,
                EngineerName = MasjidExtensionbyId.EngineerName,
                EngineerContact = MasjidExtensionbyId.EngineerContact,
                ElevationImg = MasjidExtensionbyId.ElevationImg,
                PlanImg = MasjidExtensionbyId.PlanImg,
                ConstructionImg1 = MasjidExtensionbyId.ConstructionImg1,
                ConstructionImg2 = MasjidExtensionbyId.ConstructionImg2,
                ConstructionImg3 = MasjidExtensionbyId.ConstructionImg3,
                CreatedDate = MasjidExtensionbyId.CreatedDate,
                CreatedBy = MasjidExtensionbyId.CreatedBy,
                Status = MasjidExtensionbyId.Status


            };
            return _MasjidExtension;
        }

        public void Delete(MasjidExtension entity)
        {

            tbl_MasjidExtension MasjidExtensionData = new tbl_MasjidExtension(entity);
            using (System.Transactions.TransactionScope scope = new System.Transactions.TransactionScope())
            {
                if (entity.Id != null && entity.Id != 0)
                {

                    _tbl_MasjidExtension.Delete(MasjidExtensionData.Id);

                }
                scope.Complete();
            }

        }
    }
}
