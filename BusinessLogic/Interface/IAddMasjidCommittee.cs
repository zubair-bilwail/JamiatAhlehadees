using CommonLayer.CommonModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Interface
{
    public interface IAddMasjidCommittee
    {
        List<AddMasjidCommittee> MasjidCommitteeList();

        List<AddMasjid> MasjidList();

      

        AddMasjidCommittee GetCategoryDetails(AddMasjidCommittee model);

        int SaveMasjidCommittee(AddMasjidCommittee model);

        AddMasjidCommittee GetById(int id);

        void Delete(AddMasjidCommittee entity);


    }
}
 