using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Krokoz.CRM.DL.EntityModels
{
    public class AspNetUserLogins
    {
        [Key]
        [MaxLength(128)]
        [Required]
        public string LoginProvider { get; set; }
        [Key]
        [MaxLength(128)]
        [Required]
        public string ProviderKey { get; set; }
        [Key]
        [MaxLength(128)]
        [Required]
        [Index]
        [ForeignKey("UserId")]
        public string UserId { get; set; }
        public virtual AspNetUsers AspNetUsers { get; set; }
    }
}
