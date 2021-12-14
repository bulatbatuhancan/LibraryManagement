namespace Kütüphane
{
    partial class Register
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.İsim = new System.Windows.Forms.TextBox();
            this.Soyisim = new System.Windows.Forms.TextBox();
            this.OgrNo = new System.Windows.Forms.TextBox();
            this.Sifre = new System.Windows.Forms.TextBox();
            this.SifreKontrol = new System.Windows.Forms.TextBox();
            this.Mail = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnKayıt = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.cbÖğretmen = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // İsim
            // 
            this.İsim.Location = new System.Drawing.Point(195, 171);
            this.İsim.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.İsim.Name = "İsim";
            this.İsim.Size = new System.Drawing.Size(164, 24);
            this.İsim.TabIndex = 0;
            // 
            // Soyisim
            // 
            this.Soyisim.Location = new System.Drawing.Point(195, 207);
            this.Soyisim.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Soyisim.Name = "Soyisim";
            this.Soyisim.Size = new System.Drawing.Size(164, 24);
            this.Soyisim.TabIndex = 1;
            // 
            // OgrNo
            // 
            this.OgrNo.Location = new System.Drawing.Point(195, 243);
            this.OgrNo.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.OgrNo.Name = "OgrNo";
            this.OgrNo.Size = new System.Drawing.Size(164, 24);
            this.OgrNo.TabIndex = 2;
            // 
            // Sifre
            // 
            this.Sifre.Location = new System.Drawing.Point(195, 311);
            this.Sifre.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Sifre.Name = "Sifre";
            this.Sifre.PasswordChar = '*';
            this.Sifre.Size = new System.Drawing.Size(164, 24);
            this.Sifre.TabIndex = 4;
            // 
            // SifreKontrol
            // 
            this.SifreKontrol.Location = new System.Drawing.Point(195, 347);
            this.SifreKontrol.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.SifreKontrol.Name = "SifreKontrol";
            this.SifreKontrol.PasswordChar = '*';
            this.SifreKontrol.Size = new System.Drawing.Size(164, 24);
            this.SifreKontrol.TabIndex = 5;
            // 
            // Mail
            // 
            this.Mail.Location = new System.Drawing.Point(195, 279);
            this.Mail.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Mail.Name = "Mail";
            this.Mail.Size = new System.Drawing.Size(164, 24);
            this.Mail.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(118, 175);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Name : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(95, 211);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Surname : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(78, 247);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 18);
            this.label3.TabIndex = 1;
            this.label3.Text = "Student No : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(114, 282);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 18);
            this.label4.TabIndex = 1;
            this.label4.Text = "E-mail : ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(41, 350);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(144, 18);
            this.label5.TabIndex = 1;
            this.label5.Text = "Password Again : ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(87, 314);
            this.label6.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 18);
            this.label6.TabIndex = 1;
            this.label6.Text = "Password : ";
            // 
            // btnKayıt
            // 
            this.btnKayıt.Location = new System.Drawing.Point(121, 440);
            this.btnKayıt.Name = "btnKayıt";
            this.btnKayıt.Size = new System.Drawing.Size(164, 42);
            this.btnKayıt.TabIndex = 6;
            this.btnKayıt.Text = "REGISTER";
            this.btnKayıt.UseVisualStyleBackColor = true;
            this.btnKayıt.Click += new System.EventHandler(this.btnKayıt_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("DejaVu Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label8.Location = new System.Drawing.Point(24, 44);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(350, 25);
            this.label8.TabIndex = 3;
            this.label8.Text = "Library Management System";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("DejaVu Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label9.Location = new System.Drawing.Point(116, 101);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(183, 25);
            this.label9.TabIndex = 3;
            this.label9.Text = "Register Panel";
            // 
            // cbÖğretmen
            // 
            this.cbÖğretmen.AutoSize = true;
            this.cbÖğretmen.Location = new System.Drawing.Point(195, 385);
            this.cbÖğretmen.Name = "cbÖğretmen";
            this.cbÖğretmen.Size = new System.Drawing.Size(88, 22);
            this.cbÖğretmen.TabIndex = 4;
            this.cbÖğretmen.Text = "Teacher";
            this.cbÖğretmen.UseVisualStyleBackColor = true;
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(397, 565);
            this.Controls.Add(this.cbÖğretmen);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnKayıt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SifreKontrol);
            this.Controls.Add(this.Mail);
            this.Controls.Add(this.OgrNo);
            this.Controls.Add(this.Sifre);
            this.Controls.Add(this.Soyisim);
            this.Controls.Add(this.İsim);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "Register";
            this.Text = "Register";
//            this.Load += new System.EventHandler(this.Register_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox İsim;
        private System.Windows.Forms.TextBox Soyisim;
        private System.Windows.Forms.TextBox OgrNo;
        private System.Windows.Forms.TextBox Sifre;
        private System.Windows.Forms.TextBox SifreKontrol;
        private System.Windows.Forms.TextBox Mail;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnKayıt;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.CheckBox cbÖğretmen;
    }
}

