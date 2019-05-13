using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManager
{
    public class Employee
    {
        public int id;
        public string name;
        public List<EmpTask> tasksOfEmp;
        public Employee()
        {
            tasksOfEmp = new List<EmpTask>();
        }
    }
}
