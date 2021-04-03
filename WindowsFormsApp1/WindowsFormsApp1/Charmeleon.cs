using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class Charmeleon : Pokemon
    {
        EnergyType lightningEnergyType = new EnergyType("Lightning");
        EnergyType fireEnergyType = new EnergyType("Fire");
        EnergyType fightingEnergyType = new EnergyType("Fighting");
        EnergyType waterEnergyType = new EnergyType("Water");

        Attack headButtAttack = new Attack("Head Butt");
        Attack flareAttack = new Attack("Flare");

        public Charmeleon() : base("Charmeleon", 60, true)
        {
            Weakness weakness = new Weakness(waterEnergyType, 2);
            Resistance resistance = new Resistance(lightningEnergyType, 10);

            energyType = fireEnergyType;
            attack.Add(headButtAttack);
            attack.Add(flareAttack);
            base.weakness = weakness;
            base.resistance = resistance;
        }

    }
}
