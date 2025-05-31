using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Base
{
    public class Arret
    {
        //Propriétés
        public int _NArret;
        public string _NomArret;
        public double _LongitudeArret;
        public double _LatitudeArret;
        //Constructeur
        public Arret(int id, string nom, double longitude, double latitude)
        {
            _NArret = id;
            _NomArret = nom;
            _LongitudeArret = longitude;
            _LatitudeArret = latitude;

        }
        //Accesseurs
        public int Id { get { return _NArret; } }
        public string Nom { get { return _NomArret; } }
        public double Longitude { get { return _LongitudeArret; } }
        public double Latitude
        {
            get { return _LatitudeArret; }
        }
    }
}
