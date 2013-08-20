namespace HuaweiProjectDBManager
{
    partial class Login
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
            this.addersstextbox = new System.Windows.Forms.TextBox();
            this.resetbutton = new System.Windows.Forms.Button();
            this.loginbutton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.accounttextbox = new System.Windows.Forms.TextBox();
            this.pwdtextbox = new System.Windows.Forms.TextBox();
            this.DBNameBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // addersstextbox
            // 
            this.addersstextbox.Location = new System.Drawing.Point(139, 43);
            this.addersstextbox.Name = "addersstextbox";
            this.addersstextbox.Size = new System.Drawing.Size(170, 20);
            this.addersstextbox.TabIndex = 0;
            this.addersstextbox.Text = "10.12.34.98";
            // 
            // resetbutton
            // 
            this.resetbutton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.resetbutton.Location = new System.Drawing.Point(186, 198);
            this.resetbutton.Name = "resetbutton";
            this.resetbutton.Size = new System.Drawing.Size(75, 23);
            this.resetbutton.TabIndex = 1;
            this.resetbutton.Text = "Reset";
            this.resetbutton.UseVisualStyleBackColor = true;
            this.resetbutton.Click += new System.EventHandler(this.resetbutton_Click);
            // 
            // loginbutton
            // 
            this.loginbutton.Location = new System.Drawing.Point(71, 198);
            this.loginbutton.Name = "loginbutton";
            this.loginbutton.Size = new System.Drawing.Size(75, 23);
            this.loginbutton.TabIndex = 2;
            this.loginbutton.Text = "Login";
            this.loginbutton.UseVisualStyleBackColor = true;
            this.loginbutton.Click += new System.EventHandler(this.loginbutton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "DataBase Adderss:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "DataBase Account:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "DataBase Password:";
            // 
            // accounttextbox
            // 
            this.accounttextbox.Location = new System.Drawing.Point(139, 108);
            this.accounttextbox.Name = "accounttextbox";
            this.accounttextbox.Size = new System.Drawing.Size(170, 20);
            this.accounttextbox.TabIndex = 6;
            this.accounttextbox.Text = "capgadmin";
            // 
            // pwdtextbox
            // 
            this.pwdtextbox.Location = new System.Drawing.Point(139, 144);
            this.pwdtextbox.Name = "pwdtextbox";
            this.pwdtextbox.PasswordChar = '*';
            this.pwdtextbox.Size = new System.Drawing.Size(170, 20);
            this.pwdtextbox.TabIndex = 7;
            this.pwdtextbox.Text = "capg11207";
            // 
            // DBNameBox
            // 
            this.DBNameBox.Location = new System.Drawing.Point(139, 75);
            this.DBNameBox.Name = "DBNameBox";
            this.DBNameBox.Size = new System.Drawing.Size(170, 20);
            this.DBNameBox.TabIndex = 9;
            this.DBNameBox.Text = "HuaweiSensorDB";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(45, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "DataBase Name:";
            // 
            // Login
            // 
            this.AcceptButton = this.loginbutton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.resetbutton;
            this.ClientSize = new System.Drawing.Size(344, 277);
            this.Controls.Add(this.DBNameBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pwdtextbox);
            this.Controls.Add(this.accounttextbox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.loginbutton);
            this.Controls.Add(this.resetbutton);
            this.Controls.Add(this.addersstextbox);
            this.MaximizeBox = false;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox addersstextbox;
        private System.Windows.Forms.Button resetbutton;
        private System.Windows.Forms.Button loginbutton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox accounttextbox;
        private System.Windows.Forms.TextBox pwdtextbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox DBNameBox;
        private System.Windows.Forms.Label label4;
    }
}

