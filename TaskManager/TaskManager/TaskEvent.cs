using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManager
{
    class TaskEvent
    {
        private DateTime date;

        public TaskEvent()
        {
            date = DateTime.Now;
        }

        public DateTime getDate()
        {
            return date;
        }
    }
}
