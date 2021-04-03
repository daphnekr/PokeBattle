using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class Pokemon
    {
        public string name;
        public EnergyType energyType;
        public double maxHealth;
        private double health;
        public double Health
        {
            get { return health; }
            set { health = maxHealth; }
        }
        public List<Attack> attack = new List<Attack>();
        public Weakness weakness;
        public Resistance resistance;
        public bool isAlive;

        public Pokemon(string name, double maxHealth, bool isAlive)
        {
            this.name = name;
            this.maxHealth = maxHealth;
            this.isAlive = isAlive;
        }
        public Pokemon()
        {
        }
        public void Attack(Attack attack, Pokemon attackedPokemon)
        {
            if (attackedPokemon.weakness.energyType.name == attack.name)
            {
                double damage = attack.hitpoints * attackedPokemon.weakness.multiplier;
                attackedPokemon.health = attackedPokemon.health - damage;
            }
            else if(attackedPokemon.resistance.energyType.name == this.energyType.name)
            {
                double damage = attack.hitpoints - attackedPokemon.resistance.value;
                attackedPokemon.health = attackedPokemon.health - damage;
            }
            else
            {
                attackedPokemon.health = attackedPokemon.health - attack.hitpoints;
            }

            if(attackedPokemon.health <= 0)
            {
                attackedPokemon.isAlive = false;
            }
        }

        public int getPopulation(List<Pokemon> pokemon)
        {
            int currentlyAlive = pokemon.Where(x => x.isAlive == true).Count();
            return currentlyAlive;
        }
    }
}
