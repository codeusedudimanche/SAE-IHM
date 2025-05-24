using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Base_Donnee_Bus
{
    internal class User
    {
        //Propriétés
        public int _id;
        public string _email;
        public string _pseudo;
        public string _motDePasse;
        public int _codeReinitialisation;

        //Constructeur
        public User(int id, string email, string pseudo, string motDePasse, int codeReinitialisation)
        {
            this._id = id;
            this._email = email;
            this._pseudo = pseudo;
            this._motDePasse = motDePasse;
            this._codeReinitialisation = codeReinitialisation;
        }
        //Accesseurs
        public int Id { get { return _id; } }
        public string Email { get { return _email; } }
        public string Pseudo { get { return _pseudo; } }
        public string MotDePasse { get { return _motDePasse; } }
        public int CodeReinitialisation { get { return _codeReinitialisation; } }

    }

}
