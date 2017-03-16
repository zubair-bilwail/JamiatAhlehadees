using CommonLayer.CommonModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Interface
{
    public interface IMasjidRenovation
    {
        List<MasjidRenovation> MasjidRenovationList();
        List<AddMasjid> AddMasjidList();
        List<AddMasjidCommittee> AddMasjidCommitteeList();
        List<User> UserList();

        MasjidRenovation GetMasjidMasjidRenovationDetails(MasjidRenovation model);

        int SaveMasjidRenovation(MasjidRenovation model);

        MasjidRenovation GetById(int id);

        void Delete(MasjidRenovation entity);

     
    }
}
