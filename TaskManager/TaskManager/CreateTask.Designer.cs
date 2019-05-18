namespace TaskManager
{
    partial class CreateTask
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
            this.label3 = new System.Windows.Forms.Label();
            this.Create = new System.Windows.Forms.Button();
            this.name = new System.Windows.Forms.TextBox();
            this.ProjectIDlbl = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ProjectID = new System.Windows.Forms.ComboBox();
            this.UserID = new System.Windows.Forms.ComboBox();
            this.Description = new System.Windows.Forms.RichTextBox();
            this.Back = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label2.Location = new System.Drawing.Point(25, 246);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(168, 28);
            this.label2.TabIndex = 24;
            this.label2.Text = "Description";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label3.Location = new System.Drawing.Point(25, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 28);
            this.label3.TabIndex = 22;
            this.label3.Text = "Name";
            // 
            // Create
            // 
            this.Create.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Create.ForeColor = System.Drawing.Color.Green;
            this.Create.Location = new System.Drawing.Point(374, 380);
            this.Create.Name = "Create";
            this.Create.Size = new System.Drawing.Size(114, 34);
            this.Create.TabIndex = 20;
            this.Create.Text = "Create";
            this.Create.UseVisualStyleBackColor = true;
            this.Create.Click += new System.EventHandler(this.Create_Click);
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(221, 139);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(267, 22);
            this.name.TabIndex = 19;
            // 
            // ProjectIDlbl
            // 
            this.ProjectIDlbl.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProjectIDlbl.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.ProjectIDlbl.Location = new System.Drawing.Point(25, 24);
            this.ProjectIDlbl.Name = "ProjectIDlbl";
            this.ProjectIDlbl.Size = new System.Drawing.Size(150, 28);
            this.ProjectIDlbl.TabIndex = 29;
            this.ProjectIDlbl.Text = "Project ID";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label4.Location = new System.Drawing.Point(25, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(168, 28);
            this.label4.TabIndex = 28;
            this.label4.Text = "User ID";
            // 
            // ProjectID
            // 
            this.ProjectID.FormattingEnabled = true;
            this.ProjectID.Location = new System.Drawing.Point(221, 28);
            this.ProjectID.Name = "ProjectID";
            this.ProjectID.Size = new System.Drawing.Size(267, 24);
            this.ProjectID.TabIndex = 31;
            this.ProjectID.SelectedIndexChanged += new System.EventHandler(this.ProjectID_SelectedIndexChanged);
            // 
            // UserID
            // 
            this.UserID.FormattingEnabled = true;
            this.UserID.Location = new System.Drawing.Point(221, 84);
            this.UserID.Name = "UserID";
            this.UserID.Size = new System.Drawing.Size(267, 24);
            this.UserID.TabIndex = 32;
            this.UserID.SelectedIndexChanged += new System.EventHandler(this.UserID_SelectedIndexChanged);
            // 
            // Description
            // 
            this.Description.Location = new System.Drawing.Point(221, 186);
            this.Description.Name = "Description";
            this.Description.Size = new System.Drawing.Size(267, 162);
            this.Description.TabIndex = 48;
            this.Description.Text = "";
            // 
            // Back
            // 
            this.Back.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Back.ForeColor = System.Drawing.Color.Green;
            this.Back.Location = new System.Drawing.Point(221, 380);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(146, 34);
            this.Back.TabIndex = 49;
            this.Back.Text = "Back";
            this.Back.UseVisualStyleBackColor = true;
            this.Back.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // CreateTask
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Back);
            this.Controls.Add(this.Description);
            this.Controls.Add(this.UserID);
            this.Controls.Add(this.ProjectID);
            this.Controls.Add(this.ProjectIDlbl);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Create);
            this.Controls.Add(this.name);
            this.Name = "CreateTask";
            this.Size = new System.Drawing.Size(507, 427);
            this.Load += new System.EventHandler(this.CreateTask_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Create;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.Label ProjectIDlbl;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox ProjectID;
        private System.Windows.Forms.ComboBox UserID;
        private System.Windows.Forms.RichTextBox Description;
        private System.Windows.Forms.Button Back;
    }
}
