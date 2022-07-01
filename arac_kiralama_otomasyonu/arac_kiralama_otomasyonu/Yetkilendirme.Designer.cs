
namespace arac_kiralama_otomasyonu
{
    partial class Yetkilendirme
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Yetkilendirme));
            this.panel1 = new System.Windows.Forms.Panel();
            this.kullaniciComboBox = new System.Windows.Forms.ComboBox();
            this.geributton = new System.Windows.Forms.Button();
            this.yetkilendirButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Olive;
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.Controls.Add(this.kullaniciComboBox);
            this.panel1.Controls.Add(this.geributton);
            this.panel1.Controls.Add(this.yetkilendirButton);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1592, 863);
            this.panel1.TabIndex = 3;
            // 
            // kullaniciComboBox
            // 
            this.kullaniciComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.kullaniciComboBox.FormattingEnabled = true;
            this.kullaniciComboBox.Location = new System.Drawing.Point(844, 244);
            this.kullaniciComboBox.Name = "kullaniciComboBox";
            this.kullaniciComboBox.Size = new System.Drawing.Size(252, 39);
            this.kullaniciComboBox.TabIndex = 62;
            // 
            // geributton
            // 
            this.geributton.BackColor = System.Drawing.Color.Wheat;
            this.geributton.Location = new System.Drawing.Point(885, 404);
            this.geributton.Name = "geributton";
            this.geributton.Size = new System.Drawing.Size(276, 80);
            this.geributton.TabIndex = 14;
            this.geributton.Text = "Geri";
            this.geributton.UseVisualStyleBackColor = false;
            this.geributton.Click += new System.EventHandler(this.geributton_Click);
            // 
            // yetkilendirButton
            // 
            this.yetkilendirButton.BackColor = System.Drawing.Color.LimeGreen;
            this.yetkilendirButton.Location = new System.Drawing.Point(493, 404);
            this.yetkilendirButton.Name = "yetkilendirButton";
            this.yetkilendirButton.Size = new System.Drawing.Size(276, 80);
            this.yetkilendirButton.TabIndex = 47;
            this.yetkilendirButton.Text = "Yetkilendir";
            this.yetkilendirButton.UseVisualStyleBackColor = false;
            this.yetkilendirButton.Click += new System.EventHandler(this.yetkilendirButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(639, 247);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 32);
            this.label2.TabIndex = 46;
            this.label2.Text = "Kullanıcı: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(659, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(321, 44);
            this.label3.TabIndex = 42;
            this.label3.Text = "YETKİLENDİRME";
            // 
            // Yetkilendirme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1600, 872);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Yetkilendirme";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Yetkilendirme";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button geributton;
        private System.Windows.Forms.Button yetkilendirButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox kullaniciComboBox;
    }
}