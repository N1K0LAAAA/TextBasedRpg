public class Menu : IView
{
   public void display()
    {
        Console.Clear();
        Console.WriteLine("1) Arena");
        Console.WriteLine("2) Shop");

        switch (Console.ReadKey().Key)
        {

            case ConsoleKey.D1:
                Arena1.display();
                break;

            case ConsoleKey.D2:
                display();
                break;
        }
    }
    
}