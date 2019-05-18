namespace TaskManager
{
    partial class ViewTaskForm
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
            this.viewTask1 = new TaskManager.ViewTask();
            this.SuspendLayout();
            // 
            // viewTask1
            // 
            this.viewTask1.Location = new System.Drawing.Point(32, 21);
            this.viewTask1.Name = "viewTask1";
            this.viewTask1.Size = new System.Drawing.Size(1093, 745);
            this.viewTask1.TabIndex = 0;
            // 
            // VewTaskForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1187, 774);
            this.Controls.Add(this.viewTask1);
            this.Name = "VewTaskForm";
            this.Text = "VewTaskForm";
            this.Load += new System.EventHandler(this.VewTaskForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private ViewTask viewTask1;
    }
}