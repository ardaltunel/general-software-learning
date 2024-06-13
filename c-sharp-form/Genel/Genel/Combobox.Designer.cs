namespace Genel
{
    partial class Combobox
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnEkle = new System.Windows.Forms.Button();
            this.txtEkle = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnDegistir = new System.Windows.Forms.Button();
            this.txtDegistir = new System.Windows.Forms.TextBox();
            this.btnOku = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnHepsiniSil = new System.Windows.Forms.Button();
            this.lblBilgi = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Red;
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(185, 120);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Şehirler";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(15, 44);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(164, 33);
            this.comboBox1.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Lime;
            this.groupBox2.Controls.Add(this.btnEkle);
            this.groupBox2.Controls.Add(this.txtEkle);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox2.Location = new System.Drawing.Point(221, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(170, 120);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Şehir Ekle";
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(17, 69);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(147, 31);
            this.btnEkle.TabIndex = 1;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // txtEkle
            // 
            this.txtEkle.Location = new System.Drawing.Point(17, 32);
            this.txtEkle.Name = "txtEkle";
            this.txtEkle.Size = new System.Drawing.Size(147, 31);
            this.txtEkle.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Lime;
            this.groupBox3.Controls.Add(this.btnDegistir);
            this.groupBox3.Controls.Add(this.txtDegistir);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox3.Location = new System.Drawing.Point(12, 138);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(185, 136);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Değiştirilecek Şehir";
            // 
            // btnDegistir
            // 
            this.btnDegistir.Location = new System.Drawing.Point(17, 87);
            this.btnDegistir.Name = "btnDegistir";
            this.btnDegistir.Size = new System.Drawing.Size(150, 31);
            this.btnDegistir.TabIndex = 1;
            this.btnDegistir.Text = "Değiştir";
            this.btnDegistir.UseVisualStyleBackColor = true;
            this.btnDegistir.Click += new System.EventHandler(this.btnDegistir_Click);
            // 
            // txtDegistir
            // 
            this.txtDegistir.Location = new System.Drawing.Point(17, 41);
            this.txtDegistir.Name = "txtDegistir";
            this.txtDegistir.Size = new System.Drawing.Size(150, 26);
            this.txtDegistir.TabIndex = 0;
            // 
            // btnOku
            // 
            this.btnOku.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnOku.Location = new System.Drawing.Point(221, 138);
            this.btnOku.Name = "btnOku";
            this.btnOku.Size = new System.Drawing.Size(82, 81);
            this.btnOku.TabIndex = 3;
            this.btnOku.Text = "Oku";
            this.btnOku.UseVisualStyleBackColor = true;
            this.btnOku.Click += new System.EventHandler(this.btnOku_Click);
            // 
            // btnSil
            // 
            this.btnSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSil.Location = new System.Drawing.Point(309, 138);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(82, 81);
            this.btnSil.TabIndex = 4;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnHepsiniSil
            // 
            this.btnHepsiniSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnHepsiniSil.Location = new System.Drawing.Point(221, 225);
            this.btnHepsiniSil.Name = "btnHepsiniSil";
            this.btnHepsiniSil.Size = new System.Drawing.Size(170, 49);
            this.btnHepsiniSil.TabIndex = 5;
            this.btnHepsiniSil.Text = "Hepsini Sil";
            this.btnHepsiniSil.UseVisualStyleBackColor = true;
            this.btnHepsiniSil.Click += new System.EventHandler(this.btnHepsiniSil_Click);
            // 
            // lblBilgi
            // 
            this.lblBilgi.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBilgi.Location = new System.Drawing.Point(13, 303);
            this.lblBilgi.Name = "lblBilgi";
            this.lblBilgi.Size = new System.Drawing.Size(378, 168);
            this.lblBilgi.TabIndex = 6;
            this.lblBilgi.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Combobox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(405, 480);
            this.Controls.Add(this.lblBilgi);
            this.Controls.Add(this.btnHepsiniSil);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnOku);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Combobox";
            this.Text = "Combobox";
            this.Load += new System.EventHandler(this.Combobox_Ornek3_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.TextBox txtEkle;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnDegistir;
        private System.Windows.Forms.TextBox txtDegistir;
        private System.Windows.Forms.Button btnOku;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnHepsiniSil;
        private System.Windows.Forms.Label lblBilgi;
    }
}