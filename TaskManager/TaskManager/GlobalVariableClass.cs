using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManager
{
    class GlobalVariableClass
    {
        private static string temp;
        public static string Temp
        {
            get{ return temp; }
            set{ temp = value; }
        }
    }
}
