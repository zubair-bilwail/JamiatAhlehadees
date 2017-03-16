using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonLayer.CommonModels
{
    public class MasjidExtension
    {

        public int Id { get; set; }

        public string SadrEMasjid { get; set; }

        public string Contact { get; set; }

        
        public string Location { get; set; }

        public int? MasjidId { get; set; }
        public string MasjidName { get; set; }

        public int? Area { get; set; }

        public int? ConstructionCost { get; set; }

        public int? ExistingFloors { get; set; }

        public int? AmountCollected { get; set; }

        public int? CommitteeId { get; set; }
        public string CommitteeName { get; set; }

        public int? UserId { get; set; }

        public string Name { get; set; }

        public string UserContact { get; set; }

        public int? Head { get; set; }

        
        public string EngineerName { get; set; }

        
        public string EngineerContact { get; set; }

        
        public byte[] ElevationImg { get; set; }

        
        public string PlanImg { get; set; }

        
        public string ConstructionImg1 { get; set; }

        
        public string ConstructionImg2 { get; set; }

        
        public string ConstructionImg3 { get; set; }

        
        public DateTime? CreatedDate { get; set; }

        public int? CreatedBy { get; set; }

        public bool? Status { get; set; }



        public List<MasjidExtension> MasjidExtensionList { get; set; }

        public List<AddMasjidCommittee> AddMasjidCommitteeList { get; set; }

        public List<AddMasjid> AddMasjidList { get; set; }

        public List<User> UserList { get; set; }
        

    }
}
