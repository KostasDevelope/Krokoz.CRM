using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Krokoz.CRM.DL.EntityModels
{
    public class AspNetUserClaims
    {
        [Required]
        [Key]
        public int Id { get; set; }
        [MaxLength(128)]
        [Required]
        [ForeignKey("UserId")]
        public string UserId { get; set; }

        public string ClaimType { get; set; }
        public string ClaimValue { get; set; }
    
        public virtual AspNetUsers AspNetUsers { get; set; }
    }
}
