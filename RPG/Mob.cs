
public class Mob
{

    string mobName;
    private int mobHp;
    private int mobAttack;
    private int mobDefence;
    private int mobXp;
    private int mobGold;


    public Mob(string name, int hp, int attack, int defence, int xp, int gold)
    {
        mobName = name;
        mobAttack = attack;
        mobDefence = defence;
        mobHp = hp;
        mobXp = xp;
        mobGold = gold;

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
    public int getXP()
    {
       Random r = new Random();
        int x = r.Next(0,10);
        return  mobXp + x;
         
    }
    public int getGold()
    {
        Random r = new Random();
        int x = r.Next(0,10);
        return  mobGold + x;
    }

    public bool alive()
    {
        return this.mobHp > 0;
    }
} 

