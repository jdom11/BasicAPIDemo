using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BasicAPIDemo.Models
{
    public class PublicHoliday
    { 

        public string PublicHolidayID { get; set; }
        public string date { get; set; }
        public string localName { get; set; }
        public string name { get; set; }
        public string countryCode { get; set; }
        public bool fixedName { get; set; }
        public bool GlobalName { get; set; }
        public string countries { get; set; }
        public int launchYear { get; set; }
        public string type { get; set; }
    }
}
