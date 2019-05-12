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
        private FileStream fileStream;
        private XmlSerializer xmlSerializer;
        public DateTime startDate, endDate;
        public int taskId;
        public String taskName;
        public List<Forward> forwards;
        public List<Description> descriptions;
        public List<Attachment> attachments;

        private Task()
        {
            startDate = DateTime.Now;
            forwards = new List<Forward>();
            descriptions = new List<Description>();
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
            forwards.Add(forward);
        }

        public void addAttachment(Attachment attachment)
        {
            attachments.Add(attachment);
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
        
        public void setEndDate(DateTime date)
        {
            endDate = date;
        }

        public void serialize(int projectId)
        {
            Directory.CreateDirectory(projectId.ToString());

            if (File.Exists(projectId.ToString() + "\\" + taskId))
                fileStream = new FileStream(projectId.ToString() + "\\" + taskId + ".xml", FileMode.Truncate);
            else
                fileStream = new FileStream(projectId.ToString() + "\\" + taskId + ".xml", FileMode.Create);
            
            xmlSerializer = new XmlSerializer(this.GetType());
            xmlSerializer.Serialize(fileStream, this);
            fileStream.Close();
        }
    }
}
