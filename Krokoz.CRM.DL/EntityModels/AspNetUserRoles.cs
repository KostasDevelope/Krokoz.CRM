using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Krokoz.CRM.DL.EntityModels
{
    public class AspNetUserRoles
    {
        [Key]
        [ForeignKey("UserId")]
        [MaxLength(128)]
        [Index]
        public string UserId { get; set; }

        [Key]
        [ForeignKey("RoleId")]
        [MaxLength(128)]
        [Index]
        public string RoleId { get; set; }
    }
}
