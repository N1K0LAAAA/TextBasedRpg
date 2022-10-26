
    public class Player
{
    string playerName;
    private int playerHp;
    int playerAttack;
    int playerDefense;
    int playerMana;
    int playerLevel;
    int playerGold;

    public Player(string name, int attack, int defence, int mana, int xp, int gold, int hp)
    {
        playerName = name;
        playerHp = hp;
        playerAttack = attack;
        playerDefense = defence;
        playerMana = mana;
        playerLevel = xp;
        playerGold = gold;
        
    }
    public override string ToString()
    {
        return playerName + " has " + playerHp + " Health " + playerAttack + " Attack and " + playerDefense + " Defence";

    }



}