namespace Unity_들어가기전_마지막복습;

public class Loop
{
    // 조건문
    int playerHealth;
    int playerMaxHealth ;

    public Loop(int playerhealth, int playermaxhealth)
    {
        playerHealth = playerhealth;
        playerMaxHealth = playermaxhealth;
    }
    private Loop loop = new Loop(10, 20);
    
    public void Vif(Loop playerhealth, Loop playermaxhealth)
    {
        if (playerhealth == playermaxhealth) ;
        Console.WriteLine("Now you are Full HP");
    }

    public void ifelse(Loop playerhealth, Loop playermaxhealth, Loop a)
    {
        a = 0;
        if ((playerhealth = a) != null)
        {
            
        }
    }
}