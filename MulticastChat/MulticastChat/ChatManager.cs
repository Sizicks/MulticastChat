using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.ComponentModel;
using System.Threading;

namespace MulticastChat
{
    class ChatManager
    {
        private User uUser;
        private ChatReceiver crChatReceiver;
        private ChatSender csChatSender;
        private List<Message> lChatHistory;
        private Thread rcThread;
        public event EventHandler<MessageReceivedEventArgs> MessageReceived; //L'event Handler qui handle les messages reçus.

        public List<Message> ChatHistory
        {
            get
            {
                return lChatHistory;
            }

            set
            {
                lChatHistory = value;
            }
        }

        public ChatManager(string _pseudo)
        {
            uUser = new User(_pseudo);
            crChatReceiver = new ChatReceiver();
            csChatSender = new ChatSender();
            lChatHistory = new List<Message>();
        }

        public void Connect()
        {
            csChatSender.Connect();
            crChatReceiver.Bind();
            rcThread = new Thread(new ThreadStart(ReceiveListener));
            rcThread.Start();
            csChatSender.SendRequestUser(uUser);
        }

        //Fonction de réception de messages à partir du chatReceiver, dans un nouveau thread.
        private void ReceiveListener()
        {
            while (true)
            {
                crChatReceiver.Receive(delegate (String strMessage)
                {
                    string[] arMessage = strMessage.Split(':');
                    switch(Convert.ToInt32(arMessage[0]))
                    {
                        case 0 : if (arMessage.Length == 3)
                            {
                                Message mMsg = new Message(arMessage[1], DateTime.Now, arMessage[2]);
                                lChatHistory.Add(mMsg);
                                MessageReceivedEventArgs MREA = new MessageReceivedEventArgs();
                                MREA.iFlag = 0;
                                MREA.mMsg = mMsg;
                                OnMessageReceived(MREA);
                            }
                            break;
                        case 1 : if (arMessage.Length == 2)
                            {
                                MessageReceivedEventArgs MREA = new MessageReceivedEventArgs();
                                MREA.iFlag = 1;
                                MREA.mMsg = new Message(arMessage[1], default(DateTime), String.Empty);
                                OnMessageReceived(MREA);
                                csChatSender.SendResponse(uUser);
                            }
                            break;
                        case 2 : if (arMessage.Length == 2) 
                            {
                                User uTmp = new User(arMessage[1]);
                                MessageReceivedEventArgs MREA = new MessageReceivedEventArgs();
                                MREA.iFlag = 2;
                                MREA.mMsg = new Message(arMessage[1], default(DateTime), String.Empty);
                                OnMessageReceived(MREA);
                            }
                            break;
                        case 3:
                            if (arMessage.Length == 2)
                            {
                                User uTmp = new User(arMessage[1]);
                                MessageReceivedEventArgs MREA = new MessageReceivedEventArgs();
                                MREA.iFlag = 3;
                                MREA.mMsg = new Message(arMessage[1], default(DateTime), String.Empty);
                                OnMessageReceived(MREA);
                            }
                            break;
                    }
                    /*
                    lChatHistory.Add(mMsg);

                    MessageReceivedEventArgs MREA = new MessageReceivedEventArgs();
                    MREA.mMsg = mMsg;
                    OnMessageReceived(MREA);
                    */
                });
            }
        }

        //Méthode à laquelle on va bind notre méthode pour handle les messages reçus.
        protected virtual void OnMessageReceived(MessageReceivedEventArgs _MREA)
        {
            EventHandler <MessageReceivedEventArgs> handler = MessageReceived;
            if (handler != null)
            {
                handler(this, _MREA);
            }
        }

        public void Send(string strMsg)
        {
            try
            {
                csChatSender.SendMsg(new Message (uUser.Pseudo, default(DateTime), strMsg)); //Datetime inutile dans le send, puisqu'on l'initialise quand on le reçoit
            }
            catch{}
        }

        public bool Close()
        {
            try
            {
                csChatSender.SendQuit(uUser);
                csChatSender.Close();
                crChatReceiver.Close();
                rcThread.Abort();
                return true;
            }
            catch
            {
                return false;
            }
        }
    }

    /* Quand le type de messages est 0, c'est un message
     * Si le type est 1, quelq'un demande que les utilisateurs s'annoncent
     * Le type 2 est la réponse au type 1
     * */
}
