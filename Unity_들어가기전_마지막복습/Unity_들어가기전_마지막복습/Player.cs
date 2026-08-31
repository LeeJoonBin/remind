namespace Unity_들어가기전_마지막복습;

public class Player: battleResult
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

    public void result(int HP, float RISK_PERCETAGE, int MaxHP, float INJURY)
    {
        float precentHP = (float)HP / MaxHP * 100;
        bool hasRisk = precentHP <= RISK_PERCETAGE;

        if (HP <= 0)
        {
            Console.WriteLine("전투 불가");
        }
        else if (hasRisk)
        {
            Console.WriteLine("체력 상태: 위독" + "[경고] 즉시 회복이 필요합니다.");
        }
        else if (precentHP <= INJURY)
        {
            Console.WriteLine("부상");
        }
        else
        {
            Console.WriteLine("양호");
        }
    }
}