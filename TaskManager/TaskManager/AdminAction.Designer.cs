namespace TaskManager
{
    partial class AdminAction
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
            this.CreateProject = new System.Windows.Forms.Button();
            this.EditProject = new System.Windows.Forms.Button();
            this.CloseProject = new System.Windows.Forms.Button();
            this.Projects = new System.Windows.Forms.GroupBox();
            this.ViewProject = new System.Windows.Forms.Button();
            this.Employees = new System.Windows.Forms.GroupBox();
            this.RemoveEmployee = new System.Windows.Forms.Button();
            this.EditEmployee = new System.Windows.Forms.Button();
            this.CreateEmployee = new System.Windows.Forms.Button();
            this.Tasks = new System.Windows.Forms.GroupBox();
            this.CloseTask = new System.Windows.Forms.Button();
            this.EditTask = new System.Windows.Forms.Button();
            this.CreateTask = new System.Windows.Forms.Button();
            this.Logout = new System.Windows.Forms.Button();
            this.AddEmployee = new System.Windows.Forms.Button();
            this.Projects.SuspendLayout();
            this.Employees.SuspendLayout();
            this.Tasks.SuspendLayout();
            this.SuspendLayout();
            // 
            // CreateProject
            // 
            this.CreateProject.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreateProject.ForeColor = System.Drawing.Color.Green;
            this.CreateProject.Location = new System.Drawing.Point(18, 45);
            this.CreateProject.Name = "CreateProject";
            this.CreateProject.Size = new System.Drawing.Size(182, 34);
            this.CreateProject.TabIndex = 74;
            this.CreateProject.Text = "Create Project";
            this.CreateProject.UseVisualStyleBackColor = true;
            this.CreateProject.Click += new System.EventHandler(this.CreateProject_Click);
            // 
            // EditProject
            // 
            this.EditProject.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditProject.ForeColor = System.Drawing.Color.Green;
            this.EditProject.Location = new System.Drawing.Point(225, 45);
            this.EditProject.Name = "EditProject";
            this.EditProject.Size = new System.Drawing.Size(182, 34);
            this.EditProject.TabIndex = 77;
            this.EditProject.Text = "Edit Project";
            this.EditProject.UseVisualStyleBackColor = true;
            this.EditProject.Click += new System.EventHandler(this.EditProject_Click);
            // 
            // CloseProject
            // 
            this.CloseProject.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CloseProject.ForeColor = System.Drawing.Color.Green;
            this.CloseProject.Location = new System.Drawing.Point(18, 96);
            this.CloseProject.Name = "CloseProject";
            this.CloseProject.Size = new System.Drawing.Size(182, 34);
            this.CloseProject.TabIndex = 78;
            this.CloseProject.Text = "Close Project";
            this.CloseProject.UseVisualStyleBackColor = true;
            this.CloseProject.Click += new System.EventHandler(this.CloseProject_Click);
            // 
            // Projects
            // 
            this.Projects.Controls.Add(this.ViewProject);
            this.Projects.Controls.Add(this.CloseProject);
            this.Projects.Controls.Add(this.EditProject);
            this.Projects.Controls.Add(this.CreateProject);
            this.Projects.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Projects.ForeColor = System.Drawing.Color.Purple;
            this.Projects.Location = new System.Drawing.Point(19, 16);
            this.Projects.Name = "Projects";
            this.Projects.Size = new System.Drawing.Size(431, 163);
            this.Projects.TabIndex = 80;
            this.Projects.TabStop = false;
            this.Projects.Text = "Projects";
            // 
            // ViewProject
            // 
            this.ViewProject.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ViewProject.ForeColor = System.Drawing.Color.Green;
            this.ViewProject.Location = new System.Drawing.Point(225, 96);
            this.ViewProject.Name = "ViewProject";
            this.ViewProject.Size = new System.Drawing.Size(182, 34);
            this.ViewProject.TabIndex = 79;
            this.ViewProject.Text = "View Project";
            this.ViewProject.UseVisualStyleBackColor = true;
            this.ViewProject.Click += new System.EventHandler(this.ViewProject_Click);
            // 
            // Employees
            // 
            this.Employees.Controls.Add(this.AddEmployee);
            this.Employees.Controls.Add(this.RemoveEmployee);
            this.Employees.Controls.Add(this.EditEmployee);
            this.Employees.Controls.Add(this.CreateEmployee);
            this.Employees.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Employees.ForeColor = System.Drawing.Color.Purple;
            this.Employees.Location = new System.Drawing.Point(19, 200);
            this.Employees.Name = "Employees";
            this.Employees.Size = new System.Drawing.Size(431, 135);
            this.Employees.TabIndex = 81;
            this.Employees.TabStop = false;
            this.Employees.Text = "Employees";
            // 
            // RemoveEmployee
            // 
            this.RemoveEmployee.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RemoveEmployee.ForeColor = System.Drawing.Color.Green;
            this.RemoveEmployee.Location = new System.Drawing.Point(225, 95);
            this.RemoveEmployee.Name = "RemoveEmployee";
            this.RemoveEmployee.Size = new System.Drawing.Size(182, 34);
            this.RemoveEmployee.TabIndex = 78;
            this.RemoveEmployee.Text = "Remove Employee";
            this.RemoveEmployee.UseVisualStyleBackColor = true;
            this.RemoveEmployee.Click += new System.EventHandler(this.RemoveEmployee_Click);
            // 
            // EditEmployee
            // 
            this.EditEmployee.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditEmployee.ForeColor = System.Drawing.Color.Green;
            this.EditEmployee.Location = new System.Drawing.Point(225, 45);
            this.EditEmployee.Name = "EditEmployee";
            this.EditEmployee.Size = new System.Drawing.Size(182, 34);
            this.EditEmployee.TabIndex = 77;
            this.EditEmployee.Text = "Edit Employee";
            this.EditEmployee.UseVisualStyleBackColor = true;
            this.EditEmployee.Click += new System.EventHandler(this.EditEmployee_Click);
            // 
            // CreateEmployee
            // 
            this.CreateEmployee.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreateEmployee.ForeColor = System.Drawing.Color.Green;
            this.CreateEmployee.Location = new System.Drawing.Point(18, 45);
            this.CreateEmployee.Name = "CreateEmployee";
            this.CreateEmployee.Size = new System.Drawing.Size(192, 34);
            this.CreateEmployee.TabIndex = 74;
            this.CreateEmployee.Text = "Create Employee";
            this.CreateEmployee.UseVisualStyleBackColor = true;
            this.CreateEmployee.Click += new System.EventHandler(this.CreateEmployee_Click);
            // 
            // Tasks
            // 
            this.Tasks.Controls.Add(this.CloseTask);
            this.Tasks.Controls.Add(this.EditTask);
            this.Tasks.Controls.Add(this.CreateTask);
            this.Tasks.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tasks.ForeColor = System.Drawing.Color.Purple;
            this.Tasks.Location = new System.Drawing.Point(19, 367);
            this.Tasks.Name = "Tasks";
            this.Tasks.Size = new System.Drawing.Size(431, 163);
            this.Tasks.TabIndex = 81;
            this.Tasks.TabStop = false;
            this.Tasks.Text = "Tasks";
            // 
            // CloseTask
            // 
            this.CloseTask.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CloseTask.ForeColor = System.Drawing.Color.Green;
            this.CloseTask.Location = new System.Drawing.Point(18, 96);
            this.CloseTask.Name = "CloseTask";
            this.CloseTask.Size = new System.Drawing.Size(182, 34);
            this.CloseTask.TabIndex = 78;
            this.CloseTask.Text = "Close Task";
            this.CloseTask.UseVisualStyleBackColor = true;
            this.CloseTask.Click += new System.EventHandler(this.CloseTask_Click);
            // 
            // EditTask
            // 
            this.EditTask.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditTask.ForeColor = System.Drawing.Color.Green;
            this.EditTask.Location = new System.Drawing.Point(225, 45);
            this.EditTask.Name = "EditTask";
            this.EditTask.Size = new System.Drawing.Size(182, 34);
            this.EditTask.TabIndex = 77;
            this.EditTask.Text = "Edit Task";
            this.EditTask.UseVisualStyleBackColor = true;
            this.EditTask.Click += new System.EventHandler(this.EditTask_Click);
            // 
            // CreateTask
            // 
            this.CreateTask.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreateTask.ForeColor = System.Drawing.Color.Green;
            this.CreateTask.Location = new System.Drawing.Point(18, 45);
            this.CreateTask.Name = "CreateTask";
            this.CreateTask.Size = new System.Drawing.Size(182, 34);
            this.CreateTask.TabIndex = 74;
            this.CreateTask.Text = "Create Task";
            this.CreateTask.UseVisualStyleBackColor = true;
            this.CreateTask.Click += new System.EventHandler(this.CreateTask_Click);
            // 
            // Logout
            // 
            this.Logout.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Logout.ForeColor = System.Drawing.Color.Green;
            this.Logout.Location = new System.Drawing.Point(338, 536);
            this.Logout.Name = "Logout";
            this.Logout.Size = new System.Drawing.Size(113, 34);
            this.Logout.TabIndex = 82;
            this.Logout.Text = "Logout";
            this.Logout.UseVisualStyleBackColor = true;
            this.Logout.Click += new System.EventHandler(this.Logout_Click);
            // 
            // AddEmployee
            // 
            this.AddEmployee.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddEmployee.ForeColor = System.Drawing.Color.Green;
            this.AddEmployee.Location = new System.Drawing.Point(18, 95);
            this.AddEmployee.Name = "AddEmployee";
            this.AddEmployee.Size = new System.Drawing.Size(192, 34);
            this.AddEmployee.TabIndex = 79;
            this.AddEmployee.Text = "Add Employee";
            this.AddEmployee.UseVisualStyleBackColor = true;
            this.AddEmployee.Click += new System.EventHandler(this.AddEmployee_Click);
            // 
            // AdminAction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Logout);
            this.Controls.Add(this.Tasks);
            this.Controls.Add(this.Employees);
            this.Controls.Add(this.Projects);
            this.Name = "AdminAction";
            this.Size = new System.Drawing.Size(460, 577);
            this.Projects.ResumeLayout(false);
            this.Employees.ResumeLayout(false);
            this.Tasks.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button CreateProject;
        private System.Windows.Forms.Button EditProject;
        private System.Windows.Forms.Button CloseProject;
        private System.Windows.Forms.GroupBox Projects;
        private System.Windows.Forms.GroupBox Employees;
        private System.Windows.Forms.Button EditEmployee;
        private System.Windows.Forms.Button CreateEmployee;
        private System.Windows.Forms.GroupBox Tasks;
        private System.Windows.Forms.Button CloseTask;
        private System.Windows.Forms.Button EditTask;
        private System.Windows.Forms.Button CreateTask;
        private System.Windows.Forms.Button Logout;
        private System.Windows.Forms.Button ViewProject;
        private System.Windows.Forms.Button RemoveEmployee;
        private System.Windows.Forms.Button AddEmployee;
    }
}
