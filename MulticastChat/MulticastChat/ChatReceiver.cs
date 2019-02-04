using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MulticastChat
{
    class ChatReceiver
    {
        private const string ADDRESS = "224.5.6.7";
        private const Int32 PORT = 4567;
        private Socket sReceiver;
        private IPAddress ip;
        private IPEndPoint ipep;

        public ChatReceiver()
        {
            sReceiver = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
            ip = IPAddress.Parse(ADDRESS);
        }

        //TODO: Constructeur pour la connection à un autre channel

        public int Bind()
        {
            try
            {
                ipep = new IPEndPoint(IPAddress.Any, 4567);
                sReceiver.Bind(ipep);
                sReceiver.SetSocketOption(SocketOptionLevel.IP, SocketOptionName.AddMembership, new MulticastOption(ip, IPAddress.Any));
                return 1;
            }
            catch
            {
                return -1;
            }
        }

        public void Receive(Action <String> MsgReceive)
        {
            while (true)
            {
                byte[] b = new byte[1024];
                sReceiver.Receive(b);
                //string[] strMsg = System.Text.Encoding.UTF8.GetString(b, 0, b.Length).Replace("\0", string.Empty).Split(':'); ;
                //Message mMsg = new Message(strMsg[0], DateTime.Now, strMsg[1]);
                MsgReceive(System.Text.Encoding.UTF8.GetString(b, 0, b.Length).Replace("\0", string.Empty));
            }
        }

        public void Close()
        {
            sReceiver.Close();
        }
    }
}
