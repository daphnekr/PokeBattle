﻿namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.getPokemons = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // getPokemons
            // 
            this.getPokemons.Location = new System.Drawing.Point(51, 83);
            this.getPokemons.Name = "getPokemons";
            this.getPokemons.Size = new System.Drawing.Size(75, 23);
            this.getPokemons.TabIndex = 0;
            this.getPokemons.Text = "Pokemons";
            this.getPokemons.UseVisualStyleBackColor = true;
            this.getPokemons.Click += new System.EventHandler(this.getPokemons_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.getPokemons);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button getPokemons;
    }
}

