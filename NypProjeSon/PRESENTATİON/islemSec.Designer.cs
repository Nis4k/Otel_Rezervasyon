namespace NypProjeSon.PRESENTATİON
{
    partial class frmislemSec
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
            this.grpIslemSec = new System.Windows.Forms.GroupBox();
            this.btnRezervasyon = new System.Windows.Forms.Button();
            this.btnOdaIslemleri = new System.Windows.Forms.Button();
            this.grpIslemSec.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpIslemSec
            // 
            this.grpIslemSec.BackColor = System.Drawing.Color.Linen;
            this.grpIslemSec.Controls.Add(this.btnOdaIslemleri);
            this.grpIslemSec.Controls.Add(this.btnRezervasyon);
            this.grpIslemSec.Location = new System.Drawing.Point(44, 34);
            this.grpIslemSec.Name = "grpIslemSec";
            this.grpIslemSec.Size = new System.Drawing.Size(704, 375);
            this.grpIslemSec.TabIndex = 0;
            this.grpIslemSec.TabStop = false;
            this.grpIslemSec.Text = "İŞLEM SEÇ";
            // 
            // btnRezervasyon
            // 
            this.btnRezervasyon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnRezervasyon.Location = new System.Drawing.Point(104, 106);
            this.btnRezervasyon.Name = "btnRezervasyon";
            this.btnRezervasyon.Size = new System.Drawing.Size(131, 107);
            this.btnRezervasyon.TabIndex = 0;
            this.btnRezervasyon.Text = "REZERVASYON";
            this.btnRezervasyon.UseVisualStyleBackColor = false;
            this.btnRezervasyon.Click += new System.EventHandler(this.btnRezervasyon_Click_1);
            // 
            // btnOdaIslemleri
            // 
            this.btnOdaIslemleri.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnOdaIslemleri.Location = new System.Drawing.Point(447, 106);
            this.btnOdaIslemleri.Name = "btnOdaIslemleri";
            this.btnOdaIslemleri.Size = new System.Drawing.Size(131, 107);
            this.btnOdaIslemleri.TabIndex = 1;
            this.btnOdaIslemleri.Text = "ODA İŞLEMLERİ";
            this.btnOdaIslemleri.UseVisualStyleBackColor = false;
            this.btnOdaIslemleri.Click += new System.EventHandler(this.btnOdaIslemleri_Click);
            // 
            // frmislemSec
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RosyBrown;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.grpIslemSec);
            this.Name = "frmislemSec";
            this.Text = "islemSec";
            this.grpIslemSec.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpIslemSec;
        private System.Windows.Forms.Button btnRezervasyon;
        private System.Windows.Forms.Button btnOdaIslemleri;
    }
}