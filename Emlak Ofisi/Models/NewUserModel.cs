using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Emlak_Ofisi.Models
{
    public class NewUserModel
    {
        [Display(Name = "Firma Adı")]
        [Required(ErrorMessage = "Firma Adı Giriniz !")]
        public string CompanyName { get; set; }

        [Required(ErrorMessage = "Kullanıcı Adı Giriniz !")]
        public string UserName { get; set; }
        public string Password { get; set; }
    }
}
