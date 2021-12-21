using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DataAccess1.Model
{
    public class ContactModel
    {
        [Required(ErrorMessage = "Jméno je vyžadováno"), Display(Name = "Vaše jméno")]
        public string SenderName { get; set; }
        [Required(ErrorMessage = "Email je vyžadován"), Display(Name = "Váš email"), EmailAddress]
        public string SenderEmail { get; set; }
        [Required(ErrorMessage = "Nezadali jste zprávu."),Display(Name = "Text zprávy")]
        public string Message { get; set; }
    }
}