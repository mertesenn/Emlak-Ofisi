using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AgentUI.Models
{
    public class User
    {
        public int ID { get; set; }
        public string NameSurname { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public int AdvertID { get; set; }
        public virtual List<Advert> Adverts { get; set; }
    }
}
