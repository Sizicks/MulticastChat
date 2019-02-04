using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace MulticastChat
{
    public partial class Chat : Form
    {
        ChatManager cm;
        BindingList<User> lbUsersConnected;
        string strPseudo;

        //private Padding pPadding;
        //private Padding pMargin;
        
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        
        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        public Chat(string _strPseudo)
        {
            InitializeComponent();
            lbUsersConnected = new BindingList<User>();
            strPseudo = _strPseudo;

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cm = new ChatManager(strPseudo);
            cm.Connect();
            cm.MessageReceived += cm_OnMessageReceived; //Inscription à l'event de réception des messages.
            tbxMessage.Focus();
        }

        #region Les events de base du winform

        #region btnSend
        private void btnSend_Click(object sender, EventArgs e)
        {
            if (tbxMessage.Text != String.Empty)
            {
                cm.Send(tbxMessage.Text);
                tbxMessage.Focus();
                tbxMessage.Text = String.Empty;
            }
        }

        private void btnSend_MouseDown(object sender, MouseEventArgs e)
        {
            btnSend.BackColor = Color.SteelBlue;
            btnSend.ForeColor = Color.White;
        }

        private void btnSend_MouseUp(object sender, MouseEventArgs e)
        {
            btnSend.BackColor = Color.White;
            btnSend.ForeColor = Color.SteelBlue;
        }
        #endregion

        #region btnClose
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClose_MouseDown(object sender, MouseEventArgs e)
        {
            btnClose.BackColor = Color.White;
            btnClose.ForeColor = Color.Red;
        }

        private void btnClose_MouseUp(object sender, MouseEventArgs e)
        {
            btnClose.BackColor = Color.Red;
            btnClose.ForeColor = Color.White;
        }
        #endregion

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
            //Pourra être remplacé par un switch case, avec l'iFlag 3 pour la déconnection d'un utilisateur
            if (e.iFlag == 0)
            {
                AddMessageToChat(e.mMsg.ToString());
            }
            else if (e.iFlag == 1 || e.iFlag == 2)
            {
                User uTmp = new User(e.mMsg.Pseudo);

                if (!lbUsersConnected.Contains(uTmp) && uTmp.Pseudo != strPseudo)
                {
                    lbUsersConnected.Add(uTmp);
                    lbxUsersConnected.DataSource = null;
                    lbxUsersConnected.DataSource = lbUsersConnected;
                }
            }
            else if(e.iFlag == 3)
            {
                User uTmp = new User(e.mMsg.Pseudo);
                lbUsersConnected.Remove(uTmp);
                lbxUsersConnected.DataSource = null;
                lbxUsersConnected.DataSource = lbUsersConnected;
            }
        }

        #region Fonction de mise à jour du chat
        delegate void AddMessageToChatCallback(string text);

        private void AddMessageToChat(String msg)
        {
            //Fonction pour accéder à la listView, vu qu'il est impossible d'accéder à un élément d'un autre thread
            if (this.flpChat.InvokeRequired)
            {
                AddMessageToChatCallback d = new AddMessageToChatCallback(AddMessageToChat);
                this.Invoke(d, new object[] { msg });  // ou (d, text)
            }
            else
            {
                Label lblTmp = new Label();
                lblTmp.Font = new Font("Roboto",8);
                lblTmp.Padding = new Padding(3);
                lblTmp.Margin = new Padding(2);
                lblTmp.FlatStyle = System.Windows.Forms.FlatStyle.Standard;
                lblTmp.Text = msg;
                lblTmp.AutoSize = true;

                if (msg.ToLower().Contains("@"+strPseudo.ToLower()))
                {
                    lblTmp.BackColor = Color.SteelBlue;
                    lblTmp.ForeColor = Color.White;
                }

                this.flpChat.Controls.Add(lblTmp);
                this.flpChat.ScrollControlIntoView(lblTmp);
            }
        }
        #endregion

        private void Chat_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private bool keydowncalled = false;

        private void tbxMessage_KeyDown(object sender, KeyEventArgs e)
        {
            keydowncalled = false;
            if (e.KeyData == Keys.Enter)
            {
                keydowncalled = true;
                cm.Send(tbxMessage.Text);
                tbxMessage.Focus();
                tbxMessage.Text = String.Empty;
            }
        }

        private void tbxMessage_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (keydowncalled == true)
            {
                // Stop the newline from being entered into the control.
                e.Handled = true;
            }
        }

        private void lblOptions_MouseClick(object sender, MouseEventArgs e)
        {
            //Ouvrir la fenêtre d'options
        }
    }
}
