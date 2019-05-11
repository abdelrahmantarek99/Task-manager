using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManager
{
    class Description : TaskEvent
    {
        String description;
        public Description() { }

        public Description(String description)
        {
            this.description = (String)description.Clone();
        }

        public void setDescription(String description)
        {
            this.description = (String)description.Clone();
        }

        public String getDescription()
        {
            return description;
        }
    }
}
