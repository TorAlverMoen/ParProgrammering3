namespace ParProgrammering3
{
    internal class Tasks
    {
        public string TaskName { get; set; }
        public string TaskDescription { get; set; }
        public int TaskStatus { get; set; }

        public Tasks(string taskName, string taskDescription, int taskStatus)
        {
            TaskName = taskName;
            TaskDescription = taskDescription;
            TaskStatus = taskStatus;
        }
    }
}
