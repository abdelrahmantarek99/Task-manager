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
    public partial class CloseProject : UserControl
    {
        public string selectedID;
        private AdminActionForm adminActionForm;
        private CloseProjectForm closeProjectForm;
        public CloseProject()
        {
            InitializeComponent();
        }

        public void initialize(AdminActionForm adminActionForm, CloseProjectForm closeProjectForm)
        {
            this.adminActionForm = adminActionForm;
            this.closeProjectForm = closeProjectForm;
        }

        public List<Project> get_all_projects()
        {
            Project.readProjects();
            return Project.projects;
        }

        public List<string> filter()
        {
            List<Project> allProject = get_all_projects();
            List<string> opendProject = new List<string>();

            for (int i = 0; i < allProject.Count; i++)
            {
                if (allProject[i].status == "opened")
                {
                    opendProject.Add(allProject[i].id.ToString());
                }
            }
            return opendProject;
        }

        private void loadData()
        {
            ProjectID.Items.Clear();
            List<string> list = filter();
            for (int i = 0; i < list.Count; i++)
                ProjectID.Items.Add(list[i]);
        }

        private void CloseProject_Load(object sender, EventArgs e)
        {
            loadData();
        }

        private void Close_Click(object sender, EventArgs e)
        {
            try
            {
                XmlDocument doc = new XmlDocument();
                doc.Load("projects.xml");
                XmlNodeList list = doc.GetElementsByTagName("Project");
                for (int i = 0; i < list.Count; i++)
                {
                    XmlNodeList child = list[i].ChildNodes;
                    if (child[0].InnerText == selectedID)
                    {
                        child[3].InnerText = "closed";
                        break;
                    }

                }
                doc.Save("projects.xml");
                MessageBox.Show("Project Has Been Closed");
                ProjectID.Text = "";
                loadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("the file does not exist");
            }
        }

        private void ProjectID_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedID = ProjectID.SelectedItem.ToString();
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            adminActionForm.Show();
            closeProjectForm.Dispose();
        }
    }
}
