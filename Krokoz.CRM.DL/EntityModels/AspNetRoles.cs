using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Krokoz.CRM.DL.EntityModels
{
    public class AspNetRoles
    {
        public AspNetRoles()
        {
            this.AspNetUsers = new HashSet<AspNetUsers>();
        }
        [Key]
        [MaxLength(128)]
        public string Id { get; set; }

        [MaxLength(256)]
        [Index]
        public string Name { get; set; }

        public virtual ICollection<AspNetUsers> AspNetUsers { get; set; }
    }
}
