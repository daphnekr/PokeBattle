using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class Weakness
    {
        public EnergyType energyType;
        public double multiplier;

        public Weakness(EnergyType energyType, double multiplier)
        {
            this.energyType = energyType;
            this.multiplier = multiplier;
        }
    }
}
