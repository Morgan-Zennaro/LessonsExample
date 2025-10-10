namespace BlaisePascal.LessonsExample.Domain
{
    public class Enemy
    {
        public int Health { get; private set; }
        public string Name { get; private set; }
        public bool IsAlive { get; private set; };
        public string _description;
        public Enemy(string name, int health)
        {
            SetName(name);
            SetHealth(health);
            IsAlive = true;
        }
        public Enemy(int health)
        {
            SetHealth(health);
            IsAlive = true;
        }
        public Enemy(string name)
        {
            SetName(name);
            IsAlive = true;
        }
        public Enemy() 
        {
            IsAlive = true;
        }
        public int SetHealth(int newHealth)
        {
            if (int.IsPositive(newHealth) && newHealth <= 100)
                Health = newHealth;
            return Health;
        }
        public string SetName(string newName)
        {
            if (!string.IsNullOrWhiteSpace(newName))
                Name = newName;
            return Name;
        }
        // TODO: aggiungere possibilità di morte e robe varie boh non mi ricordo.
        public void TakeDamage (int damage)
        {
            if (int.IsPositive(damage) && Health - damage > 0)
            {
                Health -= damage;
            }
        }
    }
}
