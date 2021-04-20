using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class Pokemon
    {
        private string name;
        public string Name 
        {
            get { return name; }
            set { name = value; }
        }
        private EnergyType.energyTypeName energyType;
        public EnergyType.energyTypeName Energytype
        {
            get { return energyType; }
            set { energyType = value; }
        }
        private double maxHealth;
        private double health;
        public double Health
        {
            get { return health; }
            set { health = value; }
        }
        private List<Attack.attackName> attacks = new List<Attack.attackName>();
        public List<Attack.attackName> Attacks
        {
            get { return attacks; }
            set { attacks = value; }
        }
        private Weakness weakness;
        public Weakness Weakness
        {
            get { return weakness; }
            set { weakness = value; }
        }
        private Resistance resistance;
        public Resistance Resistance
        {
            get { return resistance; }
            set { resistance = value; }
        }
        private bool isAlive = true;

        public Pokemon(string name, double maxHealth)
        {
            this.name = name;
            this.maxHealth = maxHealth;
            Health = this.maxHealth;
        }
        public Pokemon()
        {
        }
        public void Attack(Attack.attackName attack, EnergyType.energyTypeName energyTypeAttackingPok)
        {
            Damage(attack, energyTypeAttackingPok);
        }
        public void Damage(Attack.attackName attack, EnergyType.energyTypeName energyTypeAttackingPok)
        {
            if (weakness.Energytype == energyTypeAttackingPok)
            {
                double damage = (int)attack * weakness.Multiplier;
                Health = Health - damage;
            }
            else if (resistance.Energytype == energyTypeAttackingPok)
            {
                double damage = (int)attack - resistance.Value1;
                Health = Health - damage;
            }
            else
            {
                Health = Health - (int)attack;
            }

            if (Health <= 0)
            {
                isAlive = false;
            }
        }

        public int getPopulation(List<Pokemon> pokemon)
        {
            return pokemon.Where(x => x.isAlive == true).Count();
        }
    }
}
