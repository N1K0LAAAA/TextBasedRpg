public class Program
{ 
    public static void Main(string[] args)
    {
        Mob sheep = new Mob("Sheep", 4, 1, 0);
        Player hs = new Player("Player", 10, 2, 0, 0, 0, 0);
        Console.WriteLine(sheep);
        Console.ReadLine();
        
      // Console.WriteLine(sheep.mobName + " has " + sheep.mobHp + " Health " + sheep.mobAttack + " Attack and " + sheep.mobDefence + " Defence");
       // Console.WriteLine(hs.playerName);
    }
}