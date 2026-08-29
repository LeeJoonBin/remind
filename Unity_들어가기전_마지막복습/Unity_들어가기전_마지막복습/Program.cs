using System;

class Program
{
    static void Main(string[] args)
    {
        const string DUNGEON_NANE= "얼음 협곡";
        const int MAX_HP = 250;
        const int PARTY_MEMBERS = 6;
        const int MIN_ENTER_LEVEL = 25;
        const float RISK_PERCENT = 30f;
        const float INJURY = 60f;
        const int NEXT_STAGE_COST = 1000;
        const int EXPERIENCE = 1250;
        
        string name = "JB";
        int level = 27;
        int hp = MAX_HP;
        int berrier = 40;
        int killCount = 0;
        int totalGold = 2350;
        float experiencePer = 1.5f;
        bool hasKey = true;
        bool killBoss = true;
        int command = 2;
        
            berrier -= 90;
            hp += berrier;
            berrier = berrier < 0 ? 0 : berrier;
            
            hp -= 132;
            
            killCount++;
            killCount++;
            killCount++;

            hp += 45;
            
            float percentHp = (float)hp / MAX_HP * 100;//체력 비율
            
            int personalGold = totalGold / PARTY_MEMBERS;//인당 골드 퍼센트
            int remainGlod = totalGold % PARTY_MEMBERS;//골드 분배 후에 남은 골드

            float getExperience = EXPERIENCE * experiencePer;//받은 경험치량

            bool hasRisk = percentHp <= RISK_PERCENT; //위험여부
            bool isUnstable = hasRisk || berrier == 0;//불안정 여부
            bool canEnter = level >= MIN_ENTER_LEVEL;//입장 레벨 이상인지
            
            string huntGrade = killCount >= 3 ? "정예 토벌" : "일반 토벌"; // 토벌등급
            int bunusGold = killBoss == true ? 500 : 0; // 보너스 골드
            
            int afterHuntingGold = personalGold + bunusGold; // 클리어 후 획득 골드량
            
            bool canEnterNextStage = afterHuntingGold >= NEXT_STAGE_COST; //통행료 지불 여부
            bool isNextStageReady = canEnter && hasKey && canEnterNextStage; //다음 층 준비 여부
            
            Console.WriteLine("[전투 판정]");

            if (hp <= 0)
            {
                Console.WriteLine("채력 상태: 전투 불능");
            }
            else if (hasRisk)
            { 
                Console.WriteLine("체력 상태: 위독" +
                                "[경고] 즉시 회복이 필요합니다.");
            }
            else if (percentHp <= INJURY)
            {
                Console.WriteLine("체력 상태: 부상");
            }
            else
            {
                Console.WriteLine("체력 상태: 양호");
            }

            if (canEnter || hasKey || canEnterNextStage)
            {
                if (!canEnter)
                {
                    Console.WriteLine("다음 층: 레벨이 부족합니다.");
                }

                if (canEnter && !hasKey)
                {
                    Console.WriteLine("다음 층: 던전 열쇠가 없습니다.");
                }

                if (hasKey && !canEnterNextStage)
                {
                    Console.WriteLine("다음 층: 통행료가 부족합니다. N골드가 더 필요합니다.");
                }

                if (isNextStageReady)
                {
                    int currentGold = afterHuntingGold - NEXT_STAGE_COST;
                    Console.WriteLine("다음 층:이동했습니다.");
                }
            }

            switch (command)
            {
                case 1:
                    Console.WriteLine("선택한 행동: 공격 태세를 유지합니다.");
                    break;
                case 2:
                    Console.WriteLine("선택한 행동: 방어 태세를 유지합니다.");
                    break;
                case 3:
                    Console.WriteLine("선택한 행동: 회복에 집중합니다.");
                    break;
                case 4:
                    Console.WriteLine("선택한 행동: 던저에서 나갑니다.");
                    break;
                default:
                    Console.WriteLine("선택한 행동: 알 수 없는 명령입니다.");
                    break;
            }
            
            Console.WriteLine("");
            Console.WriteLine($"=== {DUNGEON_NANE} ===");
            Console.WriteLine("");
            Console.WriteLine($"토벌자 {name} (Lv. {level})");
            Console.WriteLine($"보호막 {berrier}");
            Console.WriteLine($"처치수 {killCount}");
            Console.WriteLine($"등급 {huntGrade}");
            Console.WriteLine($"획득 경험치 {getExperience}");
            Console.WriteLine($"분배 골드 {personalGold} (남은 골드 {remainGlod})");
            Console.WriteLine($"보너스 골드 {bunusGold}");
            Console.WriteLine($"최종 골드 {afterHuntingGold}");
            Console.WriteLine($"불안정 상태 {isUnstable}");
            Console.WriteLine($"다음 층 준비 {isNextStageReady}");
            
            
    }
}