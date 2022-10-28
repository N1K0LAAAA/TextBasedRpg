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
            mob.Defend(player);
            player.Defend(mob);
            Console.WriteLine(player);
            Console.WriteLine(mob);


            if (mob.alive() == false)
            {
                Console.WriteLine("You killed the Mob and earned 10 Gold");
            }
            if (player.alive() == false)
            {
                Console.WriteLine("You lost");
            }
         }
        
    }
}