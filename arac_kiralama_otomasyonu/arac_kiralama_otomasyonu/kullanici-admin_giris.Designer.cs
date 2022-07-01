
namespace arac_kiralama_otomasyonu
{
    partial class kullanici_admin_giris
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(kullanici_admin_giris));
            this.girispanel = new System.Windows.Forms.Panel();
            this.kullanicibutton = new System.Windows.Forms.Button();
            this.adminbutton = new System.Windows.Forms.Button();
            this.girispanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // girispanel
            // 
            this.girispanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("girispanel.BackgroundImage")));
            this.girispanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.girispanel.Controls.Add(this.kullanicibutton);
            this.girispanel.Controls.Add(this.adminbutton);
            this.girispanel.Location = new System.Drawing.Point(3, 1);
            this.girispanel.Name = "girispanel";
            this.girispanel.Size = new System.Drawing.Size(1595, 870);
            this.girispanel.TabIndex = 1;
            // 
            // kullanicibutton
            // 
            this.kullanicibutton.BackColor = System.Drawing.Color.White;
            this.kullanicibutton.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kullanicibutton.Location = new System.Drawing.Point(826, 330);
            this.kullanicibutton.Name = "kullanicibutton";
            this.kullanicibutton.Size = new System.Drawing.Size(415, 147);
            this.kullanicibutton.TabIndex = 6;
            this.kullanicibutton.Text = "Kullanıcı Girişi";
            this.kullanicibutton.UseVisualStyleBackColor = false;
            this.kullanicibutton.Click += new System.EventHandler(this.kullanicibutton_Click);
            // 
            // adminbutton
            // 
            this.adminbutton.BackColor = System.Drawing.Color.Black;
            this.adminbutton.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminbutton.ForeColor = System.Drawing.Color.White;
            this.adminbutton.Location = new System.Drawing.Point(299, 330);
            this.adminbutton.Name = "adminbutton";
            this.adminbutton.Size = new System.Drawing.Size(415, 147);
            this.adminbutton.TabIndex = 5;
            this.adminbutton.Text = "Admin Girişi";
            this.adminbutton.UseVisualStyleBackColor = false;
            this.adminbutton.Click += new System.EventHandler(this.adminbutton_Click);
            // 
            // kullanici_admin_giris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1600, 872);
            this.Controls.Add(this.girispanel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "kullanici_admin_giris";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kullanıcı-Admin Giriş";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.girispanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel girispanel;
        private System.Windows.Forms.Button kullanicibutton;
        private System.Windows.Forms.Button adminbutton;
    }
}