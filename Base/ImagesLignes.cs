using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Base
{
    public class ImagesLignes
    {
        public int _NLigne;
        public string CheminImage;

        public ImagesLignes(int nLigne, string cheminImage)
        {
            _NLigne = nLigne;
            CheminImage = cheminImage;
        }
    }
}
