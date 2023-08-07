using RecipeAppPart2;

public class Program
{
    private static void Main(string[] args)
    {

        Recipe recipe = new Recipe();

        Console.BackgroundColor = ConsoleColor.Blue;
        Console.Clear();

        Console.WriteLine("This is a blue background!");

        Console.BackgroundColor = ConsoleColor.Black; // Reset the background color to default (black)
        Console.ForegroundColor = ConsoleColor.White; // Set the foreground color to white

        Console.WriteLine("This is the default background color.");

        Console.ReadLine();

        while (true)
        {
            Console.WriteLine("1. Enter recipe details");
            Console.WriteLine("2. Display recipe");
            Console.WriteLine("3. Scale recipe");
            Console.WriteLine("4. Reset quantities");
            Console.WriteLine("5. Clear all data");
            Console.WriteLine("6. Exit");
            Console.WriteLine("Select an option: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    recipe.EnterDetails();
                    break;
                case "2":
                    recipe.Display();
                    break;
                case "3":
                    recipe.Scale();
                    break;
                case "4":
                    recipe.ResetQuantities();
                    break;
                case "5":
                    recipe.ClearData();
                    break;
                case "6":
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
    }
}

