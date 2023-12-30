namespace kutuphane
{
    partial class kullaniciekleform
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.kuladtxt = new System.Windows.Forms.TextBox();
            this.kultctxt = new System.Windows.Forms.TextBox();
            this.kulteltxt = new System.Windows.Forms.TextBox();
            this.kulsoyadtxt = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ad :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Soyad :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "TC :";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 116);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Telefon :";
            // 
            // kuladtxt
            // 
            this.kuladtxt.Location = new System.Drawing.Point(78, 28);
            this.kuladtxt.Name = "kuladtxt";
            this.kuladtxt.Size = new System.Drawing.Size(138, 20);
            this.kuladtxt.TabIndex = 4;
            // 
            // kultctxt
            // 
            this.kultctxt.Location = new System.Drawing.Point(78, 90);
            this.kultctxt.Name = "kultctxt";
            this.kultctxt.Size = new System.Drawing.Size(138, 20);
            this.kultctxt.TabIndex = 5;
            // 
            // kulteltxt
            // 
            this.kulteltxt.Location = new System.Drawing.Point(78, 116);
            this.kulteltxt.Name = "kulteltxt";
            this.kulteltxt.Size = new System.Drawing.Size(138, 20);
            this.kulteltxt.TabIndex = 6;
            // 
            // kulsoyadtxt
            // 
            this.kulsoyadtxt.Location = new System.Drawing.Point(78, 60);
            this.kulsoyadtxt.Name = "kulsoyadtxt";
            this.kulsoyadtxt.Size = new System.Drawing.Size(138, 20);
            this.kulsoyadtxt.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(78, 170);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(137, 40);
            this.button1.TabIndex = 8;
            this.button1.Text = "KAYDET";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(336, 39);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(419, 365);
            this.dataGridView1.TabIndex = 9;
            // 
            // kullaniciekleform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.kulsoyadtxt);
            this.Controls.Add(this.kulteltxt);
            this.Controls.Add(this.kultctxt);
            this.Controls.Add(this.kuladtxt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "kullaniciekleform";
            this.Text = "kullaniciekleform";
            this.Load += new System.EventHandler(this.kullaniciekleform_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox kuladtxt;
        private System.Windows.Forms.TextBox kultctxt;
        private System.Windows.Forms.TextBox kulteltxt;
        private System.Windows.Forms.TextBox kulsoyadtxt;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}