namespace TaskManager
{
    partial class UserAction
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
            this.label2 = new System.Windows.Forms.Label();
            this.Tasks = new System.Windows.Forms.DataGridView();
            this.ProjectID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProjectName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TaskID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TaskName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Back = new System.Windows.Forms.Button();
            this.lblAttach = new System.Windows.Forms.Label();
            this.Forwrd = new System.Windows.Forms.Label();
            this.Comment = new System.Windows.Forms.Label();
            this.Download = new System.Windows.Forms.Label();
            this.Description = new System.Windows.Forms.RichTextBox();
            this.Employees = new System.Windows.Forms.ComboBox();
            this.Select = new System.Windows.Forms.Button();
            this.FilePath = new System.Windows.Forms.Label();
            this.FileContent = new System.Windows.Forms.RichTextBox();
            this.Files = new System.Windows.Forms.ComboBox();
            this.Add = new System.Windows.Forms.Button();
            this.Forward = new System.Windows.Forms.Button();
            this.descriptiontxt = new System.Windows.Forms.RichTextBox();
            this.Edit = new System.Windows.Forms.Button();
            this.Descriptiongb = new System.Windows.Forms.GroupBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.Tasks)).BeginInit();
            this.Descriptiongb.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label2.Location = new System.Drawing.Point(19, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 28);
            this.label2.TabIndex = 53;
            this.label2.Text = "Tasks";
            // 
            // Tasks
            // 
            this.Tasks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Tasks.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProjectID,
            this.ProjectName,
            this.TaskID,
            this.TaskName});
            this.Tasks.Location = new System.Drawing.Point(24, 57);
            this.Tasks.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Tasks.MultiSelect = false;
            this.Tasks.Name = "Tasks";
            this.Tasks.ReadOnly = true;
            this.Tasks.RowTemplate.Height = 26;
            this.Tasks.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Tasks.Size = new System.Drawing.Size(531, 222);
            this.Tasks.TabIndex = 55;
            this.Tasks.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Tasks_CellClick);
            this.Tasks.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Tasks_CellContentClick);
            // 
            // ProjectID
            // 
            this.ProjectID.HeaderText = "ProjectID";
            this.ProjectID.Name = "ProjectID";
            this.ProjectID.ReadOnly = true;
            // 
            // ProjectName
            // 
            this.ProjectName.HeaderText = "ProjectName";
            this.ProjectName.Name = "ProjectName";
            this.ProjectName.ReadOnly = true;
            // 
            // TaskID
            // 
            this.TaskID.HeaderText = "TaskID";
            this.TaskID.Name = "TaskID";
            this.TaskID.ReadOnly = true;
            // 
            // TaskName
            // 
            this.TaskName.HeaderText = "TaskName";
            this.TaskName.Name = "TaskName";
            this.TaskName.ReadOnly = true;
            this.TaskName.Width = 120;
            // 
            // Back
            // 
            this.Back.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Back.ForeColor = System.Drawing.Color.Green;
            this.Back.Location = new System.Drawing.Point(1013, 752);
            this.Back.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(129, 34);
            this.Back.TabIndex = 56;
            this.Back.Text = "Back";
            this.Back.UseVisualStyleBackColor = true;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // lblAttach
            // 
            this.lblAttach.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAttach.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.lblAttach.Location = new System.Drawing.Point(21, 318);
            this.lblAttach.Name = "lblAttach";
            this.lblAttach.Size = new System.Drawing.Size(149, 28);
            this.lblAttach.TabIndex = 57;
            this.lblAttach.Text = "Attach File";
            this.lblAttach.Click += new System.EventHandler(this.lblAttach_Click);
            // 
            // Forwrd
            // 
            this.Forwrd.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Forwrd.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.Forwrd.Location = new System.Drawing.Point(680, 313);
            this.Forwrd.Name = "Forwrd";
            this.Forwrd.Size = new System.Drawing.Size(117, 33);
            this.Forwrd.TabIndex = 58;
            this.Forwrd.Text = "Forward";
            this.Forwrd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Forwrd.Click += new System.EventHandler(this.Forwrd_Click);
            // 
            // Comment
            // 
            this.Comment.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Comment.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.Comment.Location = new System.Drawing.Point(19, 665);
            this.Comment.Name = "Comment";
            this.Comment.Size = new System.Drawing.Size(139, 28);
            this.Comment.TabIndex = 59;
            this.Comment.Text = "Comment";
            // 
            // Download
            // 
            this.Download.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Download.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.Download.Location = new System.Drawing.Point(21, 359);
            this.Download.Name = "Download";
            this.Download.Size = new System.Drawing.Size(149, 28);
            this.Download.TabIndex = 60;
            this.Download.Text = "Download";
            // 
            // Description
            // 
            this.Description.Location = new System.Drawing.Point(176, 668);
            this.Description.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Description.Name = "Description";
            this.Description.Size = new System.Drawing.Size(815, 45);
            this.Description.TabIndex = 61;
            this.Description.Text = "";
            // 
            // Employees
            // 
            this.Employees.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Employees.FormattingEnabled = true;
            this.Employees.Location = new System.Drawing.Point(824, 315);
            this.Employees.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Employees.Name = "Employees";
            this.Employees.Size = new System.Drawing.Size(167, 29);
            this.Employees.TabIndex = 63;
            // 
            // Select
            // 
            this.Select.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Select.ForeColor = System.Drawing.Color.Green;
            this.Select.Location = new System.Drawing.Point(493, 318);
            this.Select.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Select.Name = "Select";
            this.Select.Size = new System.Drawing.Size(143, 34);
            this.Select.TabIndex = 64;
            this.Select.Text = "Select File";
            this.Select.UseVisualStyleBackColor = true;
            this.Select.Click += new System.EventHandler(this.Select_Click);
            // 
            // FilePath
            // 
            this.FilePath.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FilePath.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.FilePath.Location = new System.Drawing.Point(171, 318);
            this.FilePath.Name = "FilePath";
            this.FilePath.Size = new System.Drawing.Size(309, 32);
            this.FilePath.TabIndex = 65;
            // 
            // FileContent
            // 
            this.FileContent.Location = new System.Drawing.Point(176, 410);
            this.FileContent.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.FileContent.Name = "FileContent";
            this.FileContent.Size = new System.Drawing.Size(815, 242);
            this.FileContent.TabIndex = 66;
            this.FileContent.Text = "";
            // 
            // Files
            // 
            this.Files.FormattingEnabled = true;
            this.Files.Location = new System.Drawing.Point(177, 367);
            this.Files.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Files.Name = "Files";
            this.Files.Size = new System.Drawing.Size(377, 24);
            this.Files.TabIndex = 67;
            // 
            // Add
            // 
            this.Add.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Add.ForeColor = System.Drawing.Color.Green;
            this.Add.Location = new System.Drawing.Point(1013, 679);
            this.Add.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(129, 34);
            this.Add.TabIndex = 68;
            this.Add.Text = "Add";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // Forward
            // 
            this.Forward.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Forward.ForeColor = System.Drawing.Color.Green;
            this.Forward.Location = new System.Drawing.Point(1013, 311);
            this.Forward.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Forward.Name = "Forward";
            this.Forward.Size = new System.Drawing.Size(129, 34);
            this.Forward.TabIndex = 69;
            this.Forward.Text = "Forward";
            this.Forward.UseVisualStyleBackColor = true;
            this.Forward.Click += new System.EventHandler(this.Forward_Click);
            // 
            // descriptiontxt
            // 
            this.descriptiontxt.Location = new System.Drawing.Point(11, 31);
            this.descriptiontxt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.descriptiontxt.Name = "descriptiontxt";
            this.descriptiontxt.Size = new System.Drawing.Size(551, 134);
            this.descriptiontxt.TabIndex = 72;
            this.descriptiontxt.Text = "";
            // 
            // Edit
            // 
            this.Edit.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Edit.ForeColor = System.Drawing.Color.Green;
            this.Edit.Location = new System.Drawing.Point(435, 172);
            this.Edit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Edit.Name = "Edit";
            this.Edit.Size = new System.Drawing.Size(129, 34);
            this.Edit.TabIndex = 70;
            this.Edit.Text = "Edit";
            this.Edit.UseVisualStyleBackColor = true;
            this.Edit.Click += new System.EventHandler(this.Edit_Click);
            // 
            // Descriptiongb
            // 
            this.Descriptiongb.Controls.Add(this.Edit);
            this.Descriptiongb.Controls.Add(this.descriptiontxt);
            this.Descriptiongb.Enabled = false;
            this.Descriptiongb.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Descriptiongb.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.Descriptiongb.Location = new System.Drawing.Point(579, 57);
            this.Descriptiongb.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Descriptiongb.Name = "Descriptiongb";
            this.Descriptiongb.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Descriptiongb.Size = new System.Drawing.Size(573, 222);
            this.Descriptiongb.TabIndex = 82;
            this.Descriptiongb.TabStop = false;
            this.Descriptiongb.Text = "Description";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // UserAction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Descriptiongb);
            this.Controls.Add(this.Forward);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.Files);
            this.Controls.Add(this.FileContent);
            this.Controls.Add(this.FilePath);
            this.Controls.Add(this.Select);
            this.Controls.Add(this.Employees);
            this.Controls.Add(this.Description);
            this.Controls.Add(this.Download);
            this.Controls.Add(this.Comment);
            this.Controls.Add(this.Forwrd);
            this.Controls.Add(this.lblAttach);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.Tasks);
            this.Controls.Add(this.label2);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "UserAction";
            this.Size = new System.Drawing.Size(1173, 799);
            this.Load += new System.EventHandler(this.UserAction_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Tasks)).EndInit();
            this.Descriptiongb.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView Tasks;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProjectID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProjectName;
        private System.Windows.Forms.DataGridViewTextBoxColumn TaskID;
        private System.Windows.Forms.DataGridViewTextBoxColumn TaskName;
        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.Label lblAttach;
        private System.Windows.Forms.Label Forwrd;
        private System.Windows.Forms.Label Comment;
        private System.Windows.Forms.Label Download;
        private System.Windows.Forms.RichTextBox Description;
        private System.Windows.Forms.ComboBox Employees;
        private System.Windows.Forms.Button Select;
        private System.Windows.Forms.Label FilePath;
        private System.Windows.Forms.RichTextBox FileContent;
        private System.Windows.Forms.ComboBox Files;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.Button Forward;
        private System.Windows.Forms.RichTextBox descriptiontxt;
        private System.Windows.Forms.Button Edit;
        private System.Windows.Forms.GroupBox Descriptiongb;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}
