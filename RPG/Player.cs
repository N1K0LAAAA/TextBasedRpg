
    public class Player
{
    string playerName;
    int playerHp;
    int playerAttack;
    int playerDefense;
    int playerMana;
    int playerLevel;
    int playerGold;

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
}