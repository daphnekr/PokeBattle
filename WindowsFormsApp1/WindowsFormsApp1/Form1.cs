using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        // pokemons list
        List<Pokemon> pokemons = new List<Pokemon>();
        public Form1()
        {
            InitializeComponent();

            // energytypes
            EnergyType lightningEnergyType = new EnergyType("Lightning");
            EnergyType fireEnergyType = new EnergyType("Fire");
            EnergyType fightingEnergyType = new EnergyType("Fighting");
            EnergyType waterEnergyType = new EnergyType("Water");


            // attacks
            Attack electricRingAttack = new Attack("Electric Ring");
            Attack pikaPunchAttack = new Attack("Pika Punch");
            Attack headButtAttack = new Attack("Head Butt");
            Attack flareAttack = new Attack("Flare");


            // pikachu
            List<Attack> pikachuAttackList = new List<Attack>();
            pikachuAttackList.Add(electricRingAttack);
            pikachuAttackList.Add(pikaPunchAttack);
            Weakness pikachuWeakness = new Weakness(fireEnergyType, 1.5);
            Resistance pikachuResistance = new Resistance(fightingEnergyType, 20);
            
            Pokemon pikachu = new Pokemon("Pikachu", lightningEnergyType, 200, pikachuAttackList, pikachuWeakness, pikachuResistance);
            


            // charmeleon
            List<Attack> charmeleonAttackList = new List<Attack>();
            charmeleonAttackList.Add(headButtAttack);
            charmeleonAttackList.Add(flareAttack);
            Weakness charmeleonWeakness = new Weakness(waterEnergyType, 2);
            Resistance charmeleonResistance = new Resistance(lightningEnergyType, 10);

            Pokemon charmeleon = new Pokemon("Charmeleon", fireEnergyType, 200, charmeleonAttackList, charmeleonWeakness, charmeleonResistance);

            // add pokemons to list
            pokemons.Add(pikachu);
            pokemons.Add(charmeleon);
        }

        private void getPokemons_Click(object sender, EventArgs e)
        {
        }
    }
}
