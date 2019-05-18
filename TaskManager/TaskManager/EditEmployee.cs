using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using System.IO;
using System.Xml;

namespace TaskManager
{
    public partial class EditEmployee : UserControl
    {
        public string IDselected;
        private AdminActionForm adminActionForm;
        private EditEmployeeForm editEmployeeForm;

        public EditEmployee()
        {
            InitializeComponent();
        }

        public void initialize(AdminActionForm adminActionForm, EditEmployeeForm editEmployeeForm)
        {
            this.adminActionForm = adminActionForm;
            this.editEmployeeForm = editEmployeeForm;
        }

        private List<EmployeeFile> loademp()
        {
            UserID.Items.Clear();
            EmployeeFile.readEmployeeFile();
            for (int i = 0; i < EmployeeFile.employeeFiles.Count; i++)
            {
                if (EmployeeFile.employeeFiles[i].role == "User")/**************************************/
                    UserID.Items.Add(EmployeeFile.employeeFiles[i].id);
            }
            return EmployeeFile.employeeFiles;
        }

        private void EditEmployee_Load(object sender, EventArgs e)
        {
            loademp();
        }

        private string get_name()
        {
            string tmp = "";
            List<EmployeeFile> list = EmployeeFile.employeeFiles;
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i].id.ToString() == IDselected)
                {
                    tmp = list[i].name;
                    break;
                }
            }
            return tmp;
        }

        private string get_paswword()
        {
            string tmp = "";
            List<EmployeeFile> list = EmployeeFile.employeeFiles;
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i].id.ToString() == IDselected)
                {
                    tmp = list[i].password;
                    break;
                }
            }
            return tmp;

        }

        private void UserID_SelectedIndexChanged(object sender, EventArgs e)
        {
            IDselected = UserID.SelectedItem.ToString();
            name.Text = get_name();
            password.Text = get_paswword();
        }

        private void Edit_Click(object sender, EventArgs e)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load("employees.xml");
            XmlNodeList list = doc.GetElementsByTagName("EmployeeFile");

            for (int i = 0; i < list.Count; i++)
            {
                XmlNodeList child = list[i].ChildNodes;
                if (child[1].InnerText == IDselected)
                {
                    child[2].InnerText = name.Text;
                    child[3].InnerText = password.Text;
                    break;
                }
            }

            doc.Save("employees.xml");
            MessageBox.Show("Employee Has Been Edited");
            UserID.Text = "";
            name.Text = "";
            password.Text = "";
            loademp();
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            adminActionForm.Show();
            editEmployeeForm.Dispose();
        }
    }
}
