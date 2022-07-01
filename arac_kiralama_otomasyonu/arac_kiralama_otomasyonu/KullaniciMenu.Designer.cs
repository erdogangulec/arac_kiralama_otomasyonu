
namespace arac_kiralama_otomasyonu
{
    partial class KullaniciMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KullaniciMenu));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cikisButton = new System.Windows.Forms.Button();
            this.sozlesmeButton = new System.Windows.Forms.Button();
            this.aracListeleButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.cikisButton);
            this.panel1.Controls.Add(this.sozlesmeButton);
            this.panel1.Controls.Add(this.aracListeleButton);
            this.panel1.Location = new System.Drawing.Point(3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1595, 869);
            this.panel1.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Location = new System.Drawing.Point(1214, 376);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 32);
            this.label7.TabIndex = 13;
            this.label7.Text = "Çıkış";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(925, 72);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(140, 32);
            this.label5.TabIndex = 11;
            this.label5.Text = "Sözleşme";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(578, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(203, 32);
            this.label4.TabIndex = 10;
            this.label4.Text = "Araç Listeleme";
            // 
            // cikisButton
            // 
            this.cikisButton.BackColor = System.Drawing.Color.Transparent;
            this.cikisButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cikisButton.BackgroundImage")));
            this.cikisButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cikisButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cikisButton.Location = new System.Drawing.Point(1179, 420);
            this.cikisButton.Name = "cikisButton";
            this.cikisButton.Size = new System.Drawing.Size(154, 143);
            this.cikisButton.TabIndex = 6;
            this.cikisButton.UseVisualStyleBackColor = false;
            this.cikisButton.Click += new System.EventHandler(this.cikisButton_Click);
            // 
            // sozlesmeButton
            // 
            this.sozlesmeButton.BackColor = System.Drawing.Color.Transparent;
            this.sozlesmeButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("sozlesmeButton.BackgroundImage")));
            this.sozlesmeButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.sozlesmeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sozlesmeButton.Location = new System.Drawing.Point(882, 124);
            this.sozlesmeButton.Name = "sozlesmeButton";
            this.sozlesmeButton.Size = new System.Drawing.Size(212, 186);
            this.sozlesmeButton.TabIndex = 4;
            this.sozlesmeButton.UseVisualStyleBackColor = false;
            this.sozlesmeButton.Click += new System.EventHandler(this.sozlesmeButton_Click);
            // 
            // aracListeleButton
            // 
            this.aracListeleButton.BackColor = System.Drawing.Color.Transparent;
            this.aracListeleButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("aracListeleButton.BackgroundImage")));
            this.aracListeleButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.aracListeleButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.aracListeleButton.Location = new System.Drawing.Point(556, 124);
            this.aracListeleButton.Name = "aracListeleButton";
            this.aracListeleButton.Size = new System.Drawing.Size(212, 186);
            this.aracListeleButton.TabIndex = 3;
            this.aracListeleButton.UseVisualStyleBackColor = false;
            this.aracListeleButton.Click += new System.EventHandler(this.aracListeleButton_Click);
            // 
            // KullaniciMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1600, 872);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "KullaniciMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kullanıcı Menü";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button cikisButton;
        private System.Windows.Forms.Button sozlesmeButton;
        private System.Windows.Forms.Button aracListeleButton;
    }
}