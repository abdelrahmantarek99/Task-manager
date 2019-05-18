using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace TaskManager
{
    public partial class EditProject : UserControl
    {
        string selectedid;
        private AdminActionForm adminActionForm;
        private EditProjectForm editProjectForm;

        public EditProject()
        {
            InitializeComponent();
        }

        public void initialize(AdminActionForm adminActionForm, EditProjectForm editProjectForm)
        {
            this.adminActionForm = adminActionForm;
            this.editProjectForm = editProjectForm;
        }

        private void loadprojects()
        {
            /// load projects 
            List<Project> list = new List<Project>();
            Project.readProjects();
            list = Project.projects;
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i].status == "opened")
                    ProjectID.Items.Add(list[i].id);
            }

        }

        private void getDescribtion()
        {
            List<Project> list = new List<Project>();
            Project.readProjects();
            list = Project.projects;
            for (int i = 0; i < list.Count; i++)
            {
                if (selectedid == list[i].id.ToString())
                {
                    Description.Text = list[i].description;
                    break;
                }
            }
        }

        private void EditProject_Load(object sender, EventArgs e)
        {
            loadprojects();
        }

        private void ProjectID_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedid = ProjectID.SelectedItem.ToString();
            getDescribtion();
        }

        private void Edit_Click(object sender, EventArgs e)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load("projects.xml");
            XmlNodeList list = doc.GetElementsByTagName("Project");

            for (int i = 0; i < list.Count; i++)
            {
                XmlNodeList child = list[i].ChildNodes;
                if (child[0].InnerText == selectedid)
                {
                    child[2].InnerText = Description.Text;
                    break;
                }
            }

            doc.Save("projects.xml");
            MessageBox.Show("Project Has Been Edited");
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            adminActionForm.Show();
            editProjectForm.Dispose();
        }
    }
}
