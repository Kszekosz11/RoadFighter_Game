namespace RoadFighter
{
    partial class FrmGameRecords
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
            this.dtvRecords = new System.Windows.Forms.DataGridView();
            btnBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtvRecords)).BeginInit();
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
            // dtvRecords
            // 
            this.dtvRecords.AllowUserToAddRows = false;
            this.dtvRecords.AllowUserToDeleteRows = false;
            this.dtvRecords.AllowUserToOrderColumns = true;
            this.dtvRecords.AllowUserToResizeColumns = false;
            this.dtvRecords.AllowUserToResizeRows = false;
            this.dtvRecords.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtvRecords.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.dtvRecords.ColumnHeadersHeight = 22;
            this.dtvRecords.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dtvRecords.Location = new System.Drawing.Point(302, 50);
            this.dtvRecords.Margin = new System.Windows.Forms.Padding(10);
            this.dtvRecords.MultiSelect = false;
            this.dtvRecords.Name = "dtvRecords";
            this.dtvRecords.ReadOnly = true;
            this.dtvRecords.RowHeadersVisible = false;
            this.dtvRecords.RowHeadersWidth = 51;
            this.dtvRecords.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dtvRecords.RowTemplate.Height = 24;
            this.dtvRecords.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtvRecords.ShowCellToolTips = false;
            this.dtvRecords.ShowEditingIcon = false;
            this.dtvRecords.Size = new System.Drawing.Size(456, 349);
            this.dtvRecords.TabIndex = 2;
            this.dtvRecords.TabStop = false;
            // 
            // FrmGameRecords
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::RoadFighter.Properties.Resources.menuBackground2;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(btnBack);
            this.Controls.Add(this.dtvRecords);
            this.Name = "FrmGameRecords";
            this.Text = "GameRecordsForm";
            ((System.ComponentModel.ISupportInitialize)(this.dtvRecords)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtvRecords;
    }
}