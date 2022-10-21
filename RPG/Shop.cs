public class Shop : View 
{
    public Shop() {
        return "emptyString";
    }

    public override void display(ViewController viewController) {

        Console.Clear();
        Console.WriteLine("Press Escape to go back to the main Menu");
        Console.WriteLine("Shop Items");

        switch (Console.ReadKey().Key) {
            case ConsoleKey.Escape:
                viewController.display("Menu");
                break;
        }

    }

}


