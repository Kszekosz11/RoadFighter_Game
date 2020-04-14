namespace RoadFighter
{
    partial class frmGame
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGame));
            this.tmrSceneTimer = new System.Windows.Forms.Timer(this.components);
            this.pcbCar = new System.Windows.Forms.PictureBox();
            this.pcbFinishLine = new System.Windows.Forms.PictureBox();
            this.lblTime = new System.Windows.Forms.Label();
            this.lblPoints = new System.Windows.Forms.Label();
            this.pcbCoin = new System.Windows.Forms.PictureBox();
            this.pcbEnemyCar = new System.Windows.Forms.PictureBox();
            this.pcbLine1 = new System.Windows.Forms.PictureBox();
            this.lblLine7 = new System.Windows.Forms.PictureBox();
            this.pcbLine2 = new System.Windows.Forms.PictureBox();
            this.lblLine8 = new System.Windows.Forms.PictureBox();
            this.pcbLine3 = new System.Windows.Forms.PictureBox();
            this.lblLine9 = new System.Windows.Forms.PictureBox();
            this.pcbLine4 = new System.Windows.Forms.PictureBox();
            this.lblLine10 = new System.Windows.Forms.PictureBox();
            this.pcbLine5 = new System.Windows.Forms.PictureBox();
            this.lblLine6 = new System.Windows.Forms.PictureBox();
            this.tmrGameTimer = new System.Windows.Forms.Timer(this.components);
            this.pnlGrass = new System.Windows.Forms.Panel();
            this.pcbTree4 = new System.Windows.Forms.PictureBox();
            this.pcbTree1 = new System.Windows.Forms.PictureBox();
            this.pcbTree2 = new System.Windows.Forms.PictureBox();
            this.pcbTree3 = new System.Windows.Forms.PictureBox();
            this.pnlRoad = new System.Windows.Forms.Panel();
            this.pnlLeftLines = new System.Windows.Forms.Panel();
            this.pnlRightLines = new System.Windows.Forms.Panel();
            this.pnlUnderGrass = new System.Windows.Forms.Panel();
            this.tmrFinishGame = new System.Windows.Forms.Timer(this.components);
            this.pnlTest = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pcbCar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbFinishLine)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbCoin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbEnemyCar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbLine1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblLine7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbLine2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblLine8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbLine3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblLine9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbLine4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblLine10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbLine5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblLine6)).BeginInit();
            this.pnlGrass.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbTree4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbTree1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbTree2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbTree3)).BeginInit();
            this.pnlRoad.SuspendLayout();
            this.pnlLeftLines.SuspendLayout();
            this.pnlRightLines.SuspendLayout();
            this.pnlUnderGrass.SuspendLayout();
            this.SuspendLayout();
            // 
            // tmrSceneTimer
            // 
            this.tmrSceneTimer.Enabled = true;
            this.tmrSceneTimer.Interval = 10;
            this.tmrSceneTimer.Tick += new System.EventHandler(this.sceneTimer_Tick);
            // 
            // pcbCar
            // 
            this.pcbCar.BackColor = System.Drawing.Color.Transparent;
            this.pcbCar.BackgroundImage = global::RoadFighter.Properties.Resources.car;
            this.pcbCar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pcbCar.Location = new System.Drawing.Point(165, 543);
            this.pcbCar.Name = "pcbCar";
            this.pcbCar.Size = new System.Drawing.Size(50, 85);
            this.pcbCar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbCar.TabIndex = 12;
            this.pcbCar.TabStop = false;
            // 
            // pcbFinishLine
            // 
            this.pcbFinishLine.BackgroundImage = global::RoadFighter.Properties.Resources.finish;
            this.pcbFinishLine.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pcbFinishLine.Location = new System.Drawing.Point(-1, 36);
            this.pcbFinishLine.Name = "pcbFinishLine";
            this.pcbFinishLine.Size = new System.Drawing.Size(401, 50);
            this.pcbFinishLine.TabIndex = 22;
            this.pcbFinishLine.TabStop = false;
            this.pcbFinishLine.Visible = false;
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblTime.Location = new System.Drawing.Point(136, 9);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(49, 24);
            this.lblTime.TabIndex = 17;
            this.lblTime.Text = "time";
            this.lblTime.Visible = false;
            // 
            // lblPoints
            // 
            this.lblPoints.AutoSize = true;
            this.lblPoints.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblPoints.Location = new System.Drawing.Point(8, 9);
            this.lblPoints.Name = "lblPoints";
            this.lblPoints.Size = new System.Drawing.Size(66, 24);
            this.lblPoints.TabIndex = 16;
            this.lblPoints.Text = "points";
            this.lblPoints.Visible = false;
            // 
            // pcbCoin
            // 
            this.pcbCoin.BackgroundImage = global::RoadFighter.Properties.Resources.coin;
            this.pcbCoin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pcbCoin.Location = new System.Drawing.Point(174, 311);
            this.pcbCoin.Name = "pcbCoin";
            this.pcbCoin.Size = new System.Drawing.Size(30, 30);
            this.pcbCoin.TabIndex = 15;
            this.pcbCoin.TabStop = false;
            // 
            // pcbEnemyCar
            // 
            this.pcbEnemyCar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pcbEnemyCar.BackgroundImage")));
            this.pcbEnemyCar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pcbEnemyCar.Location = new System.Drawing.Point(165, 132);
            this.pcbEnemyCar.Name = "pcbEnemyCar";
            this.pcbEnemyCar.Size = new System.Drawing.Size(50, 85);
            this.pcbEnemyCar.TabIndex = 13;
            this.pcbEnemyCar.TabStop = false;
            // 
            // pcbLine1
            // 
            this.pcbLine1.BackColor = System.Drawing.Color.White;
            this.pcbLine1.Location = new System.Drawing.Point(0, 0);
            this.pcbLine1.Name = "pcbLine1";
            this.pcbLine1.Size = new System.Drawing.Size(18, 80);
            this.pcbLine1.TabIndex = 0;
            this.pcbLine1.TabStop = false;
            this.pcbLine1.Tag = "4";
            // 
            // lblLine7
            // 
            this.lblLine7.BackColor = System.Drawing.Color.White;
            this.lblLine7.Location = new System.Drawing.Point(0, 138);
            this.lblLine7.Name = "lblLine7";
            this.lblLine7.Size = new System.Drawing.Size(18, 80);
            this.lblLine7.TabIndex = 10;
            this.lblLine7.TabStop = false;
            this.lblLine7.Tag = "3";
            // 
            // pcbLine2
            // 
            this.pcbLine2.BackColor = System.Drawing.Color.White;
            this.pcbLine2.Location = new System.Drawing.Point(0, 137);
            this.pcbLine2.Name = "pcbLine2";
            this.pcbLine2.Size = new System.Drawing.Size(18, 80);
            this.pcbLine2.TabIndex = 1;
            this.pcbLine2.TabStop = false;
            this.pcbLine2.Tag = "3";
            // 
            // lblLine8
            // 
            this.lblLine8.BackColor = System.Drawing.Color.White;
            this.lblLine8.Location = new System.Drawing.Point(0, 276);
            this.lblLine8.Name = "lblLine8";
            this.lblLine8.Size = new System.Drawing.Size(18, 80);
            this.lblLine8.TabIndex = 9;
            this.lblLine8.TabStop = false;
            this.lblLine8.Tag = "2";
            // 
            // pcbLine3
            // 
            this.pcbLine3.BackColor = System.Drawing.Color.White;
            this.pcbLine3.Location = new System.Drawing.Point(0, 274);
            this.pcbLine3.Name = "pcbLine3";
            this.pcbLine3.Size = new System.Drawing.Size(18, 80);
            this.pcbLine3.TabIndex = 2;
            this.pcbLine3.TabStop = false;
            this.pcbLine3.Tag = "2";
            // 
            // lblLine9
            // 
            this.lblLine9.BackColor = System.Drawing.Color.White;
            this.lblLine9.Location = new System.Drawing.Point(0, 414);
            this.lblLine9.Name = "lblLine9";
            this.lblLine9.Size = new System.Drawing.Size(18, 80);
            this.lblLine9.TabIndex = 8;
            this.lblLine9.TabStop = false;
            this.lblLine9.Tag = "1";
            // 
            // pcbLine4
            // 
            this.pcbLine4.BackColor = System.Drawing.Color.White;
            this.pcbLine4.Location = new System.Drawing.Point(0, 411);
            this.pcbLine4.Name = "pcbLine4";
            this.pcbLine4.Size = new System.Drawing.Size(18, 80);
            this.pcbLine4.TabIndex = 3;
            this.pcbLine4.TabStop = false;
            this.pcbLine4.Tag = "1";
            // 
            // lblLine10
            // 
            this.lblLine10.BackColor = System.Drawing.Color.White;
            this.lblLine10.Location = new System.Drawing.Point(0, 552);
            this.lblLine10.Name = "lblLine10";
            this.lblLine10.Size = new System.Drawing.Size(18, 80);
            this.lblLine10.TabIndex = 7;
            this.lblLine10.TabStop = false;
            this.lblLine10.Tag = "0";
            // 
            // pcbLine5
            // 
            this.pcbLine5.BackColor = System.Drawing.Color.White;
            this.pcbLine5.Location = new System.Drawing.Point(0, 548);
            this.pcbLine5.Name = "pcbLine5";
            this.pcbLine5.Size = new System.Drawing.Size(18, 80);
            this.pcbLine5.TabIndex = 4;
            this.pcbLine5.TabStop = false;
            this.pcbLine5.Tag = "0";
            // 
            // lblLine6
            // 
            this.lblLine6.BackColor = System.Drawing.Color.White;
            this.lblLine6.Location = new System.Drawing.Point(0, 0);
            this.lblLine6.Name = "lblLine6";
            this.lblLine6.Size = new System.Drawing.Size(18, 80);
            this.lblLine6.TabIndex = 11;
            this.lblLine6.TabStop = false;
            this.lblLine6.Tag = "4";
            // 
            // tmrGameTimer
            // 
            this.tmrGameTimer.Enabled = true;
            this.tmrGameTimer.Interval = 1000;
            this.tmrGameTimer.Tick += new System.EventHandler(this.tmrGameTimer_Tick);
            // 
            // pnlGrass
            // 
            this.pnlGrass.BackColor = System.Drawing.Color.Green;
            this.pnlGrass.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlGrass.Controls.Add(this.pcbTree4);
            this.pnlGrass.Controls.Add(this.pcbTree1);
            this.pnlGrass.Controls.Add(this.pcbTree2);
            this.pnlGrass.Controls.Add(this.pcbTree3);
            this.pnlGrass.Location = new System.Drawing.Point(0, 0);
            this.pnlGrass.Name = "pnlGrass";
            this.pnlGrass.Size = new System.Drawing.Size(110, 640);
            this.pnlGrass.TabIndex = 20;
            // 
            // pcbTree4
            // 
            this.pcbTree4.BackColor = System.Drawing.Color.Transparent;
            this.pcbTree4.BackgroundImage = global::RoadFighter.Properties.Resources.tree4;
            this.pcbTree4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pcbTree4.Location = new System.Drawing.Point(12, 40);
            this.pcbTree4.Name = "pcbTree4";
            this.pcbTree4.Size = new System.Drawing.Size(90, 90);
            this.pcbTree4.TabIndex = 17;
            this.pcbTree4.TabStop = false;
            this.pcbTree4.Tag = "";
            // 
            // pcbTree1
            // 
            this.pcbTree1.BackColor = System.Drawing.Color.Transparent;
            this.pcbTree1.BackgroundImage = global::RoadFighter.Properties.Resources.tree1;
            this.pcbTree1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pcbTree1.Location = new System.Drawing.Point(12, 481);
            this.pcbTree1.Name = "pcbTree1";
            this.pcbTree1.Size = new System.Drawing.Size(90, 90);
            this.pcbTree1.TabIndex = 14;
            this.pcbTree1.TabStop = false;
            this.pcbTree1.Tag = "";
            // 
            // pcbTree2
            // 
            this.pcbTree2.BackColor = System.Drawing.Color.Transparent;
            this.pcbTree2.BackgroundImage = global::RoadFighter.Properties.Resources.tree2;
            this.pcbTree2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pcbTree2.Location = new System.Drawing.Point(12, 334);
            this.pcbTree2.Name = "pcbTree2";
            this.pcbTree2.Size = new System.Drawing.Size(90, 90);
            this.pcbTree2.TabIndex = 15;
            this.pcbTree2.TabStop = false;
            this.pcbTree2.Tag = "";
            // 
            // pcbTree3
            // 
            this.pcbTree3.BackColor = System.Drawing.Color.Transparent;
            this.pcbTree3.BackgroundImage = global::RoadFighter.Properties.Resources.tree3;
            this.pcbTree3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pcbTree3.Location = new System.Drawing.Point(12, 187);
            this.pcbTree3.Name = "pcbTree3";
            this.pcbTree3.Size = new System.Drawing.Size(90, 90);
            this.pcbTree3.TabIndex = 16;
            this.pcbTree3.TabStop = false;
            this.pcbTree3.Tag = "";
            // 
            // pnlRoad
            // 
            this.pnlRoad.Controls.Add(this.pcbCar);
            this.pnlRoad.Controls.Add(this.pcbEnemyCar);
            this.pnlRoad.Controls.Add(this.pcbCoin);
            this.pnlRoad.Controls.Add(this.pcbFinishLine);
            this.pnlRoad.Controls.Add(this.lblPoints);
            this.pnlRoad.Controls.Add(this.lblTime);
            this.pnlRoad.Controls.Add(this.pnlLeftLines);
            this.pnlRoad.Controls.Add(this.pnlRightLines);
            this.pnlRoad.Location = new System.Drawing.Point(168, 0);
            this.pnlRoad.Name = "pnlRoad";
            this.pnlRoad.Size = new System.Drawing.Size(400, 640);
            this.pnlRoad.TabIndex = 24;
            // 
            // pnlLeftLines
            // 
            this.pnlLeftLines.Controls.Add(this.pcbLine1);
            this.pnlLeftLines.Controls.Add(this.pcbLine2);
            this.pnlLeftLines.Controls.Add(this.pcbLine3);
            this.pnlLeftLines.Controls.Add(this.pcbLine4);
            this.pnlLeftLines.Controls.Add(this.pcbLine5);
            this.pnlLeftLines.Location = new System.Drawing.Point(103, 0);
            this.pnlLeftLines.Name = "pnlLeftLines";
            this.pnlLeftLines.Size = new System.Drawing.Size(18, 640);
            this.pnlLeftLines.TabIndex = 23;
            // 
            // pnlRightLines
            // 
            this.pnlRightLines.Controls.Add(this.lblLine6);
            this.pnlRightLines.Controls.Add(this.lblLine10);
            this.pnlRightLines.Controls.Add(this.lblLine7);
            this.pnlRightLines.Controls.Add(this.lblLine9);
            this.pnlRightLines.Controls.Add(this.lblLine8);
            this.pnlRightLines.Location = new System.Drawing.Point(259, 0);
            this.pnlRightLines.Name = "pnlRightLines";
            this.pnlRightLines.Size = new System.Drawing.Size(18, 640);
            this.pnlRightLines.TabIndex = 5;
            // 
            // pnlUnderGrass
            // 
            this.pnlUnderGrass.BackColor = System.Drawing.Color.Green;
            this.pnlUnderGrass.Controls.Add(this.pnlGrass);
            this.pnlUnderGrass.Location = new System.Drawing.Point(60, 0);
            this.pnlUnderGrass.Name = "pnlUnderGrass";
            this.pnlUnderGrass.Size = new System.Drawing.Size(110, 640);
            this.pnlUnderGrass.TabIndex = 24;
            // 
            // tmrFinishGame
            // 
            this.tmrFinishGame.Tick += new System.EventHandler(this.tmrFinishGame_Tick);
            // 
            // pnlTest
            // 
            this.pnlTest.Location = new System.Drawing.Point(0, 0);
            this.pnlTest.Name = "pnlTest";
            this.pnlTest.Size = new System.Drawing.Size(59, 640);
            this.pnlTest.TabIndex = 25;
            // 
            // frmGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(571, 641);
            this.Controls.Add(this.pnlTest);
            this.Controls.Add(this.pnlRoad);
            this.Controls.Add(this.pnlUnderGrass);
            this.Name = "frmGame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RoadFighter";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.keysHandling);
            ((System.ComponentModel.ISupportInitialize)(this.pcbCar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbFinishLine)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbCoin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbEnemyCar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbLine1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblLine7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbLine2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblLine8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbLine3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblLine9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbLine4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblLine10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbLine5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblLine6)).EndInit();
            this.pnlGrass.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pcbTree4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbTree1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbTree2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbTree3)).EndInit();
            this.pnlRoad.ResumeLayout(false);
            this.pnlRoad.PerformLayout();
            this.pnlLeftLines.ResumeLayout(false);
            this.pnlRightLines.ResumeLayout(false);
            this.pnlUnderGrass.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        public System.Windows.Forms.PictureBox pcbCoin;
        public System.Windows.Forms.PictureBox pcbCar;
        public System.Windows.Forms.PictureBox pcbEnemyCar;
        public System.Windows.Forms.Panel pnlGrass;
        public System.Windows.Forms.PictureBox pcbTree4;
        public System.Windows.Forms.PictureBox pcbTree3;
        public System.Windows.Forms.PictureBox pcbTree2;
        public System.Windows.Forms.PictureBox pcbTree1;
        public System.Windows.Forms.Label lblPoints;
        public System.Windows.Forms.Label lblTime;
        public System.Windows.Forms.PictureBox pcbLine1;
        public System.Windows.Forms.PictureBox pcbLine2;
        public System.Windows.Forms.PictureBox pcbLine3;
        public System.Windows.Forms.PictureBox pcbLine4;
        public System.Windows.Forms.PictureBox pcbLine5;
        public System.Windows.Forms.PictureBox lblLine6;
        public System.Windows.Forms.PictureBox lblLine7;
        public System.Windows.Forms.PictureBox lblLine8;
        public System.Windows.Forms.PictureBox lblLine9;
        public System.Windows.Forms.PictureBox lblLine10;
        public System.Windows.Forms.Panel pnlLeftLines;
        public System.Windows.Forms.PictureBox pcbFinishLine;
        public System.Windows.Forms.Timer tmrSceneTimer;
        public System.Windows.Forms.Timer tmrGameTimer;
        public System.Windows.Forms.Panel pnlRoad;
        public System.Windows.Forms.Panel pnlRightLines;
        private System.Windows.Forms.Panel pnlUnderGrass;
        public System.Windows.Forms.Timer tmrFinishGame;
        private System.Windows.Forms.Panel pnlTest;
    }
}

