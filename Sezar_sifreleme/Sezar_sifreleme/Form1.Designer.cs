namespace Sezar_sifreleme
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
            this.txtAnahtarSayi = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtYaziSifre = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSifrelenenYazi = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.txtDesifreYazi = new System.Windows.Forms.TextBox();
            this.Temizle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtAnahtarSayi
            // 
            this.txtAnahtarSayi.Location = new System.Drawing.Point(362, 38);
            this.txtAnahtarSayi.Multiline = true;
            this.txtAnahtarSayi.Name = "txtAnahtarSayi";
            this.txtAnahtarSayi.Size = new System.Drawing.Size(77, 28);
            this.txtAnahtarSayi.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(62, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Anahtar Sayı:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(65, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Şifrelenecek Yazı:";
            // 
            // txtYaziSifre
            // 
            this.txtYaziSifre.Location = new System.Drawing.Point(283, 106);
            this.txtYaziSifre.Multiline = true;
            this.txtYaziSifre.Name = "txtYaziSifre";
            this.txtYaziSifre.Size = new System.Drawing.Size(295, 112);
            this.txtYaziSifre.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(620, 143);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(111, 38);
            this.button1.TabIndex = 4;
            this.button1.Text = "Onayla";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(65, 315);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Şifrelenen Yazı:";
            // 
            // txtSifrelenenYazi
            // 
            this.txtSifrelenenYazi.Location = new System.Drawing.Point(283, 272);
            this.txtSifrelenenYazi.Multiline = true;
            this.txtSifrelenenYazi.Name = "txtSifrelenenYazi";
            this.txtSifrelenenYazi.Size = new System.Drawing.Size(295, 116);
            this.txtSifrelenenYazi.TabIndex = 6;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(607, 305);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(124, 36);
            this.button2.TabIndex = 7;
            this.button2.Text = "Temizle";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(68, 450);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(124, 44);
            this.button3.TabIndex = 8;
            this.button3.Text = "Deşifre Et";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // txtDesifreYazi
            // 
            this.txtDesifreYazi.Location = new System.Drawing.Point(283, 432);
            this.txtDesifreYazi.Multiline = true;
            this.txtDesifreYazi.Name = "txtDesifreYazi";
            this.txtDesifreYazi.Size = new System.Drawing.Size(295, 100);
            this.txtDesifreYazi.TabIndex = 9;
            // 
            // Temizle
            // 
            this.Temizle.Location = new System.Drawing.Point(607, 450);
            this.Temizle.Name = "Temizle";
            this.Temizle.Size = new System.Drawing.Size(124, 44);
            this.Temizle.TabIndex = 10;
            this.Temizle.Text = "Temizle";
            this.Temizle.UseVisualStyleBackColor = true;
            this.Temizle.Click += new System.EventHandler(this.Temizle_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 608);
            this.Controls.Add(this.Temizle);
            this.Controls.Add(this.txtDesifreYazi);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.txtSifrelenenYazi);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtYaziSifre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtAnahtarSayi);
            this.Name = "Form1";
            this.Text = "l";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtAnahtarSayi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtYaziSifre;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSifrelenenYazi;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox txtDesifreYazi;
        private System.Windows.Forms.Button Temizle;
    }
}

