namespace TaskManager
{
    partial class ViewProject
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
            this.Description = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.Label();
            this.ProjectID = new System.Windows.Forms.ComboBox();
            this.Employees = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.ViewTaskHistory = new System.Windows.Forms.Button();
            this.ViewTask = new System.Windows.Forms.Button();
            this.Back = new System.Windows.Forms.Button();
            this.Tasks = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // Description
            // 
            this.Description.Enabled = false;
            this.Description.Location = new System.Drawing.Point(223, 116);
            this.Description.Name = "Description";
            this.Description.Size = new System.Drawing.Size(267, 162);
            this.Description.TabIndex = 53;
            this.Description.Text = "";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label2.Location = new System.Drawing.Point(23, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 28);
            this.label2.TabIndex = 51;
            this.label2.Text = "Project ID";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label3.Location = new System.Drawing.Point(23, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(168, 28);
            this.label3.TabIndex = 50;
            this.label3.Text = "Description";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label4.Location = new System.Drawing.Point(23, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 28);
            this.label4.TabIndex = 49;
            this.label4.Text = "Name";
            // 
            // name
            // 
            this.name.BackColor = System.Drawing.SystemColors.Control;
            this.name.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name.ForeColor = System.Drawing.Color.Green;
            this.name.Location = new System.Drawing.Point(218, 67);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(267, 28);
            this.name.TabIndex = 54;
            // 
            // ProjectID
            // 
            this.ProjectID.FormattingEnabled = true;
            this.ProjectID.Location = new System.Drawing.Point(218, 21);
            this.ProjectID.Name = "ProjectID";
            this.ProjectID.Size = new System.Drawing.Size(267, 24);
            this.ProjectID.TabIndex = 52;
            this.ProjectID.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // Employees
            // 
            this.Employees.Enabled = false;
            this.Employees.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Employees.FormattingEnabled = true;
            this.Employees.ItemHeight = 21;
            this.Employees.Location = new System.Drawing.Point(184, 316);
            this.Employees.Name = "Employees";
            this.Employees.Size = new System.Drawing.Size(206, 109);
            this.Employees.TabIndex = 55;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label1.Location = new System.Drawing.Point(421, 304);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 28);
            this.label1.TabIndex = 56;
            this.label1.Text = "Tasks";
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label5.Location = new System.Drawing.Point(23, 304);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(150, 28);
            this.label5.TabIndex = 57;
            this.label5.Text = "Employees";
            // 
            // ViewTaskHistory
            // 
            this.ViewTaskHistory.Enabled = false;
            this.ViewTaskHistory.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ViewTaskHistory.ForeColor = System.Drawing.Color.Green;
            this.ViewTaskHistory.Location = new System.Drawing.Point(523, 471);
            this.ViewTaskHistory.Name = "ViewTaskHistory";
            this.ViewTaskHistory.Size = new System.Drawing.Size(223, 34);
            this.ViewTaskHistory.TabIndex = 59;
            this.ViewTaskHistory.Text = "View Task History";
            this.ViewTaskHistory.UseVisualStyleBackColor = true;
            this.ViewTaskHistory.Click += new System.EventHandler(this.ViewTaskHistory_Click);
            // 
            // ViewTask
            // 
            this.ViewTask.Enabled = false;
            this.ViewTask.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ViewTask.ForeColor = System.Drawing.Color.Green;
            this.ViewTask.Location = new System.Drawing.Point(523, 431);
            this.ViewTask.Name = "ViewTask";
            this.ViewTask.Size = new System.Drawing.Size(223, 34);
            this.ViewTask.TabIndex = 60;
            this.ViewTask.Text = "View Task";
            this.ViewTask.UseVisualStyleBackColor = true;
            this.ViewTask.Click += new System.EventHandler(this.ViewTask_Click);
            // 
            // Back
            // 
            this.Back.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Back.ForeColor = System.Drawing.Color.Green;
            this.Back.Location = new System.Drawing.Point(27, 470);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(114, 34);
            this.Back.TabIndex = 61;
            this.Back.Text = "Back";
            this.Back.UseVisualStyleBackColor = true;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // Tasks
            // 
            this.Tasks.FormattingEnabled = true;
            this.Tasks.Location = new System.Drawing.Point(523, 308);
            this.Tasks.Name = "Tasks";
            this.Tasks.Size = new System.Drawing.Size(223, 24);
            this.Tasks.TabIndex = 62;
            this.Tasks.SelectedIndexChanged += new System.EventHandler(this.Tasks_SelectedIndexChanged);
            // 
            // ViewProject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Tasks);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.ViewTask);
            this.Controls.Add(this.ViewTaskHistory);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Employees);
            this.Controls.Add(this.name);
            this.Controls.Add(this.Description);
            this.Controls.Add(this.ProjectID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Name = "ViewProject";
            this.Size = new System.Drawing.Size(768, 522);
            this.Load += new System.EventHandler(this.ViewProject_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox Description;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.ComboBox ProjectID;
        private System.Windows.Forms.ListBox Employees;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button ViewTaskHistory;
        private System.Windows.Forms.Button ViewTask;
        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.ComboBox Tasks;
    }
}
