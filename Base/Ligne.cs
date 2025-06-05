using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Base
{
    public class Ligne
    {
        //Propriétés
        public int _NLigne;
        public string _NomLigne;
        public string _Destination;

        //Constructeur
        public Ligne(int id, string nom, string destination)
        {
            _NLigne = id;
            _NomLigne = nom;
            _Destination = destination;
        }
        //Accessors
        public int NLigne
        {
            get { return _NLigne; }
            set { _NLigne = value; }
        }

        public string NomLigne
        {
            get { return _NomLigne; }
            set { _NomLigne = value; }
        }

        public string Destination
        {
            get { return _Destination; }
            set { _Destination = value; }
        }

        //Méthodes



    }
}
