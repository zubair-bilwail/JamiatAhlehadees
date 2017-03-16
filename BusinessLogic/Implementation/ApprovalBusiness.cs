using BusinessLogic.Interface;
using CommonLayer.CommonModels;
using DataAcessLayer.DataModel;
using DataAcessLayer.Generic_Pattern.Implementation;
using DataAcessLayer.Generic_Pattern.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Implementation
{
    public class ApprovalBusiness : IApproval
    {
        private readonly IGenericPattern<tbl_Approval> _tbl_Approval;
        private readonly Approval _Approval;
        public ApprovalBusiness()
        {
            _tbl_Approval = new GenericPattern<tbl_Approval>();
            _Approval = new Approval();
        }


        public List<Approval> ApprovalList()
        {
            List<Approval> _ApprovalList = new List<Approval>();
            var ApprovalData = _tbl_Approval.GetAll().ToList();
            _ApprovalList = (from item in ApprovalData
                             select new Approval
                               {
                                   Id = item.Id,
                                   RequestId = item.RequestId,
                                   RequestType = item.RequestType,
                                   RequestTypeName =(item.tbl_Request != null) ? item.tbl_Request.tblRequestType : string.Empty,
                                   Comment = item.Comment,
                                   Status = item.Status
                               }).OrderByDescending(x => x.Id).ToList();
            return _ApprovalList;
        }

        public void InsertApproval(Approval model)
        {
            tbl_Approval _tblApproval = new tbl_Approval(model);
            _tblApproval = _tbl_Approval.Insert(_tblApproval);
            
            
        }
    }
}
