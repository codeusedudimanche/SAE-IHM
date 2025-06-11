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

        public override string ToString()
        {
            return $"Ligne {_NLigne} - {_NomLigne}";
        }

        public override bool Equals(object obj)
        {
            if (obj is Ligne other)
            {
                return NLigne == other.NLigne;
            }
            return false;
        }

        /// <summary>
        public override int GetHashCode()
        {
            return NLigne.GetHashCode();
        }

        //Getters pour la classe Ligne
        public int GetNLigne()
        {
            return _NLigne;
        }

        public string GetNomLigne()
        {
            return _NomLigne;
        }

        public string GetDestination()
        {
            return _Destination;
        }

    }
}
