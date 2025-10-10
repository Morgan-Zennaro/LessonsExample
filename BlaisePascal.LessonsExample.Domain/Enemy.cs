namespace BlaisePascal.LessonsExample.Domain
{
    public class Enemy
    {
        public bool _isAlive;
        public string _description;
        private int _health;
        private string _name;
        public Enemy(string name, int health)
        {
            SetHealth(health);
            SetName(name);
        }
        public Enemy(int health)
        {
            SetHealth(health);
        }
        public Enemy(string name)
        {
            SetName(name);
        }
        public Enemy() { }
        public int Health { get; private set; }
        public string Name { get; private set; }
        public void TakeDamage (int damage)
        {
            if (int.IsPositive(damage) && Health - damage > 0)
            {
                Health -= damage;
            }
        }
    }
}
