using System;
using System.Configuration;
using System.IO;


namespace ADO.Net3
{
    internal class Program
    {
        

        static void Main()
        {

            string  connectionString = ConfigurationManager.ConnectionStrings["SportShopDbConnection"]
                .ConnectionString;
            SportShopApp app = new SportShopApp(connectionString);
            bool exit = false;
            while (!exit)
            {
                Console.WriteLine("Choose an operation:");
                Console.WriteLine("1. Add a new sale");
                Console.WriteLine("2. Show all sales within a period");
                Console.WriteLine("3. Show the last purchase of a client");
                Console.WriteLine("4. Delete an employee or client");
                Console.WriteLine("5. Show the employee with the highest sales amount");
                Console.WriteLine("6. Exit");

                var choice = Console.ReadLine();
                switch (choice)
                {
                    case "1":
                        app.AddSale();
                        break;
                    case "2":
                        app.ShowSallesByPeriod();
                        break;
                    case "3":
                        app.ShowLastPurchase();
                        break;
                    case "4":
                        app.DeletePerson();
                        break;
                    case "5":
                        app.ShowTopSeller();
                        break;
                    case "6":
                        exit = true;
                        break;
                    default:
                        Console.WriteLine("Invalid choice.");
                        break;
                }
            }
        }

        
    }
}

