

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
<<<<<<< Updated upstream
<<<<<<< Updated upstream
}
=======
=======
>>>>>>> Stashed changes
         public int getAttack()
    {
        return this.mobAttack;
    }

   public void Defend(Player player)
    {
        int actualAttack =player.getAttack() - (mobDefence - 2);
        mobHp =- actualAttack;
    }
} 

<<<<<<< Updated upstream
>>>>>>> Stashed changes
=======
>>>>>>> Stashed changes
