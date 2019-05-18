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
using System.IO;

namespace TaskManager
{
    public partial class Create_Employee : UserControl
    {
        private AdminActionForm adminActionForm;
        private CreateEmployeeForm createEmployeeForm;

        public Create_Employee()
        {
            InitializeComponent();
        }

        public void initialize(AdminActionForm adminActionForm, CreateEmployeeForm createEmployeeForm)
        {
            this.adminActionForm = adminActionForm;
            this.createEmployeeForm = createEmployeeForm;
        }

        private string getIdOfEmp()
        {
            EmployeeFile.readEmployeeFile();
            return (EmployeeFile.employeeFiles.Count + 1).ToString();
        }

        private void Create_Employee_Load(object sender, EventArgs e)
        {

        }

        private void Create_Click(object sender, EventArgs e)
        {
            string namee = name.Text, passwordd = password.Text, id = "1", status = "";
            if ((radioButton1.Checked || radioButton3.Checked) && (namee.Length > 0 && passwordd.Length > 0))
            {
                if (radioButton1.Checked) status = radioButton1.Text;
                else status = radioButton3.Text;

                EmployeeFile.readEmployeeFile();
                EmployeeFile employeeFile = new EmployeeFile();
                employeeFile.id = id = getIdOfEmp();
                employeeFile.name = namee;
                employeeFile.password = passwordd;
                employeeFile.role = status;
                EmployeeFile.employeeFiles.Add(employeeFile);
                EmployeeFile.writeEmployeeFile();

                MessageBox.Show("employee ID = " + id);
            }
            else
                MessageBox.Show("please check your data");
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            adminActionForm.Show();
            createEmployeeForm.Dispose();
        }
    }
}
