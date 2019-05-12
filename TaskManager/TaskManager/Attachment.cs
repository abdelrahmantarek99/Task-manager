using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManager
{
    public class Attachment : TaskEvent
    {
        public String attachment;
        public Attachment() { }

        public Attachment(String attachment) : base()
        {
            this.attachment = (String)attachment.Clone();
        }

        public void setAttachment(String attachment)
        {
            this.attachment = (String)attachment.Clone();
        }

        public String getAttachment()
        {
            return attachment;
        }
    }
}
