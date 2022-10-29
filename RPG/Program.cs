using System.ComponentModel.Design;

public class Program
{ 

    public static void Main(string[] args)
    {
        Mob mob1 = new Mob("Pillager", 6, 2, 0, 5, 5); 
        Mob mob2 = new Mob("Villager", 5, 3, 0, 5, 5);
        Mob mob3 = new Mob("Blacksmith", 10, 2, 1, 5, 5);

        Player player = new Player("Player", 2, 0, 0, 0, 0, 10);

        ViewController viewController = new ViewController();

        Mob[] mob = new Mob[3] { mob1, mob2, mob3 };
        int i = new Random().Next(0,3);

        viewController.addView("Menu", new Menu());
        viewController.addView("Arena", new Arena(1, "Village", player, mob[i]));
        viewController.addView("Shop", new Shop());
        viewController.display("Menu");


        /*  
        Arena arena2 = new Arena(2, "Desert");
        Arena arena3 = new Arena(3, "Mountain");
        Arena arena4 = new Arena(4, "Field");
        Arena arena5 = new Arena(5, "Forest");
        Arena arena6 = new Arena(6, "City");
        Arena arena7 = new Arena(7, "Ocean");
        Arena arena8 = new Arena(8, "Goblin cave");
        Arena arena9 = new Arena(9, "Zeppelin");
        Arena arena10 = new Arena(10, "Volcano"); 
        */
        

    }

}