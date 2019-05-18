namespace TaskManager
{
    partial class CloseTask
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
            this.UserID = new System.Windows.Forms.ComboBox();
            this.ProjectID = new System.Windows.Forms.ComboBox();
            this.ProjectIDlbl = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Close = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.TaskID = new System.Windows.Forms.ComboBox();
            this.Back = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // UserID
            // 
            this.UserID.FormattingEnabled = true;
            this.UserID.Location = new System.Drawing.Point(221, 75);
            this.UserID.Name = "UserID";
            this.UserID.Size = new System.Drawing.Size(267, 24);
            this.UserID.TabIndex = 37;
            this.UserID.SelectedIndexChanged += new System.EventHandler(this.UserID_SelectedIndexChanged);
            // 
            // ProjectID
            // 
            this.ProjectID.FormattingEnabled = true;
            this.ProjectID.Location = new System.Drawing.Point(221, 19);
            this.ProjectID.Name = "ProjectID";
            this.ProjectID.Size = new System.Drawing.Size(267, 24);
            this.ProjectID.TabIndex = 36;
            this.ProjectID.SelectedIndexChanged += new System.EventHandler(this.ProjectID_SelectedIndexChanged);
            // 
            // ProjectIDlbl
            // 
            this.ProjectIDlbl.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProjectIDlbl.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.ProjectIDlbl.Location = new System.Drawing.Point(47, 15);
            this.ProjectIDlbl.Name = "ProjectIDlbl";
            this.ProjectIDlbl.Size = new System.Drawing.Size(150, 28);
            this.ProjectIDlbl.TabIndex = 35;
            this.ProjectIDlbl.Text = "Project";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label4.Location = new System.Drawing.Point(47, 71);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(168, 28);
            this.label4.TabIndex = 34;
            this.label4.Text = "User";
            // 
            // Close
            // 
            this.Close.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Close.ForeColor = System.Drawing.Color.Green;
            this.Close.Location = new System.Drawing.Point(374, 177);
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(114, 34);
            this.Close.TabIndex = 33;
            this.Close.Text = "Close";
            this.Close.UseVisualStyleBackColor = true;
            this.Close.Click += new System.EventHandler(this.Close_Click);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label2.Location = new System.Drawing.Point(47, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 28);
            this.label2.TabIndex = 43;
            this.label2.Text = "Task";
            // 
            // TaskID
            // 
            this.TaskID.FormattingEnabled = true;
            this.TaskID.Location = new System.Drawing.Point(221, 126);
            this.TaskID.Name = "TaskID";
            this.TaskID.Size = new System.Drawing.Size(267, 24);
            this.TaskID.TabIndex = 44;
            // 
            // Back
            // 
            this.Back.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Back.ForeColor = System.Drawing.Color.Green;
            this.Back.Location = new System.Drawing.Point(221, 177);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(114, 34);
            this.Back.TabIndex = 45;
            this.Back.Text = "Back";
            this.Back.UseVisualStyleBackColor = true;
            this.Back.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // CloseTask
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Back);
            this.Controls.Add(this.TaskID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.UserID);
            this.Controls.Add(this.ProjectID);
            this.Controls.Add(this.ProjectIDlbl);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Close);
            this.Name = "CloseTask";
            this.Size = new System.Drawing.Size(506, 232);
            this.Load += new System.EventHandler(this.CloseTask_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox UserID;
        private System.Windows.Forms.ComboBox ProjectID;
        private System.Windows.Forms.Label ProjectIDlbl;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button Close;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox TaskID;
        private System.Windows.Forms.Button Back;
    }
}
