using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonLayer.CommonModels
{
   public class MasjidConstruction
    {
        public int Id { get; set; }

      
        public string Location { get; set; }

        public int? Area { get; set; }

        public int? ConstructionCost { get; set; }

        public int? Floors { get; set; }

        public int? AmountCollected { get; set; }

        public int? UserId { get; set; }

        public int? CommitteeId { get; set; }

        public int? Head { get; set; }

       
        public string EngineerName { get; set; }

        
        public string EngineerContact { get; set; }

        
        public string ElevationImg { get; set; }

       
        public string PlanImg { get; set; }

       
        public string ConstructionImg1 { get; set; }

       
        public string ConstructionImg2 { get; set; }

        
        public string ConstructionImg3 { get; set; }

        
        public DateTime? CreatedDate { get; set; }

        public int? CreatedBy { get; set; }
        public string CommitteeName { get; set; }

        public bool? Status { get; set; }
            public string Name { get; set; }

        public List<MasjidConstruction> MasjidConstructionList { get; set; }

        public List<AddMasjidCommittee> AddMasjidCommitteeList { get; set; }
       
        public List<User> UserList { get; set; }
    }
}
