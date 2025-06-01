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

    }
}
