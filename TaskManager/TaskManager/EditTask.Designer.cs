namespace TaskManager
{
    partial class EditTask
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Edit = new System.Windows.Forms.Button();
            this.ProjectIDlbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TaskID = new System.Windows.Forms.TextBox();
            this.UserID = new System.Windows.Forms.ComboBox();
            this.ProjectID = new System.Windows.Forms.ComboBox();
            this.IDlabel = new System.Windows.Forms.Label();
            this.Description = new System.Windows.Forms.RichTextBox();
            this.Cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Edit
            // 
            this.Edit.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Edit.ForeColor = System.Drawing.Color.Green;
            this.Edit.Location = new System.Drawing.Point(376, 347);
            this.Edit.Name = "Edit";
            this.Edit.Size = new System.Drawing.Size(114, 34);
            this.Edit.TabIndex = 37;
            this.Edit.Text = "Edit";
            this.Edit.UseVisualStyleBackColor = true;
            // 
            // ProjectIDlbl
            // 
            this.ProjectIDlbl.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProjectIDlbl.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.ProjectIDlbl.Location = new System.Drawing.Point(27, 19);
            this.ProjectIDlbl.Name = "ProjectIDlbl";
            this.ProjectIDlbl.Size = new System.Drawing.Size(150, 28);
            this.ProjectIDlbl.TabIndex = 36;
            this.ProjectIDlbl.Text = "Project ID";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label1.Location = new System.Drawing.Point(27, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 28);
            this.label1.TabIndex = 39;
            this.label1.Text = "User ID";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label2.Location = new System.Drawing.Point(27, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 28);
            this.label2.TabIndex = 41;
            this.label2.Text = "Task ID";
            // 
            // TaskID
            // 
            this.TaskID.Location = new System.Drawing.Point(223, 118);
            this.TaskID.Name = "TaskID";
            this.TaskID.Size = new System.Drawing.Size(267, 22);
            this.TaskID.TabIndex = 40;
            // 
            // UserID
            // 
            this.UserID.FormattingEnabled = true;
            this.UserID.Location = new System.Drawing.Point(223, 75);
            this.UserID.Name = "UserID";
            this.UserID.Size = new System.Drawing.Size(267, 24);
            this.UserID.TabIndex = 43;
            // 
            // ProjectID
            // 
            this.ProjectID.FormattingEnabled = true;
            this.ProjectID.Location = new System.Drawing.Point(223, 19);
            this.ProjectID.Name = "ProjectID";
            this.ProjectID.Size = new System.Drawing.Size(267, 24);
            this.ProjectID.TabIndex = 42;
            // 
            // IDlabel
            // 
            this.IDlabel.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IDlabel.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.IDlabel.Location = new System.Drawing.Point(27, 223);
            this.IDlabel.Name = "IDlabel";
            this.IDlabel.Size = new System.Drawing.Size(168, 28);
            this.IDlabel.TabIndex = 45;
            this.IDlabel.Text = "Description";
            // 
            // Description
            // 
            this.Description.Location = new System.Drawing.Point(223, 161);
            this.Description.Name = "Description";
            this.Description.Size = new System.Drawing.Size(267, 162);
            this.Description.TabIndex = 46;
            this.Description.Text = "";
            // 
            // Cancel
            // 
            this.Cancel.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cancel.ForeColor = System.Drawing.Color.Green;
            this.Cancel.Location = new System.Drawing.Point(223, 347);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(146, 34);
            this.Cancel.TabIndex = 47;
            this.Cancel.Text = "Cancel";
            this.Cancel.UseVisualStyleBackColor = true;
            // 
            // EditTask
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.Description);
            this.Controls.Add(this.IDlabel);
            this.Controls.Add(this.UserID);
            this.Controls.Add(this.ProjectID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TaskID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Edit);
            this.Controls.Add(this.ProjectIDlbl);
            this.Name = "EditTask";
            this.Size = new System.Drawing.Size(512, 398);
            this.Load += new System.EventHandler(this.EditTask_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Edit;
        private System.Windows.Forms.Label ProjectIDlbl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TaskID;
        private System.Windows.Forms.ComboBox UserID;
        private System.Windows.Forms.ComboBox ProjectID;
        private System.Windows.Forms.Label IDlabel;
        private System.Windows.Forms.RichTextBox Description;
        private System.Windows.Forms.Button Cancel;
    }
}
