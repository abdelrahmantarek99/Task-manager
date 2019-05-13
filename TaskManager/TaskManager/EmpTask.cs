using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManager
{
    public class EmpTask
    {
        public int id;
        public string name, description, comment;
        public List<string> attachment;
        
        public EmpTask()
        {
            attachment = new List<string>();
        }


    }
}
