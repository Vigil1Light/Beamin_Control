﻿namespace Beamin_Control.App_Login
{
    partial class Delete_Devices
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
            this.listView1 = new System.Windows.Forms.ListView();
       

            this.Device_Name =new System.Windows.Forms.ColumnHeader();
            this.columnHeader1 =new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 =new System.Windows.Forms.ColumnHeader();


            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(57, 78);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(121, 97);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // Delete_Devices
            // 
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.listView1);
            this.Name = "Delete_Devices";
            this.ResumeLayout(false);

        }



        #endregion

        private System.Windows.Forms.ListView listView1;

        private System.Windows.Forms.ColumnHeader Device_Name;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader1;
    }
}