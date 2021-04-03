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
        //List<Pokemon> pokemons = new List<Pokemon>();
        //List<Attack> pikachuAttackList = new List<Attack>();
        //List<Attack> charmeleonAttackList = new List<Attack>();
        Pokemon attackingPokemon = new Pokemon();
        Pokemon attackedPokemon = new Pokemon();
        Attack attacking = new Attack();

        Pikachu pikachu = new Pikachu();
        Charmeleon charmeleon = new Charmeleon();
        List<Pokemon> pokemons = new List<Pokemon>();
        public Form1()
        {
            InitializeComponent();
            attackingPokemon = null;
            attackedPokemon = null;
            
            pikachuBtn.Text = pikachu.name;
            pikachuAttack1Btn.Visible = false;
            pikachuAttack2Btn.Visible = false;
            pikachuAttack1Btn.Text = pikachu.attack[0].name;
            pikachuAttack2Btn.Text = pikachu.attack[1].name;

            charmeleonBtn.Text = charmeleon.name;
            charmeleonAttack1Btn.Visible = false;
            charmeleonAttack2Btn.Visible = false;
            charmeleonAttack1Btn.Text = charmeleon.attack[0].name;
            charmeleonAttack2Btn.Text = charmeleon.attack[1].name;

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
        }

        private void attackBtn_Click(object sender, EventArgs e)
        {
            attackingPokemon.Attack(attacking, attackedPokemon);
            pokemonName.Text = attackedPokemon.name + "'s health:";
            if(attackedPokemon.Health <= 0)
            {
                pokemonHealthLbl.Text = attackedPokemon.name + " is dead!";
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
            }
        }

        private void pikachuAttack1Btn_Click(object sender, EventArgs e)
        {
            pikachuAttack1Btn.BackColor = Color.Green;
            attacking = pikachu.attack[0];
        }

        private void pikachuAttack2Btn_Click(object sender, EventArgs e)
        {
            pikachuAttack2Btn.BackColor = Color.Green;
            attacking = pikachu.attack[1];
        }

        private void charmeleonAttack1Btn_Click(object sender, EventArgs e)
        {
            charmeleonAttack1Btn.BackColor = Color.Green;
            attacking = charmeleon.attack[0];
        }

        private void charmeleonAttack2Btn_Click(object sender, EventArgs e)
        {
            charmeleonAttack2Btn.BackColor = Color.Green;
            attacking = charmeleon.attack[1];
        }

        private void getPopulationBtn_Click(object sender, EventArgs e)
        {
            Pokemon pokemon = new Pokemon();
            int pop = pokemon.getPopulation(pokemons);
            populationLbl.Text = "Currently alive: " + pop;
        }
    }
}
