using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Xml.Serialization;
namespace TaskManager
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            loadData();
        }

        public void loadData()
        {
          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TaskHistory task = new TaskHistory("Test", 0);

            task.Forward(new ForwardHistory(0));
            task.Forward(new ForwardHistory(1));

            AttachmentHistory attachment = new AttachmentHistory("C:\\Users\\shaks");
            task.addAttachment(attachment);

            attachment = new AttachmentHistory("C:\\Users\\shakshak");
            task.addAttachment(attachment);

            DescriptionHistory description = new DescriptionHistory("Bla bla bla");
            task.editDescription(description);

            description = new DescriptionHistory("Bla bla blaaaaaaaaaaaaaaaaaaaaaa");
            task.editDescription(description);

            
            task.addComment(new CommentHistory("comment"));
            task.addComment(new CommentHistory("commmmmmmmmmment"));

            TaskHistory.readTasks();
            task.taskId = TaskHistory.tasks.Count;
            TaskHistory.tasks.Add(task);
            TaskHistory.writeTasks();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            login1.initializ(this);
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            
            ///
            Employee em=new Employee();
            FileStream ss = new FileStream("test.xml", FileMode.OpenOrCreate);
            XmlSerializer xm = new XmlSerializer(em.GetType());
            //em.name = "mohamed";
            ////em.id = 10;
            xm.Serialize(ss, em);
            ///
            List<Project> listOfproj = new List<Project>();
            Project p = new Project();
            EmpTask t=new EmpTask();

            p.id = 1;
            p.name = "chess";
            p.description = "lablablaaa";
            //em.id = 11;
            //em.name = "abdo";
            //t.id = 111;
            //t.name = "checkmyking";
            //t.description = "discc";
            //t.comment = "ya doc";

            //t.attachment.Add("hat file");

            //em.tasksOfEmp.Add(t);
            //p.emploees.Add(em);
            listOfproj.Add(p);

            XmlSerializer ser =new XmlSerializer(listOfproj.GetType());
            FileStream f= new FileStream("myfile.xml",FileMode.OpenOrCreate);
            ser.Serialize(f, listOfproj);
            f.Close();

            /// load projects into the combobox
            List<Project> list = new List<Project>();
            XmlSerializer xs = new XmlSerializer(list.GetType());
            FileStream fs = new FileStream("myfile.xml", FileMode.OpenOrCreate);
            list = (List<Project>)xs.Deserialize(fs);
            fs.Close();
            /*for (int i = 0; i < list.Count; i++)
            {
                combopro.Items.Add(list[i].name + " " + list[i].id + "\n");
            }*/

            /// add employees to employees file
            List<Employee> lis = new List<Employee>();
            Employee emp = new Employee();
            emp.id = 5;
            emp.name = "mohamed";
            lis.Add(emp);
            emp = new Employee();
            emp.name = "ahmed";
            emp.id = 7;
            lis.Add(emp);
            FileStream fss = new FileStream("employees.xml", FileMode.OpenOrCreate);
            XmlSerializer xss = new XmlSerializer(lis.GetType());
            xss.Serialize(fss, lis);
            fss.Close();

            /// load employees into comboemp

            FileStream ff = new FileStream("employees.xml", FileMode.OpenOrCreate);
            XmlSerializer xmlser = new XmlSerializer(lis.GetType());
            lis = (List<Employee>)xmlser.Deserialize(ff);
            /*for(int i = 0; i < lis.Count; i++)
            {
                comboemp.Items.Add(lis[i].name + " " + lis[i].id);
            }*/
            ff.Close();
        }

        private void combopro_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void btnadd_Click(object sender, EventArgs e)
        {
            /// get the selected employee

            List<Employee> lis = new List<Employee>();
            List<Project> list = new List<Project>();
            Employee emp = new Employee();
            Project pro = new Project();
            FileStream ff = new FileStream("employees.xml", FileMode.OpenOrCreate);
            XmlSerializer xmlser = new XmlSerializer(lis.GetType());
            lis = (List<Employee>)xmlser.Deserialize(ff);
            /*for (int i = 0; i < lis.Count; i++)
            {
                if (lis[i].name + " " + lis[i].id == comboemp.Text)
                {
                    emp = lis[i];
                    break;
                }
            }*/

            ff.Close();



            /// get the selected project
            string s = "";//combopro.Text.ToString();

            XmlSerializer xs = new XmlSerializer(list.GetType());
            FileStream fs = new FileStream("myfile.xml", FileMode.OpenOrCreate);
            list = (List<Project>)xs.Deserialize(fs);
            fs.Close();
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i].name + " " + list[i].id + "\n" == s)
                {
                    /*for (int j = 0; j < list[i].emploees.Count; j++)
                    {
                        if (list[i].emploees[j].name + " " + list[i].emploees[j].id == comboemp.Text)
                        {
                            MessageBox.Show("already exist");
                            return;
                        }
                    }*/
                    // add the employee to the project
                    list[i].emploees.Add(emp);
                    MessageBox.Show("added successfully");
                    XmlSerializer xss = new XmlSerializer(list.GetType());
                    FileStream fss = new FileStream("myfile.xml", FileMode.OpenOrCreate);
                    xss.Serialize(fss, list);
                    fss.Close();
                    break;
                }
            }
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
        }

        private void login1_Load(object sender, EventArgs e)
        {
            foreach (System.Windows.Forms.Control c in login1.Controls)
            {
                TextBox tb = new TextBox();
                if (c.GetType() == tb.GetType())
                    c.Text = "";
            }
        }
    }
}
