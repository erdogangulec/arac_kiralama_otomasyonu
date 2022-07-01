
namespace arac_kiralama_otomasyonu
{
    partial class adminGiris
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(adminGiris));
            this.girispanel = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.girisbutton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.sifreTextBox = new System.Windows.Forms.TextBox();
            this.kullaniciAdiTextBox = new System.Windows.Forms.TextBox();
            this.girispanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // girispanel
            // 
            this.girispanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("girispanel.BackgroundImage")));
            this.girispanel.Controls.Add(this.label4);
            this.girispanel.Controls.Add(this.label3);
            this.girispanel.Controls.Add(this.girisbutton);
            this.girispanel.Controls.Add(this.label2);
            this.girispanel.Controls.Add(this.label1);
            this.girispanel.Controls.Add(this.sifreTextBox);
            this.girispanel.Controls.Add(this.kullaniciAdiTextBox);
            this.girispanel.Location = new System.Drawing.Point(3, 1);
            this.girispanel.Name = "girispanel";
            this.girispanel.Size = new System.Drawing.Size(1595, 870);
            this.girispanel.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Stencil", 22.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(598, 281);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(268, 46);
            this.label4.TabIndex = 7;
            this.label4.Text = "ADMIN GİRİŞİ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Stencil", 22.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(598, 202);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(291, 46);
            this.label3.TabIndex = 6;
            this.label3.Text = "HOŞGELDİNİZ !";
            // 
            // girisbutton
            // 
            this.girisbutton.BackColor = System.Drawing.Color.LimeGreen;
            this.girisbutton.Location = new System.Drawing.Point(657, 574);
            this.girisbutton.Name = "girisbutton";
            this.girisbutton.Size = new System.Drawing.Size(150, 55);
            this.girisbutton.TabIndex = 4;
            this.girisbutton.Text = "Giriş";
            this.girisbutton.UseVisualStyleBackColor = false;
            this.girisbutton.Click += new System.EventHandler(this.girisbutton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(583, 456);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 32);
            this.label2.TabIndex = 3;
            this.label2.Text = "Şifre : ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(517, 375);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 32);
            this.label1.TabIndex = 2;
            this.label1.Text = "Kullanıcı adı :";
            // 
            // sifreTextBox
            // 
            this.sifreTextBox.Location = new System.Drawing.Point(708, 450);
            this.sifreTextBox.Name = "sifreTextBox";
            this.sifreTextBox.Size = new System.Drawing.Size(196, 38);
            this.sifreTextBox.TabIndex = 1;
            // 
            // kullaniciAdiTextBox
            // 
            this.kullaniciAdiTextBox.Location = new System.Drawing.Point(708, 372);
            this.kullaniciAdiTextBox.Name = "kullaniciAdiTextBox";
            this.kullaniciAdiTextBox.Size = new System.Drawing.Size(196, 38);
            this.kullaniciAdiTextBox.TabIndex = 0;
            // 
            // adminGiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1600, 872);
            this.Controls.Add(this.girispanel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "adminGiris";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin Girişi";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.girispanel.ResumeLayout(false);
            this.girispanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel girispanel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button girisbutton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox sifreTextBox;
        private System.Windows.Forms.TextBox kullaniciAdiTextBox;
        private System.Windows.Forms.Label label4;
    }
}