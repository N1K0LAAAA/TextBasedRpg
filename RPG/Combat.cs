public class Combat
{
    Player player;
    Mob mob;

    public Combat(Player player, Mob mob)
    {
        this.player = player;
        this.mob = mob;
    }
        
    public void Fighting()
    {
        while (mob.alive() == true && player.alive() == true)
        {
            Console.WriteLine("Press 2 to attack");
            
            if (Console.ReadKey().Key == ConsoleKey.D2)
            {
                mob.Defend(player);
                player.Defend(mob);
                Console.WriteLine(player);
                Console.WriteLine(mob);
            }
         
            if (mob.alive() == false)
            {
                Console.WriteLine("You killed the Mob and earned " + mob.getGold() + " Gold and " + mob.getXP() + " Xp");
            }

            if (player.alive() == false)    
            {
                Console.WriteLine("You lost but you earned " + mob.getXP() + " Xp");
            }
         }
        
    }
}