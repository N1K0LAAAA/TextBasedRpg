using System.ComponentModel.Design;

public class Program
{ 
    
    public static void Main(string[] args)
    {
        IView Arena1;
        Arena1 = new Arena(1,"Arena");
        Arena1.display();
       
       
       Console.ReadLine();

    }


}