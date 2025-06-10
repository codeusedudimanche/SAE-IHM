using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Base
{
    public class Horaire
    {
        public TimeSpan? Heure { get; set; }
        public int JourSemaine { get; set; }
        public int NLigne { get; set; } 
        public int NArret { get; set; } 

        public Horaire(TimeSpan? heure, int jourSemaine, int nLigne, int nArret)
        {
            Heure = heure;
            JourSemaine = jourSemaine;
            NLigne = nLigne;
            NArret = nArret;
        }
        

        
        public override string ToString()
        {
            string nomJour = "";
            switch (JourSemaine)
            {
                case 1: nomJour = "Jours de la semaine"; break;
                case 2: nomJour = "Jours feriée et week-end"; break;
                case 3: nomJour = "Jours de la semaine, feriée et week-end "; break;
            }

            return $"Ligne {NLigne} | {nomJour} | {(Heure.HasValue ? Heure.Value.ToString(@"hh\:mm") : "Non spécifié")}";
        }
    }
}
