namespace Projekat_Bioskop
{
    partial class OtpustiRadnikaForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OtpustiRadnikaForm));
            this.fireWorkerButton = new System.Windows.Forms.Button();
            this.selectWorkerComboBox = new System.Windows.Forms.ComboBox();
            this.zAPOSLENIBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.bIOSKOPDataSet5 = new Projekat_Bioskop.BIOSKOPDataSet5();
            this.selectWorkerLabel = new System.Windows.Forms.Label();
            this.noteLabel = new System.Windows.Forms.Label();
            this.zAPOSLENIBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.zAPOSLENITableAdapter1 = new Projekat_Bioskop.BIOSKOPDataSet5TableAdapters.ZAPOSLENITableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.zAPOSLENIBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bIOSKOPDataSet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zAPOSLENIBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // fireWorkerButton
            // 
            this.fireWorkerButton.Location = new System.Drawing.Point(160, 100);
            this.fireWorkerButton.Name = "fireWorkerButton";
            this.fireWorkerButton.Size = new System.Drawing.Size(100, 25);
            this.fireWorkerButton.TabIndex = 2;
            this.fireWorkerButton.Text = "Otpusti";
            this.fireWorkerButton.UseVisualStyleBackColor = true;
            this.fireWorkerButton.Click += new System.EventHandler(this.fireWorkerButton_Click);
            // 
            // selectWorkerComboBox
            // 
            this.selectWorkerComboBox.DataSource = this.zAPOSLENIBindingSource1;
            this.selectWorkerComboBox.DisplayMember = "Radnik";
            this.selectWorkerComboBox.FormattingEnabled = true;
            this.selectWorkerComboBox.Location = new System.Drawing.Point(110, 57);
            this.selectWorkerComboBox.Name = "selectWorkerComboBox";
            this.selectWorkerComboBox.Size = new System.Drawing.Size(200, 21);
            this.selectWorkerComboBox.TabIndex = 1;
            // 
            // zAPOSLENIBindingSource1
            // 
            this.zAPOSLENIBindingSource1.DataMember = "ZAPOSLENI";
            this.zAPOSLENIBindingSource1.DataSource = this.bIOSKOPDataSet5;
            // 
            // bIOSKOPDataSet5
            // 
            this.bIOSKOPDataSet5.DataSetName = "BIOSKOPDataSet5";
            this.bIOSKOPDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // selectWorkerLabel
            // 
            this.selectWorkerLabel.AutoSize = true;
            this.selectWorkerLabel.Location = new System.Drawing.Point(10, 60);
            this.selectWorkerLabel.Name = "selectWorkerLabel";
            this.selectWorkerLabel.Size = new System.Drawing.Size(85, 13);
            this.selectWorkerLabel.TabIndex = 1;
            this.selectWorkerLabel.Text = "Izaberite radnika";
            // 
            // noteLabel
            // 
            this.noteLabel.AutoSize = true;
            this.noteLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.noteLabel.Location = new System.Drawing.Point(10, 15);
            this.noteLabel.Name = "noteLabel";
            this.noteLabel.Size = new System.Drawing.Size(251, 16);
            this.noteLabel.TabIndex = 0;
            this.noteLabel.Text = "Odaberite radnika kog želite da otpustite:";
            // 
            // zAPOSLENIBindingSource
            // 
            this.zAPOSLENIBindingSource.DataMember = "ZAPOSLENI";
            // 
            // zAPOSLENITableAdapter1
            // 
            this.zAPOSLENITableAdapter1.ClearBeforeFill = true;
            // 
            // OtpustiRadnikaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 161);
            this.Controls.Add(this.fireWorkerButton);
            this.Controls.Add(this.selectWorkerComboBox);
            this.Controls.Add(this.selectWorkerLabel);
            this.Controls.Add(this.noteLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "OtpustiRadnikaForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OTPUSTI RADNIKA";
            this.Load += new System.EventHandler(this.OtpustiRadnikaForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.zAPOSLENIBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bIOSKOPDataSet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zAPOSLENIBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button fireWorkerButton;
        private System.Windows.Forms.ComboBox selectWorkerComboBox;
        private System.Windows.Forms.Label selectWorkerLabel;
        private System.Windows.Forms.Label noteLabel;
        private System.Windows.Forms.BindingSource zAPOSLENIBindingSource;
        private BIOSKOPDataSet5 bIOSKOPDataSet5;
        private System.Windows.Forms.BindingSource zAPOSLENIBindingSource1;
        private BIOSKOPDataSet5TableAdapters.ZAPOSLENITableAdapter zAPOSLENITableAdapter1;
    }
}