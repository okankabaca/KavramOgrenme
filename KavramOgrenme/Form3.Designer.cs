namespace KavramOgrenme
{
    partial class Form3
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
            this.veriekle = new System.Windows.Forms.Button();
            this.veritablosu = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.veritablosu)).BeginInit();
            this.SuspendLayout();
            // 
            // veriekle
            // 
            this.veriekle.Location = new System.Drawing.Point(12, 188);
            this.veriekle.Name = "veriekle";
            this.veriekle.Size = new System.Drawing.Size(260, 23);
            this.veriekle.TabIndex = 1;
            this.veriekle.Text = "Öğrenme verilerini kaydet";
            this.veriekle.UseVisualStyleBackColor = true;
            this.veriekle.Click += new System.EventHandler(this.veriekle_Click);
            // 
            // veritablosu
            // 
            this.veritablosu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.veritablosu.Location = new System.Drawing.Point(12, 12);
            this.veritablosu.Name = "veritablosu";
            this.veritablosu.Size = new System.Drawing.Size(260, 158);
            this.veritablosu.TabIndex = 2;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 222);
            this.Controls.Add(this.veriekle);
            this.Controls.Add(this.veritablosu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "3.Adım Öğrenme verisi girme";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.veritablosu)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button veriekle;
        private System.Windows.Forms.DataGridView veritablosu;
    }
}