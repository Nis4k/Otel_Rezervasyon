namespace NypProjeSon.PRESENTATİON
{
    partial class odalarIslem
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
            this.grpodaislemleri = new System.Windows.Forms.GroupBox();
            this.Bilgiler = new System.Windows.Forms.ListBox();
            this.btnislem101 = new System.Windows.Forms.Button();
            this.btnTemizle = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.grpodaislemleri.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpodaislemleri
            // 
            this.grpodaislemleri.BackColor = System.Drawing.Color.Linen;
            this.grpodaislemleri.Controls.Add(this.btnGuncelle);
            this.grpodaislemleri.Controls.Add(this.maskedTextBox1);
            this.grpodaislemleri.Controls.Add(this.btnTemizle);
            this.grpodaislemleri.Controls.Add(this.Bilgiler);
            this.grpodaislemleri.Controls.Add(this.btnislem101);
            this.grpodaislemleri.Location = new System.Drawing.Point(39, 38);
            this.grpodaislemleri.Name = "grpodaislemleri";
            this.grpodaislemleri.Size = new System.Drawing.Size(716, 373);
            this.grpodaislemleri.TabIndex = 0;
            this.grpodaislemleri.TabStop = false;
            this.grpodaislemleri.Text = "Oda İşlemleri";
            // 
            // Bilgiler
            // 
            this.Bilgiler.FormattingEnabled = true;
            this.Bilgiler.ItemHeight = 16;
            this.Bilgiler.Location = new System.Drawing.Point(125, 53);
            this.Bilgiler.Name = "Bilgiler";
            this.Bilgiler.Size = new System.Drawing.Size(585, 84);
            this.Bilgiler.TabIndex = 1;
            this.Bilgiler.SelectedIndexChanged += new System.EventHandler(this.Bilgiler_SelectedIndexChanged);
            // 
            // btnislem101
            // 
            this.btnislem101.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnislem101.Location = new System.Drawing.Point(18, 53);
            this.btnislem101.Name = "btnislem101";
            this.btnislem101.Size = new System.Drawing.Size(101, 78);
            this.btnislem101.TabIndex = 0;
            this.btnislem101.Text = "ODA101";
            this.btnislem101.UseVisualStyleBackColor = false;
            this.btnislem101.Click += new System.EventHandler(this.btnislem101_Click);
            // 
            // btnTemizle
            // 
            this.btnTemizle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnTemizle.Location = new System.Drawing.Point(125, 162);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(75, 23);
            this.btnTemizle.TabIndex = 2;
            this.btnTemizle.Text = "Temizle";
            this.btnTemizle.UseVisualStyleBackColor = false;
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(18, 162);
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(100, 22);
            this.maskedTextBox1.TabIndex = 3;
            this.maskedTextBox1.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBox1_MaskInputRejected);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnGuncelle.Location = new System.Drawing.Point(206, 162);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(75, 23);
            this.btnGuncelle.TabIndex = 4;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = false;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // odalarIslem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RosyBrown;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.grpodaislemleri);
            this.Name = "odalarIslem";
            this.Text = "odalarIslem";
            this.grpodaislemleri.ResumeLayout(false);
            this.grpodaislemleri.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpodaislemleri;
        private System.Windows.Forms.Button btnislem101;
        private System.Windows.Forms.ListBox Bilgiler;
        private System.Windows.Forms.Button btnTemizle;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.Button btnGuncelle;
    }
}