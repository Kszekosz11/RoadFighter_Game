namespace RoadFighter
{
    partial class FrmMenu
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlBackgroundMenu = new System.Windows.Forms.Panel();
            this.pcbMenuCar = new System.Windows.Forms.PictureBox();
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.btnQuit = new System.Windows.Forms.Button();
            this.lblName = new System.Windows.Forms.Label();
            this.btnStartGame = new System.Windows.Forms.Button();
            this.btnOptions = new System.Windows.Forms.Button();
            this.pnlBackgroundMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbMenuCar)).BeginInit();
            this.pnlMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlBackgroundMenu
            // 
            this.pnlBackgroundMenu.BackColor = System.Drawing.Color.Transparent;
            this.pnlBackgroundMenu.BackgroundImage = global::RoadFighter.Properties.Resources.menuBackground2;
            this.pnlBackgroundMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlBackgroundMenu.Controls.Add(this.pcbMenuCar);
            this.pnlBackgroundMenu.Controls.Add(this.pnlMenu);
            this.pnlBackgroundMenu.Location = new System.Drawing.Point(-1, 0);
            this.pnlBackgroundMenu.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlBackgroundMenu.Name = "pnlBackgroundMenu";
            this.pnlBackgroundMenu.Size = new System.Drawing.Size(764, 791);
            this.pnlBackgroundMenu.TabIndex = 3;
            // 
            // pcbMenuCar
            // 
            this.pcbMenuCar.BackColor = System.Drawing.Color.Transparent;
            this.pcbMenuCar.BackgroundImage = global::RoadFighter.Properties.Resources.menuCar;
            this.pcbMenuCar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pcbMenuCar.Location = new System.Drawing.Point(4, 468);
            this.pcbMenuCar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pcbMenuCar.Name = "pcbMenuCar";
            this.pcbMenuCar.Size = new System.Drawing.Size(344, 194);
            this.pcbMenuCar.TabIndex = 4;
            this.pcbMenuCar.TabStop = false;
            // 
            // pnlMenu
            // 
            this.pnlMenu.BackColor = System.Drawing.Color.Transparent;
            this.pnlMenu.Controls.Add(this.btnQuit);
            this.pnlMenu.Controls.Add(this.lblName);
            this.pnlMenu.Controls.Add(this.btnStartGame);
            this.pnlMenu.Controls.Add(this.btnOptions);
            this.pnlMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlMenu.Location = new System.Drawing.Point(164, 15);
            this.pnlMenu.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(440, 446);
            this.pnlMenu.TabIndex = 2;
            // 
            // btnQuit
            // 
            this.btnQuit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnQuit.FlatAppearance.BorderSize = 0;
            this.btnQuit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnQuit.Location = new System.Drawing.Point(121, 361);
            this.btnQuit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(229, 53);
            this.btnQuit.TabIndex = 3;
            this.btnQuit.Text = "Quit Game";
            this.btnQuit.UseVisualStyleBackColor = true;
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.BackColor = System.Drawing.Color.Transparent;
            this.lblName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(96, 48);
            this.lblName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(188, 84);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "ROAD\r\nFIGHTER";
            this.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnStartGame
            // 
            this.btnStartGame.BackColor = System.Drawing.Color.Transparent;
            this.btnStartGame.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnStartGame.FlatAppearance.BorderSize = 0;
            this.btnStartGame.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnStartGame.Location = new System.Drawing.Point(121, 240);
            this.btnStartGame.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnStartGame.Name = "btnStartGame";
            this.btnStartGame.Size = new System.Drawing.Size(229, 53);
            this.btnStartGame.TabIndex = 0;
            this.btnStartGame.Text = "Start Game";
            this.btnStartGame.UseVisualStyleBackColor = false;
            this.btnStartGame.Click += new System.EventHandler(this.btnStartGame_click);
            // 
            // btnOptions
            // 
            this.btnOptions.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnOptions.FlatAppearance.BorderSize = 0;
            this.btnOptions.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnOptions.Location = new System.Drawing.Point(121, 300);
            this.btnOptions.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnOptions.Name = "btnOptions";
            this.btnOptions.Size = new System.Drawing.Size(229, 53);
            this.btnOptions.TabIndex = 2;
            this.btnOptions.Text = "Options";
            this.btnOptions.UseVisualStyleBackColor = true;
            // 
            // FrmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(761, 789);
            this.Controls.Add(this.pnlBackgroundMenu);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FrmMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RoadFighter";
            this.pnlBackgroundMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pcbMenuCar)).EndInit();
            this.pnlMenu.ResumeLayout(false);
            this.pnlMenu.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnStartGame;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.Button btnQuit;
        private System.Windows.Forms.Button btnOptions;
        private System.Windows.Forms.Panel pnlBackgroundMenu;
        private System.Windows.Forms.PictureBox pcbMenuCar;
    }
}

