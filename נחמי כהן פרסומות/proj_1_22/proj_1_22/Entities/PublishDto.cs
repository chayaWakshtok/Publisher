using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class PublishDto
    {
        public int Id { get; set; }
        public Nullable<int> CompanyId { get; set; }
        public string CompanyName { get; set; }
        public int Priority { get; set; }
        public System.DateTime StartDate { get; set; }
        public System.DateTime EndDate { get; set; }
        public string Video { get; set; }
        public Nullable<int> TotalShow { get; set; }
        public  string PriorityName { get; set; }
    }
}
