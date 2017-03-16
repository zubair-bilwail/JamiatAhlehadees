using CommonLayer.CommonModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Interface
{
    public interface IAddMasjid
    {
        List<AddMasjid> MasjidList();

        List<AddHalqa> HalqaList();

        List<User> UserList();

        AddMasjid GetMasjidDetails(AddMasjid model);

        int SaveMasjid(AddMasjid model);

        AddMasjid GetById(int id);

        void Delete(AddMasjid entity);

    }
}
