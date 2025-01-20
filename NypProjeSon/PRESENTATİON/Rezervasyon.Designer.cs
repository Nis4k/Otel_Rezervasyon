namespace NypProjeSon.PRESENTATİON
{
    partial class frmRezervasyon
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
            this.grpRezervasyon = new System.Windows.Forms.GroupBox();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.btnRezervasyonYap = new System.Windows.Forms.Button();
            this.txtSonUcret = new System.Windows.Forms.TextBox();
            this.lblSonUcret = new System.Windows.Forms.Label();
            this.grpKroki = new System.Windows.Forms.GroupBox();
            this.lblAcilCkıs = new System.Windows.Forms.Label();
            this.lblKoridor = new System.Windows.Forms.Label();
            this.btnKroki103 = new System.Windows.Forms.Button();
            this.btnKroki102 = new System.Windows.Forms.Button();
            this.btnKroki101 = new System.Windows.Forms.Button();
            this.txtSecilenOda = new System.Windows.Forms.TextBox();
            this.txtSoyisim = new System.Windows.Forms.TextBox();
            this.txtIsim = new System.Windows.Forms.TextBox();
            this.dateCikis = new System.Windows.Forms.DateTimePicker();
            this.lblCıkısTarihi = new System.Windows.Forms.Label();
            this.lblGirisTarihi = new System.Windows.Forms.Label();
            this.dateGiris = new System.Windows.Forms.DateTimePicker();
            this.lblSecilenOda = new System.Windows.Forms.Label();
            this.lblKimlik = new System.Windows.Forms.Label();
            this.lblSoyisim = new System.Windows.Forms.Label();
            this.lblIsim = new System.Windows.Forms.Label();
            this.btnGeri = new System.Windows.Forms.Button();
            this.grpRezervasyon.SuspendLayout();
            this.grpKroki.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpRezervasyon
            // 
            this.grpRezervasyon.BackColor = System.Drawing.Color.Linen;
            this.grpRezervasyon.Controls.Add(this.btnGeri);
            this.grpRezervasyon.Controls.Add(this.maskedTextBox1);
            this.grpRezervasyon.Controls.Add(this.btnRezervasyonYap);
            this.grpRezervasyon.Controls.Add(this.txtSonUcret);
            this.grpRezervasyon.Controls.Add(this.lblSonUcret);
            this.grpRezervasyon.Controls.Add(this.grpKroki);
            this.grpRezervasyon.Controls.Add(this.txtSecilenOda);
            this.grpRezervasyon.Controls.Add(this.txtSoyisim);
            this.grpRezervasyon.Controls.Add(this.txtIsim);
            this.grpRezervasyon.Controls.Add(this.dateCikis);
            this.grpRezervasyon.Controls.Add(this.lblCıkısTarihi);
            this.grpRezervasyon.Controls.Add(this.lblGirisTarihi);
            this.grpRezervasyon.Controls.Add(this.dateGiris);
            this.grpRezervasyon.Controls.Add(this.lblSecilenOda);
            this.grpRezervasyon.Controls.Add(this.lblKimlik);
            this.grpRezervasyon.Controls.Add(this.lblSoyisim);
            this.grpRezervasyon.Controls.Add(this.lblIsim);
            this.grpRezervasyon.Location = new System.Drawing.Point(46, 35);
            this.grpRezervasyon.Name = "grpRezervasyon";
            this.grpRezervasyon.Size = new System.Drawing.Size(711, 375);
            this.grpRezervasyon.TabIndex = 0;
            this.grpRezervasyon.TabStop = false;
            this.grpRezervasyon.Text = "REZERVASYON";
            this.grpRezervasyon.Enter += new System.EventHandler(this.grpRezervasyon_Enter);
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(148, 156);
            this.maskedTextBox1.Mask = "00000000000";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(100, 22);
            this.maskedTextBox1.TabIndex = 1;
            this.maskedTextBox1.ValidatingType = typeof(int);
            this.maskedTextBox1.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBox1_MaskInputRejected);
            // 
            // btnRezervasyonYap
            // 
            this.btnRezervasyonYap.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnRezervasyonYap.Location = new System.Drawing.Point(313, 287);
            this.btnRezervasyonYap.Name = "btnRezervasyonYap";
            this.btnRezervasyonYap.Size = new System.Drawing.Size(122, 69);
            this.btnRezervasyonYap.TabIndex = 18;
            this.btnRezervasyonYap.Text = "REZERVASYON YAP";
            this.btnRezervasyonYap.UseVisualStyleBackColor = false;
            this.btnRezervasyonYap.Click += new System.EventHandler(this.btnRezervasyonYap_Click);
            // 
            // txtSonUcret
            // 
            this.txtSonUcret.Location = new System.Drawing.Point(148, 310);
            this.txtSonUcret.Name = "txtSonUcret";
            this.txtSonUcret.Size = new System.Drawing.Size(100, 22);
            this.txtSonUcret.TabIndex = 17;
            this.txtSonUcret.TextChanged += new System.EventHandler(this.txtSonUcret_TextChanged);
            // 
            // lblSonUcret
            // 
            this.lblSonUcret.AutoSize = true;
            this.lblSonUcret.Location = new System.Drawing.Point(62, 313);
            this.lblSonUcret.Name = "lblSonUcret";
            this.lblSonUcret.Size = new System.Drawing.Size(69, 16);
            this.lblSonUcret.TabIndex = 16;
            this.lblSonUcret.Text = "Son Ücret:";
            // 
            // grpKroki
            // 
            this.grpKroki.Controls.Add(this.lblAcilCkıs);
            this.grpKroki.Controls.Add(this.lblKoridor);
            this.grpKroki.Controls.Add(this.btnKroki103);
            this.grpKroki.Controls.Add(this.btnKroki102);
            this.grpKroki.Controls.Add(this.btnKroki101);
            this.grpKroki.Location = new System.Drawing.Point(469, 52);
            this.grpKroki.Name = "grpKroki";
            this.grpKroki.Size = new System.Drawing.Size(219, 256);
            this.grpKroki.TabIndex = 15;
            this.grpKroki.TabStop = false;
            this.grpKroki.Text = "Kroki";
            this.grpKroki.Enter += new System.EventHandler(this.grpKroki_Enter);
            // 
            // lblAcilCkıs
            // 
            this.lblAcilCkıs.AutoSize = true;
            this.lblAcilCkıs.Location = new System.Drawing.Point(131, 211);
            this.lblAcilCkıs.Name = "lblAcilCkıs";
            this.lblAcilCkıs.Size = new System.Drawing.Size(70, 16);
            this.lblAcilCkıs.TabIndex = 16;
            this.lblAcilCkıs.Text = "ACİL ÇIKIŞ";
            // 
            // lblKoridor
            // 
            this.lblKoridor.AutoSize = true;
            this.lblKoridor.Location = new System.Drawing.Point(67, 133);
            this.lblKoridor.Name = "lblKoridor";
            this.lblKoridor.Size = new System.Drawing.Size(84, 16);
            this.lblKoridor.TabIndex = 15;
            this.lblKoridor.Text = "--KORİDOR--";
            // 
            // btnKroki103
            // 
            this.btnKroki103.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnKroki103.Location = new System.Drawing.Point(15, 178);
            this.btnKroki103.Name = "btnKroki103";
            this.btnKroki103.Size = new System.Drawing.Size(85, 63);
            this.btnKroki103.TabIndex = 14;
            this.btnKroki103.Text = "ODA103";
            this.btnKroki103.UseVisualStyleBackColor = false;
            this.btnKroki103.Click += new System.EventHandler(this.btnKroki103_Click);
            // 
            // btnKroki102
            // 
            this.btnKroki102.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnKroki102.Location = new System.Drawing.Point(116, 35);
            this.btnKroki102.Name = "btnKroki102";
            this.btnKroki102.Size = new System.Drawing.Size(85, 63);
            this.btnKroki102.TabIndex = 13;
            this.btnKroki102.Text = "ODA102";
            this.btnKroki102.UseVisualStyleBackColor = false;
            this.btnKroki102.Click += new System.EventHandler(this.btnKroki102_Click);
            // 
            // btnKroki101
            // 
            this.btnKroki101.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnKroki101.Location = new System.Drawing.Point(15, 35);
            this.btnKroki101.Name = "btnKroki101";
            this.btnKroki101.Size = new System.Drawing.Size(85, 63);
            this.btnKroki101.TabIndex = 12;
            this.btnKroki101.Text = "ODA101";
            this.btnKroki101.UseVisualStyleBackColor = false;
            this.btnKroki101.Click += new System.EventHandler(this.btnKroki101_Click);
            // 
            // txtSecilenOda
            // 
            this.txtSecilenOda.Enabled = false;
            this.txtSecilenOda.Location = new System.Drawing.Point(148, 197);
            this.txtSecilenOda.Name = "txtSecilenOda";
            this.txtSecilenOda.Size = new System.Drawing.Size(100, 22);
            this.txtSecilenOda.TabIndex = 11;
            // 
            // txtSoyisim
            // 
            this.txtSoyisim.Location = new System.Drawing.Point(148, 108);
            this.txtSoyisim.Name = "txtSoyisim";
            this.txtSoyisim.Size = new System.Drawing.Size(100, 22);
            this.txtSoyisim.TabIndex = 10;
            // 
            // txtIsim
            // 
            this.txtIsim.Location = new System.Drawing.Point(148, 66);
            this.txtIsim.Name = "txtIsim";
            this.txtIsim.Size = new System.Drawing.Size(100, 22);
            this.txtIsim.TabIndex = 8;
            // 
            // dateCikis
            // 
            this.dateCikis.Location = new System.Drawing.Point(148, 272);
            this.dateCikis.Name = "dateCikis";
            this.dateCikis.Size = new System.Drawing.Size(128, 22);
            this.dateCikis.TabIndex = 7;
            // 
            // lblCıkısTarihi
            // 
            this.lblCıkısTarihi.AutoSize = true;
            this.lblCıkısTarihi.Location = new System.Drawing.Point(55, 277);
            this.lblCıkısTarihi.Name = "lblCıkısTarihi";
            this.lblCıkısTarihi.Size = new System.Drawing.Size(76, 16);
            this.lblCıkısTarihi.TabIndex = 6;
            this.lblCıkısTarihi.Text = "Çıkış Tarihi:";
            // 
            // lblGirisTarihi
            // 
            this.lblGirisTarihi.AutoSize = true;
            this.lblGirisTarihi.Location = new System.Drawing.Point(57, 240);
            this.lblGirisTarihi.Name = "lblGirisTarihi";
            this.lblGirisTarihi.Size = new System.Drawing.Size(74, 16);
            this.lblGirisTarihi.TabIndex = 5;
            this.lblGirisTarihi.Text = "Giriş Tarihi:";
            // 
            // dateGiris
            // 
            this.dateGiris.Location = new System.Drawing.Point(148, 234);
            this.dateGiris.Name = "dateGiris";
            this.dateGiris.Size = new System.Drawing.Size(128, 22);
            this.dateGiris.TabIndex = 4;
            // 
            // lblSecilenOda
            // 
            this.lblSecilenOda.AutoSize = true;
            this.lblSecilenOda.Location = new System.Drawing.Point(47, 200);
            this.lblSecilenOda.Name = "lblSecilenOda";
            this.lblSecilenOda.Size = new System.Drawing.Size(84, 16);
            this.lblSecilenOda.TabIndex = 3;
            this.lblSecilenOda.Text = "Seçilen Oda:";
            // 
            // lblKimlik
            // 
            this.lblKimlik.AutoSize = true;
            this.lblKimlik.Location = new System.Drawing.Point(65, 159);
            this.lblKimlik.Name = "lblKimlik";
            this.lblKimlik.Size = new System.Drawing.Size(66, 16);
            this.lblKimlik.TabIndex = 2;
            this.lblKimlik.Text = "Kimlik No:";
            this.lblKimlik.Click += new System.EventHandler(this.lblKimlik_Click);
            // 
            // lblSoyisim
            // 
            this.lblSoyisim.AutoSize = true;
            this.lblSoyisim.Location = new System.Drawing.Point(73, 111);
            this.lblSoyisim.Name = "lblSoyisim";
            this.lblSoyisim.Size = new System.Drawing.Size(58, 16);
            this.lblSoyisim.TabIndex = 1;
            this.lblSoyisim.Text = "Soyisim:";
            // 
            // lblIsim
            // 
            this.lblIsim.AutoSize = true;
            this.lblIsim.Location = new System.Drawing.Point(97, 69);
            this.lblIsim.Name = "lblIsim";
            this.lblIsim.Size = new System.Drawing.Size(34, 16);
            this.lblIsim.TabIndex = 0;
            this.lblIsim.Text = "İsim:";
            // 
            // btnGeri
            // 
            this.btnGeri.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnGeri.Location = new System.Drawing.Point(594, 333);
            this.btnGeri.Name = "btnGeri";
            this.btnGeri.Size = new System.Drawing.Size(85, 36);
            this.btnGeri.TabIndex = 19;
            this.btnGeri.Text = "Geri";
            this.btnGeri.UseVisualStyleBackColor = false;
            this.btnGeri.Click += new System.EventHandler(this.btnGeri_Click);
            // 
            // frmRezervasyon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RosyBrown;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.grpRezervasyon);
            this.Name = "frmRezervasyon";
            this.Text = "Rezervasyon";
            this.grpRezervasyon.ResumeLayout(false);
            this.grpRezervasyon.PerformLayout();
            this.grpKroki.ResumeLayout(false);
            this.grpKroki.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpRezervasyon;
        private System.Windows.Forms.Label lblKimlik;
        private System.Windows.Forms.Label lblSoyisim;
        private System.Windows.Forms.Label lblIsim;
        private System.Windows.Forms.TextBox txtSecilenOda;
        private System.Windows.Forms.TextBox txtSoyisim;
        private System.Windows.Forms.TextBox txtIsim;
        private System.Windows.Forms.DateTimePicker dateCikis;
        private System.Windows.Forms.Label lblCıkısTarihi;
        private System.Windows.Forms.Label lblGirisTarihi;
        private System.Windows.Forms.DateTimePicker dateGiris;
        private System.Windows.Forms.Label lblSecilenOda;
        private System.Windows.Forms.GroupBox grpKroki;
        private System.Windows.Forms.Button btnKroki101;
        private System.Windows.Forms.Label lblAcilCkıs;
        private System.Windows.Forms.Label lblKoridor;
        private System.Windows.Forms.Button btnKroki103;
        private System.Windows.Forms.Button btnKroki102;
        private System.Windows.Forms.TextBox txtSonUcret;
        private System.Windows.Forms.Label lblSonUcret;
        private System.Windows.Forms.Button btnRezervasyonYap;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.Button btnGeri;
    }
}