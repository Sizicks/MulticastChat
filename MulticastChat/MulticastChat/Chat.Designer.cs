namespace MulticastChat
{
    partial class Chat
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnClose = new System.Windows.Forms.Label();
            this.lblTitre = new System.Windows.Forms.Label();
            this.tbxMessage = new System.Windows.Forms.TextBox();
            this.btnSend = new System.Windows.Forms.Label();
            this.flpChat = new System.Windows.Forms.FlowLayoutPanel();
            this.lblOptions = new System.Windows.Forms.Label();
            this.lbxUsersConnected = new System.Windows.Forms.ListBox();
            this.lblUsersConnected = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.AutoSize = true;
            this.btnClose.BackColor = System.Drawing.Color.Red;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.SystemColors.Control;
            this.btnClose.Location = new System.Drawing.Point(620, 3);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(15, 13);
            this.btnClose.TabIndex = 5;
            this.btnClose.Text = "X";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            this.btnClose.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnClose_MouseDown);
            this.btnClose.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnClose_MouseUp);
            // 
            // lblTitre
            // 
            this.lblTitre.AutoSize = true;
            this.lblTitre.Font = new System.Drawing.Font("Roboto", 10F, System.Drawing.FontStyle.Bold);
            this.lblTitre.ForeColor = System.Drawing.SystemColors.Control;
            this.lblTitre.Location = new System.Drawing.Point(3, 2);
            this.lblTitre.Name = "lblTitre";
            this.lblTitre.Size = new System.Drawing.Size(38, 17);
            this.lblTitre.TabIndex = 7;
            this.lblTitre.Text = "Chat";
            // 
            // tbxMessage
            // 
            this.tbxMessage.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tbxMessage.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.tbxMessage.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbxMessage.Location = new System.Drawing.Point(6, 328);
            this.tbxMessage.MaxLength = 255;
            this.tbxMessage.Multiline = true;
            this.tbxMessage.Name = "tbxMessage";
            this.tbxMessage.Size = new System.Drawing.Size(434, 39);
            this.tbxMessage.TabIndex = 10;
            this.tbxMessage.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbxMessage_KeyDown);
            this.tbxMessage.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxMessage_KeyPress);
            // 
            // btnSend
            // 
            this.btnSend.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnSend.AutoSize = true;
            this.btnSend.BackColor = System.Drawing.Color.White;
            this.btnSend.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSend.ForeColor = System.Drawing.Color.SteelBlue;
            this.btnSend.Location = new System.Drawing.Point(447, 328);
            this.btnSend.Name = "btnSend";
            this.btnSend.Padding = new System.Windows.Forms.Padding(4, 10, 4, 10);
            this.btnSend.Size = new System.Drawing.Size(54, 39);
            this.btnSend.TabIndex = 11;
            this.btnSend.Text = "Send";
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            this.btnSend.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnSend_MouseDown);
            this.btnSend.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnSend_MouseUp);
            // 
            // flpChat
            // 
            this.flpChat.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flpChat.AutoScroll = true;
            this.flpChat.BackColor = System.Drawing.Color.White;
            this.flpChat.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flpChat.Location = new System.Drawing.Point(5, 21);
            this.flpChat.Name = "flpChat";
            this.flpChat.Padding = new System.Windows.Forms.Padding(5);
            this.flpChat.Size = new System.Drawing.Size(496, 301);
            this.flpChat.TabIndex = 12;
            this.flpChat.WrapContents = false;
            // 
            // lblOptions
            // 
            this.lblOptions.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblOptions.AutoSize = true;
            this.lblOptions.BackColor = System.Drawing.Color.SteelBlue;
            this.lblOptions.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOptions.ForeColor = System.Drawing.SystemColors.Control;
            this.lblOptions.Location = new System.Drawing.Point(564, 3);
            this.lblOptions.Name = "lblOptions";
            this.lblOptions.Size = new System.Drawing.Size(50, 13);
            this.lblOptions.TabIndex = 13;
            this.lblOptions.Text = "Options";
            this.lblOptions.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lblOptions_MouseClick);
            // 
            // lbxUsersConnected
            // 
            this.lbxUsersConnected.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbxUsersConnected.Enabled = false;
            this.lbxUsersConnected.FormattingEnabled = true;
            this.lbxUsersConnected.Location = new System.Drawing.Point(507, 39);
            this.lbxUsersConnected.Name = "lbxUsersConnected";
            this.lbxUsersConnected.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.lbxUsersConnected.Size = new System.Drawing.Size(128, 329);
            this.lbxUsersConnected.Sorted = true;
            this.lbxUsersConnected.TabIndex = 14;
            // 
            // lblUsersConnected
            // 
            this.lblUsersConnected.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblUsersConnected.AutoSize = true;
            this.lblUsersConnected.BackColor = System.Drawing.Color.SteelBlue;
            this.lblUsersConnected.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsersConnected.ForeColor = System.Drawing.SystemColors.Control;
            this.lblUsersConnected.Location = new System.Drawing.Point(507, 24);
            this.lblUsersConnected.Name = "lblUsersConnected";
            this.lblUsersConnected.Size = new System.Drawing.Size(76, 13);
            this.lblUsersConnected.TabIndex = 15;
            this.lblUsersConnected.Text = "Connected :";
            // 
            // Chat
            // 
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(643, 374);
            this.Controls.Add(this.lblUsersConnected);
            this.Controls.Add(this.lbxUsersConnected);
            this.Controls.Add(this.lblOptions);
            this.Controls.Add(this.flpChat);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.tbxMessage);
            this.Controls.Add(this.lblTitre);
            this.Controls.Add(this.btnClose);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "Chat";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Chat";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Chat_MouseDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label btnClose;
        private System.Windows.Forms.Label lblTitre;
        private System.Windows.Forms.TextBox tbxMessage;
        private System.Windows.Forms.Label btnSend;
        private System.Windows.Forms.FlowLayoutPanel flpChat;
        private System.Windows.Forms.Label lblOptions;
        private System.Windows.Forms.ListBox lbxUsersConnected;
        private System.Windows.Forms.Label lblUsersConnected;
    }
}

