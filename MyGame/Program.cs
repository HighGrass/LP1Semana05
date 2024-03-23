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
                Console.Write("Say the name of the enemy {0}: ", i + 1);
                enemyName = Console.ReadLine();

                if (enemyName.Length > 8 || enemyName.Length < 1)
                {
                    Console.WriteLine("Choose a name between 1-8 digits!");
                    i--;
                }
                else
                {

                    enemies[i] = new Enemy(enemyName);
                }

            }


            for (int i = 0; i < enemies.Length; i++)
            {
                Console.WriteLine("{0} {1} {2}", enemies[i].GetName(), enemies[i].GetHealth(), enemies[i].GetShield());
            }
        }
    }
}