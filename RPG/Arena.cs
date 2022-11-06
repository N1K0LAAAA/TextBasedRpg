public class Arena : View
{
    int stage;
    string name;
    Player player;
    Mob mob;
    Combat combat;

    public Arena(int arenaLevel, string arenaName, Player player, Mob mob)
    {
        this.stage = arenaLevel;
        this.name = arenaName;
        this.player = player;
        this.mob = mob;
        this.combat = new Combat(player, mob);
    }
    public override void display(ViewController viewController)
    {
        while(true)
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
                    Console.Clear();
                    combat.Fighting();
                    Console.WriteLine("Press Escape to go back to main menu");
                    player.playerHp = player.playerMaxHp;
                    mob.mobHp = mob.mobMaxHp;
                    while(true)
                    { 
                      if(Console.ReadKey().Key == ConsoleKey.Escape )
                      {
                        viewController.display("Menu");
                      }
                    }
                    
            }
        }
    } 
    

}
