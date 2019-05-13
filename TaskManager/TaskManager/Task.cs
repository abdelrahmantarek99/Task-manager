using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Serialization;

namespace TaskManager
{
    public class Task
    {
        static public List<Task> tasks = new List<Task>();

        public DateTime startDate, closeDate;
        public int taskId;
        public String taskName;
        public List<Forward> forwards;
        public List<Description> descriptions;
        public List<Comment> comments;
        public List<Attachment> attachments;

        private Task()
        {
            startDate = DateTime.Now;
            forwards = new List<Forward>();
            descriptions = new List<Description>();
            comments = new List<Comment>();
            attachments = new List<Attachment>();
        }

        public Task(String taskName, int taskId) : this()
        {
            this.taskName = taskName;
            this.taskId = taskId;
        }
        
        public Task(String taskName, int taskId, Description description) : this(taskName, taskId)
        {
            descriptions.Add(description);
        }

        public Task(String taskName, int taskId, Forward forward) : this(taskName, taskId)
        {
            forwards.Add(forward);
        }
        
        public Task(String taskName, int taskId, Description description, Forward forward) : this(taskName, taskId)
        {
            descriptions.Add(description);
            forwards.Add(forward);
        }

        public void Forward(Forward forward)
        {
            /*
              if (!forwards.empty())
                getCurrentEmployeId ->> remove the task
              
            add the task to the forward
             */
            forwards.Add(forward);
        }

        public int getCurrentEmployeeId()
        {
            return forwards.Last().getEmployeeId();
        }

        public void addAttachment(Attachment attachment)
        {
            attachment.setEmployeeId(getCurrentEmployeeId());
            attachments.Add(attachment);
        }
        
        public void addComment(Comment comment)
        {
            comment.setEmployeeId(getCurrentEmployeeId()); 
            comments.Add(comment);
        }

        public void editDescription(Description description)
        {
            descriptions.Add(description);
        }

        public List<TaskEvent> viewHistory()
        {
            List<TaskEvent> taskEvents = new List<TaskEvent>();

            foreach (Forward forward in forwards)
            {
                taskEvents.Add(forward);
            }

            foreach (Description description in descriptions)
            {
                taskEvents.Add(description);
            }

            foreach (Attachment attachment in attachments)
            {
                taskEvents.Add(attachment);
            }

            return taskEvents;
        }
        
        public void setCloseDate(DateTime date)
        {
            closeDate = date;
        }

        static public void readTasks()
        {
            FileStream fileStream = new FileStream("History.xml", FileMode.OpenOrCreate);
            XmlSerializer xmlSerializer = new XmlSerializer(tasks.GetType());

            if (fileStream.Length != 0)
                tasks = (List<Task>)xmlSerializer.Deserialize(fileStream);

            fileStream.Close();
        }

        static public void writeTasks()
        {
            FileStream fileStream = new FileStream("History.xml", FileMode.OpenOrCreate);
            XmlSerializer xmlSerializer = new XmlSerializer(tasks.GetType());
            xmlSerializer.Serialize(fileStream, tasks);
            fileStream.Close();
        }
    }
}
