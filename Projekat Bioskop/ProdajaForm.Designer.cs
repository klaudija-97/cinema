namespace Projekat_Bioskop
{
    partial class ProdajaForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProdajaForm));
            this.loadHallLabel = new System.Windows.Forms.Label();
            this.loadSeatLabel = new System.Windows.Forms.Label();
            this.loadRowLabel = new System.Windows.Forms.Label();
            this.loadTimeLabel = new System.Windows.Forms.Label();
            this.loadDateLabel = new System.Windows.Forms.Label();
            this.movieTitleLabel = new System.Windows.Forms.Label();
            this.rowLabel = new System.Windows.Forms.Label();
            this.seatLabel = new System.Windows.Forms.Label();
            this.hallLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // loadHallLabel
            // 
            this.loadHallLabel.AutoSize = true;
            this.loadHallLabel.BackColor = System.Drawing.Color.Transparent;
            this.loadHallLabel.Font = new System.Drawing.Font("Arial Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loadHallLabel.ForeColor = System.Drawing.Color.Violet;
            this.loadHallLabel.Location = new System.Drawing.Point(503, 105);
            this.loadHallLabel.Name = "loadHallLabel";
            this.loadHallLabel.Size = new System.Drawing.Size(84, 17);
            this.loadHallLabel.TabIndex = 23;
            this.loadHallLabel.Text = "romeo/julija";
            // 
            // loadSeatLabel
            // 
            this.loadSeatLabel.AutoSize = true;
            this.loadSeatLabel.BackColor = System.Drawing.Color.Transparent;
            this.loadSeatLabel.Font = new System.Drawing.Font("Arial Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loadSeatLabel.ForeColor = System.Drawing.Color.Violet;
            this.loadSeatLabel.Location = new System.Drawing.Point(503, 65);
            this.loadSeatLabel.Name = "loadSeatLabel";
            this.loadSeatLabel.Size = new System.Drawing.Size(33, 17);
            this.loadSeatLabel.TabIndex = 21;
            this.loadSeatLabel.Text = "broj";
            // 
            // loadRowLabel
            // 
            this.loadRowLabel.AutoSize = true;
            this.loadRowLabel.BackColor = System.Drawing.Color.Transparent;
            this.loadRowLabel.Font = new System.Drawing.Font("Arial Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loadRowLabel.ForeColor = System.Drawing.Color.Violet;
            this.loadRowLabel.Location = new System.Drawing.Point(503, 25);
            this.loadRowLabel.Name = "loadRowLabel";
            this.loadRowLabel.Size = new System.Drawing.Size(62, 17);
            this.loadRowLabel.TabIndex = 19;
            this.loadRowLabel.Text = "brojreda";
            // 
            // loadTimeLabel
            // 
            this.loadTimeLabel.AutoSize = true;
            this.loadTimeLabel.BackColor = System.Drawing.Color.Transparent;
            this.loadTimeLabel.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loadTimeLabel.ForeColor = System.Drawing.Color.Violet;
            this.loadTimeLabel.Location = new System.Drawing.Point(165, 105);
            this.loadTimeLabel.Name = "loadTimeLabel";
            this.loadTimeLabel.Size = new System.Drawing.Size(56, 18);
            this.loadTimeLabel.TabIndex = 18;
            this.loadTimeLabel.Text = "termin";
            // 
            // loadDateLabel
            // 
            this.loadDateLabel.AutoSize = true;
            this.loadDateLabel.BackColor = System.Drawing.Color.Transparent;
            this.loadDateLabel.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loadDateLabel.ForeColor = System.Drawing.Color.Violet;
            this.loadDateLabel.Location = new System.Drawing.Point(63, 105);
            this.loadDateLabel.Name = "loadDateLabel";
            this.loadDateLabel.Size = new System.Drawing.Size(54, 18);
            this.loadDateLabel.TabIndex = 15;
            this.loadDateLabel.Text = "datum";
            // 
            // movieTitleLabel
            // 
            this.movieTitleLabel.AutoSize = true;
            this.movieTitleLabel.BackColor = System.Drawing.Color.Transparent;
            this.movieTitleLabel.Font = new System.Drawing.Font("Arial Black", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.movieTitleLabel.ForeColor = System.Drawing.Color.Violet;
            this.movieTitleLabel.Location = new System.Drawing.Point(61, 45);
            this.movieTitleLabel.Name = "movieTitleLabel";
            this.movieTitleLabel.Size = new System.Drawing.Size(151, 27);
            this.movieTitleLabel.TabIndex = 13;
            this.movieTitleLabel.Text = "NAZIV FILMA";
            this.movieTitleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // rowLabel
            // 
            this.rowLabel.AutoSize = true;
            this.rowLabel.BackColor = System.Drawing.Color.Transparent;
            this.rowLabel.Font = new System.Drawing.Font("Arial Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rowLabel.ForeColor = System.Drawing.Color.Violet;
            this.rowLabel.Location = new System.Drawing.Point(420, 25);
            this.rowLabel.Name = "rowLabel";
            this.rowLabel.Size = new System.Drawing.Size(37, 17);
            this.rowLabel.TabIndex = 26;
            this.rowLabel.Text = "Red:";
            // 
            // seatLabel
            // 
            this.seatLabel.AutoSize = true;
            this.seatLabel.BackColor = System.Drawing.Color.Transparent;
            this.seatLabel.Font = new System.Drawing.Font("Arial Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.seatLabel.ForeColor = System.Drawing.Color.Violet;
            this.seatLabel.Location = new System.Drawing.Point(420, 65);
            this.seatLabel.Name = "seatLabel";
            this.seatLabel.Size = new System.Drawing.Size(65, 17);
            this.seatLabel.TabIndex = 27;
            this.seatLabel.Text = "Sjedište:";
            // 
            // hallLabel
            // 
            this.hallLabel.AutoSize = true;
            this.hallLabel.BackColor = System.Drawing.Color.Transparent;
            this.hallLabel.Font = new System.Drawing.Font("Arial Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hallLabel.ForeColor = System.Drawing.Color.Violet;
            this.hallLabel.Location = new System.Drawing.Point(420, 105);
            this.hallLabel.Name = "hallLabel";
            this.hallLabel.Size = new System.Drawing.Size(75, 17);
            this.hallLabel.TabIndex = 28;
            this.hallLabel.Text = "Prostorija:";
            // 
            // ProdajaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(586, 213);
            this.Controls.Add(this.hallLabel);
            this.Controls.Add(this.seatLabel);
            this.Controls.Add(this.rowLabel);
            this.Controls.Add(this.loadHallLabel);
            this.Controls.Add(this.loadSeatLabel);
            this.Controls.Add(this.loadRowLabel);
            this.Controls.Add(this.loadTimeLabel);
            this.Controls.Add(this.loadDateLabel);
            this.Controls.Add(this.movieTitleLabel);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ProdajaForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "KARTA";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label loadHallLabel;
        private System.Windows.Forms.Label loadSeatLabel;
        private System.Windows.Forms.Label loadRowLabel;
        private System.Windows.Forms.Label loadTimeLabel;
        private System.Windows.Forms.Label loadDateLabel;
        private System.Windows.Forms.Label movieTitleLabel;
        private System.Windows.Forms.Label rowLabel;
        private System.Windows.Forms.Label seatLabel;
        private System.Windows.Forms.Label hallLabel;
    }
}