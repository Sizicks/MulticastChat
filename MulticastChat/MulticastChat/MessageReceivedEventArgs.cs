using System;

namespace MulticastChat
{
    //Classe afin de pouvoir gérer nous même ce que retourne notre event.
    class MessageReceivedEventArgs
    {
        public int iFlag { get; set; }
        public Message mMsg { get; set; }
    }
}
