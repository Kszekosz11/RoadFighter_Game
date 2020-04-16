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
            this.lblTime = new System.Windows.Forms.Label();
            this.lblPoints = new System.Windows.Forms.Label();
            this.tmrGameTimer = new System.Windows.Forms.Timer(this.components);
            this.pnlGrass = new System.Windows.Forms.Panel();
            this.pnlRoad = new System.Windows.Forms.Panel();
            this.lblDistance = new System.Windows.Forms.Label();
            this.pnlLeftLines = new System.Windows.Forms.Panel();
            this.pnlRightLines = new System.Windows.Forms.Panel();
            this.pnlUnderGrass = new System.Windows.Forms.Panel();
            this.tmrFinishGame = new System.Windows.Forms.Timer(this.components);
            this.pnlTest = new System.Windows.Forms.Panel();
            this.pcbMiniCar = new System.Windows.Forms.PictureBox();
            this.pcbMiniFinishLine = new System.Windows.Forms.PictureBox();
            this.pcbClock = new System.Windows.Forms.PictureBox();
            this.pcbCoin = new System.Windows.Forms.PictureBox();
            this.pcbCar = new System.Windows.Forms.PictureBox();
            this.pcbEnemyCar = new System.Windows.Forms.PictureBox();
            this.pcbFinishLine = new System.Windows.Forms.PictureBox();
            this.pcbLine1 = new System.Windows.Forms.PictureBox();
            this.pcbLine2 = new System.Windows.Forms.PictureBox();
            this.pcbLine3 = new System.Windows.Forms.PictureBox();
            this.pcbLine4 = new System.Windows.Forms.PictureBox();
            this.pcbLine5 = new System.Windows.Forms.PictureBox();
            this.lblLine6 = new System.Windows.Forms.PictureBox();
            this.lblLine10 = new System.Windows.Forms.PictureBox();
            this.lblLine7 = new System.Windows.Forms.PictureBox();
            this.lblLine9 = new System.Windows.Forms.PictureBox();
            this.lblLine8 = new System.Windows.Forms.PictureBox();
            this.pcbTree4 = new System.Windows.Forms.PictureBox();
            this.pcbTree1 = new System.Windows.Forms.PictureBox();
            this.pcbTree2 = new System.Windows.Forms.PictureBox();
            this.pcbTree3 = new System.Windows.Forms.PictureBox();
            this.pnlGrass.SuspendLayout();
            this.pnlRoad.SuspendLayout();
            this.pnlLeftLines.SuspendLayout();
            this.pnlRightLines.SuspendLayout();
            this.pnlUnderGrass.SuspendLayout();
            this.pnlTest.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbMiniCar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbMiniFinishLine)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbClock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbCoin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbCar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbEnemyCar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbFinishLine)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbLine1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbLine2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbLine3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbLine4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbLine5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblLine6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblLine10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblLine7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblLine9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblLine8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbTree4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbTree1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbTree2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbTree3)).BeginInit();
            this.SuspendLayout();
            // 
            // tmrSceneTimer
            // 
            this.tmrSceneTimer.Enabled = true;
            this.tmrSceneTimer.Interval = 10;
            this.tmrSceneTimer.Tick += new System.EventHandler(this.sceneTimer_Tick);
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
            this.pnlGrass.Margin = new System.Windows.Forms.Padding(4);
            this.pnlGrass.Name = "pnlGrass";
            this.pnlGrass.Size = new System.Drawing.Size(147, 788);
            this.pnlGrass.TabIndex = 20;
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
            this.pnlRoad.Location = new System.Drawing.Point(224, 0);
            this.pnlRoad.Margin = new System.Windows.Forms.Padding(4);
            this.pnlRoad.Name = "pnlRoad";
            this.pnlRoad.Size = new System.Drawing.Size(533, 788);
            this.pnlRoad.TabIndex = 24;
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
            // pnlUnderGrass
            // 
            this.pnlUnderGrass.BackColor = System.Drawing.Color.Green;
            this.pnlUnderGrass.Controls.Add(this.pnlGrass);
            this.pnlUnderGrass.Location = new System.Drawing.Point(80, 0);
            this.pnlUnderGrass.Margin = new System.Windows.Forms.Padding(4);
            this.pnlUnderGrass.Name = "pnlUnderGrass";
            this.pnlUnderGrass.Size = new System.Drawing.Size(147, 788);
            this.pnlUnderGrass.TabIndex = 24;
            // 
            // tmrFinishGame
            // 
            this.tmrFinishGame.Tick += new System.EventHandler(this.tmrFinishGame_Tick);
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
            this.pcbMiniCar.BackgroundImage = global::RoadFighter.Properties.Resources.car;
            this.pcbMiniCar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pcbMiniCar.Location = new System.Drawing.Point(23, 714);
            this.pcbMiniCar.Margin = new System.Windows.Forms.Padding(4);
            this.pcbMiniCar.Name = "pcbMiniCar";
            this.pcbMiniCar.Size = new System.Drawing.Size(35, 62);
            this.pcbMiniCar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbMiniCar.TabIndex = 13;
            this.pcbMiniCar.TabStop = false;
            // 
            // pcbMiniFinishLine
            // 
            this.pcbMiniFinishLine.BackgroundImage = global::RoadFighter.Properties.Resources.finish;
            this.pcbMiniFinishLine.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pcbMiniFinishLine.Location = new System.Drawing.Point(0, 49);
            this.pcbMiniFinishLine.Margin = new System.Windows.Forms.Padding(4);
            this.pcbMiniFinishLine.Name = "pcbMiniFinishLine";
            this.pcbMiniFinishLine.Size = new System.Drawing.Size(80, 12);
            this.pcbMiniFinishLine.TabIndex = 23;
            this.pcbMiniFinishLine.TabStop = false;
            // 
            // pcbClock
            // 
            this.pcbClock.BackColor = System.Drawing.Color.Transparent;
            this.pcbClock.BackgroundImage = global::RoadFighter.Properties.Resources.time;
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
            this.pcbCoin.BackgroundImage = global::RoadFighter.Properties.Resources.coin;
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
            this.pcbCar.BackgroundImage = global::RoadFighter.Properties.Resources.car;
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
            // pcbFinishLine
            // 
            this.pcbFinishLine.BackgroundImage = global::RoadFighter.Properties.Resources.finish;
            this.pcbFinishLine.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pcbFinishLine.Location = new System.Drawing.Point(-1, 44);
            this.pcbFinishLine.Margin = new System.Windows.Forms.Padding(4);
            this.pcbFinishLine.Name = "pcbFinishLine";
            this.pcbFinishLine.Size = new System.Drawing.Size(535, 62);
            this.pcbFinishLine.TabIndex = 22;
            this.pcbFinishLine.TabStop = false;
            this.pcbFinishLine.Visible = false;
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
            // pcbTree4
            // 
            this.pcbTree4.BackColor = System.Drawing.Color.Transparent;
            this.pcbTree4.BackgroundImage = global::RoadFighter.Properties.Resources.river;
            this.pcbTree4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pcbTree4.Location = new System.Drawing.Point(16, 49);
            this.pcbTree4.Margin = new System.Windows.Forms.Padding(4);
            this.pcbTree4.Name = "pcbTree4";
            this.pcbTree4.Size = new System.Drawing.Size(120, 111);
            this.pcbTree4.TabIndex = 17;
            this.pcbTree4.TabStop = false;
            this.pcbTree4.Tag = "";
            // 
            // pcbTree1
            // 
            this.pcbTree1.BackColor = System.Drawing.Color.Transparent;
            this.pcbTree1.BackgroundImage = global::RoadFighter.Properties.Resources.church;
            this.pcbTree1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pcbTree1.Location = new System.Drawing.Point(16, 592);
            this.pcbTree1.Margin = new System.Windows.Forms.Padding(4);
            this.pcbTree1.Name = "pcbTree1";
            this.pcbTree1.Size = new System.Drawing.Size(120, 111);
            this.pcbTree1.TabIndex = 14;
            this.pcbTree1.TabStop = false;
            this.pcbTree1.Tag = "";
            // 
            // pcbTree2
            // 
            this.pcbTree2.BackColor = System.Drawing.Color.Transparent;
            this.pcbTree2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pcbTree2.BackgroundImage")));
            this.pcbTree2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pcbTree2.Location = new System.Drawing.Point(16, 411);
            this.pcbTree2.Margin = new System.Windows.Forms.Padding(4);
            this.pcbTree2.Name = "pcbTree2";
            this.pcbTree2.Size = new System.Drawing.Size(120, 111);
            this.pcbTree2.TabIndex = 15;
            this.pcbTree2.TabStop = false;
            this.pcbTree2.Tag = "";
            // 
            // pcbTree3
            // 
            this.pcbTree3.BackColor = System.Drawing.Color.Transparent;
            this.pcbTree3.BackgroundImage = global::RoadFighter.Properties.Resources.flat;
            this.pcbTree3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pcbTree3.Location = new System.Drawing.Point(16, 230);
            this.pcbTree3.Margin = new System.Windows.Forms.Padding(4);
            this.pcbTree3.Name = "pcbTree3";
            this.pcbTree3.Size = new System.Drawing.Size(120, 111);
            this.pcbTree3.TabIndex = 16;
            this.pcbTree3.TabStop = false;
            this.pcbTree3.Tag = "";
            // 
            // frmGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(761, 789);
            this.Controls.Add(this.pnlTest);
            this.Controls.Add(this.pnlRoad);
            this.Controls.Add(this.pnlUnderGrass);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmGame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RoadFighter";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.keysHandling);
            this.pnlGrass.ResumeLayout(false);
            this.pnlRoad.ResumeLayout(false);
            this.pnlRoad.PerformLayout();
            this.pnlLeftLines.ResumeLayout(false);
            this.pnlRightLines.ResumeLayout(false);
            this.pnlUnderGrass.ResumeLayout(false);
            this.pnlTest.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pcbMiniCar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbMiniFinishLine)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbClock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbCoin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbCar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbEnemyCar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbFinishLine)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbLine1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbLine2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbLine3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbLine4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbLine5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblLine6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblLine10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblLine7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblLine9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblLine8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbTree4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbTree1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbTree2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbTree3)).EndInit();
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
        public System.Windows.Forms.PictureBox pcbMiniCar;
        public System.Windows.Forms.PictureBox pcbMiniFinishLine;
        public System.Windows.Forms.Label lblDistance;
        public System.Windows.Forms.PictureBox pcbClock;
    }
}

