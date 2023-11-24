namespace PokemonBattle.View{
    partial class InitTournamentForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code
        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InitTournamentForm));
            this.labelSelectSizeTournament = new System.Windows.Forms.Label();
            this.cmbSizeTournament = new System.Windows.Forms.ComboBox();
            this.labelNumberPlayer = new System.Windows.Forms.Label();
            this.cmbNumberPlayer = new System.Windows.Forms.ComboBox();
            this.layoutNamePlayers = new System.Windows.Forms.TableLayoutPanel();
            this.btnNextPlayersForm = new System.Windows.Forms.Button();
            this.labelWarning = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelSelectSizeTournament
            // 
            this.labelSelectSizeTournament.AutoSize = true;
            this.labelSelectSizeTournament.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelSelectSizeTournament.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSelectSizeTournament.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.labelSelectSizeTournament.Location = new System.Drawing.Point(33, 27);
            this.labelSelectSizeTournament.Name = "labelSelectSizeTournament";
            this.labelSelectSizeTournament.Size = new System.Drawing.Size(221, 21);
            this.labelSelectSizeTournament.TabIndex = 0;
            this.labelSelectSizeTournament.Text = "Select the Tournament Size.";
            // 
            // cmbSizeTournament
            // 
            this.cmbSizeTournament.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSizeTournament.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSizeTournament.FormattingEnabled = true;
            this.cmbSizeTournament.Items.AddRange(new object[] {
            "4",
            "8",
            "16"});
            this.cmbSizeTournament.Location = new System.Drawing.Point(33, 60);
            this.cmbSizeTournament.Name = "cmbSizeTournament";
            this.cmbSizeTournament.Size = new System.Drawing.Size(121, 25);
            this.cmbSizeTournament.TabIndex = 1;
            this.cmbSizeTournament.SelectedIndexChanged += new System.EventHandler(this.ChangeListOfPlayer);
            // 
            // labelNumberPlayer
            // 
            this.labelNumberPlayer.AutoSize = true;
            this.labelNumberPlayer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelNumberPlayer.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNumberPlayer.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.labelNumberPlayer.Location = new System.Drawing.Point(518, 27);
            this.labelNumberPlayer.Name = "labelNumberPlayer";
            this.labelNumberPlayer.Size = new System.Drawing.Size(232, 21);
            this.labelNumberPlayer.TabIndex = 2;
            this.labelNumberPlayer.Text = "Select the number of Players.";
            // 
            // cmbNumberPlayer
            // 
            this.cmbNumberPlayer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbNumberPlayer.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbNumberPlayer.FormattingEnabled = true;
            this.cmbNumberPlayer.Items.AddRange(new object[] {
            "Seleccione el tamaño del Torneo"});
            this.cmbNumberPlayer.Location = new System.Drawing.Point(518, 60);
            this.cmbNumberPlayer.Name = "cmbNumberPlayer";
            this.cmbNumberPlayer.Size = new System.Drawing.Size(123, 25);
            this.cmbNumberPlayer.TabIndex = 1;
            this.cmbNumberPlayer.SelectedIndexChanged += new System.EventHandler(this.ChangeListCreateInputForNamesPlayers);
            // 
            // layoutNamePlayers
            // 
            this.layoutNamePlayers.BackColor = System.Drawing.Color.Transparent;
            this.layoutNamePlayers.ColumnCount = 5;
            this.layoutNamePlayers.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.layoutNamePlayers.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 111F));
            this.layoutNamePlayers.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 111F));
            this.layoutNamePlayers.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 109F));
            this.layoutNamePlayers.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 103F));
            this.layoutNamePlayers.Location = new System.Drawing.Point(185, 281);
            this.layoutNamePlayers.Name = "layoutNamePlayers";
            this.layoutNamePlayers.RowCount = 5;
            this.layoutNamePlayers.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.layoutNamePlayers.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 58F));
            this.layoutNamePlayers.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 54F));
            this.layoutNamePlayers.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.layoutNamePlayers.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 55F));
            this.layoutNamePlayers.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 118F));
            this.layoutNamePlayers.Size = new System.Drawing.Size(555, 280);
            this.layoutNamePlayers.TabIndex = 3;
            // 
            // btnNextPlayersForm
            // 
            this.btnNextPlayersForm.BackColor = System.Drawing.Color.Transparent;
            this.btnNextPlayersForm.BackgroundImage = global::PokemonBattle.Properties.Resources.ButtonNext;
            this.btnNextPlayersForm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnNextPlayersForm.FlatAppearance.BorderSize = 0;
            this.btnNextPlayersForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNextPlayersForm.Font = new System.Drawing.Font("Segoe UI Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNextPlayersForm.Location = new System.Drawing.Point(791, 453);
            this.btnNextPlayersForm.Name = "btnNextPlayersForm";
            this.btnNextPlayersForm.Size = new System.Drawing.Size(93, 41);
            this.btnNextPlayersForm.TabIndex = 4;
            this.btnNextPlayersForm.Text = "NEXT";
            this.btnNextPlayersForm.UseVisualStyleBackColor = false;
            // 
            // labelWarning
            // 
            this.labelWarning.AutoSize = true;
            this.labelWarning.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelWarning.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWarning.ForeColor = System.Drawing.Color.Red;
            this.labelWarning.Location = new System.Drawing.Point(182, 245);
            this.labelWarning.Name = "labelWarning";
            this.labelWarning.Size = new System.Drawing.Size(229, 21);
            this.labelWarning.TabIndex = 6;
            this.labelWarning.Text = "*All players must have a name.";
            this.labelWarning.Visible = false;
            // 
            // InitTournamentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.BackgroundImage = global::PokemonBattle.Properties.Resources.BackgroundInitTournament;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(914, 515);
            this.Controls.Add(this.labelWarning);
            this.Controls.Add(this.btnNextPlayersForm);
            this.Controls.Add(this.layoutNamePlayers);
            this.Controls.Add(this.cmbNumberPlayer);
            this.Controls.Add(this.labelNumberPlayer);
            this.Controls.Add(this.cmbSizeTournament);
            this.Controls.Add(this.labelSelectSizeTournament);
            this.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "InitTournamentForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pokemon Battle";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
        #endregion

        private System.Windows.Forms.Label labelSelectSizeTournament;
        private System.Windows.Forms.ComboBox cmbSizeTournament;
        private System.Windows.Forms.Label labelNumberPlayer;
        private System.Windows.Forms.ComboBox cmbNumberPlayer;
        private System.Windows.Forms.TableLayoutPanel layoutNamePlayers;
        public System.Windows.Forms.Button btnNextPlayersForm;
        public System.Windows.Forms.Label labelWarning;
    }
}