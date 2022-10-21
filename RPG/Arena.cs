public class Arena : View {
    int currentArena;
    string arenaName;

    public Arena(int arenaLevel, string name) {
        currentArena = arenaLevel;
        arenaName = name;
    }

    public override void display(ViewController viewController) {
        Console.Clear();
        Console.WriteLine("Press Escape to go back to the main Menu");

        switch (Console.ReadKey().Key) {
            case ConsoleKey.Escape:
                viewController.display("Menu");
                break;
        }
    }
}
