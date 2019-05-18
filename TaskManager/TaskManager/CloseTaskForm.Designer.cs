namespace TaskManager
{
    partial class CloseTaskForm
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
            this.closeTask1 = new TaskManager.CloseTask();
            this.SuspendLayout();
            // 
            // closeTask1
            // 
            this.closeTask1.Location = new System.Drawing.Point(120, 90);
            this.closeTask1.Name = "closeTask1";
            this.closeTask1.Size = new System.Drawing.Size(506, 232);
            this.closeTask1.TabIndex = 0;
            // 
            // CloseTaskForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.closeTask1);
            this.Name = "CloseTaskForm";
            this.Text = "CloseTaskForm";
            this.Load += new System.EventHandler(this.CloseTaskForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CloseTask closeTask1;
    }
}