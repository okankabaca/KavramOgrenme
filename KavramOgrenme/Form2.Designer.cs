namespace KavramOgrenme
{
    partial class Form2
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
            this.alanadiekle = new System.Windows.Forms.Button();
            this.textalanadi = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // alanadiekle
            // 
            this.alanadiekle.Location = new System.Drawing.Point(15, 51);
            this.alanadiekle.Name = "alanadiekle";
            this.alanadiekle.Size = new System.Drawing.Size(241, 24);
            this.alanadiekle.TabIndex = 0;
            this.alanadiekle.Text = "1.alan adını ekle";
            this.alanadiekle.UseVisualStyleBackColor = true;
            this.alanadiekle.Click += new System.EventHandler(this.alanadiekle_Click);
            // 
            // textalanadi
            // 
            this.textalanadi.Location = new System.Drawing.Point(15, 25);
            this.textalanadi.Name = "textalanadi";
            this.textalanadi.Size = new System.Drawing.Size(241, 20);
            this.textalanadi.TabIndex = 1;
            this.textalanadi.TextChanged += new System.EventHandler(this.textalanadi_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(15, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(241, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Sonraki adım için butona tekrar tıklayınız.";
            this.label1.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Gireceğiniz alan adı";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(271, 116);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textalanadi);
            this.Controls.Add(this.alanadiekle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "2.Adım Alan adları belirleme";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form2_FormClosing);
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button alanadiekle;
        private System.Windows.Forms.TextBox textalanadi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}