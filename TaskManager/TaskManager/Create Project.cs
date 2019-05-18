using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TaskManager
{
    public partial class Create_Project : UserControl
    {
        AdminActionForm adminActionForm;
        CreateProjectForm CreateProjectForm;
        public Create_Project()
        {
            InitializeComponent();
        }

        public void initialize(AdminActionForm adminActionForm, CreateProjectForm createProjectForm)
        {
            this.CreateProjectForm = createProjectForm;
            this.adminActionForm = adminActionForm;
        }

        private void Create_Project_Load(object sender, EventArgs e)
        {

        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            adminActionForm.Show();
            CreateProjectForm.Dispose();
        }

        private void Create_Click(object sender, EventArgs e)
        {
            Project p = new Project();
            p.name = name.Text;
            p.description = Description.Text;
            p.status = "opened";
            Project.readProjects();
            p.id = Project.projects.Count + 1;
            Project.projects.Add(p);
            Project.writeProjects();
            MessageBox.Show("Project " + name.Text + " Has Been Added");
            name.Text = "";
            Description.Text = "";
        }
    }
}
//