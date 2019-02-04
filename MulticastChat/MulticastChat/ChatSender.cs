using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace MulticastChat
{
    class ChatSender
    {
        private const string ADDRESS = "224.5.6.7";
        private const Int32 PORT = 4567;
        private Socket sSender;
        private IPAddress ip;

        public ChatSender()
        {
            sSender = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
            ip = IPAddress.Parse(ADDRESS);
        }

        //TODO: Constructeur pour la connection à un autre channel

        public int Connect()
        {
            try
            {
                sSender.SetSocketOption(SocketOptionLevel.IP, SocketOptionName.AddMembership, new MulticastOption(ip));
                sSender.SetSocketOption(SocketOptionLevel.IP, SocketOptionName.MulticastTimeToLive, 2);
                IPEndPoint ipep = new IPEndPoint(ip, PORT);
                sSender.Connect(ipep);
                return 1;
            }
            catch
            {
                return -1;
            }
        }

        public void SendMsg(Message msg)
        {
            //Envoie le message sous forme pseudo:message
            string strMsg = "0:" + msg.Pseudo + ":" + msg.Text;
            byte[] bMsg = new byte[strMsg.Length];

            bMsg = Encoding.UTF8.GetBytes(strMsg);

            sSender.Send(bMsg, bMsg.Length, SocketFlags.None);
        }

        public void SendRequestUser(User uUser)
        {
            //Envoie le message sous forme pseudo:message
            string strRequest = "1:" + uUser.Pseudo;
            byte[] bRequest = new byte[strRequest.Length];

            bRequest = Encoding.UTF8.GetBytes(strRequest);

            sSender.Send(bRequest, bRequest.Length, SocketFlags.None);
        }

        public void SendResponse(User uUser)
        {
            //Envoie le message sous forme pseudo:message
            string strResponse = "2:" + uUser.Pseudo;
            byte[] bResponse = new byte[strResponse.Length];

            bResponse = Encoding.UTF8.GetBytes(strResponse);

            sSender.Send(bResponse, bResponse.Length, SocketFlags.None);
        }

        public void SendQuit(User uUser)
        {
            //Envoie le message sous forme pseudo:message
            string strResponse = "3:" + uUser.Pseudo;
            byte[] bResponse = new byte[strResponse.Length];

            bResponse = Encoding.UTF8.GetBytes(strResponse);

            sSender.Send(bResponse, bResponse.Length, SocketFlags.None);
        }

        public void Close()
        {
            sSender.Close();
        }
    }
}
