namespace TaskManager
{
    partial class AddEmployee
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
            this.Add = new System.Windows.Forms.Button();
            this.IDlabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ProjectID = new System.Windows.Forms.ComboBox();
            this.UserID = new System.Windows.Forms.ComboBox();
            this.Back = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Add
            // 
            this.Add.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Add.ForeColor = System.Drawing.Color.Green;
            this.Add.Location = new System.Drawing.Point(322, 151);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(100, 34);
            this.Add.TabIndex = 20;
            this.Add.Text = "Add";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // IDlabel
            // 
            this.IDlabel.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IDlabel.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.IDlabel.Location = new System.Drawing.Point(20, 21);
            this.IDlabel.Name = "IDlabel";
            this.IDlabel.Size = new System.Drawing.Size(147, 28);
            this.IDlabel.TabIndex = 21;
            this.IDlabel.Text = "Project ID";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label3.Location = new System.Drawing.Point(20, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 28);
            this.label3.TabIndex = 22;
            this.label3.Text = "User ID";
            // 
            // ProjectID
            // 
            this.ProjectID.FormattingEnabled = true;
            this.ProjectID.Location = new System.Drawing.Point(188, 21);
            this.ProjectID.Name = "ProjectID";
            this.ProjectID.Size = new System.Drawing.Size(234, 24);
            this.ProjectID.TabIndex = 33;
            this.ProjectID.SelectedIndexChanged += new System.EventHandler(this.ProjectID_SelectedIndexChanged);
            this.ProjectID.TextUpdate += new System.EventHandler(this.ProjectID_TextUpdate);
            // 
            // UserID
            // 
            this.UserID.Enabled = false;
            this.UserID.FormattingEnabled = true;
            this.UserID.Location = new System.Drawing.Point(188, 77);
            this.UserID.Name = "UserID";
            this.UserID.Size = new System.Drawing.Size(234, 24);
            this.UserID.TabIndex = 34;
            this.UserID.TextUpdate += new System.EventHandler(this.UserID_TextUpdate);
            // 
            // Back
            // 
            this.Back.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Back.ForeColor = System.Drawing.Color.Green;
            this.Back.Location = new System.Drawing.Point(24, 151);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(100, 34);
            this.Back.TabIndex = 46;
            this.Back.Text = "Back";
            this.Back.UseVisualStyleBackColor = true;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // AddEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Back);
            this.Controls.Add(this.UserID);
            this.Controls.Add(this.ProjectID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.IDlabel);
            this.Controls.Add(this.Add);
            this.Name = "AddEmployee";
            this.Size = new System.Drawing.Size(437, 201);
            this.Load += new System.EventHandler(this.AddEmployee_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.Label IDlabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox ProjectID;
        private System.Windows.Forms.ComboBox UserID;
        private System.Windows.Forms.Button Back;
    }
}
