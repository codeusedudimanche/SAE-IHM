using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Base
{
    public class ListeLigne
    {
        public List<Ligne> _mesLigne = new List<Ligne>();
        public ListeLigne() 
        {
            _mesLigne = new List<Ligne>();
        }

        public List<Ligne> MesLigne
        {
            get { return _mesLigne; }
        }

        public void AjoutLigne(int id, string nom, string destination)
        {
            Ligne ligne = new Ligne(id, nom, destination);
            _mesLigne.Add(ligne);
        }

        public void SupprimerLigne(Ligne ligne)
        {
            _mesLigne.Remove(ligne);
        }
    }
}
