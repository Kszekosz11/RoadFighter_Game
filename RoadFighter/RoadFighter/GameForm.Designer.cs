namespace RoadFighter
{
    partial class FrmGame
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmGame));
            this.tmrSceneTimer = new System.Windows.Forms.Timer(this.components);
            this.lblTime = new System.Windows.Forms.Label();
            this.lblPoints = new System.Windows.Forms.Label();
            this.tmrGameTimer = new System.Windows.Forms.Timer(this.components);
            this.pnlRoad = new System.Windows.Forms.Panel();
            this.pcbClock = new System.Windows.Forms.PictureBox();
            this.pcbCoin = new System.Windows.Forms.PictureBox();
            this.pcbCar = new System.Windows.Forms.PictureBox();
            this.pcbEnemyCar = new System.Windows.Forms.PictureBox();
            this.lblDistance = new System.Windows.Forms.Label();
            this.pcbFinishLine = new System.Windows.Forms.PictureBox();
            this.pnlLeftLines = new System.Windows.Forms.Panel();
            this.pcbLine1 = new System.Windows.Forms.PictureBox();
            this.pcbLine2 = new System.Windows.Forms.PictureBox();
            this.pcbLine3 = new System.Windows.Forms.PictureBox();
            this.pcbLine4 = new System.Windows.Forms.PictureBox();
            this.pcbLine5 = new System.Windows.Forms.PictureBox();
            this.pnlRightLines = new System.Windows.Forms.Panel();
            this.lblLine6 = new System.Windows.Forms.PictureBox();
            this.lblLine10 = new System.Windows.Forms.PictureBox();
            this.lblLine7 = new System.Windows.Forms.PictureBox();
            this.lblLine9 = new System.Windows.Forms.PictureBox();
            this.lblLine8 = new System.Windows.Forms.PictureBox();
            this.pnlUnderGrass = new System.Windows.Forms.Panel();
            this.pnlGrass = new System.Windows.Forms.Panel();
            this.pcbFlats = new System.Windows.Forms.PictureBox();
            this.pcbHouses = new System.Windows.Forms.PictureBox();
            this.pcbChurch = new System.Windows.Forms.PictureBox();
            this.tmrFinishGame = new System.Windows.Forms.Timer(this.components);
            this.pnlTest = new System.Windows.Forms.Panel();
            this.pcbMiniCar = new System.Windows.Forms.PictureBox();
            this.pcbMiniFinishLine = new System.Windows.Forms.PictureBox();
            this.pnlRoad.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbClock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbCoin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbCar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbEnemyCar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbFinishLine)).BeginInit();
            this.pnlLeftLines.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbLine1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbLine2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbLine3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbLine4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbLine5)).BeginInit();
            this.pnlRightLines.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lblLine6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblLine10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblLine7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblLine9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblLine8)).BeginInit();
            this.pnlUnderGrass.SuspendLayout();
            this.pnlGrass.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbFlats)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbHouses)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbChurch)).BeginInit();
            this.pnlTest.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbMiniCar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbMiniFinishLine)).BeginInit();
            this.SuspendLayout();
            // 
            // tmrSceneTimer
            // 
            this.tmrSceneTimer.Interval = 10;
            this.tmrSceneTimer.Tick += new System.EventHandler(this.SceneTimer_Tick);
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblTime.Location = new System.Drawing.Point(215, 11);
            this.lblTime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(70, 29);
            this.lblTime.TabIndex = 17;
            this.lblTime.Text = "time:";
            // 
            // lblPoints
            // 
            this.lblPoints.AutoSize = true;
            this.lblPoints.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblPoints.Location = new System.Drawing.Point(11, 11);
            this.lblPoints.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPoints.Name = "lblPoints";
            this.lblPoints.Size = new System.Drawing.Size(91, 29);
            this.lblPoints.TabIndex = 16;
            this.lblPoints.Text = "points:";
            // 
            // tmrGameTimer
            // 
            this.tmrGameTimer.Interval = 1000;
            this.tmrGameTimer.Tick += new System.EventHandler(this.GameTimer_Tick);
            // 
            // pnlRoad
            // 
            this.pnlRoad.Controls.Add(this.pcbClock);
            this.pnlRoad.Controls.Add(this.pcbCoin);
            this.pnlRoad.Controls.Add(this.pcbCar);
            this.pnlRoad.Controls.Add(this.pcbEnemyCar);
            this.pnlRoad.Controls.Add(this.lblDistance);
            this.pnlRoad.Controls.Add(this.pcbFinishLine);
            this.pnlRoad.Controls.Add(this.lblPoints);
            this.pnlRoad.Controls.Add(this.lblTime);
            this.pnlRoad.Controls.Add(this.pnlLeftLines);
            this.pnlRoad.Controls.Add(this.pnlRightLines);
            this.pnlRoad.Location = new System.Drawing.Point(280, 0);
            this.pnlRoad.Margin = new System.Windows.Forms.Padding(4);
            this.pnlRoad.Name = "pnlRoad";
            this.pnlRoad.Size = new System.Drawing.Size(533, 788);
            this.pnlRoad.TabIndex = 24;
            // 
            // pcbClock
            // 
            this.pcbClock.BackColor = System.Drawing.Color.Transparent;
            this.pcbClock.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pcbClock.BackgroundImage")));
            this.pcbClock.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pcbClock.Location = new System.Drawing.Point(264, 304);
            this.pcbClock.Margin = new System.Windows.Forms.Padding(4);
            this.pcbClock.Name = "pcbClock";
            this.pcbClock.Size = new System.Drawing.Size(40, 37);
            this.pcbClock.TabIndex = 25;
            this.pcbClock.TabStop = false;
            // 
            // pcbCoin
            // 
            this.pcbCoin.BackColor = System.Drawing.Color.Transparent;
            this.pcbCoin.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pcbCoin.BackgroundImage")));
            this.pcbCoin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pcbCoin.Location = new System.Drawing.Point(195, 304);
            this.pcbCoin.Margin = new System.Windows.Forms.Padding(4);
            this.pcbCoin.Name = "pcbCoin";
            this.pcbCoin.Size = new System.Drawing.Size(40, 37);
            this.pcbCoin.TabIndex = 15;
            this.pcbCoin.TabStop = false;
            // 
            // pcbCar
            // 
            this.pcbCar.BackColor = System.Drawing.Color.Transparent;
            this.pcbCar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pcbCar.BackgroundImage")));
            this.pcbCar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pcbCar.Location = new System.Drawing.Point(220, 668);
            this.pcbCar.Margin = new System.Windows.Forms.Padding(4);
            this.pcbCar.Name = "pcbCar";
            this.pcbCar.Size = new System.Drawing.Size(67, 105);
            this.pcbCar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbCar.TabIndex = 12;
            this.pcbCar.TabStop = false;
            // 
            // pcbEnemyCar
            // 
            this.pcbEnemyCar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pcbEnemyCar.BackgroundImage")));
            this.pcbEnemyCar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pcbEnemyCar.Location = new System.Drawing.Point(220, 162);
            this.pcbEnemyCar.Margin = new System.Windows.Forms.Padding(4);
            this.pcbEnemyCar.Name = "pcbEnemyCar";
            this.pcbEnemyCar.Size = new System.Drawing.Size(67, 105);
            this.pcbEnemyCar.TabIndex = 13;
            this.pcbEnemyCar.TabStop = false;
            // 
            // lblDistance
            // 
            this.lblDistance.AutoSize = true;
            this.lblDistance.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblDistance.Location = new System.Drawing.Point(377, 11);
            this.lblDistance.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDistance.Name = "lblDistance";
            this.lblDistance.Size = new System.Drawing.Size(111, 29);
            this.lblDistance.TabIndex = 24;
            this.lblDistance.Text = "distance";
            // 
            // pcbFinishLine
            // 
            this.pcbFinishLine.BackColor = System.Drawing.Color.Transparent;
            this.pcbFinishLine.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pcbFinishLine.BackgroundImage")));
            this.pcbFinishLine.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pcbFinishLine.Enabled = false;
            this.pcbFinishLine.Location = new System.Drawing.Point(-1, 44);
            this.pcbFinishLine.Margin = new System.Windows.Forms.Padding(4);
            this.pcbFinishLine.Name = "pcbFinishLine";
            this.pcbFinishLine.Size = new System.Drawing.Size(535, 62);
            this.pcbFinishLine.TabIndex = 22;
            this.pcbFinishLine.TabStop = false;
            this.pcbFinishLine.Visible = false;
            // 
            // pnlLeftLines
            // 
            this.pnlLeftLines.Controls.Add(this.pcbLine1);
            this.pnlLeftLines.Controls.Add(this.pcbLine2);
            this.pnlLeftLines.Controls.Add(this.pcbLine3);
            this.pnlLeftLines.Controls.Add(this.pcbLine4);
            this.pnlLeftLines.Controls.Add(this.pcbLine5);
            this.pnlLeftLines.Location = new System.Drawing.Point(137, 0);
            this.pnlLeftLines.Margin = new System.Windows.Forms.Padding(4);
            this.pnlLeftLines.Name = "pnlLeftLines";
            this.pnlLeftLines.Size = new System.Drawing.Size(24, 788);
            this.pnlLeftLines.TabIndex = 23;
            // 
            // pcbLine1
            // 
            this.pcbLine1.BackColor = System.Drawing.Color.White;
            this.pcbLine1.Location = new System.Drawing.Point(0, 0);
            this.pcbLine1.Margin = new System.Windows.Forms.Padding(4);
            this.pcbLine1.Name = "pcbLine1";
            this.pcbLine1.Size = new System.Drawing.Size(24, 98);
            this.pcbLine1.TabIndex = 0;
            this.pcbLine1.TabStop = false;
            this.pcbLine1.Tag = "4";
            // 
            // pcbLine2
            // 
            this.pcbLine2.BackColor = System.Drawing.Color.White;
            this.pcbLine2.Location = new System.Drawing.Point(0, 169);
            this.pcbLine2.Margin = new System.Windows.Forms.Padding(4);
            this.pcbLine2.Name = "pcbLine2";
            this.pcbLine2.Size = new System.Drawing.Size(24, 98);
            this.pcbLine2.TabIndex = 1;
            this.pcbLine2.TabStop = false;
            this.pcbLine2.Tag = "3";
            // 
            // pcbLine3
            // 
            this.pcbLine3.BackColor = System.Drawing.Color.White;
            this.pcbLine3.Location = new System.Drawing.Point(0, 337);
            this.pcbLine3.Margin = new System.Windows.Forms.Padding(4);
            this.pcbLine3.Name = "pcbLine3";
            this.pcbLine3.Size = new System.Drawing.Size(24, 98);
            this.pcbLine3.TabIndex = 2;
            this.pcbLine3.TabStop = false;
            this.pcbLine3.Tag = "2";
            // 
            // pcbLine4
            // 
            this.pcbLine4.BackColor = System.Drawing.Color.White;
            this.pcbLine4.Location = new System.Drawing.Point(0, 506);
            this.pcbLine4.Margin = new System.Windows.Forms.Padding(4);
            this.pcbLine4.Name = "pcbLine4";
            this.pcbLine4.Size = new System.Drawing.Size(24, 98);
            this.pcbLine4.TabIndex = 3;
            this.pcbLine4.TabStop = false;
            this.pcbLine4.Tag = "1";
            // 
            // pcbLine5
            // 
            this.pcbLine5.BackColor = System.Drawing.Color.White;
            this.pcbLine5.Location = new System.Drawing.Point(0, 674);
            this.pcbLine5.Margin = new System.Windows.Forms.Padding(4);
            this.pcbLine5.Name = "pcbLine5";
            this.pcbLine5.Size = new System.Drawing.Size(24, 98);
            this.pcbLine5.TabIndex = 4;
            this.pcbLine5.TabStop = false;
            this.pcbLine5.Tag = "0";
            // 
            // pnlRightLines
            // 
            this.pnlRightLines.Controls.Add(this.lblLine6);
            this.pnlRightLines.Controls.Add(this.lblLine10);
            this.pnlRightLines.Controls.Add(this.lblLine7);
            this.pnlRightLines.Controls.Add(this.lblLine9);
            this.pnlRightLines.Controls.Add(this.lblLine8);
            this.pnlRightLines.Location = new System.Drawing.Point(345, 0);
            this.pnlRightLines.Margin = new System.Windows.Forms.Padding(4);
            this.pnlRightLines.Name = "pnlRightLines";
            this.pnlRightLines.Size = new System.Drawing.Size(24, 788);
            this.pnlRightLines.TabIndex = 5;
            // 
            // lblLine6
            // 
            this.lblLine6.BackColor = System.Drawing.Color.White;
            this.lblLine6.Location = new System.Drawing.Point(0, 0);
            this.lblLine6.Margin = new System.Windows.Forms.Padding(4);
            this.lblLine6.Name = "lblLine6";
            this.lblLine6.Size = new System.Drawing.Size(24, 98);
            this.lblLine6.TabIndex = 11;
            this.lblLine6.TabStop = false;
            this.lblLine6.Tag = "4";
            // 
            // lblLine10
            // 
            this.lblLine10.BackColor = System.Drawing.Color.White;
            this.lblLine10.Location = new System.Drawing.Point(0, 679);
            this.lblLine10.Margin = new System.Windows.Forms.Padding(4);
            this.lblLine10.Name = "lblLine10";
            this.lblLine10.Size = new System.Drawing.Size(24, 98);
            this.lblLine10.TabIndex = 7;
            this.lblLine10.TabStop = false;
            this.lblLine10.Tag = "0";
            // 
            // lblLine7
            // 
            this.lblLine7.BackColor = System.Drawing.Color.White;
            this.lblLine7.Location = new System.Drawing.Point(0, 170);
            this.lblLine7.Margin = new System.Windows.Forms.Padding(4);
            this.lblLine7.Name = "lblLine7";
            this.lblLine7.Size = new System.Drawing.Size(24, 98);
            this.lblLine7.TabIndex = 10;
            this.lblLine7.TabStop = false;
            this.lblLine7.Tag = "3";
            // 
            // lblLine9
            // 
            this.lblLine9.BackColor = System.Drawing.Color.White;
            this.lblLine9.Location = new System.Drawing.Point(0, 510);
            this.lblLine9.Margin = new System.Windows.Forms.Padding(4);
            this.lblLine9.Name = "lblLine9";
            this.lblLine9.Size = new System.Drawing.Size(24, 98);
            this.lblLine9.TabIndex = 8;
            this.lblLine9.TabStop = false;
            this.lblLine9.Tag = "1";
            // 
            // lblLine8
            // 
            this.lblLine8.BackColor = System.Drawing.Color.White;
            this.lblLine8.Location = new System.Drawing.Point(0, 340);
            this.lblLine8.Margin = new System.Windows.Forms.Padding(4);
            this.lblLine8.Name = "lblLine8";
            this.lblLine8.Size = new System.Drawing.Size(24, 98);
            this.lblLine8.TabIndex = 9;
            this.lblLine8.TabStop = false;
            this.lblLine8.Tag = "2";
            // 
            // pnlUnderGrass
            // 
            this.pnlUnderGrass.BackColor = System.Drawing.Color.DarkGreen;
            this.pnlUnderGrass.Controls.Add(this.pnlGrass);
            this.pnlUnderGrass.Location = new System.Drawing.Point(80, 0);
            this.pnlUnderGrass.Margin = new System.Windows.Forms.Padding(4);
            this.pnlUnderGrass.Name = "pnlUnderGrass";
            this.pnlUnderGrass.Size = new System.Drawing.Size(200, 788);
            this.pnlUnderGrass.TabIndex = 24;
            // 
            // pnlGrass
            // 
            this.pnlGrass.BackColor = System.Drawing.Color.DarkGreen;
            this.pnlGrass.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pnlGrass.Controls.Add(this.pcbFlats);
            this.pnlGrass.Controls.Add(this.pcbHouses);
            this.pnlGrass.Controls.Add(this.pcbChurch);
            this.pnlGrass.Location = new System.Drawing.Point(0, 0);
            this.pnlGrass.Margin = new System.Windows.Forms.Padding(4);
            this.pnlGrass.Name = "pnlGrass";
            this.pnlGrass.Size = new System.Drawing.Size(200, 788);
            this.pnlGrass.TabIndex = 20;
            // 
            // pcbFlats
            // 
            this.pcbFlats.BackColor = System.Drawing.Color.Transparent;
            this.pcbFlats.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pcbFlats.BackgroundImage")));
            this.pcbFlats.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pcbFlats.Location = new System.Drawing.Point(0, 279);
            this.pcbFlats.Margin = new System.Windows.Forms.Padding(4);
            this.pcbFlats.Name = "pcbFlats";
            this.pcbFlats.Size = new System.Drawing.Size(200, 202);
            this.pcbFlats.TabIndex = 3;
            this.pcbFlats.TabStop = false;
            // 
            // pcbHouses
            // 
            this.pcbHouses.BackColor = System.Drawing.Color.Transparent;
            this.pcbHouses.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pcbHouses.BackgroundImage")));
            this.pcbHouses.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pcbHouses.Location = new System.Drawing.Point(35, 92);
            this.pcbHouses.Margin = new System.Windows.Forms.Padding(4);
            this.pcbHouses.Name = "pcbHouses";
            this.pcbHouses.Size = new System.Drawing.Size(135, 119);
            this.pcbHouses.TabIndex = 1;
            this.pcbHouses.TabStop = false;
            // 
            // pcbChurch
            // 
            this.pcbChurch.BackColor = System.Drawing.Color.Transparent;
            this.pcbChurch.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pcbChurch.BackgroundImage")));
            this.pcbChurch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pcbChurch.Location = new System.Drawing.Point(0, 562);
            this.pcbChurch.Margin = new System.Windows.Forms.Padding(4);
            this.pcbChurch.Name = "pcbChurch";
            this.pcbChurch.Size = new System.Drawing.Size(200, 164);
            this.pcbChurch.TabIndex = 0;
            this.pcbChurch.TabStop = false;
            // 
            // tmrFinishGame
            // 
            this.tmrFinishGame.Tick += new System.EventHandler(this.FinishGame_Tick);
            // 
            // pnlTest
            // 
            this.pnlTest.Controls.Add(this.pcbMiniCar);
            this.pnlTest.Controls.Add(this.pcbMiniFinishLine);
            this.pnlTest.Location = new System.Drawing.Point(0, 0);
            this.pnlTest.Margin = new System.Windows.Forms.Padding(4);
            this.pnlTest.Name = "pnlTest";
            this.pnlTest.Size = new System.Drawing.Size(80, 788);
            this.pnlTest.TabIndex = 25;
            // 
            // pcbMiniCar
            // 
            this.pcbMiniCar.BackColor = System.Drawing.Color.Transparent;
            this.pcbMiniCar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pcbMiniCar.BackgroundImage")));
            this.pcbMiniCar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pcbMiniCar.Location = new System.Drawing.Point(23, 660);
            this.pcbMiniCar.Margin = new System.Windows.Forms.Padding(4);
            this.pcbMiniCar.Name = "pcbMiniCar";
            this.pcbMiniCar.Size = new System.Drawing.Size(35, 62);
            this.pcbMiniCar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbMiniCar.TabIndex = 13;
            this.pcbMiniCar.TabStop = false;
            // 
            // pcbMiniFinishLine
            // 
            this.pcbMiniFinishLine.BackColor = System.Drawing.Color.Transparent;
            this.pcbMiniFinishLine.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pcbMiniFinishLine.BackgroundImage")));
            this.pcbMiniFinishLine.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pcbMiniFinishLine.Location = new System.Drawing.Point(0, 50);
            this.pcbMiniFinishLine.Margin = new System.Windows.Forms.Padding(4);
            this.pcbMiniFinishLine.Name = "pcbMiniFinishLine";
            this.pcbMiniFinishLine.Size = new System.Drawing.Size(80, 10);
            this.pcbMiniFinishLine.TabIndex = 23;
            this.pcbMiniFinishLine.TabStop = false;
            // 
            // FrmGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(813, 789);
            this.Controls.Add(this.pnlTest);
            this.Controls.Add(this.pnlRoad);
            this.Controls.Add(this.pnlUnderGrass);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmGame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RoadFighter";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeysHandling);
            this.pnlRoad.ResumeLayout(false);
            this.pnlRoad.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbClock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbCoin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbCar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbEnemyCar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbFinishLine)).EndInit();
            this.pnlLeftLines.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pcbLine1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbLine2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbLine3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbLine4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbLine5)).EndInit();
            this.pnlRightLines.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.lblLine6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblLine10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblLine7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblLine9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblLine8)).EndInit();
            this.pnlUnderGrass.ResumeLayout(false);
            this.pnlGrass.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pcbFlats)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbHouses)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbChurch)).EndInit();
            this.pnlTest.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pcbMiniCar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbMiniFinishLine)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        public System.Windows.Forms.PictureBox pcbCoin;
        public System.Windows.Forms.PictureBox pcbCar;
        public System.Windows.Forms.PictureBox pcbEnemyCar;
        public System.Windows.Forms.Panel pnlGrass;
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
        public System.Windows.Forms.PictureBox pcbMiniCar;
        public System.Windows.Forms.PictureBox pcbMiniFinishLine;
        public System.Windows.Forms.Label lblDistance;
        public System.Windows.Forms.PictureBox pcbClock;
        public System.Windows.Forms.PictureBox pcbFlats;
        public System.Windows.Forms.PictureBox pcbHouses;
        public System.Windows.Forms.PictureBox pcbChurch;
    }
}

