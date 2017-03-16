using CommonLayer.CommonModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Interface
{
    public interface IApproval
    {
        List<Approval> ApprovalList();

        void InsertApproval(Approval model);
    }
}
