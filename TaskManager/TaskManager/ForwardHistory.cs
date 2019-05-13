using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManager
{
    public class ForwardHistory : TaskEvent
    {
        public int empId;

        public ForwardHistory() { }

        public ForwardHistory(int empId) : base()
        {
            this.empId = empId;
        }

        public void setEmployeeId(int empId)
        {
            this.empId = empId;
        }

        public int getEmployeeId()
        {
            return empId;
        }
    }
}
