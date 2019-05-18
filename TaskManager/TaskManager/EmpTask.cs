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
        public Boolean close;
        public List<string> attachment;
        
        public EmpTask()
        {
            this.id = 0;
            this.close = false;
            this.name = this.description = this.comment = "";
            this.attachment = new List<string>();
        }
    }
}
