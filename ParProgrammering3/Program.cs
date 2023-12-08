using System;
using System.Collections.Generic;

namespace ParProgrammering3
{
    internal class Program
    {

        List<Tasks> TaskList = new List<Tasks>();

        void LeggTilOppgave()
        {
            Console.Write("\nSkriv inn navn på oppgaven: ");
            string taskName = Console.ReadLine();

            Console.Write("Beskriv oppgaven:");
            string taskDescription = Console.ReadLine();

            Console.WriteLine("Framdrift kan være: 1. To Do, 2. In Progress, 3. Done");
            Console.Write("Sett oppgave framdrift: ");

            int taskState = int.Parse(Console.ReadLine());

            if (taskState >= 1 && taskState <= 3)
            {
                Tasks newTasks = new Tasks(taskName, taskDescription, taskState);
                TaskList.Add(newTasks);
            }
        }

        void VisOppgaver()
        {
            if (TaskList.Count == 0)
            {
                Console.WriteLine("\nDu har ingen oppgaver!");
                return;
            }

            string[] taskNames = { "To Do", "In Progress", "Done" };

            Console.WriteLine("\nDu har disse oppgavene:");

            for (int i = 0; i < TaskList.Count; i++)
            {
                Console.WriteLine($"{i + 1}. Oppgave: {TaskList[i].TaskName}, Beskrivelse: {TaskList[i].TaskDescription}, Framdrift: {taskNames[TaskList[i].TaskStatus - 1]}");
            }
        }

        void RemoveTask()
        {
            if (TaskList.Count == 0)
            {
                Console.WriteLine("\nDu har ingen oppgaver!");
                return;
            }


        }

        void MainMenu()
        {
            while (true)
            {
                Console.WriteLine("\nTo do liste");
                Console.WriteLine("1. Legg til ny oppgave");
                Console.WriteLine("2. Vis oppgaver");
                Console.WriteLine("3. Slett oppgave");
                Console.WriteLine("4. Avslutt");

                Console.Write("\nHva vil du gjøre? ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        LeggTilOppgave();
                        break;
                    case "2":
                        VisOppgaver();
                        break;
                    case "3":
                        RemoveTask();
                        break;
                    case "4":
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Velg en av oppgavene!");
                        break;
                }
            }
        }

        static void Main(string[] args)
        {
            Program newProgram = new Program();
            newProgram.MainMenu();
        }
    }
}
