public class Arena : IView
{
    int arena1bis10;
    string arenaName;

    public Arena(int arenaLevel, string name)
    {
        arena1bis10 = arenaLevel;
        arenaName = name;
    }
    public void display()
    {
        Console.Clear();
        Console.WriteLine("Press Escape to go back to the main Menu");
        Console.WriteLine("1");

        switch (Console.ReadKey().Key)
        {
            case ConsoleKey.Escape:
                break;
        }
    }
    

}
