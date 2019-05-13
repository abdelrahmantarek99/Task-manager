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
    }
}
