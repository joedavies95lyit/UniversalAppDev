using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TV_Guide
{
    class CastMember
    {
        public String FirstName { get; set; }
        public String LastName { get; set; }
        public CastRole Role { get; set; }
        public DateTime DOB { get; set; }
    }
}
