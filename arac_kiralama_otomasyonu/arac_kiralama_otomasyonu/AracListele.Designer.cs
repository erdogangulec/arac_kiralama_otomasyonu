
namespace arac_kiralama_otomasyonu
{
    partial class AracListele
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AracListele));
            this.aracListeleListView = new System.Windows.Forms.ListView();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.aracSilButton = new System.Windows.Forms.Button();
            this.geributton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
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
            // pictureBox
            // 
            this.pictureBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox.Location = new System.Drawing.Point(830, 490);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(302, 263);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox.TabIndex = 2;
            this.pictureBox.TabStop = false;
            this.pictureBox.Click += new System.EventHandler(this.pictureBox_Click);
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.Controls.Add(this.aracSilButton);
            this.panel1.Controls.Add(this.geributton);
            this.panel1.Controls.Add(this.pictureBox);
            this.panel1.Controls.Add(this.aracListeleListView);
            this.panel1.Location = new System.Drawing.Point(4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1592, 863);
            this.panel1.TabIndex = 1;
            // 
            // aracSilButton
            // 
            this.aracSilButton.BackColor = System.Drawing.Color.Crimson;
            this.aracSilButton.Location = new System.Drawing.Point(474, 565);
            this.aracSilButton.Name = "aracSilButton";
            this.aracSilButton.Size = new System.Drawing.Size(276, 80);
            this.aracSilButton.TabIndex = 15;
            this.aracSilButton.Text = "Seçili Aracı Sil";
            this.aracSilButton.UseVisualStyleBackColor = false;
            this.aracSilButton.Click += new System.EventHandler(this.aracSilButton_Click);
            // 
            // geributton
            // 
            this.geributton.BackColor = System.Drawing.Color.Wheat;
            this.geributton.Location = new System.Drawing.Point(1211, 565);
            this.geributton.Name = "geributton";
            this.geributton.Size = new System.Drawing.Size(276, 80);
            this.geributton.TabIndex = 14;
            this.geributton.Text = "Geri";
            this.geributton.UseVisualStyleBackColor = false;
            this.geributton.Click += new System.EventHandler(this.geributton_Click);
            // 
            // AracListele
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1600, 872);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "AracListele";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AracListele";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView aracListeleListView;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button geributton;
        private System.Windows.Forms.Button aracSilButton;
    }
}