using System;

namespace MyGame
{
    public class Enemy
    {

        private string name;
        private float health;
        private float shield;

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