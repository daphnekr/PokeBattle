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
        Pokemon attackingPokemon = new Pokemon();
        Pokemon attackedPokemon = new Pokemon();
        Attack.attackName attacking;

        Pikachu pikachu = new Pikachu();
        Charmeleon charmeleon = new Charmeleon();
        List<Pokemon> pokemons = new List<Pokemon>();
        public Form1()
        {
            InitializeComponent();
            attackingPokemon = null;
            attackedPokemon = null;
            
            pikachuBtn.Text = pikachu.Name;
            pikachuAttack1Btn.Visible = false;
            pikachuAttack2Btn.Visible = false;
            pikachuAttack1Btn.Text = pikachu.Attacks[0].ToString();
            pikachuAttack2Btn.Text = pikachu.Attacks[1].ToString();

            charmeleonBtn.Text = charmeleon.Name;
            charmeleonAttack1Btn.Visible = false;
            charmeleonAttack2Btn.Visible = false;
            charmeleonAttack1Btn.Text = charmeleon.Attacks[0].ToString();
            charmeleonAttack2Btn.Text = charmeleon.Attacks[1].ToString();

            pokemons.Add(pikachu);
            pokemons.Add(charmeleon);

        }

        private void pikachuBtn_Click(object sender, EventArgs e)
        {
            pikachuBtn.BackColor = Color.Green;
            if(attackingPokemon == null)
            {
                attackingPokemon = pikachu;
                pikachuAttack1Btn.Visible = true;
                pikachuAttack2Btn.Visible = true;
                
            }
            else
            {
                pikachuBtn.BackColor = Color.Red;
                attackedPokemon = pikachu;
            }
            pikachuBtn.Enabled = false;
        }

        private void charmeleonBtn_Click(object sender, EventArgs e)
        {
            if (attackingPokemon == null)
            {
                charmeleonBtn.BackColor = Color.Green;
                attackingPokemon = charmeleon;
                charmeleonAttack1Btn.Visible = true;
                charmeleonAttack2Btn.Visible = true;
            }
            else
            {
                charmeleonBtn.BackColor = Color.Red;
                attackedPokemon = charmeleon;
            }
            charmeleonBtn.Enabled = false;
        }

        private void attackBtn_Click(object sender, EventArgs e)
        {
            attackedPokemon.Attack(attacking, attackingPokemon.Energytype);
            pokemonName.Text = attackedPokemon.Name + "'s health:";
            if(attackedPokemon.Health <= 0)
            {
                pokemonHealthLbl.Text = attackedPokemon.Name + " is dead!";
            }
            else
            {
                pokemonHealthLbl.Text = attackedPokemon.Health.ToString();
            }
            
            attackingPokemon = null;
            attackedPokemon = null;
            pikachuAttack1Btn.Visible = false;
            pikachuAttack2Btn.Visible = false;
            charmeleonAttack1Btn.Visible = false;
            charmeleonAttack2Btn.Visible = false;
            foreach (var button in this.Controls.OfType<Button>())
            {
                button.BackColor = Color.Empty;
                button.Enabled = true;
            }
        }

        private void pikachuAttack1Btn_Click(object sender, EventArgs e)
        {
            pikachuAttack1Btn.BackColor = Color.Green;
            attacking = pikachu.Attacks[0];
            pikachuAttack1Btn.Enabled = false;
        }

        private void pikachuAttack2Btn_Click(object sender, EventArgs e)
        {
            pikachuAttack2Btn.BackColor = Color.Green;
            attacking = pikachu.Attacks[1];
            pikachuAttack2Btn.Enabled = false;
        }

        private void charmeleonAttack1Btn_Click(object sender, EventArgs e)
        {
            charmeleonAttack1Btn.BackColor = Color.Green;
            attacking = charmeleon.Attacks[0];
            charmeleonAttack1Btn.Enabled = false;
        }

        private void charmeleonAttack2Btn_Click(object sender, EventArgs e)
        {
            charmeleonAttack2Btn.BackColor = Color.Green;
            attacking = charmeleon.Attacks[1];
            charmeleonAttack2Btn.Enabled = false;
        }

        private void getPopulationBtn_Click(object sender, EventArgs e)
        {
            Pokemon pokemon = new Pokemon();
            populationLbl.Text = "Currently alive: " + pokemon.getPopulation(pokemons);
        }
    }
}
