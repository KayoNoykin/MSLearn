Random random = new Random();
int atk;
int heroHP = 10;
int monsterHP = 10;

while (heroHP > 0 && monsterHP > 0)
{
    // hero attacks
    atk = random.Next(1, 11);
    monsterHP -= atk;
    Console.WriteLine($"Monster was damaged and lost {atk} health and now has {monsterHP} health.");
    if (monsterHP <= 0)
    {
        Console.WriteLine("Hero wins!");
        break;
    }
    // monster attacks
    atk = random.Next(1, 11);
    heroHP -= atk;
    Console.WriteLine($"Hero was damage and lost {atk} health and now has {heroHP} health.");
    if (heroHP <= 0)
    {
        Console.WriteLine("Monster wins!");
        break;
    }
    

}