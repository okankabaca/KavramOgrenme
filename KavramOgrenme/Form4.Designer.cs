namespace KavramOgrenme
{
    partial class Form4
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
            this.veritablosu = new System.Windows.Forms.DataGridView();
            this.combosonuc = new System.Windows.Forms.ComboBox();
            this.analizet = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.veritablosu)).BeginInit();
            this.SuspendLayout();
            // 
            // veritablosu
            // 
            this.veritablosu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.veritablosu.Location = new System.Drawing.Point(12, 12);
            this.veritablosu.Name = "veritablosu";
            this.veritablosu.Size = new System.Drawing.Size(260, 150);
            this.veritablosu.TabIndex = 0;
            // 
            // combosonuc
            // 
            this.combosonuc.FormattingEnabled = true;
            this.combosonuc.Location = new System.Drawing.Point(12, 197);
            this.combosonuc.Name = "combosonuc";
            this.combosonuc.Size = new System.Drawing.Size(235, 21);
            this.combosonuc.TabIndex = 1;
            // 
            // analizet
            // 
            this.analizet.Location = new System.Drawing.Point(12, 224);
            this.analizet.Name = "analizet";
            this.analizet.Size = new System.Drawing.Size(235, 23);
            this.analizet.TabIndex = 2;
            this.analizet.Text = "Analiz et";
            this.analizet.UseVisualStyleBackColor = true;
            this.analizet.Click += new System.EventHandler(this.analizet_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 181);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Hangi referans sonuç verisi?";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 253);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Önceki adım";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 275);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.analizet);
            this.Controls.Add(this.combosonuc);
            this.Controls.Add(this.veritablosu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "Form4";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sonuç verisi";
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.veritablosu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView veritablosu;
        private System.Windows.Forms.ComboBox combosonuc;
        private System.Windows.Forms.Button analizet;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}