using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class Attack
    {
        public string Name;
        public int Hitpoints
        {
            get
            {
                switch(Name)
                {
                    case "Electric Ring":
                        return 50;
                    case "Pika Punch":
                        return 20;
                    case "Head Butt":
                        return 10;
                    case "Flare":
                        return 30;
                    default:
                        return 0;

                }
            }
        }

        public Attack(string name)
        {
            Name = name;
        }


    }
}
