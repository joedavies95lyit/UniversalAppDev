using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TV_Guide
{
    class CastRole
    {
        private string desc;
        private DateTime dateTime;

        public CastRole(string desc, DateTime dateTime)
        {
            this.desc = desc;
            this.dateTime = dateTime;
        }

        public String Description { get; set; }
        public DateTime ActiveFrom { get; set; }
    }
}
