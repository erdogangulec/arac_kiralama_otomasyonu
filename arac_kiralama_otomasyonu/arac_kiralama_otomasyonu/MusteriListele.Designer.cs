
namespace arac_kiralama_otomasyonu
{
    partial class MusteriListele
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MusteriListele));
            this.panel1 = new System.Windows.Forms.Panel();
            this.musteriSilButton = new System.Windows.Forms.Button();
            this.geributton = new System.Windows.Forms.Button();
            this.musteriListeleListView = new System.Windows.Forms.ListView();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.Controls.Add(this.musteriSilButton);
            this.panel1.Controls.Add(this.geributton);
            this.panel1.Controls.Add(this.musteriListeleListView);
            this.panel1.Location = new System.Drawing.Point(4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1592, 863);
            this.panel1.TabIndex = 1;
            // 
            // musteriSilButton
            // 
            this.musteriSilButton.BackColor = System.Drawing.Color.Crimson;
            this.musteriSilButton.Location = new System.Drawing.Point(751, 665);
            this.musteriSilButton.Name = "musteriSilButton";
            this.musteriSilButton.Size = new System.Drawing.Size(276, 80);
            this.musteriSilButton.TabIndex = 16;
            this.musteriSilButton.Text = "Seçili Müşteriyi Sil";
            this.musteriSilButton.UseVisualStyleBackColor = false;
            this.musteriSilButton.Click += new System.EventHandler(this.musteriSilButton_Click);
            // 
            // geributton
            // 
            this.geributton.BackColor = System.Drawing.Color.Wheat;
            this.geributton.Location = new System.Drawing.Point(1170, 665);
            this.geributton.Name = "geributton";
            this.geributton.Size = new System.Drawing.Size(276, 80);
            this.geributton.TabIndex = 14;
            this.geributton.Text = "Geri";
            this.geributton.UseVisualStyleBackColor = false;
            this.geributton.Click += new System.EventHandler(this.geributton_Click);
            // 
            // musteriListeleListView
            // 
            this.musteriListeleListView.HideSelection = false;
            this.musteriListeleListView.Location = new System.Drawing.Point(4, 4);
            this.musteriListeleListView.Name = "musteriListeleListView";
            this.musteriListeleListView.Size = new System.Drawing.Size(1580, 570);
            this.musteriListeleListView.TabIndex = 0;
            this.musteriListeleListView.UseCompatibleStateImageBehavior = false;
            // 
            // MusteriListele
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1600, 872);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "MusteriListele";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MusteriListele";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListView musteriListeleListView;
        private System.Windows.Forms.Button geributton;
        private System.Windows.Forms.Button musteriSilButton;
    }
}