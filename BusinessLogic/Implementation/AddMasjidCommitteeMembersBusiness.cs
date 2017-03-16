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
   public class AddMasjidCommitteeMembersBusiness
    {
        private readonly IGenericPattern<tbl_AddMasjidCommitteeMember> _tbl_AddMasjidCommitteeMember;
        private AddMasjidCommitteeMember _AddMasjidCommitteeMember;
        public AddMasjidCommitteeMembersBusiness()
        {
            _tbl_AddMasjidCommitteeMember = new GenericPattern<tbl_AddMasjidCommitteeMember>();
            _AddMasjidCommitteeMember = new AddMasjidCommitteeMember();
        }
        public List<AddMasjidCommitteeMember> MasjidCommitteeMemberList()
        {
            List<AddMasjidCommitteeMember> _AddMasjidCommitteeMemberList = new List<AddMasjidCommitteeMember>();
            var AddMasjidCommitteeMemberData = _tbl_AddMasjidCommitteeMember.GetAll().ToList();
            _AddMasjidCommitteeMemberList = (from item in AddMasjidCommitteeMemberData
                                             select new AddMasjidCommitteeMember
                                             {
                                                 Id = item.Id,
                                                 CommitteeId = item.CommitteeId,
                                                 CommitteeName = (item.tbl_AddMasjidCommittee != null) ? item.tbl_AddMasjidCommittee.CommitteeName : string.Empty,
                                                 UserID = item.UserID,
                                                 UserName = (item.tbl_User != null) ? item.tbl_User.Name : string.Empty,
                                                 CreateDate = item.CreateDate,
                                                 CreatedBy = item.CreatedBy,
                                                 Status = item.Status
                                       }).OrderByDescending(x => x.Id).ToList();
            return _AddMasjidCommitteeMemberList;
        }


        public List<AddMasjidCommittee> MasjidCommitteeList()
        {
            List<AddMasjidCommittee> _AddMasjidCommitteeList = new List<AddMasjidCommittee>();
            IGenericPattern<tbl_AddMasjidCommittee> _tbl_AddMasjidCommittee = new GenericPattern<tbl_AddMasjidCommittee>();
            var AddMasjidCommitteeData = _tbl_AddMasjidCommittee.GetAll().ToList();
            _AddMasjidCommitteeList = (from item in AddMasjidCommitteeData
                                       select new AddMasjidCommittee
                                       {
                                           Id = item.Id,
                                           CommitteeName = item.CommitteeName,
                                           MasjidId = item.MasjidId,
                                           MasjidName = (item.tbl_AddMasjid != null) ? item.tbl_AddMasjid.MasjidName : string.Empty,
                                           CreatedDate = item.CreatedDate,
                                           CreatedBy = item.CreatedBy,
                                           Status = item.Status
                                       }).OrderByDescending(x => x.Id).ToList();
            return _AddMasjidCommitteeList;
        }

        public List<User> UserList()
        {
            IGenericPattern<tbl_User> _tbl_User = new GenericPattern<tbl_User>();
            List<User> _UserList = new List<User>();
            var UserData = _tbl_User.GetAll().ToList();
            _UserList = (from item in UserData
                         select new User
                         {
                             Id = item.Id,
                             Name = item.Name,
                             Mobile = item.Mobile,
                             Email = item.Email,
                             Password = item.Password,
                             Area = item.Area,
                             CreatedDate = item.CreatedDate,
                             CreatedBy = item.CreatedBy,
                             Status = item.Status
                         }).OrderByDescending(x => x.Id).ToList();
            return _UserList;
        }

        public AddMasjidCommitteeMember GetById(int id)
        {
            AddMasjidCommitteeMember _AddMasjidCommitteeMember = new AddMasjidCommitteeMember();
            var item = _tbl_AddMasjidCommitteeMember.GetById(id);
            item = item ?? new tbl_AddMasjidCommitteeMember();
            _AddMasjidCommitteeMember = new AddMasjidCommitteeMember
            {
                Id = item.Id,
                CommitteeId = item.CommitteeId,
                CommitteeName = (item.tbl_AddMasjidCommittee != null) ? item.tbl_AddMasjidCommittee.CommitteeName : string.Empty,
                UserID = item.UserID,
                UserName = (item.tbl_User != null) ? item.tbl_User.Name : string.Empty,
                CreateDate = item.CreateDate,
                CreatedBy = item.CreatedBy,
                Status = item.Status
            };
            return _AddMasjidCommitteeMember;
        }


        public int SaveMasjidCommitteeMember(AddMasjidCommitteeMember model)
        {
            tbl_AddMasjidCommitteeMember _tbl_addMasjidCommitteeMember = new tbl_AddMasjidCommitteeMember(model);
            if (model.Id != null && model.Id != 0)
            {
                _tbl_addMasjidCommitteeMember.Status = true;
                _tbl_AddMasjidCommitteeMember.Update(_tbl_addMasjidCommitteeMember);

            }
            else
            {
                _tbl_addMasjidCommitteeMember.CreatedBy = 1;
                _tbl_addMasjidCommitteeMember.CreateDate = System.DateTime.Now;
                _tbl_addMasjidCommitteeMember.Status = true;
                _tbl_addMasjidCommitteeMember = _tbl_AddMasjidCommitteeMember.Insert(_tbl_addMasjidCommitteeMember);
            }

            return _tbl_addMasjidCommitteeMember.Id;
        }


    }
}
