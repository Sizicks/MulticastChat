using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MulticastChat
{
    public partial class Form1 : Form
    {
        ChatManager cm;
        List<Message> lChatList;

        public Form1()
        {
            InitializeComponent();
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lChatList = new List<Message>();
            cm = new ChatManager("Séb");
            cm.Connect();
            cm.MessageReceived += cm_OnMessageReceived; //Inscription à l'event de réception des messages.

            //listView Configuration
            ColumnHeader header = new ColumnHeader();
            header.Text = "";
            header.Name = "col1";
            lvChat.Columns.Add(header);
            lvChat.HeaderStyle = ColumnHeaderStyle.None;
        }

        #region Les events de base du winform
        private void btnSend_Click(object sender, EventArgs e)
        {
            cm.Send(tbxMessage.Text);
            tbxMessage.Text = "";
            tbxMessage.Focus();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(!cm.Close())
            {
                MessageBox.Show("Cm can't be closed");
            }
        }
        #endregion

        // L'event pour être prévenu lorsqu'un message est reçu.
        private void cm_OnMessageReceived(object sender, MessageReceivedEventArgs e)
        {
            lChatList.Add(new Message(e.UserName, DateTime.Now, e.Message));
            AddMessageToChat(e.UserName + ": " + e.Message);
        }

        #region Fonction de mise à jour de la listView
        delegate void AddMessageToChatCallback(string text);

        private void AddMessageToChat(String msg)
        {
            //Fonction pour accéder à la listView, vu qu'il est impossible d'accéder à un élément d'un autre thread
            if (this.lvChat.InvokeRequired)
            {
                AddMessageToChatCallback d = new AddMessageToChatCallback(AddMessageToChat);
                this.Invoke(d, new object[] { msg });  // ou (d, text)
            }
            else
            {
                ListViewItem lviTmp = new ListViewItem(msg);
                lviTmp.ToolTipText = DateTime.Now.ToShortTimeString();
                this.lvChat.Items.Add(lviTmp);
                this.lvChat.EnsureVisible(lChatList.Count-1); //-1 Pour avoir le bonne index, vu que c'est le nombre d'item et non pas l'index
            }
        }
        #endregion

    }
}
