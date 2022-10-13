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
    }

}