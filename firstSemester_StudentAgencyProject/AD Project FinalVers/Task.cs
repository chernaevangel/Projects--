using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AD_Project_FinalVers
{
    public class Task
    {
        private TaskTypes type;
        private bool completed = false;
        public TaskTypes Type { get { return this.type; } }
        public string GetTypes { get { return this.type.ToString(); } }

        public bool Status
        { get { return this.completed; } }
        public bool CompleteTheTask
        {
            set { this.completed = true; }
            get { return this.completed; }
        }
        public Task(TaskTypes type)
        {
            this.type = type;
            this.completed = false;
        }
    }
}
