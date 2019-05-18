namespace TaskManager
{
    partial class RemoveEmployeeForm
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
            this.removeEmployee1 = new TaskManager.RemoveEmployee();
            this.SuspendLayout();
            // 
            // removeEmployee1
            // 
            this.removeEmployee1.Location = new System.Drawing.Point(12, 12);
            this.removeEmployee1.Name = "removeEmployee1";
            this.removeEmployee1.Size = new System.Drawing.Size(422, 211);
            this.removeEmployee1.TabIndex = 0;
            // 
            // RemoveEmployeeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(443, 233);
            this.Controls.Add(this.removeEmployee1);
            this.Name = "RemoveEmployeeForm";
            this.Text = "RemoveEmployeeForm";
            this.Load += new System.EventHandler(this.RemoveEmployeeForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private RemoveEmployee removeEmployee1;
    }
}