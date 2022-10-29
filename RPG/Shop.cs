public class Shop : View 
{
    public Shop()
    {
        
    }

    public override void display(ViewController viewController)
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("Press Escape to go back to the main Menu");
            Console.WriteLine("Shop Items");
            if (Console.ReadKey().Key == ConsoleKey.Escape)
            {
                viewController.display("Menu");
                    break;
            }
        }
    }
}
