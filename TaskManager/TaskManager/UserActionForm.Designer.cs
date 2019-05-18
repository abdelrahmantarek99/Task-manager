namespace TaskManager
{
    partial class UserActionForm
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
            this.userAction1 = new TaskManager.UserAction();
            this.SuspendLayout();
            // 
            // userAction1
            // 
            this.userAction1.Location = new System.Drawing.Point(-3, 3);
            this.userAction1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.userAction1.Name = "userAction1";
            this.userAction1.Size = new System.Drawing.Size(880, 649);
            this.userAction1.TabIndex = 0;
            this.userAction1.Load += new System.EventHandler(this.userAction1_Load);
            // 
            // UserActionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(915, 647);
            this.Controls.Add(this.userAction1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "UserActionForm";
            this.Text = "UserActionsFormcs";
            this.Load += new System.EventHandler(this.UserActionsFormcs_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private UserAction userAction1;
    }
}