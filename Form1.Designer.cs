
namespace SiberGuvenlikOdev
{
    partial class Form1
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnGizlenecekResimSec = new System.Windows.Forms.Button();
            this.btnGizlenmisMetinSec = new System.Windows.Forms.Button();
            this.btnGonder = new System.Windows.Forms.Button();
            this.btnAl = new System.Windows.Forms.Button();
            this.btnGizle = new System.Windows.Forms.Button();
            this.btnSifreyiCoz = new System.Windows.Forms.Button();
            this.lblGizlenecekMetin = new System.Windows.Forms.Label();
            this.tbGizlenecekMetin = new System.Windows.Forms.TextBox();
            this.lblGizlenmisMetin = new System.Windows.Forms.Label();
            this.tbGizlenmisMetin = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(118, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(564, 343);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnGizlenecekResimSec
            // 
            this.btnGizlenecekResimSec.Location = new System.Drawing.Point(12, 12);
            this.btnGizlenecekResimSec.Name = "btnGizlenecekResimSec";
            this.btnGizlenecekResimSec.Size = new System.Drawing.Size(100, 72);
            this.btnGizlenecekResimSec.TabIndex = 1;
            this.btnGizlenecekResimSec.Text = "Metin Gizlemek İstediğiniz Resmi Seçiniz";
            this.btnGizlenecekResimSec.UseVisualStyleBackColor = true;
            this.btnGizlenecekResimSec.Click += new System.EventHandler(this.btnGizlenecekResimSec_Click);
            // 
            // btnGizlenmisMetinSec
            // 
            this.btnGizlenmisMetinSec.Location = new System.Drawing.Point(12, 90);
            this.btnGizlenmisMetinSec.Name = "btnGizlenmisMetinSec";
            this.btnGizlenmisMetinSec.Size = new System.Drawing.Size(100, 84);
            this.btnGizlenmisMetinSec.TabIndex = 2;
            this.btnGizlenmisMetinSec.Text = "Gizlemiş Olduğunuz Metni Görmek İstediğiniz Resmi Seçiniz";
            this.btnGizlenmisMetinSec.UseVisualStyleBackColor = true;
            this.btnGizlenmisMetinSec.Click += new System.EventHandler(this.btnGizlenmisMetinSec_Click);
            // 
            // btnGonder
            // 
            this.btnGonder.Location = new System.Drawing.Point(688, 12);
            this.btnGonder.Name = "btnGonder";
            this.btnGonder.Size = new System.Drawing.Size(100, 48);
            this.btnGonder.TabIndex = 3;
            this.btnGonder.Text = "Gönder";
            this.btnGonder.UseVisualStyleBackColor = true;
            this.btnGonder.Click += new System.EventHandler(this.btnGonder_Click);
            // 
            // btnAl
            // 
            this.btnAl.Location = new System.Drawing.Point(688, 66);
            this.btnAl.Name = "btnAl";
            this.btnAl.Size = new System.Drawing.Size(100, 48);
            this.btnAl.TabIndex = 4;
            this.btnAl.Text = "Al";
            this.btnAl.UseVisualStyleBackColor = true;
            this.btnAl.Click += new System.EventHandler(this.btnAl_Click);
            // 
            // btnGizle
            // 
            this.btnGizle.Location = new System.Drawing.Point(688, 402);
            this.btnGizle.Name = "btnGizle";
            this.btnGizle.Size = new System.Drawing.Size(100, 36);
            this.btnGizle.TabIndex = 5;
            this.btnGizle.Text = "Gizle";
            this.btnGizle.UseVisualStyleBackColor = true;
            this.btnGizle.Click += new System.EventHandler(this.btnGizle_Click);
            // 
            // btnSifreyiCoz
            // 
            this.btnSifreyiCoz.Location = new System.Drawing.Point(688, 360);
            this.btnSifreyiCoz.Name = "btnSifreyiCoz";
            this.btnSifreyiCoz.Size = new System.Drawing.Size(100, 36);
            this.btnSifreyiCoz.TabIndex = 6;
            this.btnSifreyiCoz.Text = "Çöz";
            this.btnSifreyiCoz.UseVisualStyleBackColor = true;
            this.btnSifreyiCoz.Click += new System.EventHandler(this.btnSifreyiCoz_Click);
            // 
            // lblGizlenecekMetin
            // 
            this.lblGizlenecekMetin.AutoSize = true;
            this.lblGizlenecekMetin.Location = new System.Drawing.Point(12, 414);
            this.lblGizlenecekMetin.Name = "lblGizlenecekMetin";
            this.lblGizlenecekMetin.Size = new System.Drawing.Size(237, 13);
            this.lblGizlenecekMetin.TabIndex = 7;
            this.lblGizlenecekMetin.Text = "Resmin içerisine gizlemek istediğiniz metini giriniz:";
            // 
            // tbGizlenecekMetin
            // 
            this.tbGizlenecekMetin.Location = new System.Drawing.Point(255, 411);
            this.tbGizlenecekMetin.Name = "tbGizlenecekMetin";
            this.tbGizlenecekMetin.Size = new System.Drawing.Size(219, 20);
            this.tbGizlenecekMetin.TabIndex = 8;
            // 
            // lblGizlenmisMetin
            // 
            this.lblGizlenmisMetin.AutoSize = true;
            this.lblGizlenmisMetin.Location = new System.Drawing.Point(12, 383);
            this.lblGizlenmisMetin.Name = "lblGizlenmisMetin";
            this.lblGizlenmisMetin.Size = new System.Drawing.Size(199, 13);
            this.lblGizlenmisMetin.TabIndex = 9;
            this.lblGizlenmisMetin.Text = "Resim içerisine gizlemiş olduğunuz metin:";
            // 
            // tbGizlenmisMetin
            // 
            this.tbGizlenmisMetin.Location = new System.Drawing.Point(220, 379);
            this.tbGizlenmisMetin.Name = "tbGizlenmisMetin";
            this.tbGizlenmisMetin.Size = new System.Drawing.Size(219, 20);
            this.tbGizlenmisMetin.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tbGizlenmisMetin);
            this.Controls.Add(this.lblGizlenmisMetin);
            this.Controls.Add(this.tbGizlenecekMetin);
            this.Controls.Add(this.lblGizlenecekMetin);
            this.Controls.Add(this.btnSifreyiCoz);
            this.Controls.Add(this.btnGizle);
            this.Controls.Add(this.btnAl);
            this.Controls.Add(this.btnGonder);
            this.Controls.Add(this.btnGizlenmisMetinSec);
            this.Controls.Add(this.btnGizlenecekResimSec);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnGizlenecekResimSec;
        private System.Windows.Forms.Button btnGizlenmisMetinSec;
        private System.Windows.Forms.Button btnGonder;
        private System.Windows.Forms.Button btnAl;
        private System.Windows.Forms.Button btnGizle;
        private System.Windows.Forms.Button btnSifreyiCoz;
        private System.Windows.Forms.Label lblGizlenecekMetin;
        private System.Windows.Forms.TextBox tbGizlenecekMetin;
        private System.Windows.Forms.Label lblGizlenmisMetin;
        private System.Windows.Forms.TextBox tbGizlenmisMetin;
    }
}

