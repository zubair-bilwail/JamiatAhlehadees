using CommonLayer.CommonModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Interface
{
    public interface IAddMadarsaCommittee
    {
        List<AddMadarsaCommittee> MadarsaCommitteeList();

        List<AddMadarsa> MadarsaList();

        AddMadarsaCommittee GetCategoryDetails(AddMadarsaCommittee model);

        int SaveMadarsaCommittee(AddMadarsaCommittee model);

        AddMadarsaCommittee GetById(int id);

        void Delete(AddMadarsaCommittee entity);

    }
}
