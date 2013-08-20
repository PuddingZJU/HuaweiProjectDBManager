namespace HuaweiProjectDBManager
{
    partial class eigenvalueform
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
            this.elist = new System.Windows.Forms.ListView();
            this.ename = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.evalue = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // elist
            // 
            this.elist.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ename,
            this.evalue});
            this.elist.FullRowSelect = true;
            this.elist.GridLines = true;
            this.elist.Location = new System.Drawing.Point(0, -2);
            this.elist.Name = "elist";
            this.elist.Size = new System.Drawing.Size(400, 600);
            this.elist.TabIndex = 0;
            this.elist.UseCompatibleStateImageBehavior = false;
            this.elist.View = System.Windows.Forms.View.Details;
            // 
            // ename
            // 
            this.ename.Text = "特征值名称";
            this.ename.Width = 200;
            // 
            // evalue
            // 
            this.evalue.Text = "值";
            this.evalue.Width = 200;
            // 
            // eigenvalueform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(399, 597);
            this.Controls.Add(this.elist);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "eigenvalueform";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "特征值列表";
            this.Load += new System.EventHandler(this.eigenvalueform_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView elist;
        private System.Windows.Forms.ColumnHeader ename;
        private System.Windows.Forms.ColumnHeader evalue;
    }
}