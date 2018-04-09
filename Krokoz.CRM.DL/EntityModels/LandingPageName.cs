using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Krokoz.CRM.DL.EntityModels
{
    public  class LandingPageName
    {
        public LandingPageName()
        {
            LoggingLandingPages = new HashSet<LoggingLandingPage>();
        }
        [Key]
        [Required]
        public long Id { get; set; }
        [MaxLength(256)]
        [Required]
        public string PageName { get; set; }
        [Required]
        public DateTime Created { get; set; }
        public DateTime? Modified { get; set; }
        public virtual ICollection<LoggingLandingPage> LoggingLandingPages { get; set; }
    }
}
