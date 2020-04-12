namespace RoadFighter
{
    partial class GameForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameForm));
            this.line1 = new System.Windows.Forms.PictureBox();
            this.line2 = new System.Windows.Forms.PictureBox();
            this.line3 = new System.Windows.Forms.PictureBox();
            this.line4 = new System.Windows.Forms.PictureBox();
            this.line5 = new System.Windows.Forms.PictureBox();
            this.tmrSceneTimer = new System.Windows.Forms.Timer(this.components);
            this.line6 = new System.Windows.Forms.PictureBox();
            this.line7 = new System.Windows.Forms.PictureBox();
            this.line8 = new System.Windows.Forms.PictureBox();
            this.line9 = new System.Windows.Forms.PictureBox();
            this.line10 = new System.Windows.Forms.PictureBox();
            this.car = new System.Windows.Forms.PictureBox();
            this.tree1 = new System.Windows.Forms.PictureBox();
            this.tree2 = new System.Windows.Forms.PictureBox();
            this.tree3 = new System.Windows.Forms.PictureBox();
            this.tree4 = new System.Windows.Forms.PictureBox();
            this.grass = new System.Windows.Forms.Panel();
            this.road = new System.Windows.Forms.Panel();
            this.pcbFinish = new System.Windows.Forms.PictureBox();
            this.lblGameTime = new System.Windows.Forms.Label();
            this.lblPoints = new System.Windows.Forms.Label();
            this.pcbCoin = new System.Windows.Forms.PictureBox();
            this.lblHelper = new System.Windows.Forms.Label();
            this.pcbEnemy1 = new System.Windows.Forms.PictureBox();
            this.tmrGameTimer = new System.Windows.Forms.Timer(this.components);
            this.underGrass = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.line1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.line2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.line3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.line4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.line5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.line6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.line7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.line8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.line9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.line10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.car)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tree1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tree2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tree3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tree4)).BeginInit();
            this.grass.SuspendLayout();
            this.road.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbFinish)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbCoin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbEnemy1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.underGrass)).BeginInit();
            this.SuspendLayout();
            // 
            // line1
            // 
            this.line1.BackColor = System.Drawing.Color.White;
            this.line1.Location = new System.Drawing.Point(147, 0);
            this.line1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.line1.Name = "line1";
            this.line1.Size = new System.Drawing.Size(24, 98);
            this.line1.TabIndex = 0;
            this.line1.TabStop = false;
            // 
            // line2
            // 
            this.line2.BackColor = System.Drawing.Color.White;
            this.line2.Location = new System.Drawing.Point(147, 169);
            this.line2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.line2.Name = "line2";
            this.line2.Size = new System.Drawing.Size(24, 98);
            this.line2.TabIndex = 1;
            this.line2.TabStop = false;
            // 
            // line3
            // 
            this.line3.BackColor = System.Drawing.Color.White;
            this.line3.Location = new System.Drawing.Point(147, 337);
            this.line3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.line3.Name = "line3";
            this.line3.Size = new System.Drawing.Size(24, 98);
            this.line3.TabIndex = 2;
            this.line3.TabStop = false;
            // 
            // line4
            // 
            this.line4.BackColor = System.Drawing.Color.White;
            this.line4.Location = new System.Drawing.Point(147, 506);
            this.line4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.line4.Name = "line4";
            this.line4.Size = new System.Drawing.Size(24, 98);
            this.line4.TabIndex = 3;
            this.line4.TabStop = false;
            // 
            // line5
            // 
            this.line5.BackColor = System.Drawing.Color.White;
            this.line5.Location = new System.Drawing.Point(147, 674);
            this.line5.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.line5.Name = "line5";
            this.line5.Size = new System.Drawing.Size(24, 98);
            this.line5.TabIndex = 4;
            this.line5.TabStop = false;
            // 
            // tmrSceneTimer
            // 
            this.tmrSceneTimer.Enabled = true;
            this.tmrSceneTimer.Interval = 10;
            this.tmrSceneTimer.Tick += new System.EventHandler(this.sceneTimer_Tick);
            // 
            // line6
            // 
            this.line6.BackColor = System.Drawing.Color.White;
            this.line6.Location = new System.Drawing.Point(364, 0);
            this.line6.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.line6.Name = "line6";
            this.line6.Size = new System.Drawing.Size(24, 98);
            this.line6.TabIndex = 11;
            this.line6.TabStop = false;
            // 
            // line7
            // 
            this.line7.BackColor = System.Drawing.Color.White;
            this.line7.Location = new System.Drawing.Point(364, 170);
            this.line7.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.line7.Name = "line7";
            this.line7.Size = new System.Drawing.Size(24, 98);
            this.line7.TabIndex = 10;
            this.line7.TabStop = false;
            // 
            // line8
            // 
            this.line8.BackColor = System.Drawing.Color.White;
            this.line8.Location = new System.Drawing.Point(364, 340);
            this.line8.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.line8.Name = "line8";
            this.line8.Size = new System.Drawing.Size(24, 98);
            this.line8.TabIndex = 9;
            this.line8.TabStop = false;
            // 
            // line9
            // 
            this.line9.BackColor = System.Drawing.Color.White;
            this.line9.Location = new System.Drawing.Point(364, 510);
            this.line9.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.line9.Name = "line9";
            this.line9.Size = new System.Drawing.Size(24, 98);
            this.line9.TabIndex = 8;
            this.line9.TabStop = false;
            // 
            // line10
            // 
            this.line10.BackColor = System.Drawing.Color.White;
            this.line10.Location = new System.Drawing.Point(364, 679);
            this.line10.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.line10.Name = "line10";
            this.line10.Size = new System.Drawing.Size(24, 98);
            this.line10.TabIndex = 7;
            this.line10.TabStop = false;
            // 
            // car
            // 
            this.car.BackColor = System.Drawing.Color.Transparent;
            this.car.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("car.BackgroundImage")));
            this.car.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.car.Location = new System.Drawing.Point(232, 682);
            this.car.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.car.Name = "car";
            this.car.Size = new System.Drawing.Size(73, 92);
            this.car.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.car.TabIndex = 12;
            this.car.TabStop = false;
            // 
            // tree1
            // 
            this.tree1.BackColor = System.Drawing.Color.Transparent;
            this.tree1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tree1.BackgroundImage")));
            this.tree1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tree1.Location = new System.Drawing.Point(45, 612);
            this.tree1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tree1.Name = "tree1";
            this.tree1.Size = new System.Drawing.Size(120, 111);
            this.tree1.TabIndex = 14;
            this.tree1.TabStop = false;
            this.tree1.Tag = "0";
            // 
            // tree2
            // 
            this.tree2.BackColor = System.Drawing.Color.Transparent;
            this.tree2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tree2.BackgroundImage")));
            this.tree2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tree2.Location = new System.Drawing.Point(45, 431);
            this.tree2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tree2.Name = "tree2";
            this.tree2.Size = new System.Drawing.Size(120, 111);
            this.tree2.TabIndex = 15;
            this.tree2.TabStop = false;
            this.tree2.Tag = "1";
            // 
            // tree3
            // 
            this.tree3.BackColor = System.Drawing.Color.Transparent;
            this.tree3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tree3.BackgroundImage")));
            this.tree3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tree3.Location = new System.Drawing.Point(45, 250);
            this.tree3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tree3.Name = "tree3";
            this.tree3.Size = new System.Drawing.Size(120, 111);
            this.tree3.TabIndex = 16;
            this.tree3.TabStop = false;
            this.tree3.Tag = "2";
            // 
            // tree4
            // 
            this.tree4.BackColor = System.Drawing.Color.Transparent;
            this.tree4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tree4.BackgroundImage")));
            this.tree4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tree4.Location = new System.Drawing.Point(45, 69);
            this.tree4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tree4.Name = "tree4";
            this.tree4.Size = new System.Drawing.Size(120, 111);
            this.tree4.TabIndex = 17;
            this.tree4.TabStop = false;
            this.tree4.Tag = "3";
            // 
            // grass
            // 
            this.grass.BackColor = System.Drawing.Color.Green;
            this.grass.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("grass.BackgroundImage")));
            this.grass.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.grass.Controls.Add(this.tree4);
            this.grass.Controls.Add(this.tree1);
            this.grass.Controls.Add(this.tree2);
            this.grass.Controls.Add(this.tree3);
            this.grass.Location = new System.Drawing.Point(0, 0);
            this.grass.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grass.Name = "grass";
            this.grass.Size = new System.Drawing.Size(240, 788);
            this.grass.TabIndex = 20;
            // 
            // road
            // 
            this.road.BackColor = System.Drawing.Color.Silver;
            this.road.Controls.Add(this.car);
            this.road.Controls.Add(this.pcbFinish);
            this.road.Controls.Add(this.lblGameTime);
            this.road.Controls.Add(this.lblPoints);
            this.road.Controls.Add(this.pcbCoin);
            this.road.Controls.Add(this.lblHelper);
            this.road.Controls.Add(this.pcbEnemy1);
            this.road.Controls.Add(this.line1);
            this.road.Controls.Add(this.line7);
            this.road.Controls.Add(this.line2);
            this.road.Controls.Add(this.line8);
            this.road.Controls.Add(this.line3);
            this.road.Controls.Add(this.line9);
            this.road.Controls.Add(this.line4);
            this.road.Controls.Add(this.line10);
            this.road.Controls.Add(this.line5);
            this.road.Controls.Add(this.line6);
            this.road.Location = new System.Drawing.Point(240, 0);
            this.road.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.road.Name = "road";
            this.road.Size = new System.Drawing.Size(533, 788);
            this.road.TabIndex = 21;
            // 
            // pcbFinish
            // 
            this.pcbFinish.BackgroundImage = global::RoadFighter.Properties.Resources.finish;
            this.pcbFinish.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pcbFinish.Location = new System.Drawing.Point(0, 49);
            this.pcbFinish.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pcbFinish.Name = "pcbFinish";
            this.pcbFinish.Size = new System.Drawing.Size(533, 62);
            this.pcbFinish.TabIndex = 22;
            this.pcbFinish.TabStop = false;
            this.pcbFinish.Visible = false;
            // 
            // lblGameTime
            // 
            this.lblGameTime.AutoSize = true;
            this.lblGameTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblGameTime.Location = new System.Drawing.Point(179, 11);
            this.lblGameTime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGameTime.Name = "lblGameTime";
            this.lblGameTime.Size = new System.Drawing.Size(63, 29);
            this.lblGameTime.TabIndex = 17;
            this.lblGameTime.Text = "time";
            this.lblGameTime.Visible = false;
            // 
            // lblPoints
            // 
            this.lblPoints.AutoSize = true;
            this.lblPoints.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblPoints.Location = new System.Drawing.Point(8, 11);
            this.lblPoints.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPoints.Name = "lblPoints";
            this.lblPoints.Size = new System.Drawing.Size(84, 29);
            this.lblPoints.TabIndex = 16;
            this.lblPoints.Text = "points";
            this.lblPoints.Visible = false;
            // 
            // pcbCoin
            // 
            this.pcbCoin.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pcbCoin.BackgroundImage")));
            this.pcbCoin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pcbCoin.Location = new System.Drawing.Point(245, 362);
            this.pcbCoin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pcbCoin.Name = "pcbCoin";
            this.pcbCoin.Size = new System.Drawing.Size(40, 37);
            this.pcbCoin.TabIndex = 15;
            this.pcbCoin.TabStop = false;
            // 
            // lblHelper
            // 
            this.lblHelper.AutoSize = true;
            this.lblHelper.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblHelper.Location = new System.Drawing.Point(207, 288);
            this.lblHelper.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHelper.Name = "lblHelper";
            this.lblHelper.Size = new System.Drawing.Size(212, 31);
            this.lblHelper.TabIndex = 14;
            this.lblHelper.Text = "GAMEHELPER";
            this.lblHelper.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblHelper.Visible = false;
            // 
            // pcbEnemy1
            // 
            this.pcbEnemy1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pcbEnemy1.BackgroundImage")));
            this.pcbEnemy1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pcbEnemy1.Location = new System.Drawing.Point(40, 214);
            this.pcbEnemy1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pcbEnemy1.Name = "pcbEnemy1";
            this.pcbEnemy1.Size = new System.Drawing.Size(65, 106);
            this.pcbEnemy1.TabIndex = 13;
            this.pcbEnemy1.TabStop = false;
            // 
            // tmrGameTimer
            // 
            this.tmrGameTimer.Enabled = true;
            this.tmrGameTimer.Interval = 1000;
            this.tmrGameTimer.Tick += new System.EventHandler(this.tmrGameTimer_Tick);
            // 
            // underGrass
            // 
            this.underGrass.BackColor = System.Drawing.Color.Green;
            this.underGrass.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("underGrass.BackgroundImage")));
            this.underGrass.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.underGrass.Location = new System.Drawing.Point(0, 0);
            this.underGrass.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.underGrass.Name = "underGrass";
            this.underGrass.Size = new System.Drawing.Size(240, 788);
            this.underGrass.TabIndex = 19;
            this.underGrass.TabStop = false;
            // 
            // GameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(771, 789);
            this.Controls.Add(this.road);
            this.Controls.Add(this.grass);
            this.Controls.Add(this.underGrass);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "GameForm";
            this.Text = "RoadFighter";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.keysHandling);
            ((System.ComponentModel.ISupportInitialize)(this.line1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.line2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.line3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.line4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.line5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.line6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.line7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.line8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.line9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.line10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.car)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tree1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tree2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tree3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tree4)).EndInit();
            this.grass.ResumeLayout(false);
            this.road.ResumeLayout(false);
            this.road.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbFinish)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbCoin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbEnemy1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.underGrass)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox line1;
        private System.Windows.Forms.PictureBox line2;
        private System.Windows.Forms.PictureBox line3;
        private System.Windows.Forms.PictureBox line4;
        private System.Windows.Forms.PictureBox line5;
        private System.Windows.Forms.Timer tmrSceneTimer;
        private System.Windows.Forms.PictureBox line6;
        private System.Windows.Forms.PictureBox line7;
        private System.Windows.Forms.PictureBox line8;
        private System.Windows.Forms.PictureBox line9;
        private System.Windows.Forms.PictureBox line10;
        private System.Windows.Forms.PictureBox car;
        private System.Windows.Forms.PictureBox tree1;
        private System.Windows.Forms.PictureBox tree2;
        private System.Windows.Forms.PictureBox tree3;
        private System.Windows.Forms.PictureBox tree4;
        private System.Windows.Forms.Panel grass;
        private System.Windows.Forms.Panel road;
        private System.Windows.Forms.PictureBox pcbEnemy1;
        private System.Windows.Forms.Label lblHelper;
        private System.Windows.Forms.PictureBox pcbCoin;
        private System.Windows.Forms.Label lblPoints;
        private System.Windows.Forms.Label lblGameTime;
        private System.Windows.Forms.Timer tmrGameTimer;
        private System.Windows.Forms.PictureBox underGrass;
        private System.Windows.Forms.PictureBox pcbFinish;
    }
}

