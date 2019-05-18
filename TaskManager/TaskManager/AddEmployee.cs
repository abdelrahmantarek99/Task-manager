using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
namespace TaskManager
{
    public partial class AddEmployee : UserControl
    {
        public AddEmployee()
        {
            InitializeComponent();
        }
        public void LoadProjects()
        {
            List<Project> list = new List<Project>();
            FileStream fs = new FileStream("projects.xml", FileMode.Open);
            XmlSerializer xs = new XmlSerializer(list.GetType());
            list = (List<Project>)xs.Deserialize(fs);
            for (int i = 0; i < list.Count; i++)
            {
                if(list[i].status.ToString() == "opened")
                    ProjectID.Items.Add(list[i].id);
            }
            fs.Close();
        }
        public List<string> Get_User_Ids_Of_Selected_Project(String selsected_project_id)
        {
            //load projects to and filter employees of selected project
            List<Project> list = new List<Project>();
            List<string> selected_project_user_ids = new List<string>();
            FileStream fs = new FileStream("projects.xml", FileMode.OpenOrCreate);
            XmlSerializer xs = new XmlSerializer(list.GetType());
            list = (List<Project>)xs.Deserialize(fs);
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i].id.ToString() == selsected_project_id)
                {
                    for (int j = 0; j < list[i].emploees.Count; j++)
                    {
                        selected_project_user_ids.Add(list[i].emploees[j].id.ToString());
                    }
                    break;
                }
            }
            fs.Close();
            return selected_project_user_ids;
        }
        public void LoadUsers(string selsected_project_id)
        {
            UserID.Items.Clear();
            UserID.Text = "";
            UserID.SelectedItem = null;
            List<string> selected_project_user_ids = Get_User_Ids_Of_Selected_Project(selsected_project_id);
            EmployeeFile.readEmployeeFile();
            List<EmployeeFile> list = EmployeeFile.employeeFiles;
            for(int i = 0; i < list.Count; i++)
            {
                if(!selected_project_user_ids.Contains(list[i].id.ToString()) && list[i].role.ToString() == "User")
                {
                    UserID.Items.Add(list[i].id.ToString());
                }
            }

        }
        public Employee Selected_Employee;
        public void Get_Selected_Employee()
        {
            // get selected employee
            string Selected_User_Id = UserID.SelectedItem.ToString();
            EmployeeFile.readEmployeeFile();
            List<EmployeeFile> lis = EmployeeFile.employeeFiles;
            for (int i = 0; i < lis.Count; i++)
            {
                if (lis[i].id.ToString() == Selected_User_Id)
                {
                    Selected_Employee = new Employee();
                    Selected_Employee.id = int.Parse(lis[i].id);
                    Selected_Employee.name = lis[i].name;
                    Selected_Employee.role = lis[i].role;
                    break;
                }
            }
        }
        private void AddEmployee_Load(object sender, EventArgs e)
        {
            LoadProjects();
        }

        private void ProjectID_SelectedIndexChanged(object sender, EventArgs e)
        {
            UserID.Enabled = true;
            LoadUsers(ProjectID.Text.ToString());
        }

        private void Back_Click(object sender, EventArgs e)
        {

        }


        private void Add_Click(object sender, EventArgs e)
        {
            if(ProjectID.SelectedItem == null)
            {
                MessageBox.Show("Please Select Project ID");
                return;
            }
            else if (UserID.SelectedItem == null)
            {
                MessageBox.Show("Please Select User ID");
                return;
            }
            // adding  selected employee to the selected project 
            string Selected_Project_Id = ProjectID.SelectedItem.ToString(), Selected_User_Id = UserID.SelectedItem.ToString();
            Get_Selected_Employee();
            Project.readProjects();
            List<Project> list = Project.projects;
            
            for(int i = 0; i < list.Count; i++)
            {
                if(list[i].id.ToString() == Selected_Project_Id)
                {
                    list[i].emploees.Add(Selected_Employee);
                    break;
                }
            }
            Project.writeProjects();
            MessageBox.Show("User added successfully to the selected project");
            LoadUsers(Selected_Project_Id);
        }

        private void UserID_TextUpdate(object sender, EventArgs e)
        {
            UserID.Text = "";
        }

        private void ProjectID_TextUpdate(object sender, EventArgs e)
        {
            ProjectID.Text = "";
        }
    }
}
