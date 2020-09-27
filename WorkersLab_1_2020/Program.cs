using System;
using System.Linq;
using WorkersModel;
using BL;

namespace WorkersLab_1_2020
{
    class Program
    {
        static void Main(string[] args)
        {
            Logic logic = new Logic();
            while (true)
            {
                Console.WriteLine("\n1.Show workers list\n2.Add worker\n3.Delete worker");
                Console.Write("Enter command:");
                string command = Console.ReadLine();

                switch (command)
                {
                    case "1":
                        {
                            //if (logic.GetWorkers().Count == 0) Console.WriteLine("List is empty.");
                           // else
                           // {
                            foreach (Worker w in logic.GetWorkers())
                            {
                                Console.WriteLine($"Name:{w.Name},Position: {w.Position}, Age:{w.Age}");
                            }
                            Console.WriteLine("ok");
                           // }
                            break;
                        }
                    case "2":
                        {
                            try
                            {
                                Console.WriteLine("Input name, position and age by spaces:");
                                string inp = Console.ReadLine();
                                logic.AddWorker(inp);
                                Console.WriteLine("ok");
                            }
                            catch (Exception e)
                            {
                                Console.WriteLine(e.Message);
                            }
                            break;
                        }
                    case "3":
                        {
                            try
                            {
                                Console.WriteLine("Enter the employee you want to delete:");
                                var n = Console.ReadLine();
                                logic.RemoveWorker(n);
                                Console.WriteLine("ok");
                            }
                            catch (Exception e)
                            {
                                Console.WriteLine(e.Message);
                            }
                            
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("Incorrect input.Try again.");
                            break;
                        }
                       
                }
                
                
            }

        }
    }
}
