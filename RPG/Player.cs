
public class Player
{

    private string playerName;
    private int playerAttack;
    private int playerDefense;
    private int playerMana;
    public int playerHp { get; set; }
    private int playerXp;
    private int playerGold;
    public int playerMaxHp { get; set; }


    public Player(string name, int attack, int defence, int mana, int xp, int gold, int hp)
    {
        playerName = name;
        playerHp = hp;
        playerAttack = attack;
        playerDefense = defence;
        playerMana = mana;
        playerXp = xp;
        playerGold = gold;
        playerMaxHp = playerHp;
        
       
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
        int actualAttack = mob.getAttack() - (playerDefense - 0); 
        playerHp -= actualAttack;
    }
 
    public bool alive() 
    {
        return this.playerHp > 0;
    }
    }
    
