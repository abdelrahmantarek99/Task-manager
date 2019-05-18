namespace TaskManager
{
    partial class AdminActionForm
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
            this.adminAction1 = new TaskManager.AdminAction();
            this.SuspendLayout();
            // 
            // adminAction1
            // 
            this.adminAction1.Location = new System.Drawing.Point(2, 0);
            this.adminAction1.Name = "adminAction1";
            this.adminAction1.Size = new System.Drawing.Size(533, 578);
            this.adminAction1.TabIndex = 0;
            this.adminAction1.Load += new System.EventHandler(this.adminAction1_Load);
            // 
            // AdminActionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(540, 580);
            this.Controls.Add(this.adminAction1);
            this.Name = "AdminActionForm";
            this.Text = "AdminActionForm";
            this.Load += new System.EventHandler(this.AdminActionForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private AdminAction adminAction1;
    }
}