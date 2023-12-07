using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParProgrammering3
{
    enum TaskState
    {
        ToDo = 1,
        InProgress = 2,
        Done = 3
    }

    internal class Tasks
    {
        public string TaskName { get; set; }
        public string TaskDescription { get; set; }
        public TaskState TaskStatus { get; set; }

        public Tasks(string taskName, string taskDescription, TaskState taskStatus)
        {
            TaskName = taskName;
            TaskDescription = taskDescription;
            TaskStatus = taskStatus;
        }

        public void VisOppgaver()
        {
            Console.WriteLine($"Oppgave: {TaskName}, Beskrivelse: {TaskDescription}, Framdrift: {TaskStatus}");
        }
    }
}
