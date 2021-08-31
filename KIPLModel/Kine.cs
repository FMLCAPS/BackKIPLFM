using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KIPLModel
{
    public class Kine
    {
        public int Id { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public DateTime DateDeNaissance { get; set; }
        public string Numero { get; set; }
        public string Email { get; set; }

        public int? CabinetId { get; set; }
        public Cabinet Cabinet { get; set; }


    }
}
