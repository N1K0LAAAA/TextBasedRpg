public class Program
{ 
    public static void Main(string[] args)
    {
        displayMenu();
       
       
       Console.ReadLine();

    }
    static void displayMenu()
    {
        Console.Clear();
        Console.WriteLine("1) Arena");
        Console.WriteLine("2) Shop");

           switch(Console.ReadKey().Key)
            {

                case ConsoleKey.D1:
                  displayArena();
                    break;

                case ConsoleKey.D2:
                    displayShop();
                break;
           }
    }
    static void displayArena()
    {
        Console.Clear();
        Console.WriteLine("Press Escape to go back to the main Menu");
        Console.WriteLine("1");

        switch (Console.ReadKey().Key)
        {
            case ConsoleKey.Escape:
                displayMenu();
                break;
        }
    }
    static void displayShop()
    {
        
        Console.Clear();
        Console.WriteLine("Press Escape to go back to the main Menu");
        Console.WriteLine("Shop Items");

        switch (Console.ReadKey().Key)
        {
            case ConsoleKey.Escape:
                displayMenu();
                break;
        }

    }
}