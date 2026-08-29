namespace Unity_들어가기전_마지막복습;

public class Player
{
    protected string name{get; private set;}
    protected int level { get; private set;}
    protected int hp {get; private set;}
    protected int barriers {get; private set;}
    protected int killCount {get; private set;}
    protected int totalGold {get; private set;}
    protected float experiencPercentage {get; private set;}
    protected bool hasKey {get; private set;}
    protected bool killBoss {get; private set;}

    public Player(string name, int level, int hp, int barriers, float experiencPercentage, bool hasKey, bool killBoss)
    {
        this.name = name;
        this.level = level;
        this.hp = hp;
        this.barriers = barriers;
        this.experiencPercentage = experiencPercentage;
        this.hasKey = hasKey;
        this.killBoss = killBoss;
    }
    
    
}