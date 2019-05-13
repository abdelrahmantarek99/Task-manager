using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManager
{
    public class Project
    {
        public int id;
        public string name, description;
        public List<Employee> emploees;
        public Project()
        {
             emploees=new List<Employee>();
        }
    }
}
////projecs 
////employess
////tasks
