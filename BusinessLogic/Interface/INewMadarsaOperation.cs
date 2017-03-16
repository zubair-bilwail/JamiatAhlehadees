using CommonLayer.CommonModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Interface
{
    public interface INewMadarsaOperation
    {
        List<NewMadarsaOperation> NewMadarsaOperationList();

        List<AddMadarsaCommittee> AddMadarsaCommitteeList();

        List<User> UserList();

        int Save(NewMadarsaOperation model);

        void Delete(NewMadarsaOperation entity);

        NewMadarsaOperation GetById(int id);

        NewMadarsaOperation GetDetails(NewMadarsaOperation model);
    }
}
