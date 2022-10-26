using System.ComponentModel.Design;

public class Program
{ 
    public static void Main(string[] args)
    {
        ViewController viewController = new ViewController();

        viewController.addView("Menu", new Menu());
        viewController.addView("Arena", new Arena(1, "Arena"));
        viewController.addView("Shop", new Shop());

        viewController.display("Menu");


        Mob mob1 = new Mob("Hurensohn", 5, 1, 0); 

        Player player = new Player("Player", 2, 0, 0, 0, 0, 10);

        Arena arena1 = new Arena(1, "Village");
        Arena arena2 = new Arena(2, "Desert");
        Arena arena3 = new Arena(3, "Mountain");
        Arena arena4 = new Arena(4, "Field");
        Arena arena5 = new Arena(5, "Forest");
        Arena arena6 = new Arena(6, "City");
        Arena arena7 = new Arena(7, "Ocean");
        Arena arena8 = new Arena(8, "Goblin cave");
        Arena arena9 = new Arena(9, "Zeppelin");
        Arena arena10 = new Arena(10, "Volcano");

    }

}