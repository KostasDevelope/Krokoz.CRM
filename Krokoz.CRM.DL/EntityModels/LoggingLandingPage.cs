using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Krokoz.CRM.DL.EntityModels
{
   public class LoggingLandingPage
    {
        [Key]
        [Required]
        public long Id { get; set; }

        [ForeignKey("UserId")]
        [Required]
        public string UserId { get; set; }
       
        [ForeignKey("UserId")]
        public long LandingPageNameId { get; set; }

        [ForeignKey("LandingTypeId")]
        [Required]
        public long LandingTypeId { get; set; }
        public DateTime Created { get; set; }

        public virtual AspNetUsers User { get; set; }
        public virtual LandingType LandingType { get; set; }
        public virtual LandingPageName LandingPageName { get; set; }
    }
}
