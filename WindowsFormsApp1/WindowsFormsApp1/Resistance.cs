using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class Resistance
    {
        public EnergyType energyType;
        public int value;

        public Resistance(EnergyType energyType, int value)
        {
            this.energyType = energyType;
            this.value = value;
        }
    }
}
