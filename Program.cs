using System.Text;

namespace Parks
{
    internal class Program
    {
        class park
        {
            public string Name;
            public string Description;
            public string Location;
            public bool Visited;

            public park(string name, string description, string location, bool visited)
            {
                Name = name;
                Description = description;
                Location = location;
                Visited = visited;
            }
        }
        static void Main(string[] args)
        {

            Console.BackgroundColor = ConsoleColor.DarkRed;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkYellow;

            static void Loading()
            {
                for (int i = 0; i <= 100; i++)
                {
                    Console.Write($"\rLoading: {i}%   ");
                    Thread.Sleep(10);

                }
            }   

            List<park> parks = new List<park>();
            parks.Add(new park("Bell Park", "Enjoy the view of Ramsey Lake ", "South End Sudbury", false));
            parks.Add(new park("Bell Park", "Enjoy the view of Ramsey Lake ", "South End Sudbury", false));
            parks.Add(new park("Bell Park", "Enjoy the view of Ramsey Lake ", "South End Sudbury", false));
            parks.Add(new park("Bell Park", "Enjoy the view of Ramsey Lake ", "South End Sudbury", false));
            try
            {

                while (true)
                {

                    Console.Clear();
                    Console.WriteLine("------------------------------------------------------------------------------------------------------------------------\n");
                    Console.WriteLine(String.Format("{0," + Console.WindowWidth / 2 + "}", " Public Park Application"));
                    Console.WriteLine(" \t\tAdd and Remove your own park list with the location and also look if you have visited it or not.\n");
                    Console.WriteLine("------------------------------------------------------------------------------------------------------------------------\n");

                    Console.WriteLine(String.Format("{0," + Console.WindowWidth / 2 + "}", "\tWhat would you like to do?\n"));
                    Console.WriteLine("\t1) Add a park");
                    Console.WriteLine("\t2) Remove a park");
                    Console.WriteLine("\t3) Mark a park as visited");
                    Console.WriteLine("\t4) See a list of all parks \n");

                    Console.WriteLine("\tChoose the option (1,2,3,4): ");

                    int choice = Convert.ToInt32(Console.ReadLine());

                    if (choice == 1)
                    {
                        Console.Clear();
                        Console.WriteLine("**Add a park**");

                        Console.Write("\nAdd Park name :");
                        string name = Console.ReadLine();

                        Console.Write($"\nAdd {name} Description :");
                        string description = Console.ReadLine();

                        Console.Write($"\nAdd {name} Location in the City:");
                        string location = Console.ReadLine();

                        Console.WriteLine($"\nHave you ever visited {name} [Press y for yes and n for no ] :");
                        bool visited = true;

                        if (Console.ReadLine().ToLower().Contains("y"))
                        {
                            visited = true;
                        }

                        parks.Add(new park(name, description, location, visited));

                        Loading();

                        Console.WriteLine($"\n\nNew park added to the list is: " + name);

                        Console.WriteLine("Press any key to RETURN TO MENU");
                        Console.ReadKey();

                    }
                    else if (choice == 2)
                    {
                        Console.Clear();
                        Console.WriteLine(String.Format("{0," + Console.WindowWidth / 2 + "}", "**Remove a park**"));

                        int count = 1;

                        foreach (var pk in parks)
                        {
                            Console.WriteLine($"\t {count}){pk.Name}");
                            count++;
                        }

                        Console.Write("\t\nChoose the number you want to remove: ");
                        int select; 
                        try
                        {
                            select = Convert.ToInt32(Console.ReadLine());
                            parks.RemoveAt(select - 1);

                        }
                        catch
                        {
                            Console.WriteLine("Please enter valid number!!");
                            Console.WriteLine("\t\nChoose the number you want to remove: ");
                            select = Convert.ToInt32(Console.ReadLine());
                            parks.RemoveAt(select - 1);
                        }

                        Loading();

                        Console.WriteLine("\nPark Removed Successfully!");
                        Console.WriteLine("Press any key to RETURN TO MENU");
                        Console.ReadKey();

                    }
                    else if (choice == 3)
                    {
                        Console.Clear();
                        Console.WriteLine(String.Format("{0," + Console.WindowWidth / 2 + "}", "**Mark a park visited**"));

                        int count = 1;

                        foreach (var pk in parks)
                        {
                            Console.WriteLine($"\t {count}){pk.Name}");
                            count++;
                        }

                        Console.Write("\t\nChoose the number you want to change it to visited: ");
                        int select = Convert.ToInt32(Console.ReadLine());
                        parks[select - 1].Visited = true;

                        Loading();

                        Console.WriteLine("Press any key to RETURN TO MENU");
                        Console.ReadKey();

                    }
                    else if (choice == 4)
                    {
                        Console.Clear();
                        Console.WriteLine(String.Format("{0," + Console.WindowWidth / 2 + "}", "**See the list of all the park**\n"));
                        Loading();

                            foreach (var pk in parks)

                            {
                                string visitedans = pk.Visited ? "Yes" : "No";
                                Console.WriteLine($"\n\n\t{pk.Name} \t {pk.Description} \t {pk.Location} \t {visitedans}");
                            }

                        Console.WriteLine("\nPress any key to RETURN TO MENU");
                        Console.ReadKey();

                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("Please choose a number from the given options i.e 1,2,3 or 4.");

                        Console.WriteLine("Press any key to RETURN TO MENU");
                        Console.ReadKey();
                    }

                }
            }
            catch
            {
                Console.WriteLine("Application Under Maintenence.");
            }
        }
 
    }
}