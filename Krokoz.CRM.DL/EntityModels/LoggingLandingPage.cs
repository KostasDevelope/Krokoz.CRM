using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Krokoz.CRM.DL.EntityModels
{
    [Table("LoggingLandingPage")]
    public class LoggingLandingPage
    {
        [Key]
        [Required]
        public long Id { get; set; }

        public string UserId { get; set; }
 
        public long LandingPageNameId { get; set; }

        [Required]
        public long LandingTypeId { get; set; }
        public DateTime Created { get; set; }

        //public virtual AspNetUsers User { get; set; }
        public virtual LandingType LandingType { get; set; }
        public virtual LandingPageName LandingPageName { get; set; }
    }
}
