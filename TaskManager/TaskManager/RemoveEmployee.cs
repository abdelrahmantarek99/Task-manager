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
using System.Xml.Serialization;
using System.IO;

namespace TaskManager
{
    public partial class RemoveEmployee : UserControl
    {
        string selectedUserID, pro_id_selected;
        private AdminActionForm adminActionForm;
        private RemoveEmployeeForm removeEmployeeForm;

        public RemoveEmployee()
        {
            InitializeComponent();
        }

        public void initialize(AdminActionForm adminActionForm, RemoveEmployeeForm removeEmployeeForm)
        {
            this.adminActionForm = adminActionForm;
            this.removeEmployeeForm = removeEmployeeForm;
        }
        private void Remove_Click(object sender, EventArgs e)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load("projects.xml");
            XmlNodeList list = doc.GetElementsByTagName("Employee");

            for (int i = 0; i < list.Count; i++)
            {
                XmlNodeList child = list[i].ChildNodes;
                XmlNodeList parent = list[i].ParentNode.ParentNode.ChildNodes;

                if (child[0].InnerText == selectedUserID && parent[0].InnerText == pro_id_selected)
                    list[i].ParentNode.RemoveAll();
            }
            doc.Save("projects.xml");   
        }

        private void ProjectID_SelectedIndexChanged(object sender, EventArgs e)
        {
            pro_id_selected = ProjectID.SelectedItem.ToString();
            UserID.Items.Clear();
            /// load employees 
            List<Project> list = new List<Project>();
            XmlSerializer xs = new XmlSerializer(list.GetType());
            FileStream fs = new FileStream("projects.xml", FileMode.OpenOrCreate);
            list = (List<Project>)xs.Deserialize(fs);
            fs.Close();

            for (int i = 0; i < list.Count; i++)
            {
                if (pro_id_selected == list[i].id.ToString())
                {
                    List<Employee> l = list[i].emploees;
                    for (int y = 0; y < l.Count; y++)
                        UserID.Items.Add(l[y].id);
                }
            }
        }

        private void UserID_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedUserID = UserID.SelectedItem.ToString();
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            adminActionForm.Show();
            removeEmployeeForm.Dispose();
        }

        private void ProjectID_TextUpdate(object sender, EventArgs e)
        {
            ProjectID.Text = "";
        }

        private void UserID_TextUpdate(object sender, EventArgs e)
        {
            UserID.Text = "";
        }

        private void RemoveEmployee_Load(object sender, EventArgs e)
        {
            List<Project> list = new List<Project>();
            Project.readProjects();
            list = Project.projects;
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i].status == "opened")
                    ProjectID.Items.Add(list[i].id);
            }
        }
    }
}
