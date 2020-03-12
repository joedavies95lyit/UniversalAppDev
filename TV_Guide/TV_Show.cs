using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TV_Guide
{
    class TV_Show
    {
        public String Title { get; set; }
        public String Year { get; set; }
        public String Genre { get; set; }
        public String Photo { get; set; }
        public String Channel { get; set; }
        public List<CastMember> castList { get; set; }
    }
}
