using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.IO;

namespace TaskManager
{
    public class Project
    {
        static public List<Project> projects = new List<Project>();
        public int id;
        public string name, description;
        public List<Employee> emploees;
        public Project()
        {
             emploees=new List<Employee>();
        }

        static public void readProjects()
        {
            FileStream fileStream = new FileStream("Projects.xml", FileMode.OpenOrCreate);
            XmlSerializer xmlSerializer = new XmlSerializer(projects.GetType());

            if (fileStream.Length != 0)
                projects = (List<Project>)xmlSerializer.Deserialize(fileStream);

            fileStream.Close();
        }

        static public void writeProjects()
        {
            FileStream fileStream = new FileStream("Projects.xml", FileMode.OpenOrCreate);
            XmlSerializer xmlSerializer = new XmlSerializer(projects.GetType());
            xmlSerializer.Serialize(fileStream, projects);
            fileStream.Close();
        }
    }
}
////projecs 
////employess
////tasks
