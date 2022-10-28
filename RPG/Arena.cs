public class Arena : View
{
    int arena1bis10;
    string arenaName;
    Player player;
    Mob mob;
    Combat combat;

    public Arena(int arenaLevel, string name, Player player, Mob mob)
    {
        arena1bis10 = arenaLevel;
        arenaName = name;
        this.player = player;
        this.mob = mob;
        combat = new Combat(player,mob);
    }
    public override void display(ViewController viewController)
    {
        Console.Clear();
        Console.WriteLine("Press Escape to go back to the main Menu");
        Console.WriteLine("1) Village");
        

        switch (Console.ReadKey().Key)
        {
            case ConsoleKey.Escape:
                viewController.display("Menu");
                break;
             case ConsoleKey.D1:
                viewController.display("Village");
                 break;
        }
    } 
    

}
