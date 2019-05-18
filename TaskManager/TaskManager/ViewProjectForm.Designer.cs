namespace TaskManager
{
    partial class ViewProjectForm
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
            this.viewProject1 = new TaskManager.ViewProject();
            this.SuspendLayout();
            // 
            // viewProject1
            // 
            this.viewProject1.Location = new System.Drawing.Point(1, 0);
            this.viewProject1.Name = "viewProject1";
            this.viewProject1.Size = new System.Drawing.Size(768, 522);
            this.viewProject1.TabIndex = 0;
            this.viewProject1.Load += new System.EventHandler(this.viewProject1_Load);
            // 
            // ViewProjectForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(787, 529);
            this.Controls.Add(this.viewProject1);
            this.Name = "ViewProjectForm";
            this.Text = "ViewProjectForm";
            this.Load += new System.EventHandler(this.ViewProjectForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private ViewProject viewProject1;
    }
}