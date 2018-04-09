using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Krokoz.CRM.DL.EntityModels
{
    [Table("LandingPageName")]

    public  class LandingPageName
    {
        public LandingPageName()
        {
            LoggingLandingPages = new HashSet<LoggingLandingPage>();
        }
        [Key]
        [Required]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
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
