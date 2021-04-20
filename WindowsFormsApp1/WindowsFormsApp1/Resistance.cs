using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class Resistance
    {
        private EnergyType.energyTypeName energyType;
        public EnergyType.energyTypeName Energytype
        {
            get { return energyType; }
            set { energyType = value; }
        }
        private int value1;
        public int Value1
        {
            get { return value1; }
            set { value1 = value; }
        }

        public Resistance(EnergyType.energyTypeName energyType, int value)
        {
            this.Energytype = energyType;
            this.Value1 = value;
        }
    }
}
