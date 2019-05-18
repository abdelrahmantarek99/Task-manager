namespace TaskManager
{
    partial class CreateTaskForm
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
            this.createTask1 = new TaskManager.CreateTask();
            this.SuspendLayout();
            // 
            // createTask1
            // 
            this.createTask1.Location = new System.Drawing.Point(87, 21);
            this.createTask1.Name = "createTask1";
            this.createTask1.Size = new System.Drawing.Size(507, 427);
            this.createTask1.TabIndex = 0;
            // 
            // CreateTaskForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.createTask1);
            this.Name = "CreateTaskForm";
            this.Text = "CreateTaskForm";
            this.Load += new System.EventHandler(this.CreateTaskForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CreateTask createTask1;
    }
}