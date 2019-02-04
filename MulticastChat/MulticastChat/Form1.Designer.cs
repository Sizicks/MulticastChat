namespace MulticastChat
{
    partial class Form1
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
            this.btnSend = new System.Windows.Forms.Button();
            this.tbxMessage = new System.Windows.Forms.TextBox();
            this.lvChat = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // btnSend
            // 
            this.btnSend.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSend.AutoSize = true;
            this.btnSend.Location = new System.Drawing.Point(321, 347);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(75, 26);
            this.btnSend.TabIndex = 1;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // tbxMessage
            // 
            this.tbxMessage.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxMessage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxMessage.Location = new System.Drawing.Point(5, 347);
            this.tbxMessage.Multiline = true;
            this.tbxMessage.Name = "tbxMessage";
            this.tbxMessage.Size = new System.Drawing.Size(310, 26);
            this.tbxMessage.TabIndex = 2;
            // 
            // lvChat
            // 
            this.lvChat.Location = new System.Drawing.Point(-2, 1);
            this.lvChat.MultiSelect = false;
            this.lvChat.Name = "lvChat";
            this.lvChat.ShowItemToolTips = true;
            this.lvChat.Scrollable = true;
            this.lvChat.Size = new System.Drawing.Size(398, 340);
            this.lvChat.TabIndex = 3;
            this.lvChat.UseCompatibleStateImageBehavior = false;
            this.lvChat.View = System.Windows.Forms.View.Details;
            // 
            // Form1
            // 
            this.AcceptButton = this.btnSend;
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(396, 378);
            this.Controls.Add(this.lvChat);
            this.Controls.Add(this.tbxMessage);
            this.Controls.Add(this.btnSend);
            this.DoubleBuffered = true;
            this.Name = "Form1";
            this.Text = "Chat";
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.TextBox tbxMessage;
        private System.Windows.Forms.ListView lvChat;
    }
}

