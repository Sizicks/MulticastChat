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
    public partial class Accueil : Form
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        
        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        public Accueil()
        {
            InitializeComponent();
        }


        private void Accueil_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        #region btnOk
        private void btnOk_Click(object sender, EventArgs e)
        {
            Chat chat = new MulticastChat.Chat(tbxPseudo.Text);
            this.Visible = false;
            chat.ShowDialog();
            this.Close();
        }

        private void btnOk_MouseDown(object sender, MouseEventArgs e)
        {
            btnOk.BackColor = Color.SteelBlue;
            btnOk.ForeColor = Color.White;
        }

        private void btnOk_MouseUp(object sender, MouseEventArgs e)
        {
            btnOk.BackColor = Color.White;
            btnOk.ForeColor = Color.SteelBlue;
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

        private void tbxPseudo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                btnOk_Click(null, default(EventArgs));
            }
        }
    }
}
