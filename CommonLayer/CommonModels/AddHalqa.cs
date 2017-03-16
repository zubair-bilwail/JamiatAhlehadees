using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonLayer.CommonModels
{
    public class AddHalqa
    {
        public int Id { get; set; }

        public string HalqaName { get; set; }

        public string Area { get; set; }

        public int? CreatedBy { get; set; }

        public DateTime? CreatedDate { get; set; }

        public bool? Status { get; set; }

        public List<AddHalqa> AddHalqaList { get; set; }
    }
}
