using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParProgrammering3
{
    internal class Program
    {

        List<Tasks> TaskList = new List<Tasks>();

        void LeggTilOppgave()
        {
            Console.Write("Skriv inn navn på oppgaven: ");
            string taskName = Console.ReadLine();

            Console.Write("Beskriv oppgaven:");
            string taskDescription = Console.ReadLine();

            Console.WriteLine("Framdrift kan være: 1. To Do, 2. In Progress, 3. Done");
            Console.Write("Sett oppgave framdrift: ");

            if (Enum.TryParse(Console.ReadLine(), out TaskState currentState))
            {
                Tasks newTask = new Tasks(taskName, taskDescription, currentState);
                TaskList.Add(newTask);
            }
            else
            {
                Console.WriteLine("Ugyldig framdrifts valg");
            }
        }

        void VisOppgaver()
        {
            if (TaskList.Count == 0)
            {
                Console.WriteLine("Du har ingen oppgaver!");
                return;
            }
            
            Console.WriteLine("Du har disse oppgavene:");

            for (int i = 0;i < TaskList.Count; i++)
            {
                Console.WriteLine($"{i + 1}. Oppgave: {TaskList[i].TaskName}, Beskrivelse: {TaskList[i].TaskDescription}, Framdrift: {TaskList[i].TaskStatus}");
            }
        }

        void RemoveTask()
        {
            if (TaskList.Count == 0)
            {
                Console.WriteLine("Du har ingen oppgaver!");
                return;
            }


        }

        void MainMenu()
        {
            while (true)
            {
                Console.WriteLine("To do liste");
                Console.WriteLine("1. Legg til ny oppgave");
                Console.WriteLine("2. Vis oppgaver");
                Console.WriteLine("3. Slett oppgave");
                Console.WriteLine("4. Avslutt");

                Console.Write("Hva vil du gjøre? ");
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
                        // slett oppgaver
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
