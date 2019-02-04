using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MulticastChat
{
    class Message
    {
        private string strPseudo;
        private DateTime dtReceiveTime;
        private string strText;

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

        public DateTime ReceiveTime
        {
            get
            {
                return dtReceiveTime;
            }

            set
            {
                dtReceiveTime = value;
            }
        }

        public string Text
        {
            get
            {
                return strText;
            }

            set
            {
                strText = value;
            }
        }

        public Message(string _strPseudo, DateTime _dtReceiveTime, string _strText)
        {
            Pseudo = _strPseudo;
            ReceiveTime = _dtReceiveTime;
            Text = _strText;
        }

        public override string ToString()
        {
            return "[" + ReceiveTime.ToShortTimeString() + "] " + Pseudo + " : " + Text; 
        }
    }
}
