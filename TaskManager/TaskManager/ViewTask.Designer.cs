namespace TaskManager
{
    partial class ViewTask
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.name = new System.Windows.Forms.Label();
            this.Description = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TaskID = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.UserID = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.FileContent = new System.Windows.Forms.RichTextBox();
            this.Files = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Lastcomment = new System.Windows.Forms.RichTextBox();
            this.Back = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // name
            // 
            this.name.BackColor = System.Drawing.SystemColors.Control;
            this.name.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name.ForeColor = System.Drawing.Color.Green;
            this.name.Location = new System.Drawing.Point(225, 76);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(267, 28);
            this.name.TabIndex = 60;
            // 
            // Description
            // 
            this.Description.Enabled = false;
            this.Description.Location = new System.Drawing.Point(230, 193);
            this.Description.Name = "Description";
            this.Description.Size = new System.Drawing.Size(325, 162);
            this.Description.TabIndex = 59;
            this.Description.Text = "";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label3.Location = new System.Drawing.Point(30, 193);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(168, 28);
            this.label3.TabIndex = 56;
            this.label3.Text = "Description";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label4.Location = new System.Drawing.Point(30, 76);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 28);
            this.label4.TabIndex = 55;
            this.label4.Text = "Name";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label2.Location = new System.Drawing.Point(30, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 28);
            this.label2.TabIndex = 61;
            this.label2.Text = "Task ID";
            // 
            // TaskID
            // 
            this.TaskID.BackColor = System.Drawing.SystemColors.Control;
            this.TaskID.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TaskID.ForeColor = System.Drawing.Color.Green;
            this.TaskID.Location = new System.Drawing.Point(230, 30);
            this.TaskID.Name = "TaskID";
            this.TaskID.Size = new System.Drawing.Size(267, 28);
            this.TaskID.TabIndex = 62;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label1.Location = new System.Drawing.Point(30, 121);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 28);
            this.label1.TabIndex = 63;
            this.label1.Text = "User ID";
            // 
            // UserID
            // 
            this.UserID.BackColor = System.Drawing.SystemColors.Control;
            this.UserID.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserID.ForeColor = System.Drawing.Color.Green;
            this.UserID.Location = new System.Drawing.Point(230, 121);
            this.UserID.Name = "UserID";
            this.UserID.Size = new System.Drawing.Size(267, 28);
            this.UserID.TabIndex = 64;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label5.Location = new System.Drawing.Point(11, 383);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(186, 28);
            this.label5.TabIndex = 65;
            this.label5.Text = "Attached Files";
            // 
            // FileContent
            // 
            this.FileContent.Enabled = false;
            this.FileContent.Location = new System.Drawing.Point(234, 449);
            this.FileContent.Name = "FileContent";
            this.FileContent.Size = new System.Drawing.Size(836, 233);
            this.FileContent.TabIndex = 66;
            this.FileContent.Text = "";
            // 
            // Files
            // 
            this.Files.FormattingEnabled = true;
            this.Files.Location = new System.Drawing.Point(234, 387);
            this.Files.Name = "Files";
            this.Files.Size = new System.Drawing.Size(267, 24);
            this.Files.TabIndex = 67;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label6.Location = new System.Drawing.Point(593, 193);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(190, 28);
            this.label6.TabIndex = 68;
            this.label6.Text = "Last Comment";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // Lastcomment
            // 
            this.Lastcomment.Enabled = false;
            this.Lastcomment.Location = new System.Drawing.Point(790, 193);
            this.Lastcomment.Name = "Lastcomment";
            this.Lastcomment.Size = new System.Drawing.Size(281, 82);
            this.Lastcomment.TabIndex = 69;
            this.Lastcomment.Text = "";
            // 
            // Back
            // 
            this.Back.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Back.ForeColor = System.Drawing.Color.Green;
            this.Back.Location = new System.Drawing.Point(957, 697);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(114, 34);
            this.Back.TabIndex = 70;
            this.Back.Text = "Back";
            this.Back.UseVisualStyleBackColor = true;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // ViewTask
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Back);
            this.Controls.Add(this.Lastcomment);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Files);
            this.Controls.Add(this.FileContent);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.UserID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TaskID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.name);
            this.Controls.Add(this.Description);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Name = "ViewTask";
            this.Size = new System.Drawing.Size(1093, 745);
            this.Load += new System.EventHandler(this.ViewTask_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label name;
        private System.Windows.Forms.RichTextBox Description;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label TaskID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label UserID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RichTextBox FileContent;
        private System.Windows.Forms.ComboBox Files;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RichTextBox Lastcomment;
        private System.Windows.Forms.Button Back;
    }
}
