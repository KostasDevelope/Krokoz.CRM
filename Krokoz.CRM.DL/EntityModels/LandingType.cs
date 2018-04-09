using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Krokoz.CRM.DL.EntityModels
{
    public class LandingType
    {
        public LandingType()
        {
            LoggingLandingPages = new HashSet<LoggingLandingPage>();
        }
        [Key]
        [Required]
        public long Id { get; set; }
        public DateTime Created { get; set; }
        public DateTime? Modified { get; set; }
        [Required]
        [MaxLength(256)]
        public int Type { get; set; }
        public virtual ICollection<LoggingLandingPage> LoggingLandingPages { get; set; }
    }
}
