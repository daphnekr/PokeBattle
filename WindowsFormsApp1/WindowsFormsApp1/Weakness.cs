using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class Weakness
    {
        private EnergyType.energyTypeName energyType;
        public EnergyType.energyTypeName Energytype
        {
            get { return energyType; }
            set { energyType = value; }
        }
        private double multiplier;
        public double Multiplier
        {
            get { return multiplier; }
            set { multiplier = value; }
        }

        public Weakness(EnergyType.energyTypeName energyType, double multiplier)
        {
            this.Energytype = energyType;
            this.Multiplier = multiplier;
        }
    }
}
