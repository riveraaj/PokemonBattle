namespace PokemonBattle.Views
{
    partial class VersusForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VersusForm));
            this.lblPLayerOneName = new System.Windows.Forms.Label();
            this.lblPLayerTwoName = new System.Windows.Forms.Label();
            this.picBoxPLayerOneImage = new System.Windows.Forms.PictureBox();
            this.picBoxPLayerTwoImage = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxPLayerOneImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxPLayerTwoImage)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPLayerOneName
            // 
            this.lblPLayerOneName.BackColor = System.Drawing.Color.Transparent;
            this.lblPLayerOneName.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPLayerOneName.Location = new System.Drawing.Point(174, 257);
            this.lblPLayerOneName.Name = "lblPLayerOneName";
            this.lblPLayerOneName.Size = new System.Drawing.Size(120, 27);
            this.lblPLayerOneName.TabIndex = 0;
            this.lblPLayerOneName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblPLayerTwoName
            // 
            this.lblPLayerTwoName.BackColor = System.Drawing.Color.Transparent;
            this.lblPLayerTwoName.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPLayerTwoName.Location = new System.Drawing.Point(634, 251);
            this.lblPLayerTwoName.Name = "lblPLayerTwoName";
            this.lblPLayerTwoName.Size = new System.Drawing.Size(120, 27);
            this.lblPLayerTwoName.TabIndex = 1;
            this.lblPLayerTwoName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // picBoxPLayerOneImage
            // 
            this.picBoxPLayerOneImage.BackColor = System.Drawing.Color.Transparent;
            this.picBoxPLayerOneImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picBoxPLayerOneImage.Location = new System.Drawing.Point(106, 244);
            this.picBoxPLayerOneImage.Name = "picBoxPLayerOneImage";
            this.picBoxPLayerOneImage.Size = new System.Drawing.Size(47, 49);
            this.picBoxPLayerOneImage.TabIndex = 2;
            this.picBoxPLayerOneImage.TabStop = false;
            // 
            // picBoxPLayerTwoImage
            // 
            this.picBoxPLayerTwoImage.BackColor = System.Drawing.Color.Transparent;
            this.picBoxPLayerTwoImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picBoxPLayerTwoImage.Location = new System.Drawing.Point(774, 239);
            this.picBoxPLayerTwoImage.Name = "picBoxPLayerTwoImage";
            this.picBoxPLayerTwoImage.Size = new System.Drawing.Size(47, 49);
            this.picBoxPLayerTwoImage.TabIndex = 3;
            this.picBoxPLayerTwoImage.TabStop = false;
            // 
            // VersusForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PokemonBattle.Properties.Resources.Versus;
            this.ClientSize = new System.Drawing.Size(914, 515);
            this.Controls.Add(this.picBoxPLayerTwoImage);
            this.Controls.Add(this.picBoxPLayerOneImage);
            this.Controls.Add(this.lblPLayerTwoName);
            this.Controls.Add(this.lblPLayerOneName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "VersusForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Versus";
            ((System.ComponentModel.ISupportInitialize)(this.picBoxPLayerOneImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxPLayerTwoImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.Label lblPLayerOneName;
        internal System.Windows.Forms.Label lblPLayerTwoName;
        internal System.Windows.Forms.PictureBox picBoxPLayerOneImage;
        internal System.Windows.Forms.PictureBox picBoxPLayerTwoImage;
    }
}