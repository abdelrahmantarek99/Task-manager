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
using System.Xml.Serialization;

namespace TaskManager
{
    public partial class UserAction : UserControl
    {
        private Boolean admin;
        private Form1 form1;
        private AdminActionForm adminActionForm;
        UserActionForm UserActionForm;
        private string id;
        public UserAction()
        {
            admin = false;
            InitializeComponent();
        }
        public void initilize(Form1 form1, UserActionForm userActionForm , string id)
        {
            this.form1 = form1;
            this.UserActionForm = userActionForm;
            this.id = id;
            admin = false;
        }
        public void initilize(Form1 form1, UserActionForm userActionForm)
        {
            this.form1 = form1;
            this.UserActionForm = userActionForm;
            admin = false;
        }
        public void initilize(AdminActionForm adminActionForm, UserActionForm userActionForm)
        {
            this.adminActionForm = adminActionForm;
            this.UserActionForm = userActionForm;
            admin = true;
        }

        

        private void lblAttach_Click(object sender, EventArgs e)
        {

        }

        private void Forwrd_Click(object sender, EventArgs e)
        {

        }
        public List<string> taskDescription = new List<string>();
        private void UserAction_Load(object sender, EventArgs e)
        {
            MessageBox.Show(this.id);
            
            if (admin)
            {
                Descriptiongb.Enabled = true;
                Back.Text = "Back";
                
                List<Project> list = new List<Project>();
                FileStream fs = new FileStream("Projects.xml", FileMode.OpenOrCreate);
                XmlSerializer xs = new XmlSerializer(list.GetType());
                list = (List<Project>)xs.Deserialize(fs);
                fs.Close();
                
                Tasks.Rows.Clear();
                for (int i = 0; i < list.Count; i++)
                {
                    string projectId = "";
                    string projectName = "";
                    string taskId = "";
                    string taskName = "";

                    for (int j = 0; j < list[i].emploees.Count; j++)
                    {
                        for (int k = 0; k < list[i].emploees[j].tasksOfEmp.Count; k++)
                        {
                            
                                projectId = list[i].id.ToString();
                                projectName = list[i].name.ToString();
                                taskId = list[i].emploees[j].tasksOfEmp[k].id.ToString();
                                taskName = list[i].emploees[j].tasksOfEmp[k].name.ToString();
                                taskDescription.Add(list[i].emploees[j].tasksOfEmp[k].description.ToString());
                                if (Tasks.ColumnCount == 0)
                                {
                                    Tasks.Columns.Add("ProjectID", projectId);
                                    Tasks.Columns.Add("ProjectName", projectName);
                                    Tasks.Columns.Add("TaskID", taskId);
                                    Tasks.Columns.Add("TaskName", taskName);
                                }
                                Tasks.Rows.Add(new string[] { projectId, projectName, taskId, taskName });
                                
                            
                        }
                    }
                }

            }
            else
            {
                Descriptiongb.Enabled = false;
                Back.Text = "Logout";


                List<Project> list = new List<Project>();
                FileStream fs = new FileStream("Projects.xml", FileMode.OpenOrCreate);
                XmlSerializer xs = new XmlSerializer(list.GetType());
                list = (List<Project>)xs.Deserialize(fs);
                fs.Close();
                Tasks.Rows.Clear();
                for (int i = 0; i < list.Count; i++)
                {
                    string projectId = "";
                    string projectName = "";
                    string taskId = "";
                    string taskName = "";

                    for (int j = 0; j < list[i].emploees.Count; j++)
                    {
                        for (int k = 0; k < list[i].emploees[j].tasksOfEmp.Count; k++)
                        {
                            
                            if (id.Equals(list[i].emploees[j].id.ToString()))
                            {
                               
                                projectId = list[i].id.ToString();
                                projectName = list[i].name.ToString();
                                taskId = list[i].emploees[j].tasksOfEmp[k].id.ToString();
                                taskName = list[i].emploees[j].tasksOfEmp[k].name.ToString();
                                taskDescription.Add(list[i].emploees[j].tasksOfEmp[k].description.ToString());
                                if (Tasks.ColumnCount == 0)
                                {
                                    Tasks.Columns.Add("ProjectID", projectId);
                                    Tasks.Columns.Add("ProjectName", projectName);
                                    Tasks.Columns.Add("TaskID", taskId);
                                    Tasks.Columns.Add("TaskName", taskName);
                                }
                                Tasks.Rows.Add(new string[] { projectId, projectName, taskId, taskName });
                            }
                        }
                    }
                }




            }
        }

        private void Back_Click(object sender, EventArgs e)
        {
            if(Back.Text == "Back")
            {
                adminActionForm.Show();
            }
            else
            {
                form1.Show();
            }

            UserActionForm.Dispose();
        }



        private string TaskId;
        private string SelectedProjectID;
        private int indexOf;
        private void Tasks_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            indexOf = index;
            if (Tasks.Rows.Count > 0 && index>=0)
            {
                descriptiontxt.Clear();
                descriptiontxt.AppendText(taskDescription[index]);
                string proID = Tasks.Rows[index].Cells[0].Value.ToString();

                List<Project> list = new List<Project>();
                FileStream fs = new FileStream("Projects.xml", FileMode.OpenOrCreate);
                XmlSerializer xs = new XmlSerializer(list.GetType());
                list = (List<Project>)xs.Deserialize(fs);
                fs.Close();
                for (int i = 0; i < list.Count; i++)
                { 
                    if (list[i].id.ToString().Equals(proID)) {
                        //MessageBox.Show("haha");
                        List<string> emps = new List<string>();
                        for(int j = 0; j < list[i].emploees.Count; j++)
                        {
                            if (!list[i].id.ToString().Equals(id))
                            {
                                emps.Add(list[i].emploees[j].name.ToString());
                                MessageBox.Show((list[i].emploees[j].name.ToString()));
                            }
                        }
                        System.Object[] itemObject = new System.Object[emps.Count];
                        for (int ii = 0; ii <emps.Count; ii++)
                        {
                            itemObject[ii] = emps[ii];
                        }
                        Employees.Items.AddRange(itemObject);
                        
                    }
                }       
            }

            //List<string> filesPath = new List<string>();

        }

        private void Select_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            string fileName = openFileDialog1.FileName;
            string readFile = File.ReadAllText(fileName);
            FileContent.Text = readFile;
            FileContent.Enabled = false;
            FilePath.Text = fileName;
        }

        private void Tasks_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Forward_Click(object sender, EventArgs e)
        {
            List<Project> list = new List<Project>();
            FileStream fs = new FileStream("Projects.xml", FileMode.OpenOrCreate);
            XmlSerializer xs = new XmlSerializer(list.GetType());
            list = (List<Project>)xs.Deserialize(fs);
            fs.Close();
            string empselected = Employees.SelectedItem.ToString();
            MessageBox.Show( empselected);












        }

        private void Add_Click(object sender, EventArgs e)
        {
            string CommentText = Description.Text;
            if (!CommentText.Equals(""))
            {
                TaskHistory.readTasks();
                foreach(TaskHistory taskHistory in TaskHistory.tasks)
                {
                    if(taskHistory.taskId.ToString() == id)
                    {
                        CommentHistory commentHistory = new CommentHistory(CommentText);
                        taskHistory.addComment(commentHistory);
                        break;
                    }
                }
                TaskHistory.writeTasks();
            }
            else
                MessageBox.Show("Please Add comment");
        }

        private void Edit_Click(object sender, EventArgs e)
        {

        }
    }
}
