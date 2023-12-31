namespace kutuphane
{
    partial class kulsilform
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.kullsilbut = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(20, 110);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(754, 436);
            this.dataGridView1.TabIndex = 0;
            // 
            // kullsilbut
            // 
            this.kullsilbut.Font = new System.Drawing.Font("Bahnschrift SemiBold Condensed", 13.75F, System.Drawing.FontStyle.Bold);
            this.kullsilbut.Location = new System.Drawing.Point(51, 29);
            this.kullsilbut.Name = "kullsilbut";
            this.kullsilbut.Size = new System.Drawing.Size(194, 56);
            this.kullsilbut.TabIndex = 1;
            this.kullsilbut.Text = "Sil";
            this.kullsilbut.UseVisualStyleBackColor = true;
            // 
            // kulsilform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkOrange;
            this.ClientSize = new System.Drawing.Size(1034, 557);
            this.Controls.Add(this.kullsilbut);
            this.Controls.Add(this.dataGridView1);
            this.Name = "kulsilform";
            this.Text = "kulsilform";
            this.Load += new System.EventHandler(this.kulsilform_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button kullsilbut;
    }
}