using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AgentUI.Models
{
    public class Advert
    {
        public int ID { get; set; }

        [Display(Name = "Şehir")]
        public string City { get; set; }

        [Display(Name = "Bina Yaşı")]
        public int AgeofBuild { get; set; }

        [Display(Name = "İlçe")]
        public string district { get; set; }

        [Display(Name = "Oda Sayısı")]
        public int NumberOfRoom { get; set; }

        [Display(Name = "Metrekare")]
        public int SquareMeters { get; set; }

        [Display(Name = "Bulunduğu Kat")]
        public int BuildFloor { get; set; }

        [Display(Name = "Bina Kat Sayısı")]
        public int TotalFloor { get; set; }

        public virtual User Users { get; set; }
    }
}
