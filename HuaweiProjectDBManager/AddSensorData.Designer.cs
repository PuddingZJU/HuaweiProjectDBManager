namespace HuaweiProjectDBManager
{
    partial class AddSensorData
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
            this.openbutton = new System.Windows.Forms.Button();
            this.filepathnamebox = new System.Windows.Forms.TextBox();
            this.OperatorIDBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.DeviceIDBOX = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.label3 = new System.Windows.Forms.Label();
            this.SRbox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // openbutton
            // 
            this.openbutton.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.openbutton.Location = new System.Drawing.Point(452, 37);
            this.openbutton.Name = "openbutton";
            this.openbutton.Size = new System.Drawing.Size(84, 29);
            this.openbutton.TabIndex = 0;
            this.openbutton.Text = "打开";
            this.openbutton.UseVisualStyleBackColor = true;
            this.openbutton.Click += new System.EventHandler(this.openbutton_Click);
            // 
            // filepathnamebox
            // 
            this.filepathnamebox.AllowDrop = true;
            this.filepathnamebox.Location = new System.Drawing.Point(17, 42);
            this.filepathnamebox.Name = "filepathnamebox";
            this.filepathnamebox.Size = new System.Drawing.Size(409, 20);
            this.filepathnamebox.TabIndex = 1;
            // 
            // OperatorIDBox
            // 
            this.OperatorIDBox.Location = new System.Drawing.Point(135, 90);
            this.OperatorIDBox.Name = "OperatorIDBox";
            this.OperatorIDBox.Size = new System.Drawing.Size(45, 20);
            this.OperatorIDBox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(44, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Operator ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(223, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Device ID:";
            // 
            // DeviceIDBOX
            // 
            this.DeviceIDBOX.Location = new System.Drawing.Point(299, 88);
            this.DeviceIDBOX.Name = "DeviceIDBOX";
            this.DeviceIDBOX.Size = new System.Drawing.Size(45, 20);
            this.DeviceIDBOX.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button1.Location = new System.Drawing.Point(135, 147);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(99, 35);
            this.button1.TabIndex = 6;
            this.button1.Text = "添加";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button2.Location = new System.Drawing.Point(327, 147);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(99, 35);
            this.button2.TabIndex = 7;
            this.button2.Text = "取消";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(370, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "Sample Rate:";
            // 
            // SRbox
            // 
            this.SRbox.Location = new System.Drawing.Point(463, 88);
            this.SRbox.Name = "SRbox";
            this.SRbox.Size = new System.Drawing.Size(45, 20);
            this.SRbox.TabIndex = 8;
            // 
            // AddSensorData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 218);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.SRbox);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.DeviceIDBOX);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.OperatorIDBox);
            this.Controls.Add(this.filepathnamebox);
            this.Controls.Add(this.openbutton);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddSensorData";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddSensorData";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AddSensorData_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button openbutton;
        private System.Windows.Forms.TextBox filepathnamebox;
        private System.Windows.Forms.TextBox OperatorIDBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox DeviceIDBOX;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox SRbox;
    }
}