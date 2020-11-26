using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class PriorityDto
    {
        public int PriorityId { get; set; }
        public int PriorityValue { get; set; }
        public string PriorityDescription { get; set; }
        public Nullable<int> Show { get; set; }

    }
}
