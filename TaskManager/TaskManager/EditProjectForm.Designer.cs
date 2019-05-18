namespace TaskManager
{
    partial class EditProjectForm
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
            this.editProject1 = new TaskManager.EditProject();
            this.SuspendLayout();
            // 
            // editProject1
            // 
            this.editProject1.Location = new System.Drawing.Point(109, 35);
            this.editProject1.Name = "editProject1";
            this.editProject1.Size = new System.Drawing.Size(518, 317);
            this.editProject1.TabIndex = 0;
            // 
            // EditProjectForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.editProject1);
            this.Name = "EditProjectForm";
            this.Text = "EditProjectForm";
            this.Load += new System.EventHandler(this.EditProjectForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private EditProject editProject1;
    }
}