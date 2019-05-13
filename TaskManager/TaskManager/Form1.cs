﻿using System;
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
            Task task = new Task("Test", 0);

            task.Forward(new Forward(0));
            task.Forward(new Forward(1));

            Attachment attachment = new Attachment("C:\\Users\\shaks");
            task.addAttachment(attachment);

            attachment = new Attachment("C:\\Users\\shakshak");
            task.addAttachment(attachment);

            Description description = new Description("Bla bla bla");
            task.editDescription(description);

            description = new Description("Bla bla blaaaaaaaaaaaaaaaaaaaaaa");
            task.editDescription(description);

            
            task.addComment(new Comment("comment"));
            task.addComment(new Comment("commmmmmmmmmment"));

            Task.readTasks();
            task.taskId = Task.tasks.Count;
            Task.tasks.Add(task);
            Task.writeTasks();
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
