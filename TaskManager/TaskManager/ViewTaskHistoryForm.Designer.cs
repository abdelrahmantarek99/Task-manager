namespace TaskManager
{
    partial class ViewTaskHistoryForm
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
            this.viewTaskHistory1 = new TaskManager.ViewTaskHistory();
            this.SuspendLayout();
            // 
            // viewTaskHistory1
            // 
            this.viewTaskHistory1.Location = new System.Drawing.Point(0, 2);
            this.viewTaskHistory1.Name = "viewTaskHistory1";
            this.viewTaskHistory1.Size = new System.Drawing.Size(1143, 420);
            this.viewTaskHistory1.TabIndex = 0;
            this.viewTaskHistory1.Load += new System.EventHandler(this.viewTaskHistory1_Load);
            // 
            // ViewTaskHistoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1148, 427);
            this.Controls.Add(this.viewTaskHistory1);
            this.Name = "ViewTaskHistoryForm";
            this.Text = "ViewTaskHistoryForm";
            this.Load += new System.EventHandler(this.ViewTaskHistoryForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private ViewTaskHistory viewTaskHistory1;
    }
}