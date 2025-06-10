using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Base
{
    public class Horaire
    {
        public TimeSpan Heure { get; set; }
        public int JourSemaine { get; set; }
        public int NLigne { get; set; } 
        public int NArret { get; set; } 

        public Horaire(TimeSpan heure, int jourSemaine, int nLigne, int nArret)
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
                case 1: nomJour = "Lundi"; break;
                case 2: nomJour = "Mardi"; break;
                case 3: nomJour = "Mercredi"; break;
                case 4: nomJour = "Jeudi"; break;
                case 5: nomJour = "Vendredi"; break;
                case 6: nomJour = "Samedi"; break;
                case 7: nomJour = "Dimanche"; break;
                default: nomJour = $"Jour {JourSemaine}"; break;
            }

            return $"Ligne {NLigne} | {nomJour} | {Heure.ToString(@"hh\:mm")}";
        }
    }
}
