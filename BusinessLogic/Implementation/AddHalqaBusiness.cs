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
    public class AddHalqaBusiness : IAddHalqa
    {
        private readonly IGenericPattern<tbl_AddHalqa> _tbl_AddHalqa;
        private readonly AddHalqa _AddHalqa;
        public AddHalqaBusiness()
        {
            _tbl_AddHalqa = new GenericPattern<tbl_AddHalqa>();
            _AddHalqa = new AddHalqa();
        }


        public List<AddHalqa> HalqaList()
        {
            List<AddHalqa> _AddHalqaList = new List<AddHalqa>();

            var AddHalqaData = _tbl_AddHalqa.FindBy(x=>x.Status == true).ToList();
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

        public AddHalqa GetHalqaDetails(AddHalqa model)
        {
            model = model ?? new AddHalqa(); 
            if (model.Id != 0)
            {
                model.AddHalqaList = HalqaList();

            }
            model.AddHalqaList = HalqaList();

            return model;

        }

        public int SaveHalqa(AddHalqa model)
        {
            tbl_AddHalqa _tbl_addHalqa = new tbl_AddHalqa(model);
#pragma warning disable CS0472 // The result of the expression is always the same since a value of this type is never equal to 'null'
            if (model.Id != null && model.Id != 0)
#pragma warning restore CS0472 // The result of the expression is always the same since a value of this type is never equal to 'null'
            {
                _tbl_addHalqa.Status = true;
                _tbl_AddHalqa.Update(_tbl_addHalqa);

            }
            else
            {
                _tbl_addHalqa.CreatedBy = 1;
                _tbl_addHalqa.CreatedDate = System.DateTime.Now;
                _tbl_addHalqa.Status = true;
                _tbl_addHalqa = _tbl_AddHalqa.Insert(_tbl_addHalqa);
            }

            return _tbl_addHalqa.Id;
        }

        public AddHalqa GetById(int id)
        {
            AddHalqa _AddHalqa = new AddHalqa();
            var HalqabyId = _tbl_AddHalqa.GetById(id);
            HalqabyId = HalqabyId ?? new tbl_AddHalqa();
            _AddHalqa = new AddHalqa
            {
                Id = HalqabyId.Id,
                HalqaName = HalqabyId.HalqaName,
                Area = HalqabyId.Area,
                CreatedDate = HalqabyId.CreatedDate,
                CreatedBy = HalqabyId.CreatedBy,
                Status = HalqabyId.Status
            };
            return _AddHalqa;
        }

        public void Delete(AddHalqa entity)
        {

            tbl_AddHalqa AddHalqaData = new tbl_AddHalqa(entity);
            using (System.Transactions.TransactionScope scope = new System.Transactions.TransactionScope())
            {
                if (entity.Id != null && entity.Id != 0)
                {
                    _tbl_AddHalqa.Delete(AddHalqaData.Id);

                }
                scope.Complete();
            }

        }
    }
}