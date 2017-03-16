using CommonLayer.CommonModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Interface
{
    public interface IMasjidExtension
    {
        List<MasjidExtension> MasjidExtensionListf();

        MasjidExtension GetMasjidExtensionDetails(MasjidExtension model);

        int SaveMasjidExtension(MasjidExtension model);

        MasjidExtension GetById(int id);

        void Delete(MasjidExtension entity);
    }
}