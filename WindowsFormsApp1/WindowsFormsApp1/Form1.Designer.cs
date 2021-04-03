namespace WindowsFormsApp1
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
            this.pikachuBtn = new System.Windows.Forms.Button();
            this.charmeleonBtn = new System.Windows.Forms.Button();
            this.attackBtn = new System.Windows.Forms.Button();
            this.pokemonHealthLbl = new System.Windows.Forms.Label();
            this.pokemonName = new System.Windows.Forms.Label();
            this.pikachuAttack1Btn = new System.Windows.Forms.Button();
            this.pikachuAttack2Btn = new System.Windows.Forms.Button();
            this.charmeleonAttack1Btn = new System.Windows.Forms.Button();
            this.charmeleonAttack2Btn = new System.Windows.Forms.Button();
            this.getPopulationBtn = new System.Windows.Forms.Button();
            this.populationLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // pikachuBtn
            // 
            this.pikachuBtn.Location = new System.Drawing.Point(108, 81);
            this.pikachuBtn.Name = "pikachuBtn";
            this.pikachuBtn.Size = new System.Drawing.Size(75, 23);
            this.pikachuBtn.TabIndex = 0;
            this.pikachuBtn.UseVisualStyleBackColor = true;
            this.pikachuBtn.Click += new System.EventHandler(this.pikachuBtn_Click);
            // 
            // charmeleonBtn
            // 
            this.charmeleonBtn.Location = new System.Drawing.Point(505, 81);
            this.charmeleonBtn.Name = "charmeleonBtn";
            this.charmeleonBtn.Size = new System.Drawing.Size(75, 23);
            this.charmeleonBtn.TabIndex = 2;
            this.charmeleonBtn.UseVisualStyleBackColor = true;
            this.charmeleonBtn.Click += new System.EventHandler(this.charmeleonBtn_Click);
            // 
            // attackBtn
            // 
            this.attackBtn.Location = new System.Drawing.Point(324, 270);
            this.attackBtn.Name = "attackBtn";
            this.attackBtn.Size = new System.Drawing.Size(75, 23);
            this.attackBtn.TabIndex = 3;
            this.attackBtn.Text = "Attack!";
            this.attackBtn.UseVisualStyleBackColor = true;
            this.attackBtn.Click += new System.EventHandler(this.attackBtn_Click);
            // 
            // pokemonHealthLbl
            // 
            this.pokemonHealthLbl.AutoSize = true;
            this.pokemonHealthLbl.Location = new System.Drawing.Point(308, 364);
            this.pokemonHealthLbl.Name = "pokemonHealthLbl";
            this.pokemonHealthLbl.Size = new System.Drawing.Size(14, 17);
            this.pokemonHealthLbl.TabIndex = 4;
            this.pokemonHealthLbl.Text = "x";
            // 
            // pokemonName
            // 
            this.pokemonName.AutoSize = true;
            this.pokemonName.Location = new System.Drawing.Point(105, 364);
            this.pokemonName.Name = "pokemonName";
            this.pokemonName.Size = new System.Drawing.Size(14, 17);
            this.pokemonName.TabIndex = 5;
            this.pokemonName.Text = "x";
            // 
            // pikachuAttack1Btn
            // 
            this.pikachuAttack1Btn.Location = new System.Drawing.Point(12, 117);
            this.pikachuAttack1Btn.Name = "pikachuAttack1Btn";
            this.pikachuAttack1Btn.Size = new System.Drawing.Size(106, 23);
            this.pikachuAttack1Btn.TabIndex = 6;
            this.pikachuAttack1Btn.UseVisualStyleBackColor = true;
            this.pikachuAttack1Btn.Click += new System.EventHandler(this.pikachuAttack1Btn_Click);
            // 
            // pikachuAttack2Btn
            // 
            this.pikachuAttack2Btn.Location = new System.Drawing.Point(187, 117);
            this.pikachuAttack2Btn.Name = "pikachuAttack2Btn";
            this.pikachuAttack2Btn.Size = new System.Drawing.Size(75, 23);
            this.pikachuAttack2Btn.TabIndex = 7;
            this.pikachuAttack2Btn.UseVisualStyleBackColor = true;
            this.pikachuAttack2Btn.Click += new System.EventHandler(this.pikachuAttack2Btn_Click);
            // 
            // charmeleonAttack1Btn
            // 
            this.charmeleonAttack1Btn.Location = new System.Drawing.Point(420, 117);
            this.charmeleonAttack1Btn.Name = "charmeleonAttack1Btn";
            this.charmeleonAttack1Btn.Size = new System.Drawing.Size(75, 23);
            this.charmeleonAttack1Btn.TabIndex = 8;
            this.charmeleonAttack1Btn.UseVisualStyleBackColor = true;
            this.charmeleonAttack1Btn.Click += new System.EventHandler(this.charmeleonAttack1Btn_Click);
            // 
            // charmeleonAttack2Btn
            // 
            this.charmeleonAttack2Btn.Location = new System.Drawing.Point(584, 117);
            this.charmeleonAttack2Btn.Name = "charmeleonAttack2Btn";
            this.charmeleonAttack2Btn.Size = new System.Drawing.Size(75, 23);
            this.charmeleonAttack2Btn.TabIndex = 9;
            this.charmeleonAttack2Btn.UseVisualStyleBackColor = true;
            this.charmeleonAttack2Btn.Click += new System.EventHandler(this.charmeleonAttack2Btn_Click);
            // 
            // getPopulationBtn
            // 
            this.getPopulationBtn.Location = new System.Drawing.Point(597, 286);
            this.getPopulationBtn.Name = "getPopulationBtn";
            this.getPopulationBtn.Size = new System.Drawing.Size(132, 23);
            this.getPopulationBtn.TabIndex = 10;
            this.getPopulationBtn.Text = "Get population";
            this.getPopulationBtn.UseVisualStyleBackColor = true;
            this.getPopulationBtn.Click += new System.EventHandler(this.getPopulationBtn_Click);
            // 
            // populationLbl
            // 
            this.populationLbl.AutoSize = true;
            this.populationLbl.Location = new System.Drawing.Point(567, 364);
            this.populationLbl.Name = "populationLbl";
            this.populationLbl.Size = new System.Drawing.Size(106, 17);
            this.populationLbl.TabIndex = 11;
            this.populationLbl.Text = "Currently alive: ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.populationLbl);
            this.Controls.Add(this.getPopulationBtn);
            this.Controls.Add(this.charmeleonAttack2Btn);
            this.Controls.Add(this.charmeleonAttack1Btn);
            this.Controls.Add(this.pikachuAttack2Btn);
            this.Controls.Add(this.pikachuAttack1Btn);
            this.Controls.Add(this.pokemonName);
            this.Controls.Add(this.pokemonHealthLbl);
            this.Controls.Add(this.attackBtn);
            this.Controls.Add(this.charmeleonBtn);
            this.Controls.Add(this.pikachuBtn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button pikachuBtn;
        private System.Windows.Forms.Button charmeleonBtn;
        private System.Windows.Forms.Button attackBtn;
        private System.Windows.Forms.Label pokemonHealthLbl;
        private System.Windows.Forms.Label pokemonName;
        private System.Windows.Forms.Button pikachuAttack1Btn;
        private System.Windows.Forms.Button pikachuAttack2Btn;
        private System.Windows.Forms.Button charmeleonAttack1Btn;
        private System.Windows.Forms.Button charmeleonAttack2Btn;
        private System.Windows.Forms.Button getPopulationBtn;
        private System.Windows.Forms.Label populationLbl;
    }
}

