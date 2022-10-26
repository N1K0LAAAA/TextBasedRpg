
    public class Player
{
<<<<<<< Updated upstream
<<<<<<< Updated upstream
    string playerName;
    int playerHp;
    int playerAttack;
    int playerDefense;
    int playerMana;
    int playerLevel;
    int playerGold;
=======
=======
>>>>>>> Stashed changes
    private string playerName;
    private int playerHp;
    private int playerAttack;
    private int playerDefense;
    private int playerMana;
    private int playerLevel;
    private int playerGold;
<<<<<<< Updated upstream
>>>>>>> Stashed changes
=======
>>>>>>> Stashed changes

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
<<<<<<< Updated upstream
=======
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
        int actualAttack = mob.getAttack() - (mobDefence - 2);
        playerHp =- actualAttack;
    }
   

>>>>>>> Stashed changes
}