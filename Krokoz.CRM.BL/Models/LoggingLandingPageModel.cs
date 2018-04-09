using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Krokoz.CRM.BL.Models
{
    public class LoggingLandingPageModel
    {
        public string PageName { get; set; }
        public DateTime Created { get; set; }
        public int LandingType { get; set; }
        public  string UserName { get; set; }
    }
}
