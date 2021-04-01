using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class EnergyType
    {
        public string Name;
        public int Value
        {
            get
            {
                switch(Name)
                {
                    case "Lightning":
                        return 60;
                    case "Fire":
                        return 50;
                    case "Fighting":
                        return 40;
                    case "Water":
                        return 30;
                    default:
                        return 0;
                }
            }
        }

        public EnergyType(string name)
        {
            Name = name;
        }
    }
}
