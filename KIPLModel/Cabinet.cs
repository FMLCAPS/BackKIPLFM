using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KIPLModel
{
    public class Cabinet
    {
        public int Id { get; set; }
        public string Libelle { get; set; }
        public string Adresse { get; set; }
        public TimeSpan? HeureOuverture { get; set; }
        public TimeSpan? HeureFermeture { get; set; }
        public int NombrePlaces { get; set; }

        public IList<Kine> Kines { get; set; }

    }
}
