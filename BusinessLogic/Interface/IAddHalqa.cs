using CommonLayer.CommonModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Interface
{
    public interface IAddHalqa
    {
        List<AddHalqa> HalqaList();

        AddHalqa GetHalqaDetails(AddHalqa model);

        int SaveHalqa(AddHalqa model);

        AddHalqa GetById(int id);

        void Delete(AddHalqa entity);
    }
}
