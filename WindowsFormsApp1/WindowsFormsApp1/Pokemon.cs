using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class Pokemon
    {
        //heeft een naam
        //heeft een EnergyType
        //heeft hitpoints(maximum health)
        //heeft health die bij de geboorte gelijk is aan de waarde van de hitpoints
        //heeft 1 of meerdere Attacks
        //heeft een Weakness
        //heeft een Resistance
        //kan een andere Pokemon aanvallen met een Attack
        //de schade van een Attack wordt vermenigvuldigd met de multiplier van de Weakness indien de EnergyType van de Weakness gelijk is aan de EnergyType van de aanvallende Pokemon
        //de schade van een Attack wordt verminderd met de waarde van de Resistance indien de EnergyType van de Resistance gelijk is aan de EnergyType van de aanvallende Pokemon
        //kan schade krijgen van een andere Pokemon als resultaat van een Attack
        //de totale schade van een Attack wordt verminderd op de health van de Pokemon die wordt aangevallen
        public string Name;
        public EnergyType EnergyType;
        public int MaxHealth;
        public int Healthpoints;
        public List<Attack> Attack;
        public Weakness Weakness;
        public Resistance Resistance;

        public Pokemon(string name, EnergyType energyType, int maxHealth, List<Attack> attack, Weakness weakness, Resistance resistance)
        {
            Name = name;
            EnergyType = energyType;
            MaxHealth = maxHealth;
            Attack = attack;
            Weakness = weakness;
            Resistance = resistance;
        }
    }
}
