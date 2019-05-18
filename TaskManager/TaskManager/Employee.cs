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
        public string name, role;
        public List<EmpTask> tasksOfEmp;
        public Employee()
        {
            this.id = 0;
            this.name = this.role = "";
            tasksOfEmp = new List<EmpTask>();
        }
    }
}
