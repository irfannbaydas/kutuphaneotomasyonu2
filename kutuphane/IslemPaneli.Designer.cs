namespace kutuphane
{
    partial class IslemPaneli
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IslemPaneli));
            this.kullanicipanel = new System.Windows.Forms.Panel();
            this.kullaniciblgipanel = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.kullanicipanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // kullanicipanel
            // 
            this.kullanicipanel.BackColor = System.Drawing.Color.DarkOrange;
            this.kullanicipanel.Controls.Add(this.button5);
            this.kullanicipanel.Controls.Add(this.button4);
            this.kullanicipanel.Controls.Add(this.button3);
            this.kullanicipanel.Controls.Add(this.button2);
            this.kullanicipanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.kullanicipanel.Location = new System.Drawing.Point(0, 0);
            this.kullanicipanel.Name = "kullanicipanel";
            this.kullanicipanel.Size = new System.Drawing.Size(176, 450);
            this.kullanicipanel.TabIndex = 0;
            // 
            // kullaniciblgipanel
            // 
            this.kullaniciblgipanel.BackColor = System.Drawing.Color.DarkOrange;
            this.kullaniciblgipanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.kullaniciblgipanel.Location = new System.Drawing.Point(176, 0);
            this.kullaniciblgipanel.Name = "kullaniciblgipanel";
            this.kullaniciblgipanel.Size = new System.Drawing.Size(624, 59);
            this.kullaniciblgipanel.TabIndex = 1;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.Font = new System.Drawing.Font("Bahnschrift SemiBold Condensed", 13.75F, System.Drawing.FontStyle.Bold);
            this.button2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(0, 160);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(176, 88);
            this.button2.TabIndex = 2;
            this.button2.Text = "           Kullanıcı Güncelle";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Transparent;
            this.button3.Font = new System.Drawing.Font("Bahnschrift SemiBold Condensed", 13.75F, System.Drawing.FontStyle.Bold);
            this.button3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(0, 82);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(176, 82);
            this.button3.TabIndex = 3;
            this.button3.Text = "            Kullanıcı Ekle";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Transparent;
            this.button4.Font = new System.Drawing.Font("Bahnschrift SemiBold Condensed", 13.75F, System.Drawing.FontStyle.Bold);
            this.button4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button4.Image = ((System.Drawing.Image)(resources.GetObject("button4.Image")));
            this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.Location = new System.Drawing.Point(0, 0);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(176, 86);
            this.button4.TabIndex = 4;
            this.button4.Text = "    Kullanıcı İşlemleri";
            this.button4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Transparent;
            this.button5.Font = new System.Drawing.Font("Bahnschrift SemiBold Condensed", 13.75F, System.Drawing.FontStyle.Bold);
            this.button5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button5.Image = ((System.Drawing.Image)(resources.GetObject("button5.Image")));
            this.button5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button5.Location = new System.Drawing.Point(0, 245);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(176, 88);
            this.button5.TabIndex = 3;
            this.button5.Text = "            Kullanıcı Sil";
            this.button5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button5.UseVisualStyleBackColor = false;
            // 
            // IslemPaneli
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateGray;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.kullaniciblgipanel);
            this.Controls.Add(this.kullanicipanel);
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.Name = "IslemPaneli";
            this.Text = "IslemPaneli";
            this.kullanicipanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel kullanicipanel;
        private System.Windows.Forms.Panel kullaniciblgipanel;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
    }
}