using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Serialization;

namespace TaskManager
{
    public class EmployeeFile
    {
        static public List<EmployeeFile> employeeFiles = new List<EmployeeFile>();
        public string role, id, name, password;

        public EmployeeFile()
        {
        }

        static public void readEmployeeFile()
        {
            FileStream fileStream = new FileStream("employees.xml", FileMode.OpenOrCreate);
            XmlSerializer xmlSerializer = new XmlSerializer(employeeFiles.GetType());

            if (fileStream.Length != 0)
                employeeFiles = (List<EmployeeFile>)xmlSerializer.Deserialize(fileStream);

            fileStream.Close();
        }

        static public void writeEmployeeFile()
        {
            FileStream fileStream;

            if(File.Exists("employees.xml"))
                fileStream = new FileStream("employees.xml", FileMode.Truncate);
            else
                fileStream = new FileStream("employees.xml", FileMode.OpenOrCreate);

            XmlSerializer xmlSerializer = new XmlSerializer(employeeFiles.GetType());
            xmlSerializer.Serialize(fileStream, employeeFiles);
            fileStream.Close();
        }
    }
}
