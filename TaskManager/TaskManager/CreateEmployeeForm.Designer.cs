namespace TaskManager
{
    partial class CreateEmployeeForm
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
            this.create_Employee1 = new TaskManager.Create_Employee();
            this.SuspendLayout();
            // 
            // create_Employee1
            // 
            this.create_Employee1.Location = new System.Drawing.Point(127, 57);
            this.create_Employee1.Name = "create_Employee1";
            this.create_Employee1.Size = new System.Drawing.Size(513, 218);
            this.create_Employee1.TabIndex = 0;
            // 
            // CreateEmployeeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.create_Employee1);
            this.Name = "CreateEmployeeForm";
            this.Text = "CreateEmployeeForm";
            this.ResumeLayout(false);

        }

        #endregion

        private Create_Employee create_Employee1;
    }
}