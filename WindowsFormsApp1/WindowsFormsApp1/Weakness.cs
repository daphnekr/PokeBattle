using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class Weakness
    {
        public EnergyType EnergyType;
        public double Multiplier;

        public Weakness(EnergyType energyType, double multiplier)
        {
            EnergyType = energyType;
            Multiplier = multiplier;
        }
    }
}
