using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class UserDto
    {
        public int UserID { get; set; }
        public string UserPassword { get; set; }
        public bool IsAdmin { get; set; }
        public string Username { get; set; }
        public Nullable<int> CompanyId { get; set; }
        public CompanyDto Company { get; set; }
    }
}
