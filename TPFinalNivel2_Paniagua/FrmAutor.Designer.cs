namespace TPFinalNivel2_Paniagua
{
    partial class FrmAutor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAutor));
            this.pbxPerfil = new System.Windows.Forms.PictureBox();
            this.pbxGitHub = new System.Windows.Forms.PictureBox();
            this.pbxLN = new System.Windows.Forms.PictureBox();
            this.pbxPortfolio = new System.Windows.Forms.PictureBox();
            this.pbxGmail = new System.Windows.Forms.PictureBox();
            this.lblCopyright = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbxPerfil)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxGitHub)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxLN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxPortfolio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxGmail)).BeginInit();
            this.SuspendLayout();
            // 
            // pbxPerfil
            // 
            this.pbxPerfil.Image = ((System.Drawing.Image)(resources.GetObject("pbxPerfil.Image")));
            this.pbxPerfil.InitialImage = ((System.Drawing.Image)(resources.GetObject("pbxPerfil.InitialImage")));
            this.pbxPerfil.Location = new System.Drawing.Point(12, 55);
            this.pbxPerfil.Name = "pbxPerfil";
            this.pbxPerfil.Size = new System.Drawing.Size(179, 165);
            this.pbxPerfil.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxPerfil.TabIndex = 1;
            this.pbxPerfil.TabStop = false;
            // 
            // pbxGitHub
            // 
            this.pbxGitHub.Image = ((System.Drawing.Image)(resources.GetObject("pbxGitHub.Image")));
            this.pbxGitHub.InitialImage = ((System.Drawing.Image)(resources.GetObject("pbxGitHub.InitialImage")));
            this.pbxGitHub.Location = new System.Drawing.Point(247, 44);
            this.pbxGitHub.Name = "pbxGitHub";
            this.pbxGitHub.Size = new System.Drawing.Size(65, 61);
            this.pbxGitHub.TabIndex = 2;
            this.pbxGitHub.TabStop = false;
            this.pbxGitHub.Click += new System.EventHandler(this.pbxGitHub_Click);
            // 
            // pbxLN
            // 
            this.pbxLN.Image = ((System.Drawing.Image)(resources.GetObject("pbxLN.Image")));
            this.pbxLN.Location = new System.Drawing.Point(360, 43);
            this.pbxLN.Name = "pbxLN";
            this.pbxLN.Size = new System.Drawing.Size(62, 62);
            this.pbxLN.TabIndex = 3;
            this.pbxLN.TabStop = false;
            this.pbxLN.Click += new System.EventHandler(this.pbxLN_Click);
            // 
            // pbxPortfolio
            // 
            this.pbxPortfolio.Image = ((System.Drawing.Image)(resources.GetObject("pbxPortfolio.Image")));
            this.pbxPortfolio.Location = new System.Drawing.Point(248, 155);
            this.pbxPortfolio.Name = "pbxPortfolio";
            this.pbxPortfolio.Size = new System.Drawing.Size(64, 65);
            this.pbxPortfolio.TabIndex = 4;
            this.pbxPortfolio.TabStop = false;
            this.pbxPortfolio.Click += new System.EventHandler(this.pbxPortfolio_Click);
            // 
            // pbxGmail
            // 
            this.pbxGmail.Image = ((System.Drawing.Image)(resources.GetObject("pbxGmail.Image")));
            this.pbxGmail.Location = new System.Drawing.Point(360, 155);
            this.pbxGmail.Name = "pbxGmail";
            this.pbxGmail.Size = new System.Drawing.Size(62, 65);
            this.pbxGmail.TabIndex = 5;
            this.pbxGmail.TabStop = false;
            this.pbxGmail.Click += new System.EventHandler(this.pbxGmail_Click);
            // 
            // lblCopyright
            // 
            this.lblCopyright.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCopyright.AutoSize = true;
            this.lblCopyright.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCopyright.Location = new System.Drawing.Point(108, 253);
            this.lblCopyright.Name = "lblCopyright";
            this.lblCopyright.Size = new System.Drawing.Size(204, 19);
            this.lblCopyright.TabIndex = 6;
            this.lblCopyright.Text = "@CopyRight - Aylin Paniagua";
            // 
            // FrmAutor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(449, 281);
            this.Controls.Add(this.lblCopyright);
            this.Controls.Add(this.pbxGmail);
            this.Controls.Add(this.pbxPortfolio);
            this.Controls.Add(this.pbxLN);
            this.Controls.Add(this.pbxGitHub);
            this.Controls.Add(this.pbxPerfil);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(465, 320);
            this.Name = "FrmAutor";
            this.Text = "FrmAutor";
            ((System.ComponentModel.ISupportInitialize)(this.pbxPerfil)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxGitHub)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxLN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxPortfolio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxGmail)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pbxPerfil;
        private System.Windows.Forms.PictureBox pbxGitHub;
        private System.Windows.Forms.PictureBox pbxLN;
        private System.Windows.Forms.PictureBox pbxPortfolio;
        private System.Windows.Forms.PictureBox pbxGmail;
        private System.Windows.Forms.Label lblCopyright;
    }
}