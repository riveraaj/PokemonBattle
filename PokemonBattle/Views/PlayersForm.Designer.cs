namespace PokemonBattle.View
{
    partial class PlayersForm
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
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PlayersForm));
            this.tableLayoutPlayers = new System.Windows.Forms.TableLayoutPanel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.Jonathan = new System.Windows.Forms.Label();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnChoosePokemon = new System.Windows.Forms.Button();
            this.tableLayoutPlayers.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPlayers
            // 
            this.tableLayoutPlayers.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPlayers.ColumnCount = 5;
            this.tableLayoutPlayers.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 46.76923F));
            this.tableLayoutPlayers.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 53.23077F));
            this.tableLayoutPlayers.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 188F));
            this.tableLayoutPlayers.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 182F));
            this.tableLayoutPlayers.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 180F));
            this.tableLayoutPlayers.Controls.Add(this.flowLayoutPanel1, 0, 0);
            this.tableLayoutPlayers.Location = new System.Drawing.Point(20, 27);
            this.tableLayoutPlayers.Name = "tableLayoutPlayers";
            this.tableLayoutPlayers.RowCount = 4;
            this.tableLayoutPlayers.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 47.94521F));
            this.tableLayoutPlayers.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 52.05479F));
            this.tableLayoutPlayers.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 123F));
            this.tableLayoutPlayers.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 121F));
            this.tableLayoutPlayers.Size = new System.Drawing.Size(875, 464);
            this.tableLayoutPlayers.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.Jonathan);
            this.flowLayoutPanel1.Controls.Add(this.btnChoosePokemon);
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(20, 15, 0, 0);
            this.flowLayoutPanel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.flowLayoutPanel1.Size = new System.Drawing.Size(146, 99);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // Jonathan
            // 
            this.Jonathan.AutoSize = true;
            this.Jonathan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Jonathan.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Jonathan.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.Jonathan.Location = new System.Drawing.Point(27, 15);
            this.Jonathan.Margin = new System.Windows.Forms.Padding(7, 0, 3, 5);
            this.Jonathan.Name = "Jonathan";
            this.Jonathan.Size = new System.Drawing.Size(75, 21);
            this.Jonathan.TabIndex = 0;
            this.Jonathan.Text = "Jonathan";
            this.Jonathan.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnChoosePokemon
            // 
            this.btnChoosePokemon.BackgroundImage = global::PokemonBattle.Properties.Resources.ButtonChoosePokemon;
            this.btnChoosePokemon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnChoosePokemon.FlatAppearance.BorderSize = 0;
            this.btnChoosePokemon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChoosePokemon.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChoosePokemon.Location = new System.Drawing.Point(23, 44);
            this.btnChoosePokemon.Name = "btnChoosePokemon";
            this.btnChoosePokemon.Size = new System.Drawing.Size(100, 40);
            this.btnChoosePokemon.TabIndex = 1;
            this.btnChoosePokemon.Text = "Ir a Pokedex";
            this.btnChoosePokemon.UseVisualStyleBackColor = true;
            this.btnChoosePokemon.Click += new System.EventHandler(this.OpenPokedex);
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.Color.Transparent;
            this.btnNext.BackgroundImage = global::PokemonBattle.Properties.Resources.ButtonNext;
            this.btnNext.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnNext.FlatAppearance.BorderSize = 0;
            this.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNext.Font = new System.Drawing.Font("Segoe UI Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnNext.Location = new System.Drawing.Point(790, 450);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(93, 41);
            this.btnNext.TabIndex = 1;
            this.btnNext.Text = "SIGUIENTE";
            this.btnNext.UseVisualStyleBackColor = false;
            // 
            // PlayersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PokemonBattle.Properties.Resources.BackgroundPlayersScreen;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(914, 515);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.tableLayoutPlayers);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "PlayersForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pokemon Battle";
            this.tableLayoutPlayers.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPlayers;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label Jonathan;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnChoosePokemon;
    }
}