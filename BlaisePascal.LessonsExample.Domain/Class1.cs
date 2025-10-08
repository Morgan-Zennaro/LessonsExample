namespace BlaisePascal.LessonsExample.Domain
{
    public class Enemy
    {
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
            SetName("Enemy");
        }
        public Enemy(string name)
        {
            SetHealth(100);
            SetName(name);
        }
        public Enemy()
        {
            SetHealth(100);
            SetName("Enemy");
        }
        public void SetName (string newName)
        {
            if (!string.IsNullOrWhiteSpace(newName))
            {
                _name = newName;
            }
        }
        public void SetHealth (int newHealth)
        {
            if (int.IsPositive(newHealth) && newHealth <= 100)
            {
                _health = newHealth;
            }
        }
        public string GetName()
        {
            return _name;
        }
        public int GetHealth()
        {
            return _health;
        }
    }
}
