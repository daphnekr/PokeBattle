using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{

    public class Pikachu : Pokemon
    {
        public Pikachu() : base("Pikachu", 60)
        {
            Weakness weakness = new Weakness(EnergyType.energyTypeName.Fire, 1.5);
            Resistance resistance = new Resistance(EnergyType.energyTypeName.Fighting, 20);

            Energytype = EnergyType.energyTypeName.Lighting;
            Attacks.Add(WindowsFormsApp1.Attack.attackName.ElectricRing);
            Attacks.Add(WindowsFormsApp1.Attack.attackName.PikaPunch);
            Weakness = weakness;
            Resistance = resistance;
        }

    }
}
