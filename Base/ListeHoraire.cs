using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Base
{
    public class ListeHoraire
    {
        public List<Horaire> _mesHoraires = new List<Horaire>();

        public ListeHoraire()
        {
            _mesHoraires = new List<Horaire>();
        }

        public List<Horaire> MesHoraires { get { return _mesHoraires; } }

        public void AjoutHoraire(TimeSpan heure, int jourSemaine, int nLigne, int nArret)
        {
            Horaire horaire = new Horaire(heure, jourSemaine, nLigne, nArret);
            _mesHoraires.Add(horaire);
        }


        public void SupprimerHoraire(Horaire horaire)
        {
            _mesHoraires.Remove(horaire);
        }
    }
}
