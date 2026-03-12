using Models;

namespace ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool isRunning = true;
            int userResponse = 0;
            TaskRepository taskRepository = new TaskRepository();

            while (isRunning)
            {
                Console.WriteLine("Welcome to the task management app!");
                Console.WriteLine("To begin, select one of the following options: (1-5)");
                Console.WriteLine("1. Add a task");
                Console.WriteLine("2. Remove a task");
                Console.WriteLine("3. View tasks");
                Console.WriteLine("4. Complete a task");
                Console.WriteLine("5. Exit");

                try
                {
                    userResponse = Int32.Parse(Console.ReadLine());
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Please select one of the options above (1-5)");
                }

                if (userResponse >= 1 && userResponse <= 5)
                {
                    switch (userResponse)
                    {
                        case 1:
                            Console.WriteLine("Please Describe your task: ");
                            string taskDesc = Console.ReadLine();
                            if (taskDesc != null)
                            {
                                Models.Task task = new Models.Task(taskDesc);
                                taskRepository.Add(task);
                            }
                            break;
                        case 2:
                            if (taskRepository.Tasks.Count > 0)
                            {
                                while (true)
                                {
                                    Console.WriteLine("Please select a task number: ");
                                    taskRepository.Display();
                                    int taskNum = 0;
                                    try
                                    {
                                        taskNum = Int32.Parse(Console.ReadLine());
                                        taskRepository.Remove(taskRepository.Tasks[taskNum - 1]);
                                        Console.WriteLine($"Task {taskNum} Removed.");
                                        break;
                                    }
                                    catch (Exception ex)
                                    {
                                        Console.WriteLine("Please select one of the options above.");
                                    }
                                }
                            }
                            else
                            {
                                Console.WriteLine("No tasks yet, try creating one!");
                            }
                            break;
                        case 3:
                            if (taskRepository.Tasks.Count > 0)
                            {
                                taskRepository.Display();
                            }
                            else
                            {
                                Console.WriteLine("No tasks yet, try creating one!");
                            }
                            break;
                        case 4:
                            if (taskRepository.Tasks.Count > 0)
                            {
                                while (true)
                                {
                                    Console.WriteLine("Please select a task number: ");
                                    taskRepository.Display();
                                    int taskNum = 0;
                                    try
                                    {
                                        taskNum = Int32.Parse(Console.ReadLine());
                                        Worker worker = new Worker(taskRepository.Tasks[taskNum - 1]);
                                        worker.CompleteTask();
                                        Console.WriteLine($"Task {taskNum} Completed.");
                                        break;
                                    }
                                    catch (Exception ex)
                                    {
                                        Console.WriteLine("Please select one of the options above.");
                                    }
                                }
                            }
                            else
                            {
                                Console.WriteLine("No tasks yet, try creating one!");
                            }
                            break;
                        case 5:
                            Console.WriteLine("Thanks for using my app!");
                            isRunning = false;
                            break;
                        default:
                            Console.WriteLine("How did you get here?");
                            break;
                    }
                }
            }
        }
    }
}
