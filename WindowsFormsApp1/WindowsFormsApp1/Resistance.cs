using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class Resistance
    {
        public EnergyType EnergyType;
        public int Value;

        public Resistance(EnergyType energyType, int value)
        {
            EnergyType = energyType;
            Value = value;
        }
    }
}
