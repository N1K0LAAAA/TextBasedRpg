
public class Mob
{

    string mobName;
    private int mobHp;
    private int mobAttack;
    private int mobDefence;

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

    public int getAttack() 
    {
        return this.mobAttack;
    }

    public void Defend(Player player)
    { 
        int actualAttack =player.getAttack() - (mobDefence - 0);
        mobHp -= actualAttack;
    }

    public bool alive()
    {
        return this.mobHp > 0;
    }
} 

