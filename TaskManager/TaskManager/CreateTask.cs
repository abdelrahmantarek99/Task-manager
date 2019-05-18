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
    public partial class CreateTask : UserControl
    {
        private AdminActionForm adminActionForm;
        private CreateTaskForm createTaskForm;

        public CreateTask()
        {
            InitializeComponent();
        }

        public void initialize(AdminActionForm adminActionForm, CreateTaskForm createTaskForm)
        {
            this.adminActionForm = adminActionForm;
            this.createTaskForm = createTaskForm;
        }

        private void ProjectID_SelectedIndexChanged(object sender, EventArgs e)
        {
            UserID.Items.Clear();
            String selected = ProjectID.SelectedItem.ToString();
            int id = Tools.getId(selected);
            List<Employee> employees = Tools.GetEmployeesAtProject(id);

            foreach (Employee employee in employees)
            {
                UserID.Items.Add(employee.name + "(" + employee.id + ")");
            }
        }

        private void UserID_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Create_Click(object sender, EventArgs e)
        {
            if(UserID.SelectedItem == null || ProjectID.SelectedItem == null || name.Text == "" || Description.Text == "")
            {
                MessageBox.Show("All Fileds Are Requierd");
                return;
            }

            int projectId = Tools.getId(ProjectID.SelectedItem.ToString());
            int employeeId = Tools.getId(UserID.SelectedItem.ToString());
            EmpTask empTask = new EmpTask();
            empTask.id = Tools.getNumberOfTasks();
            empTask.name = name.Text;
            empTask.description = Description.Text;

            Employee employee = Tools.getEmployee(projectId, employeeId);
            employee.tasksOfEmp.Add(empTask);
            Project.writeProjects();
            MessageBox.Show("Task " + name.Text + " Has Been Added");
            name.Text = "";
            Description.Text = "";
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            adminActionForm.Show();
            createTaskForm.Dispose();
        }

        private void loadData()
        {
            Project.readProjects();

            foreach (Project project in Project.projects)
            {
                ProjectID.Items.Add(project.name + "(" + project.id + ")");
            }
        }

        private void CreateTask_Load(object sender, EventArgs e)
        {
            loadData();
        }
    }
}
