namespace KavramOgrenme
{
    partial class Form1
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
            this.sonrakiadim = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textalansayisi = new System.Windows.Forms.TextBox();
            this.textverisayisi = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // sonrakiadim
            // 
            this.sonrakiadim.Location = new System.Drawing.Point(33, 127);
            this.sonrakiadim.Name = "sonrakiadim";
            this.sonrakiadim.Size = new System.Drawing.Size(158, 23);
            this.sonrakiadim.TabIndex = 0;
            this.sonrakiadim.Text = "Sonraki adıma geç";
            this.sonrakiadim.UseVisualStyleBackColor = true;
            this.sonrakiadim.Click += new System.EventHandler(this.sonrakiadim_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Kaç alan bilgisi girekceksiniz?";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(161, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Kaç öğrenme verisi gireceksiniz?";
            // 
            // textalansayisi
            // 
            this.textalansayisi.Location = new System.Drawing.Point(91, 39);
            this.textalansayisi.Name = "textalansayisi";
            this.textalansayisi.Size = new System.Drawing.Size(100, 20);
            this.textalansayisi.TabIndex = 3;
            this.textalansayisi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textalansayisi_KeyPress);
            // 
            // textverisayisi
            // 
            this.textverisayisi.Location = new System.Drawing.Point(91, 84);
            this.textverisayisi.Name = "textverisayisi";
            this.textverisayisi.Size = new System.Drawing.Size(100, 20);
            this.textverisayisi.TabIndex = 4;
            this.textverisayisi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textverisayisi_KeyPress);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(240, 184);
            this.Controls.Add(this.textverisayisi);
            this.Controls.Add(this.textalansayisi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.sonrakiadim);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "1.Adım boyutları belirleme";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button sonrakiadim;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textalansayisi;
        private System.Windows.Forms.TextBox textverisayisi;
    }
}

