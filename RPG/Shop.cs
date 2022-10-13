public class Shop : IView 
{
    int itemPrice;
    string itemName;

    public Shop(string name, int price)
    {
    itemName = name;
    itemPrice = price;
   
    }
    public void display()
    {

        Console.Clear();
        Console.WriteLine("Press Escape to go back to the main Menu");
        Console.WriteLine("Shop Items");

        switch (Console.ReadKey().Key)
        {
            case ConsoleKey.Escape:
                this.change();
                break;
        }

    }

}


