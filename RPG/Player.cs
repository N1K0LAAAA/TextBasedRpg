
public class Player {
    string playerName;
    int playerHp;
    int playerAttack;
    int playerDefence;
    int playerMana;
    int playerLevel;
    int playerGold;

    public Player(string name, int attack, int defence, int mana, int level, int gold, int hp) {
        playerName = name;
        playerHp = hp;
        playerAttack = attack;
        playerDefence = defence;
        playerMana = mana;
        playerLevel = level;
        playerGold = gold;
    }

    public override string ToString() {
        return playerName + " has " + playerHp + " hp, " + playerAttack + " attack and " + playerDefence + " defence";
    }

    /*
    * This method is used to display the player's stats
    * If you don't want to use this method, please make individual getters for each stat
    */
    public int[] getStats() { // stats[0] = hp...
        int[] stats = { playerHp, playerAttack, playerDefence, playerMana, playerLevel, playerGold };
        return stats;
    }

    public void setStats(int hp, int attack, int defence, int mana, int level, int gold) {
        playerHp = hp;
        playerAttack = attack;
        playerDefence = defence;
        playerMana = mana;
        playerLevel = level;
        playerGold = gold;
    }

    public void addStats(int newHP = 0, int newAttack = 0, int newDefence = 0, int newMana = 0, int newLevel = 0, int newGold = 0) {
        setStats(playerHp + newHP, playerAttack + newAttack, playerDefence + newDefence, playerMana + newMana, playerLevel + newLevel, playerGold + newGold);
    }

    public void doAttack(Mob mob) {
        mob.mobHp -= playerAttack;
    }

    public void doDefend(Mob mob) {
        playerHp -= mob.mobAttack - playerDefence;
    }

    // public void addMana(int newMana) {
    //     playerMana += newMana;
    // }

    // public void removeMana(int newMana) {
    //     playerMana -= newMana;
    // }

    // public void addHp(int newHP) {
    //     playerHp += newHP;
    // }

    // public void removeHp(int newHP) {
    //     playerHp -= newHP;
    // }

    // public void addGold(int newGold) {
    //     playerGold += newGold;
    // }

    // public void removeGold(int newGold) {
    //     playerGold -= newGold;
    // }

    // public void addAttack(int newAttack) {
    //     playerAttack += newAttack;
    // }

    // public void removeAttack(int newAttack) {
    //     playerAttack -= newAttack;
    // }

    // public void addDefence(int newDefence) {
    //     playerDefence += newDefence;
    // }

    // public void removeDefence(int newDefence) {
    //     playerDefence -= newDefence;
    // }

    // public void addLevel(int newLevel) {
    //     playerLevel += newLevel;
    // }

    // public void removeLevel(int newLevel) {
    //     playerLevel -= newLevel;
    // }
}