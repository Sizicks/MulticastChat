namespace MulticastChat
{
    partial class Accueil
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnClose = new System.Windows.Forms.Label();
            this.lblPseudo = new System.Windows.Forms.Label();
            this.tbxPseudo = new System.Windows.Forms.TextBox();
            this.btnOk = new System.Windows.Forms.Label();
            this.lblTitre = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.AutoSize = true;
            this.btnClose.BackColor = System.Drawing.Color.Red;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.SystemColors.Control;
            this.btnClose.Location = new System.Drawing.Point(214, 3);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(15, 13);
            this.btnClose.TabIndex = 0;
            this.btnClose.Text = "X";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            this.btnClose.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnClose_MouseDown);
            this.btnClose.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnClose_MouseUp);
            // 
            // lblPseudo
            // 
            this.lblPseudo.AutoSize = true;
            this.lblPseudo.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPseudo.ForeColor = System.Drawing.SystemColors.Control;
            this.lblPseudo.Location = new System.Drawing.Point(12, 28);
            this.lblPseudo.Name = "lblPseudo";
            this.lblPseudo.Size = new System.Drawing.Size(94, 13);
            this.lblPseudo.TabIndex = 1;
            this.lblPseudo.Text = "Entrer un pseudo:";
            // 
            // tbxPseudo
            // 
            this.tbxPseudo.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.tbxPseudo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbxPseudo.Location = new System.Drawing.Point(109, 28);
            this.tbxPseudo.MaxLength = 10;
            this.tbxPseudo.Name = "tbxPseudo";
            this.tbxPseudo.Size = new System.Drawing.Size(111, 13);
            this.tbxPseudo.TabIndex = 2;
            this.tbxPseudo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxPseudo_KeyPress);
            // 
            // btnOk
            // 
            this.btnOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOk.AutoSize = true;
            this.btnOk.BackColor = System.Drawing.Color.White;
            this.btnOk.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOk.ForeColor = System.Drawing.Color.SteelBlue;
            this.btnOk.Location = new System.Drawing.Point(190, 47);
            this.btnOk.Name = "btnOk";
            this.btnOk.Padding = new System.Windows.Forms.Padding(3);
            this.btnOk.Size = new System.Drawing.Size(30, 19);
            this.btnOk.TabIndex = 3;
            this.btnOk.Text = "OK";
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            this.btnOk.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnOk_MouseDown);
            this.btnOk.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnOk_MouseUp);
            // 
            // lblTitre
            // 
            this.lblTitre.AutoSize = true;
            this.lblTitre.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitre.ForeColor = System.Drawing.SystemColors.Control;
            this.lblTitre.Location = new System.Drawing.Point(12, 1);
            this.lblTitre.Name = "lblTitre";
            this.lblTitre.Size = new System.Drawing.Size(50, 15);
            this.lblTitre.TabIndex = 4;
            this.lblTitre.Text = "Accueil";
            // 
            // Accueil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(232, 72);
            this.Controls.Add(this.lblTitre);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.tbxPseudo);
            this.Controls.Add(this.lblPseudo);
            this.Controls.Add(this.btnClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Accueil";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Accueil";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Accueil_MouseDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label btnClose;
        private System.Windows.Forms.Label lblPseudo;
        private System.Windows.Forms.TextBox tbxPseudo;
        private System.Windows.Forms.Label btnOk;
        private System.Windows.Forms.Label lblTitre;
    }
}