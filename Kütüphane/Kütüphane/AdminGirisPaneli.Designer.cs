namespace Kütüphane
{
    partial class AdminGirişPaneli
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
            this.btnGiriş = new System.Windows.Forms.Button();
            this.txtAdminŞif = new System.Windows.Forms.TextBox();
            this.txtAdminNo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnGiriş
            // 
            this.btnGiriş.Location = new System.Drawing.Point(125, 68);
            this.btnGiriş.Name = "btnGiriş";
            this.btnGiriş.Size = new System.Drawing.Size(75, 23);
            this.btnGiriş.TabIndex = 0;
            this.btnGiriş.Text = "LOGIN";
            this.btnGiriş.UseVisualStyleBackColor = true;
            this.btnGiriş.Click += new System.EventHandler(this.btnGiriş_Click);
            // 
            // txtAdminŞif
            // 
            this.txtAdminŞif.Location = new System.Drawing.Point(77, 42);
            this.txtAdminŞif.Name = "txtAdminŞif";
            this.txtAdminŞif.PasswordChar = '*';
            this.txtAdminŞif.Size = new System.Drawing.Size(123, 20);
            this.txtAdminŞif.TabIndex = 2;
            // 
            // txtAdminNo
            // 
            this.txtAdminNo.Location = new System.Drawing.Point(100, 16);
            this.txtAdminNo.Name = "txtAdminNo";
            this.txtAdminNo.Size = new System.Drawing.Size(100, 20);
            this.txtAdminNo.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Admin Number :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Password :";
            // 
            // AdminGirişPaneli
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(416, 213);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtAdminNo);
            this.Controls.Add(this.txtAdminŞif);
            this.Controls.Add(this.btnGiriş);
            this.Name = "AdminGirişPaneli";
            this.Text = "AdminGirişPaneli";
            //this.Load += new System.EventHandler(this.AdminGirişPaneli_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGiriş;
        private System.Windows.Forms.TextBox txtAdminŞif;
        private System.Windows.Forms.TextBox txtAdminNo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}