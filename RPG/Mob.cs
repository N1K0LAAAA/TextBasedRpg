

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

}
