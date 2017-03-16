using CommonLayer.CommonModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Interface
{
    public interface IExistingMadarsaOperations
    {
        List<ExistingMadarsaOperations> _ExistingMadarsaOperarionList();

        List<AddMasjidCommittee> _AddMasjidCommitteeList();
        List<AddMadarsaCommittee> _AddMadarsaCommitteeList();
        ExistingMadarsaOperations Get_EMO_Details(ExistingMadarsaOperations model);

        int Save_EMO(ExistingMadarsaOperations model);

        ExistingMadarsaOperations GetById(int id);

        void Delete(ExistingMadarsaOperations entity);
    }
}
