using PokemonBattle.Properties;
using System.Drawing;

namespace PokemonBattle.View
{
    partial class PokedexForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PokedexForm));
            this.picBoxPokemon1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.picBoxPokemon2 = new System.Windows.Forms.PictureBox();
            this.picBoxPokemon3 = new System.Windows.Forms.PictureBox();
            this.picBoxPokemon4 = new System.Windows.Forms.PictureBox();
            this.picBoxPokemon5 = new System.Windows.Forms.PictureBox();
            this.picBoxPokemon6 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxPokemon1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxPokemon2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxPokemon3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxPokemon4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxPokemon5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxPokemon6)).BeginInit();
            this.SuspendLayout();
            // 
            // picBoxPokemon1
            // 
            this.picBoxPokemon1.BackColor = System.Drawing.Color.Transparent;
            this.picBoxPokemon1.BackgroundImage = global::PokemonBattle.Properties.Resources._391;
            this.picBoxPokemon1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picBoxPokemon1.Location = new System.Drawing.Point(56, 25);
            this.picBoxPokemon1.Name = "picBoxPokemon1";
            this.picBoxPokemon1.Size = new System.Drawing.Size(105, 104);
            this.picBoxPokemon1.TabIndex = 0;
            this.picBoxPokemon1.TabStop = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImage = global::PokemonBattle.Properties.Resources.ButtonNext;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Cursor = System.Windows.Forms.Cursors.Default;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Location = new System.Drawing.Point(809, 462);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(93, 41);
            this.button1.TabIndex = 1;
            this.button1.Text = "SIGUIENTE";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Next);
            // 
            // picBoxPokemon2
            // 
            this.picBoxPokemon2.BackColor = System.Drawing.Color.Transparent;
            this.picBoxPokemon2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picBoxPokemon2.Location = new System.Drawing.Point(182, 25);
            this.picBoxPokemon2.Name = "picBoxPokemon2";
            this.picBoxPokemon2.Size = new System.Drawing.Size(105, 104);
            this.picBoxPokemon2.TabIndex = 2;
            this.picBoxPokemon2.TabStop = false;
            // 
            // picBoxPokemon3
            // 
            this.picBoxPokemon3.BackColor = System.Drawing.Color.Transparent;
            this.picBoxPokemon3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picBoxPokemon3.Location = new System.Drawing.Point(309, 25);
            this.picBoxPokemon3.Name = "picBoxPokemon3";
            this.picBoxPokemon3.Size = new System.Drawing.Size(105, 104);
            this.picBoxPokemon3.TabIndex = 3;
            this.picBoxPokemon3.TabStop = false;
            // 
            // picBoxPokemon4
            // 
            this.picBoxPokemon4.BackColor = System.Drawing.Color.Transparent;
            this.picBoxPokemon4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picBoxPokemon4.Location = new System.Drawing.Point(510, 25);
            this.picBoxPokemon4.Name = "picBoxPokemon4";
            this.picBoxPokemon4.Size = new System.Drawing.Size(105, 104);
            this.picBoxPokemon4.TabIndex = 4;
            this.picBoxPokemon4.TabStop = false;
            // 
            // picBoxPokemon5
            // 
            this.picBoxPokemon5.BackColor = System.Drawing.Color.Transparent;
            this.picBoxPokemon5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picBoxPokemon5.Location = new System.Drawing.Point(637, 25);
            this.picBoxPokemon5.Name = "picBoxPokemon5";
            this.picBoxPokemon5.Size = new System.Drawing.Size(105, 104);
            this.picBoxPokemon5.TabIndex = 5;
            this.picBoxPokemon5.TabStop = false;
            // 
            // picBoxPokemon6
            // 
            this.picBoxPokemon6.BackColor = System.Drawing.Color.Transparent;
            this.picBoxPokemon6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picBoxPokemon6.Location = new System.Drawing.Point(760, 25);
            this.picBoxPokemon6.Name = "picBoxPokemon6";
            this.picBoxPokemon6.Size = new System.Drawing.Size(105, 104);
            this.picBoxPokemon6.TabIndex = 6;
            this.picBoxPokemon6.TabStop = false;
            // 
            // PokedexForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PokemonBattle.Properties.Resources.BackgroundPokedex;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(914, 515);
            this.Controls.Add(this.picBoxPokemon6);
            this.Controls.Add(this.picBoxPokemon5);
            this.Controls.Add(this.picBoxPokemon4);
            this.Controls.Add(this.picBoxPokemon3);
            this.Controls.Add(this.picBoxPokemon2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.picBoxPokemon1);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "PokedexForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pokedex";
            ((System.ComponentModel.ISupportInitialize)(this.picBoxPokemon1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxPokemon2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxPokemon3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxPokemon4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxPokemon5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxPokemon6)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picBoxPokemon1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox picBoxPokemon2;
        private System.Windows.Forms.PictureBox picBoxPokemon3;
        private System.Windows.Forms.PictureBox picBoxPokemon4;
        private System.Windows.Forms.PictureBox picBoxPokemon5;
        private System.Windows.Forms.PictureBox picBoxPokemon6;
    }
}