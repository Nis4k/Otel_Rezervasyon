namespace NypProjeSon.PRESENTATİON
{
    partial class frmadminGiris
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
            this.grpAdminGiris = new System.Windows.Forms.GroupBox();
            this.btnGirisYap = new System.Windows.Forms.Button();
            this.txtSifre = new System.Windows.Forms.TextBox();
            this.txtKullanıcıAdi = new System.Windows.Forms.TextBox();
            this.lblSifre = new System.Windows.Forms.Label();
            this.lblKullanıcıAdi = new System.Windows.Forms.Label();
            this.lblAdminGiris = new System.Windows.Forms.Label();
            this.grpAdminGiris.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpAdminGiris
            // 
            this.grpAdminGiris.BackColor = System.Drawing.Color.Linen;
            this.grpAdminGiris.Controls.Add(this.btnGirisYap);
            this.grpAdminGiris.Controls.Add(this.txtSifre);
            this.grpAdminGiris.Controls.Add(this.txtKullanıcıAdi);
            this.grpAdminGiris.Controls.Add(this.lblSifre);
            this.grpAdminGiris.Controls.Add(this.lblKullanıcıAdi);
            this.grpAdminGiris.Controls.Add(this.lblAdminGiris);
            this.grpAdminGiris.Location = new System.Drawing.Point(46, 38);
            this.grpAdminGiris.Name = "grpAdminGiris";
            this.grpAdminGiris.Size = new System.Drawing.Size(701, 377);
            this.grpAdminGiris.TabIndex = 0;
            this.grpAdminGiris.TabStop = false;
            this.grpAdminGiris.Text = "adminGiris";
            // 
            // btnGirisYap
            // 
            this.btnGirisYap.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnGirisYap.Location = new System.Drawing.Point(279, 232);
            this.btnGirisYap.Name = "btnGirisYap";
            this.btnGirisYap.Size = new System.Drawing.Size(112, 33);
            this.btnGirisYap.TabIndex = 5;
            this.btnGirisYap.Text = "Giriş Yap";
            this.btnGirisYap.UseVisualStyleBackColor = false;
            this.btnGirisYap.Click += new System.EventHandler(this.btnGirisYap_Click);
            // 
            // txtSifre
            // 
            this.txtSifre.Location = new System.Drawing.Point(301, 154);
            this.txtSifre.Name = "txtSifre";
            this.txtSifre.PasswordChar = '*';
            this.txtSifre.Size = new System.Drawing.Size(100, 22);
            this.txtSifre.TabIndex = 4;
            // 
            // txtKullanıcıAdi
            // 
            this.txtKullanıcıAdi.Location = new System.Drawing.Point(301, 118);
            this.txtKullanıcıAdi.Name = "txtKullanıcıAdi";
            this.txtKullanıcıAdi.Size = new System.Drawing.Size(100, 22);
            this.txtKullanıcıAdi.TabIndex = 3;
            // 
            // lblSifre
            // 
            this.lblSifre.AutoSize = true;
            this.lblSifre.Location = new System.Drawing.Point(258, 157);
            this.lblSifre.Name = "lblSifre";
            this.lblSifre.Size = new System.Drawing.Size(37, 16);
            this.lblSifre.TabIndex = 2;
            this.lblSifre.Text = "Şifre:";
            // 
            // lblKullanıcıAdi
            // 
            this.lblKullanıcıAdi.AutoSize = true;
            this.lblKullanıcıAdi.Location = new System.Drawing.Point(213, 121);
            this.lblKullanıcıAdi.Name = "lblKullanıcıAdi";
            this.lblKullanıcıAdi.Size = new System.Drawing.Size(82, 16);
            this.lblKullanıcıAdi.TabIndex = 1;
            this.lblKullanıcıAdi.Text = "Kullanıcı Adı:";
            // 
            // lblAdminGiris
            // 
            this.lblAdminGiris.AutoSize = true;
            this.lblAdminGiris.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAdminGiris.Location = new System.Drawing.Point(285, 52);
            this.lblAdminGiris.Name = "lblAdminGiris";
            this.lblAdminGiris.Size = new System.Drawing.Size(129, 22);
            this.lblAdminGiris.TabIndex = 0;
            this.lblAdminGiris.Text = "ADMİN GİRİŞ";
            // 
            // frmadminGiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RosyBrown;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.grpAdminGiris);
            this.Name = "frmadminGiris";
            this.Text = "adminGiris";
            this.Load += new System.EventHandler(this.frmadminGiris_Load);
            this.grpAdminGiris.ResumeLayout(false);
            this.grpAdminGiris.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpAdminGiris;
        private System.Windows.Forms.Label lblSifre;
        private System.Windows.Forms.Label lblKullanıcıAdi;
        private System.Windows.Forms.Label lblAdminGiris;
        private System.Windows.Forms.Button btnGirisYap;
        private System.Windows.Forms.TextBox txtSifre;
        private System.Windows.Forms.TextBox txtKullanıcıAdi;
    }
}