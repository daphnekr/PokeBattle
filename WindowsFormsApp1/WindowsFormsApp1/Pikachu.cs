using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{

    public class Pikachu : Pokemon
    {
        EnergyType lightningEnergyType = new EnergyType("Lightning");
        EnergyType fireEnergyType = new EnergyType("Fire");
        EnergyType fightingEnergyType = new EnergyType("Fighting");

        Attack electricRingAttack = new Attack("Electric Ring");
        Attack pikaPunchAttack = new Attack("Pika Punch");

        public Pikachu() : base("Pikachu", 60, true)
        {
            Weakness weakness = new Weakness(fireEnergyType, 1.5);
            Resistance resistance = new Resistance(fightingEnergyType, 20);

            energyType = lightningEnergyType;
            attack.Add(electricRingAttack);
            attack.Add(pikaPunchAttack);
            base.weakness = weakness;
            base.resistance = resistance;
        }

    }
}
