
public class Player
{
    
    private string playerName;
    private int playerHp;
    private int playerAttack;
    private int playerDefense;
    private int playerMana;
    private int playerXp;
    public int PlayerXp
  
    {
    get { return playerXp;}
    set { playerXp = value;}
    }
    private int playerGold;
    public int PlayerGold 
    {
    get { return playerGold;}
    set {  playerGold = value;}
    }

    public Player(string name, int attack, int defence, int mana, int xp, int gold, int hp)
    {
        playerName = name;
        playerHp = hp;
        playerAttack = attack;
        playerDefense = defence;
        playerMana = mana;
        playerXp = xp;
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
        int actualAttack = mob.getAttack() - (playerDefense - 0); 
        playerHp -= actualAttack;
    }
 
    public bool alive() 
    {
        return this.playerHp > 0;
    }


}
