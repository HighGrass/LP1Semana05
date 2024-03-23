using System;
using System.Collections;

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
                else enemies[i] = new Enemy(enemyName);
            }

            for (int i = 0; i < enemies.Length; i++)
            {
                Console.Write("Want to PowerUp Enemy " + enemies[i].GetName() + "? (y/n)");
                string answer = Console.ReadLine();
                if (answer == "n") continue;
                else if (answer == "y") PowerUpEnemy(i);

            }

            for (int i = 0; i < enemies.Length; i++)
            {
                enemies[i].TakeDamage(10);
                Console.WriteLine("{0} {1} {2}", enemies[i].GetName(), enemies[i].GetHealth(), enemies[i].GetShield());
            }


        }

        static private void PowerUpEnemy(int enemyID)
        {

            Console.Write("How much do you want to powerup health? ");
            int healthPowerUp = int.Parse(Console.ReadLine());
            Console.Write("How much do you want to powerup shield? ");
            int shieldPowerUp = int.Parse(Console.ReadLine());

            Enemy.PowerUp whichPowerup;
            if (healthPowerUp != 0) if (shieldPowerUp == 0)
                {
                    whichPowerup = Enemy.PowerUp.health;
                    enemies[enemyID].PickupPowerUp(whichPowerup, healthPowerUp);
                }
            if (shieldPowerUp != 0) if (healthPowerUp == 0)
                {
                    whichPowerup = Enemy.PowerUp.shield;
                    enemies[enemyID].PickupPowerUp(whichPowerup, shieldPowerUp);
                }
            if (healthPowerUp != 0 && shieldPowerUp != 0)
            {
                whichPowerup = Enemy.PowerUp.health & Enemy.PowerUp.shield;
                enemies[enemyID].PickupPowerUp(whichPowerup, shieldPowerUp);
            }


        }
    }
}