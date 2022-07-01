
namespace arac_kiralama_otomasyonu
{
    partial class YeniKayit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(YeniKayit));
            this.panel1 = new System.Windows.Forms.Panel();
            this.kayitbutton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.sifreTekrarTextBox = new System.Windows.Forms.TextBox();
            this.kullaniciAdiTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.sifreTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.sifreTextBox);
            this.panel1.Controls.Add(this.kayitbutton);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.sifreTekrarTextBox);
            this.panel1.Controls.Add(this.kullaniciAdiTextBox);
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1596, 868);
            this.panel1.TabIndex = 0;
            // 
            // kayitbutton
            // 
            this.kayitbutton.BackColor = System.Drawing.Color.Aqua;
            this.kayitbutton.Location = new System.Drawing.Point(773, 536);
            this.kayitbutton.Name = "kayitbutton";
            this.kayitbutton.Size = new System.Drawing.Size(150, 55);
            this.kayitbutton.TabIndex = 9;
            this.kayitbutton.Text = "Kaydol !";
            this.kayitbutton.UseVisualStyleBackColor = false;
            this.kayitbutton.Click += new System.EventHandler(this.kayitbutton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(625, 457);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(195, 32);
            this.label2.TabIndex = 8;
            this.label2.Text = "Şifre(Tekrar) : ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(635, 308);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 32);
            this.label1.TabIndex = 7;
            this.label1.Text = "Kullanıcı adı :";
            // 
            // sifreTekrarTextBox
            // 
            this.sifreTekrarTextBox.Location = new System.Drawing.Point(826, 454);
            this.sifreTekrarTextBox.Name = "sifreTekrarTextBox";
            this.sifreTekrarTextBox.Size = new System.Drawing.Size(196, 38);
            this.sifreTekrarTextBox.TabIndex = 6;
            // 
            // kullaniciAdiTextBox
            // 
            this.kullaniciAdiTextBox.Location = new System.Drawing.Point(826, 305);
            this.kullaniciAdiTextBox.Name = "kullaniciAdiTextBox";
            this.kullaniciAdiTextBox.Size = new System.Drawing.Size(196, 38);
            this.kullaniciAdiTextBox.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(701, 379);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 32);
            this.label3.TabIndex = 11;
            this.label3.Text = "Şifre : ";
            // 
            // sifreTextBox
            // 
            this.sifreTextBox.Location = new System.Drawing.Point(826, 376);
            this.sifreTextBox.Name = "sifreTextBox";
            this.sifreTextBox.Size = new System.Drawing.Size(196, 38);
            this.sifreTextBox.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(699, 135);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(408, 99);
            this.label4.TabIndex = 12;
            this.label4.Text = "LÜTFEN İSTENİLEN BİLGİLERİ GİRİNİZ";
            // 
            // YeniKayit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1600, 872);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "YeniKayit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kullanıcı Kaydı";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox sifreTextBox;
        private System.Windows.Forms.Button kayitbutton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox sifreTekrarTextBox;
        private System.Windows.Forms.TextBox kullaniciAdiTextBox;
        private System.Windows.Forms.Label label4;
    }
}