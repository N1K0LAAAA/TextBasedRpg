public class Arena : View
{
    int arena1bis10;
    string arenaName;

    public Arena(int arenaLevel, string name)
    {
        arena1bis10 = arenaLevel;
        arenaName = name;
    }
    public override void display(ViewController viewController)
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("Press Escape to go back to the main Menu");

            if (Console.ReadKey().Key == ConsoleKey.Escape)
            {
                viewController.display("Menu");
                    break;
            }
        }
    }
}
