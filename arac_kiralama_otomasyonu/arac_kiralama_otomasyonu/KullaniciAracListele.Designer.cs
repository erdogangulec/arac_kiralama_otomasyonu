
namespace arac_kiralama_otomasyonu
{
    partial class KullaniciAracListele
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KullaniciAracListele));
            this.panel1 = new System.Windows.Forms.Panel();
            this.geributton = new System.Windows.Forms.Button();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.aracListeleListView = new System.Windows.Forms.ListView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.Controls.Add(this.geributton);
            this.panel1.Controls.Add(this.pictureBox);
            this.panel1.Controls.Add(this.aracListeleListView);
            this.panel1.Location = new System.Drawing.Point(4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1592, 863);
            this.panel1.TabIndex = 2;
            // 
            // geributton
            // 
            this.geributton.BackColor = System.Drawing.Color.Wheat;
            this.geributton.Location = new System.Drawing.Point(1099, 567);
            this.geributton.Name = "geributton";
            this.geributton.Size = new System.Drawing.Size(276, 80);
            this.geributton.TabIndex = 14;
            this.geributton.Text = "Geri";
            this.geributton.UseVisualStyleBackColor = false;
            this.geributton.Click += new System.EventHandler(this.geributton_Click);
            // 
            // pictureBox
            // 
            this.pictureBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox.Location = new System.Drawing.Point(664, 479);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(302, 263);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox.TabIndex = 2;
            this.pictureBox.TabStop = false;
            // 
            // aracListeleListView
            // 
            this.aracListeleListView.HideSelection = false;
            this.aracListeleListView.Location = new System.Drawing.Point(4, 7);
            this.aracListeleListView.Name = "aracListeleListView";
            this.aracListeleListView.Size = new System.Drawing.Size(1580, 404);
            this.aracListeleListView.TabIndex = 1;
            this.aracListeleListView.UseCompatibleStateImageBehavior = false;
            this.aracListeleListView.SelectedIndexChanged += new System.EventHandler(this.aracListeleListView_SelectedIndexChanged);
            // 
            // KullaniciAracListele
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1600, 872);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "KullaniciAracListele";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "KullaniciAracListele";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button geributton;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.ListView aracListeleListView;
    }
}