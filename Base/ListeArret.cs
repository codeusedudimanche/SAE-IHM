using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Base
{
    public class ListeArret
    {
        // Propriétés
        public List<Arret> _mesArret = new List<Arret>();


        // Constructeur
        public ListeArret()
        {
            _mesArret = new List<Arret>();
        }
        //accesseurs
        public List<Arret> MesArret { get { return _mesArret; } }

        //Méthodes

        public void AjoutArret(int id, string nom, double longitude, double latitude)
        {
            Arret arret = new Arret(id, nom, longitude, latitude);
            _mesArret.Add(arret);

        }
        public void SupprimerArret(Arret arret)
        {
            _mesArret.Remove(arret);

        }
    }

}
