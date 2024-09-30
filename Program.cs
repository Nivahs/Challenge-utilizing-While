using System;
using System.Threading;


//AMBIENTE DE ESTUDO

Console.WriteLine("Welcome my hero");

Random random = new Random();
int healthHero = 10;
int healthMonster = 10;

while (healthHero > 0 && healthMonster > 0){
    int randomHero = random.Next(1, 11);
    int randomMonster = random.Next(1, 11);

    healthMonster -= randomHero;
    Console.WriteLine($"Monster was damaged and lost {randomHero} health and now has {healthMonster} health.");
    Thread.Sleep(3000);
        if (healthMonster <= 0){
            Console.WriteLine("Hero Win");
            break;
        }

    healthHero -= randomMonster;
    Console.WriteLine($"Hero was damaged and lost {randomMonster} health and now has {healthHero} health.");
    Thread.Sleep(3000);
        if (healthHero <= 0){
            Console.WriteLine("Monster Win");
            break;
        }

}
