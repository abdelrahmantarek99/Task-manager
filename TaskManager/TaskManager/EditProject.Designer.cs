namespace TaskManager
{
    partial class EditProject
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
            this.ProjectIDlbl = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Edit = new System.Windows.Forms.Button();
            this.ProjectID = new System.Windows.Forms.ComboBox();
            this.Description = new System.Windows.Forms.RichTextBox();
            this.Back = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ProjectIDlbl
            // 
            this.ProjectIDlbl.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProjectIDlbl.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.ProjectIDlbl.Location = new System.Drawing.Point(39, 34);
            this.ProjectIDlbl.Name = "ProjectIDlbl";
            this.ProjectIDlbl.Size = new System.Drawing.Size(150, 28);
            this.ProjectIDlbl.TabIndex = 33;
            this.ProjectIDlbl.Text = "Project ID";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label2.Location = new System.Drawing.Point(39, 152);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(168, 28);
            this.label2.TabIndex = 30;
            this.label2.Text = "Description";
            // 
            // Edit
            // 
            this.Edit.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Edit.ForeColor = System.Drawing.Color.Green;
            this.Edit.Location = new System.Drawing.Point(387, 267);
            this.Edit.Name = "Edit";
            this.Edit.Size = new System.Drawing.Size(114, 34);
            this.Edit.TabIndex = 34;
            this.Edit.Text = "Edit";
            this.Edit.UseVisualStyleBackColor = true;
            this.Edit.Click += new System.EventHandler(this.Edit_Click);
            // 
            // ProjectID
            // 
            this.ProjectID.FormattingEnabled = true;
            this.ProjectID.Location = new System.Drawing.Point(234, 38);
            this.ProjectID.Name = "ProjectID";
            this.ProjectID.Size = new System.Drawing.Size(267, 24);
            this.ProjectID.TabIndex = 35;
            this.ProjectID.SelectedIndexChanged += new System.EventHandler(this.ProjectID_SelectedIndexChanged);
            // 
            // Description
            // 
            this.Description.Location = new System.Drawing.Point(234, 79);
            this.Description.Name = "Description";
            this.Description.Size = new System.Drawing.Size(267, 162);
            this.Description.TabIndex = 48;
            this.Description.Text = "";
            // 
            // Back
            // 
            this.Back.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Back.ForeColor = System.Drawing.Color.Green;
            this.Back.Location = new System.Drawing.Point(234, 267);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(146, 34);
            this.Back.TabIndex = 49;
            this.Back.Text = "Back";
            this.Back.UseVisualStyleBackColor = true;
            this.Back.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // EditProject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Back);
            this.Controls.Add(this.Description);
            this.Controls.Add(this.ProjectID);
            this.Controls.Add(this.Edit);
            this.Controls.Add(this.ProjectIDlbl);
            this.Controls.Add(this.label2);
            this.Name = "EditProject";
            this.Size = new System.Drawing.Size(518, 317);
            this.Load += new System.EventHandler(this.EditProject_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label ProjectIDlbl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Edit;
        private System.Windows.Forms.ComboBox ProjectID;
        private System.Windows.Forms.RichTextBox Description;
        private System.Windows.Forms.Button Back;
    }
}
