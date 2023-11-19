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
            this.btnBack = new System.Windows.Forms.Button();
            this.picBoxPokemon2 = new System.Windows.Forms.PictureBox();
            this.picBoxPokemon3 = new System.Windows.Forms.PictureBox();
            this.picBoxPokemon4 = new System.Windows.Forms.PictureBox();
            this.picBoxPokemon5 = new System.Windows.Forms.PictureBox();
            this.picBoxPokemon6 = new System.Windows.Forms.PictureBox();
            this.picBoxPokemon = new System.Windows.Forms.PictureBox();
            this.txtDescription = new System.Windows.Forms.RichTextBox();
            this.lblPokemonID = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblTypeOne = new System.Windows.Forms.Label();
            this.lblTypeTwo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxPokemon1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxPokemon2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxPokemon3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxPokemon4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxPokemon5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxPokemon6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxPokemon)).BeginInit();
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
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Transparent;
            this.btnBack.BackgroundImage = global::PokemonBattle.Properties.Resources.ButtonNext;
            this.btnBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBack.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Segoe UI Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnBack.Location = new System.Drawing.Point(809, 462);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(93, 41);
            this.btnBack.TabIndex = 1;
            this.btnBack.Text = "ATRAS";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.Next);
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
            // picBoxPokemon
            // 
            this.picBoxPokemon.BackColor = System.Drawing.Color.Transparent;
            this.picBoxPokemon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picBoxPokemon.Location = new System.Drawing.Point(123, 224);
            this.picBoxPokemon.Name = "picBoxPokemon";
            this.picBoxPokemon.Size = new System.Drawing.Size(98, 88);
            this.picBoxPokemon.TabIndex = 7;
            this.picBoxPokemon.TabStop = false;
            // 
            // txtDescription
            // 
            this.txtDescription.BackColor = System.Drawing.Color.White;
            this.txtDescription.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDescription.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txtDescription.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescription.Location = new System.Drawing.Point(82, 373);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.ReadOnly = true;
            this.txtDescription.Size = new System.Drawing.Size(177, 94);
            this.txtDescription.TabIndex = 10;
            this.txtDescription.Text = "";
            // 
            // lblPokemonID
            // 
            this.lblPokemonID.AutoSize = true;
            this.lblPokemonID.BackColor = System.Drawing.Color.Transparent;
            this.lblPokemonID.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPokemonID.ForeColor = System.Drawing.Color.Black;
            this.lblPokemonID.Location = new System.Drawing.Point(152, 315);
            this.lblPokemonID.Name = "lblPokemonID";
            this.lblPokemonID.Size = new System.Drawing.Size(0, 17);
            this.lblPokemonID.TabIndex = 11;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.BackColor = System.Drawing.Color.Transparent;
            this.lblName.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.Color.Black;
            this.lblName.Location = new System.Drawing.Point(141, 341);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(0, 17);
            this.lblName.TabIndex = 12;
            // 
            // lblTypeOne
            // 
            this.lblTypeOne.AutoSize = true;
            this.lblTypeOne.BackColor = System.Drawing.Color.Transparent;
            this.lblTypeOne.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTypeOne.ForeColor = System.Drawing.Color.Black;
            this.lblTypeOne.Location = new System.Drawing.Point(98, 486);
            this.lblTypeOne.Name = "lblTypeOne";
            this.lblTypeOne.Size = new System.Drawing.Size(0, 17);
            this.lblTypeOne.TabIndex = 13;
            // 
            // lblTypeTwo
            // 
            this.lblTypeTwo.AutoSize = true;
            this.lblTypeTwo.BackColor = System.Drawing.Color.Transparent;
            this.lblTypeTwo.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTypeTwo.ForeColor = System.Drawing.Color.Black;
            this.lblTypeTwo.Location = new System.Drawing.Point(195, 486);
            this.lblTypeTwo.Name = "lblTypeTwo";
            this.lblTypeTwo.Size = new System.Drawing.Size(0, 17);
            this.lblTypeTwo.TabIndex = 14;
            // 
            // PokedexForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(914, 515);
            this.Controls.Add(this.lblTypeTwo);
            this.Controls.Add(this.lblTypeOne);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblPokemonID);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.picBoxPokemon);
            this.Controls.Add(this.picBoxPokemon6);
            this.Controls.Add(this.picBoxPokemon5);
            this.Controls.Add(this.picBoxPokemon4);
            this.Controls.Add(this.picBoxPokemon3);
            this.Controls.Add(this.picBoxPokemon2);
            this.Controls.Add(this.btnBack);
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
            ((System.ComponentModel.ISupportInitialize)(this.picBoxPokemon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picBoxPokemon1;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.PictureBox picBoxPokemon2;
        private System.Windows.Forms.PictureBox picBoxPokemon3;
        private System.Windows.Forms.PictureBox picBoxPokemon4;
        private System.Windows.Forms.PictureBox picBoxPokemon5;
        private System.Windows.Forms.PictureBox picBoxPokemon6;
        private System.Windows.Forms.PictureBox picBoxPokemon;
        private System.Windows.Forms.RichTextBox txtDescription;
        private System.Windows.Forms.Label lblPokemonID;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblTypeOne;
        private System.Windows.Forms.Label lblTypeTwo;
    }
}