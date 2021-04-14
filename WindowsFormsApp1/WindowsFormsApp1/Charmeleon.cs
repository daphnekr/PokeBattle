using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class Charmeleon : Pokemon
    {
        public Charmeleon() : base("Charmeleon", 60)
        {
            Weakness weakness = new Weakness(EnergyType.energyTypeName.Water, 2);
            Resistance resistance = new Resistance(EnergyType.energyTypeName.Lighting, 10);

            Energytype = EnergyType.energyTypeName.Fire;
            Attacks.Add(WindowsFormsApp1.Attack.attackName.HeadButt);
            Attacks.Add(WindowsFormsApp1.Attack.attackName.Flare);
            Weakness = weakness;
            Resistance = resistance;
        }

    }
}
