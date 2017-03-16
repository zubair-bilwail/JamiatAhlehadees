using CommonLayer.CommonModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Interface
{
    public interface IAddMadarsa
    {
        List<AddMadarsa> MadarsaList();

        List<AddHalqa> HalqaList();

        List<User> UserList();

        AddMadarsa GetMadarsaDetails(AddMadarsa model);

        int SaveMadarsa(AddMadarsa model);

        AddMadarsa GetById(int id);

        void Delete(AddMadarsa entity);
    }
}
