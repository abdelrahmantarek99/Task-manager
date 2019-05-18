namespace TaskManager
{
    partial class RemoveEmployee
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
            this.Back = new System.Windows.Forms.Button();
            this.UserID = new System.Windows.Forms.ComboBox();
            this.ProjectID = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.IDlabel = new System.Windows.Forms.Label();
            this.Remove = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Back
            // 
            this.Back.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Back.ForeColor = System.Drawing.Color.Green;
            this.Back.Location = new System.Drawing.Point(10, 164);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(100, 34);
            this.Back.TabIndex = 52;
            this.Back.Text = "Back";
            this.Back.UseVisualStyleBackColor = true;
            this.Back.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // UserID
            // 
            this.UserID.FormattingEnabled = true;
            this.UserID.Location = new System.Drawing.Point(175, 90);
            this.UserID.Name = "UserID";
            this.UserID.Size = new System.Drawing.Size(234, 24);
            this.UserID.TabIndex = 51;
            this.UserID.SelectedIndexChanged += new System.EventHandler(this.UserID_SelectedIndexChanged);
            this.UserID.TextUpdate += new System.EventHandler(this.UserID_TextUpdate);
            // 
            // ProjectID
            // 
            this.ProjectID.FormattingEnabled = true;
            this.ProjectID.Location = new System.Drawing.Point(175, 34);
            this.ProjectID.Name = "ProjectID";
            this.ProjectID.Size = new System.Drawing.Size(234, 24);
            this.ProjectID.TabIndex = 50;
            this.ProjectID.SelectedIndexChanged += new System.EventHandler(this.ProjectID_SelectedIndexChanged);
            this.ProjectID.TextUpdate += new System.EventHandler(this.ProjectID_TextUpdate);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label3.Location = new System.Drawing.Point(7, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 28);
            this.label3.TabIndex = 49;
            this.label3.Text = "User ID";
            // 
            // IDlabel
            // 
            this.IDlabel.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IDlabel.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.IDlabel.Location = new System.Drawing.Point(7, 34);
            this.IDlabel.Name = "IDlabel";
            this.IDlabel.Size = new System.Drawing.Size(147, 28);
            this.IDlabel.TabIndex = 48;
            this.IDlabel.Text = "Project ID";
            // 
            // Remove
            // 
            this.Remove.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Remove.ForeColor = System.Drawing.Color.Green;
            this.Remove.Location = new System.Drawing.Point(309, 164);
            this.Remove.Name = "Remove";
            this.Remove.Size = new System.Drawing.Size(100, 34);
            this.Remove.TabIndex = 47;
            this.Remove.Text = "Remove";
            this.Remove.UseVisualStyleBackColor = true;
            this.Remove.Click += new System.EventHandler(this.Remove_Click);
            // 
            // RemoveEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Back);
            this.Controls.Add(this.UserID);
            this.Controls.Add(this.ProjectID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.IDlabel);
            this.Controls.Add(this.Remove);
            this.Name = "RemoveEmployee";
            this.Size = new System.Drawing.Size(429, 221);
            this.Load += new System.EventHandler(this.RemoveEmployee_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.ComboBox UserID;
        private System.Windows.Forms.ComboBox ProjectID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label IDlabel;
        private System.Windows.Forms.Button Remove;
    }
}
