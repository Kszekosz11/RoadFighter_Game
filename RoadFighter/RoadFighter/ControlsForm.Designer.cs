namespace RoadFighter
{
    partial class FrmControls
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
            System.Windows.Forms.Button btnBack;
            this.pnlInstruction = new System.Windows.Forms.Panel();
            this.lblEnemyDesc = new System.Windows.Forms.Label();
            this.lblTimeDesc = new System.Windows.Forms.Label();
            this.lblSpace = new System.Windows.Forms.Label();
            this.lblCoinDesc = new System.Windows.Forms.Label();
            this.pcbKeys = new System.Windows.Forms.PictureBox();
            this.pcbEnemy = new System.Windows.Forms.PictureBox();
            this.pcbSpacebar = new System.Windows.Forms.PictureBox();
            this.pcbTime = new System.Windows.Forms.PictureBox();
            this.lblRight = new System.Windows.Forms.Label();
            this.pcbCoin = new System.Windows.Forms.PictureBox();
            this.lblForward = new System.Windows.Forms.Label();
            this.pcbMenuCar = new System.Windows.Forms.PictureBox();
            this.lblLeft = new System.Windows.Forms.Label();
            this.lblBack = new System.Windows.Forms.Label();
            btnBack = new System.Windows.Forms.Button();
            this.pnlInstruction.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbKeys)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbEnemy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbSpacebar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbCoin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbMenuCar)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            btnBack.BackColor = System.Drawing.Color.Transparent;
            btnBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            btnBack.Location = new System.Drawing.Point(12, 12);
            btnBack.Name = "btnBack";
            btnBack.Size = new System.Drawing.Size(64, 64);
            btnBack.TabIndex = 1;
            btnBack.Text = "↩";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += new System.EventHandler(this.BtnBack_Click);
            // 
            // pnlInstruction
            // 
            this.pnlInstruction.BackgroundImage = global::RoadFighter.Properties.Resources.menuBackground2;
            this.pnlInstruction.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlInstruction.Controls.Add(this.lblEnemyDesc);
            this.pnlInstruction.Controls.Add(this.lblTimeDesc);
            this.pnlInstruction.Controls.Add(this.lblSpace);
            this.pnlInstruction.Controls.Add(this.lblCoinDesc);
            this.pnlInstruction.Controls.Add(this.pcbKeys);
            this.pnlInstruction.Controls.Add(this.pcbEnemy);
            this.pnlInstruction.Controls.Add(this.pcbSpacebar);
            this.pnlInstruction.Controls.Add(this.pcbTime);
            this.pnlInstruction.Controls.Add(this.lblRight);
            this.pnlInstruction.Controls.Add(this.pcbCoin);
            this.pnlInstruction.Controls.Add(this.lblForward);
            this.pnlInstruction.Controls.Add(btnBack);
            this.pnlInstruction.Controls.Add(this.pcbMenuCar);
            this.pnlInstruction.Controls.Add(this.lblLeft);
            this.pnlInstruction.Controls.Add(this.lblBack);
            this.pnlInstruction.Location = new System.Drawing.Point(0, 0);
            this.pnlInstruction.Name = "pnlInstruction";
            this.pnlInstruction.Size = new System.Drawing.Size(760, 791);
            this.pnlInstruction.TabIndex = 12;
            // 
            // lblEnemyDesc
            // 
            this.lblEnemyDesc.AutoSize = true;
            this.lblEnemyDesc.BackColor = System.Drawing.Color.Transparent;
            this.lblEnemyDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblEnemyDesc.Location = new System.Drawing.Point(442, 309);
            this.lblEnemyDesc.Name = "lblEnemyDesc";
            this.lblEnemyDesc.Size = new System.Drawing.Size(207, 20);
            this.lblEnemyDesc.TabIndex = 5;
            this.lblEnemyDesc.Text = "-5 seconds if you crash";
            // 
            // lblTimeDesc
            // 
            this.lblTimeDesc.AutoSize = true;
            this.lblTimeDesc.BackColor = System.Drawing.Color.Transparent;
            this.lblTimeDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblTimeDesc.Location = new System.Drawing.Point(77, 333);
            this.lblTimeDesc.Name = "lblTimeDesc";
            this.lblTimeDesc.Size = new System.Drawing.Size(230, 20);
            this.lblTimeDesc.TabIndex = 4;
            this.lblTimeDesc.Text = "+10 seconds if you collect";
            // 
            // lblSpace
            // 
            this.lblSpace.AutoSize = true;
            this.lblSpace.BackColor = System.Drawing.Color.Transparent;
            this.lblSpace.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblSpace.Location = new System.Drawing.Point(178, 620);
            this.lblSpace.Name = "lblSpace";
            this.lblSpace.Size = new System.Drawing.Size(70, 20);
            this.lblSpace.TabIndex = 11;
            this.lblSpace.Text = "PAUSE";
            // 
            // lblCoinDesc
            // 
            this.lblCoinDesc.AutoSize = true;
            this.lblCoinDesc.BackColor = System.Drawing.Color.Transparent;
            this.lblCoinDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblCoinDesc.Location = new System.Drawing.Point(82, 286);
            this.lblCoinDesc.Name = "lblCoinDesc";
            this.lblCoinDesc.Size = new System.Drawing.Size(191, 20);
            this.lblCoinDesc.TabIndex = 3;
            this.lblCoinDesc.Text = "+1 point if you collect";
            // 
            // pcbKeys
            // 
            this.pcbKeys.BackColor = System.Drawing.Color.Transparent;
            this.pcbKeys.BackgroundImage = global::RoadFighter.Properties.Resources.keys;
            this.pcbKeys.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pcbKeys.Location = new System.Drawing.Point(131, 421);
            this.pcbKeys.Name = "pcbKeys";
            this.pcbKeys.Size = new System.Drawing.Size(164, 96);
            this.pcbKeys.TabIndex = 9;
            this.pcbKeys.TabStop = false;
            // 
            // pcbEnemy
            // 
            this.pcbEnemy.BackColor = System.Drawing.Color.Transparent;
            this.pcbEnemy.BackgroundImage = global::RoadFighter.Properties.Resources.enemyCar;
            this.pcbEnemy.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pcbEnemy.Location = new System.Drawing.Point(376, 276);
            this.pcbEnemy.Name = "pcbEnemy";
            this.pcbEnemy.Size = new System.Drawing.Size(45, 87);
            this.pcbEnemy.TabIndex = 2;
            this.pcbEnemy.TabStop = false;
            // 
            // pcbSpacebar
            // 
            this.pcbSpacebar.BackgroundImage = global::RoadFighter.Properties.Resources.spacebar;
            this.pcbSpacebar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pcbSpacebar.Location = new System.Drawing.Point(105, 572);
            this.pcbSpacebar.Name = "pcbSpacebar";
            this.pcbSpacebar.Size = new System.Drawing.Size(216, 33);
            this.pcbSpacebar.TabIndex = 10;
            this.pcbSpacebar.TabStop = false;
            // 
            // pcbTime
            // 
            this.pcbTime.BackColor = System.Drawing.Color.Transparent;
            this.pcbTime.BackgroundImage = global::RoadFighter.Properties.Resources.time;
            this.pcbTime.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pcbTime.Location = new System.Drawing.Point(22, 323);
            this.pcbTime.Name = "pcbTime";
            this.pcbTime.Size = new System.Drawing.Size(40, 40);
            this.pcbTime.TabIndex = 1;
            this.pcbTime.TabStop = false;
            // 
            // lblRight
            // 
            this.lblRight.AutoSize = true;
            this.lblRight.BackColor = System.Drawing.Color.Transparent;
            this.lblRight.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblRight.Location = new System.Drawing.Point(298, 497);
            this.lblRight.Name = "lblRight";
            this.lblRight.Size = new System.Drawing.Size(66, 20);
            this.lblRight.TabIndex = 8;
            this.lblRight.Text = "RIGHT";
            // 
            // pcbCoin
            // 
            this.pcbCoin.BackColor = System.Drawing.Color.Transparent;
            this.pcbCoin.BackgroundImage = global::RoadFighter.Properties.Resources.coin;
            this.pcbCoin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pcbCoin.Location = new System.Drawing.Point(22, 276);
            this.pcbCoin.Name = "pcbCoin";
            this.pcbCoin.Size = new System.Drawing.Size(40, 40);
            this.pcbCoin.TabIndex = 0;
            this.pcbCoin.TabStop = false;
            // 
            // lblForward
            // 
            this.lblForward.AutoSize = true;
            this.lblForward.BackColor = System.Drawing.Color.Transparent;
            this.lblForward.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblForward.Location = new System.Drawing.Point(162, 392);
            this.lblForward.Name = "lblForward";
            this.lblForward.Size = new System.Drawing.Size(103, 20);
            this.lblForward.TabIndex = 5;
            this.lblForward.Text = "FORWARD";
            // 
            // pcbMenuCar
            // 
            this.pcbMenuCar.BackColor = System.Drawing.Color.Transparent;
            this.pcbMenuCar.BackgroundImage = global::RoadFighter.Properties.Resources.menuCar;
            this.pcbMenuCar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pcbMenuCar.Location = new System.Drawing.Point(492, 468);
            this.pcbMenuCar.Margin = new System.Windows.Forms.Padding(4);
            this.pcbMenuCar.Name = "pcbMenuCar";
            this.pcbMenuCar.Size = new System.Drawing.Size(344, 194);
            this.pcbMenuCar.TabIndex = 13;
            this.pcbMenuCar.TabStop = false;
            // 
            // lblLeft
            // 
            this.lblLeft.AutoSize = true;
            this.lblLeft.BackColor = System.Drawing.Color.Transparent;
            this.lblLeft.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblLeft.Location = new System.Drawing.Point(68, 497);
            this.lblLeft.Name = "lblLeft";
            this.lblLeft.Size = new System.Drawing.Size(54, 20);
            this.lblLeft.TabIndex = 7;
            this.lblLeft.Text = "LEFT";
            // 
            // lblBack
            // 
            this.lblBack.AutoSize = true;
            this.lblBack.BackColor = System.Drawing.Color.Transparent;
            this.lblBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblBack.Location = new System.Drawing.Point(184, 526);
            this.lblBack.Name = "lblBack";
            this.lblBack.Size = new System.Drawing.Size(59, 20);
            this.lblBack.TabIndex = 6;
            this.lblBack.Text = "BACK";
            // 
            // FrmControls
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(761, 789);
            this.Controls.Add(this.pnlInstruction);
            this.Name = "FrmControls";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ControlsForm";
            this.pnlInstruction.ResumeLayout(false);
            this.pnlInstruction.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbKeys)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbEnemy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbSpacebar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbCoin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbMenuCar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblForward;
        private System.Windows.Forms.Label lblBack;
        private System.Windows.Forms.Label lblRight;
        private System.Windows.Forms.Label lblLeft;
        private System.Windows.Forms.PictureBox pcbKeys;
        private System.Windows.Forms.Label lblSpace;
        private System.Windows.Forms.PictureBox pcbSpacebar;
        private System.Windows.Forms.Panel pnlInstruction;
        private System.Windows.Forms.PictureBox pcbMenuCar;
        private System.Windows.Forms.Label lblTimeDesc;
        private System.Windows.Forms.Label lblCoinDesc;
        private System.Windows.Forms.PictureBox pcbEnemy;
        private System.Windows.Forms.PictureBox pcbTime;
        private System.Windows.Forms.PictureBox pcbCoin;
        private System.Windows.Forms.Label lblEnemyDesc;
    }
}