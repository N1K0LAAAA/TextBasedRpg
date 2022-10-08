//Player Stats
class Player
{
    string Name;
    int PlayerHp = 10;
    int PlayerAttack = 2;
    int PlayerDefense = 0;
    int PlayerMana = 0;
    int PlayerLevel = 0;
    int PlayerGold = 0;

    public Player(string PlayerName, int Attack, int Defence, int Mana, int Level, int Gold)
    {
        Name = PlayerName;
        PlayerAttack = Attack;
        PlayerDefense = Defence;
        PlayerMana = Mana;
        PlayerLevel = Level;
        PlayerGold = Gold;
    }
}