using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDo_List
{
    internal class Task
    {
        public Task(string name)
        {
            this.name = name;
            this.isDone = false;
        }

        private string name;
        private bool isDone;

        public string getName()
        {
            return this.name;
        }

        public bool getIsDone()
        {
            return this.isDone;
        }

        public void setName(string name)
        {
            this.name = name;
        }

        public void setIsDone(bool isDone)
        {
            this.isDone = isDone;
        }
    }
}
