namespace TaskManager
{
    partial class CreateProjectForm
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
            this.create_Project1 = new TaskManager.Create_Project();
            this.SuspendLayout();
            // 
            // create_Project1
            // 
            this.create_Project1.Location = new System.Drawing.Point(110, 61);
            this.create_Project1.Name = "create_Project1";
            this.create_Project1.Size = new System.Drawing.Size(515, 303);
            this.create_Project1.TabIndex = 0;
            // 
            // CreateProjectForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.create_Project1);
            this.Name = "CreateProjectForm";
            this.Text = "CreateProjectForm";
            this.Load += new System.EventHandler(this.CreateProjectForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Create_Project create_Project1;
    }
}