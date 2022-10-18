

public class Mob
{

    string mobName;
    int mobHp;
    int mobAttack;
    int mobDefence;

    public Mob(string name, int hp, int attack, int defence)
    {
        mobName = name;
        mobAttack = attack;
        mobDefence = defence;
        mobHp = hp;
    }
    public override string ToString()
    {
        return mobName + " has " + mobHp + " Health " + mobAttack + " Attack and " + mobDefence + " Defence";

    }

    public void mob_death()
    {
        if (mobHp == 0)
        {
            Console.WriteLine("You killed the mob, he dropped 10 coins and 5 xp");
        }
    }
}
