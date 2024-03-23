using System;

namespace MyGame
{
    class Program
    {
        static int enemyAmount;
        static Enemy[] enemies;

        static void Main(string[] args)
        {

            enemyAmount = int.Parse(args[0]);
            enemies = new Enemy[enemyAmount];

            for (int i = 0; i < enemyAmount; i++)
            {
                string enemyName;
                Console.Write("Choose the name of the enemy " + (i + 1) + ":");
                enemyName = Console.ReadLine();
                enemies[i] = new Enemy(enemyName);
            }
            for (int i = 0; i < enemies.Length; i++)
            {
                Console.WriteLine("{0} {1} {2}", enemies[i].GetName(), enemies[i].GetHealth(), enemies[i].GetShield());
            }
        }
    }
}