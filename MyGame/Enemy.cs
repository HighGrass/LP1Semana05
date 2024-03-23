using System;

namespace MyGame
{
    public class Enemy
    {

        private string name;
        private float health;
        private float shield;
        public int enemyPowerUps;

        [Flags] public enum PowerUp { health = 1 << 0, shield = 1 << 1 }

        public Enemy(string name)
        {
            SetName(name);
            health = 100;
            shield = 0;
        }

        public void TakeDamage(float damage)
        {
            shield -= damage;
            if (shield < 0)
            {
                float damageStillToInflict = -shield;
                shield = 0;
                health -= damageStillToInflict;
                if (health < 0) health = 0;
            }
        }

        public void PickupPowerUp(PowerUp powerUp, float f)
        {
            if (powerUp == PowerUp.health)
            {
                health += f;
            }
            else if (powerUp == PowerUp.shield)
            {
                shield += f;
            }
            else if (powerUp == (PowerUp.health & PowerUp.shield))
            {

                health += f;
                shield += f;
            }

            if (health > 100f) health = 100f;
            if (shield > 100f) shield = 100f;

            enemyPowerUps++;

        }
        public string GetName()
        {
            return name;
        }

        public float GetHealth()
        {
            return health;
        }

        public void SetName(string nameGet)
        {
            if (nameGet.Length > 8) return;
            this.name = nameGet;
        }

        public float GetShield()
        {
            return shield;
        }

    }
}