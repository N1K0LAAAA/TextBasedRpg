public class Menu : View
{
   public override void display(ViewController viewController)
    {
        Console.Clear();
        Console.WriteLine("1) Arena");
        Console.WriteLine("2) Shop");

        switch (Console.ReadKey().Key)
        {
            case ConsoleKey.D1:
                viewController.display("Arena");
                break;
            case ConsoleKey.D2:
                viewController.display("Shop");
                break;
        }
    }
    
}