using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Krokoz.CRM.MVCClient.ViewModels
{
    public class LeadViewModel
    {
        public long Id { get; set; }

        [Required(ErrorMessage = "Field can't be empty")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Field can't be empty")]
        [DataType(DataType.EmailAddress, ErrorMessage = "E-mail is not valid")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Field can't be empty")]
        [DataType(DataType.PhoneNumber, ErrorMessage = "PhoneNumber is not valid")]
        public string Telephone { get; set; }

        [Required(ErrorMessage = "Field can't be empty")]
        public string Message { get; set; }
    }

    
}