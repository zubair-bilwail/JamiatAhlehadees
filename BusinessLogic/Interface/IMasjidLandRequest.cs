using CommonLayer.CommonModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Interface
{
    public interface IMasjidLandRequest
    {
        List<MasjidLandRequest> LandRequestList();

        List<AddMasjidCommittee> MasjidCommitteeList();

        List<AddMasjid> MasjidList();

        List<User> UserList();
        MasjidLandRequest GetMasjidLandRequestDetails(MasjidLandRequest model);

        int SaveMasjidLandRequest(MasjidLandRequest model);

        MasjidLandRequest GetById(int id);

        void Delete(MasjidLandRequest entity);
    }
}
