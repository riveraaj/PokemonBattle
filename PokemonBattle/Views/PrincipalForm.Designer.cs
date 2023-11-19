namespace PokemonBattle
{
    partial class PrincipalForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PrincipalForm));
            this.labelStart = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnPlayer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelStart
            // 
            this.labelStart.AutoSize = true;
            this.labelStart.BackColor = System.Drawing.Color.Transparent;
            this.labelStart.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStart.Location = new System.Drawing.Point(370, 456);
            this.labelStart.Name = "labelStart";
            this.labelStart.Size = new System.Drawing.Size(170, 21);
            this.labelStart.TabIndex = 0;
            this.labelStart.Text = "Press any key to start";
            this.labelStart.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer1
            // 
            this.timer1.Interval = 500;
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // btnPlayer
            // 
            this.btnPlayer.BackColor = System.Drawing.Color.Transparent;
            this.btnPlayer.BackgroundImage = global::PokemonBattle.Properties.Resources.ButtonStop;
            this.btnPlayer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPlayer.FlatAppearance.BorderSize = 0;
            this.btnPlayer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlayer.Location = new System.Drawing.Point(862, 12);
            this.btnPlayer.Name = "btnPlayer";
            this.btnPlayer.Size = new System.Drawing.Size(40, 38);
            this.btnPlayer.TabIndex = 1;
            this.btnPlayer.UseVisualStyleBackColor = false;
            this.btnPlayer.Click += new System.EventHandler(this.StopMusic);
            // 
            // PrincipalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PokemonBattle.Properties.Resources.BackgroundMainScreen;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(914, 515);
            this.Controls.Add(this.btnPlayer);
            this.Controls.Add(this.labelStart);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "PrincipalForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pokemon Battle";
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OpenInitTournament);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelStart;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnPlayer;
    }
}

