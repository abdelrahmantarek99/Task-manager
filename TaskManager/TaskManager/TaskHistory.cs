using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Serialization;

namespace TaskManager
{
    public class TaskHistory
    {
        static public List<TaskHistory> tasks = new List<TaskHistory>();

        public DateTime startDate, closeDate;
        public int taskId;
        public String taskName;
        public List<ForwardHistory> forwards;
        public List<DescriptionHistory> descriptions;
        public List<CommentHistory> comments;
        public List<AttachmentHistory> attachments;

        private TaskHistory()
        {
            startDate = DateTime.Now;
            forwards = new List<ForwardHistory>();
            descriptions = new List<DescriptionHistory>();
            comments = new List<CommentHistory>();
            attachments = new List<AttachmentHistory>();
        }

        public TaskHistory(String taskName, int taskId) : this()
        {
            this.taskName = taskName;
            this.taskId = taskId;
        }
        
        public TaskHistory(String taskName, int taskId, DescriptionHistory description) : this(taskName, taskId)
        {
            descriptions.Add(description);
        }

        public TaskHistory(String taskName, int taskId, ForwardHistory forward) : this(taskName, taskId)
        {
            forwards.Add(forward);
        }
        
        public TaskHistory(String taskName, int taskId, DescriptionHistory description, ForwardHistory forward) : this(taskName, taskId)
        {
            descriptions.Add(description);
            forwards.Add(forward);
        }

        public void Forward(ForwardHistory forward)
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

        public void addAttachment(AttachmentHistory attachment)
        {
            attachment.setEmployeeId(getCurrentEmployeeId());
            attachments.Add(attachment);
        }
        
        public void addComment(CommentHistory comment)
        {
            comment.setEmployeeId(getCurrentEmployeeId()); 
            comments.Add(comment);
        }

        public void editDescription(DescriptionHistory description)
        {
            descriptions.Add(description);
        }

        public List<TaskEvent> viewHistory()
        {
            List<TaskEvent> taskEvents = new List<TaskEvent>();

            foreach (ForwardHistory forward in forwards)
            {
                taskEvents.Add(forward);
            }

            foreach (DescriptionHistory description in descriptions)
            {
                taskEvents.Add(description);
            }

            foreach (AttachmentHistory attachment in attachments)
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
                tasks = (List<TaskHistory>)xmlSerializer.Deserialize(fileStream);

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
