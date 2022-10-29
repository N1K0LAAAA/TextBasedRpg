
public class Player
{

    private string playerName;
    private int playerHp;
    private int playerAttack;
    private int playerDefense;
    private int playerMana;
    private int playerLevel;
    private int playerGold;


    public Player(string name, int attack, int defence, int mana, int level, int gold, int hp)
    {
        playerName = name;
        playerHp = hp;
        playerAttack = attack;
        playerDefense = defence;
        playerMana = mana;
        playerLevel = level;
        playerGold = gold;
        
    }

    public override string ToString()
    {
        return playerName + " has " + playerHp + " Health " + playerAttack + " Attack and " + playerDefense + " Defence";

    }

    public int getAttack()
    {
       return this.playerAttack;
    }

    public void Defend(Mob mob)
    {
        int actualAttack = mob.getAttack() - (playerDefense - 1);
        playerHp -= actualAttack;
    }

    public bool alive() 
    {
        return this.playerHp > 0;
    }
}
