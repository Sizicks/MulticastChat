using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MulticastChat
{
    class User:IEquatable<User>
    {
        private string strPseudo;

        public string Pseudo
        {
            get
            {
                return strPseudo;
            }

            set
            {
                strPseudo = value;
            }
        }

        public User(string _pseudo)
        {
            Pseudo = _pseudo;
        }

        public override string ToString()
        {
            return Pseudo;
        }

        public bool Equals(User other)
        {
            return this.Pseudo == other.Pseudo;
        }
    }
}
