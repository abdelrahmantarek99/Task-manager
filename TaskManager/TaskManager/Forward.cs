using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManager
{
    public class Forward : TaskEvent
    {
        public int empId;

        public Forward() { }

        public Forward(int empId) : base()
        {
            this.empId = empId;
        }

        public int getEmployeeId()
        {
            return empId;
        }
    }
}
