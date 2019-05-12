using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManager
{
    public class TaskEvent
    {
        public DateTime date;

        public TaskEvent()
        {
            date = DateTime.Now;
        }

        public void setDate(DateTime date)
        {
            this.date = date;
        }

        public DateTime getDate()
        {
            return date;
        }
    }
}
