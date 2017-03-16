using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommonLayer.CommonModels;

namespace BusinessLogic.Interface
{
   public interface IMasjidConstruction
    {
       List<MasjidConstruction> MasjidConstructionList();

       List<AddMasjidCommittee> AddMasjidCommitteeList();

       List<User> UserList();

       MasjidConstruction GetMasjidConstructionDetails(MasjidConstruction model);

       int SaveMasjidConstruction(MasjidConstruction model);

       MasjidConstruction GetById(int id);

       void Delete(MasjidConstruction entity);
    }
}
