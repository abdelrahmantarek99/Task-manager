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
using System.Xml;
namespace TaskManager
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
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

        }
        string getIdOfEmp()
        {
            XmlDocument doc = new XmlDocument();
            doc.Load("employees.xml");
            XmlNodeList list=doc.GetElementsByTagName("employee");
            return (list.Count+1).ToString();

        }
        private void button2_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text, password = textBox3.Text, id = "1", status="";
            if ( (radioButton1.Checked || radioButton2.Checked) && (name.Length>0 && password.Length>0) )
            {
                if (radioButton1.Checked) status = radioButton1.Text;
                else status = radioButton2.Text;
                if (!File.Exists("employees.xml"))
                {
                    XmlWriter wr = XmlWriter.Create("employees.xml");
                    wr.WriteStartDocument();
                    wr.WriteStartElement("arrayOfEmp");
                    wr.WriteStartElement("employee");

                    wr.WriteStartElement("status");
                    wr.WriteString(status);
                    wr.WriteEndElement();

                    wr.WriteStartElement("id");
                    wr.WriteString(id);
                    wr.WriteEndElement();

                    wr.WriteStartElement("name");
                    wr.WriteString(name);
                    wr.WriteEndElement();

                    wr.WriteStartElement("password");
                    wr.WriteString(password);
                    wr.WriteEndElement();

                    wr.WriteEndElement();
                    wr.WriteEndElement();
                    wr.WriteEndDocument();
                    wr.Close();
                }
                else
                {
                    id = getIdOfEmp();

                    XmlDocument doc = new XmlDocument();

                    XmlElement parent = doc.CreateElement("employee");

                    XmlElement child = doc.CreateElement("status");
                    child.InnerText = status;
                    parent.AppendChild(child);

                    child = doc.CreateElement("id");
                    child.InnerText = id;
                    parent.AppendChild(child);

                    child = doc.CreateElement("name");
                    child.InnerText = name;
                    parent.AppendChild(child);

                    child = doc.CreateElement("password");
                    child.InnerText = password;
                    parent.AppendChild(child);
                    //////////
                    doc.Load("employees.xml");

                    XmlElement root = doc.DocumentElement;
                    root.AppendChild(parent);

                    doc.Save("employees.xml");
                }

                MessageBox.Show("employee ID = " + id);
            }
            else
                MessageBox.Show("please check your data");
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            List<Project> listOfproj = new List<Project>();
            Employee em=new Employee();
            Project p = new Project();
            EmpTask t=new EmpTask();
            
            p.id = 1;
            p.name = "chess";
            p.description = "lablablaaa";
            em.id=11;
            em.name="abdo";
            t.id=111;
            t.name="checkmyking";
            t.description="discc";
            t.comment="ya doc";
            t.attachment.Add("hat file");
           
            em.tasksOfEmp.Add(t);
            p.emploees.Add(em);
            listOfproj.Add(p);
            XmlSerializer ser =new XmlSerializer(listOfproj.GetType());
            FileStream f= new FileStream("myfile.xml",FileMode.OpenOrCreate);
            ser.Serialize(f, listOfproj);
            f.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {     
            Project p = new Project();
            p.name = textBox6.Text;
            p.description = textBox5.Text;
            Project.readProjects();
            p.id=Project.projects.Count;
            Project.projects.Add(p);
            Project.writeProjects();

        }
    }
}
