namespace Projekat_Bioskop
{
    partial class OtkaziProjekcijuForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OtkaziProjekcijuForm));
            this.noteLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.selectMovieComboBox = new System.Windows.Forms.ComboBox();
            this.pROJEKCIJEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bIOSKOPDataSet3BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bIOSKOPDataSet3 = new Projekat_Bioskop.BIOSKOPDataSet3();
            this.cancelShowingButton = new System.Windows.Forms.Button();
            this.pROJEKCIJETableAdapter = new Projekat_Bioskop.BIOSKOPDataSet3TableAdapters.PROJEKCIJETableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.pROJEKCIJEBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bIOSKOPDataSet3BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bIOSKOPDataSet3)).BeginInit();
            this.SuspendLayout();
            // 
            // noteLabel
            // 
            this.noteLabel.AutoSize = true;
            this.noteLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.noteLabel.Location = new System.Drawing.Point(10, 15);
            this.noteLabel.Name = "noteLabel";
            this.noteLabel.Size = new System.Drawing.Size(267, 16);
            this.noteLabel.TabIndex = 0;
            this.noteLabel.Text = "Odaberite projekciju koju želite da otkažete:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Izaberite film";
            // 
            // selectMovieComboBox
            // 
            this.selectMovieComboBox.DataSource = this.pROJEKCIJEBindingSource;
            this.selectMovieComboBox.DisplayMember = "naslov";
            this.selectMovieComboBox.FormattingEnabled = true;
            this.selectMovieComboBox.Location = new System.Drawing.Point(100, 57);
            this.selectMovieComboBox.Name = "selectMovieComboBox";
            this.selectMovieComboBox.Size = new System.Drawing.Size(200, 21);
            this.selectMovieComboBox.TabIndex = 1;
            // 
            // pROJEKCIJEBindingSource
            // 
            this.pROJEKCIJEBindingSource.DataMember = "PROJEKCIJE";
            this.pROJEKCIJEBindingSource.DataSource = this.bIOSKOPDataSet3BindingSource;
            // 
            // bIOSKOPDataSet3BindingSource
            // 
            this.bIOSKOPDataSet3BindingSource.DataSource = this.bIOSKOPDataSet3;
            this.bIOSKOPDataSet3BindingSource.Position = 0;
            // 
            // bIOSKOPDataSet3
            // 
            this.bIOSKOPDataSet3.DataSetName = "BIOSKOPDataSet3";
            this.bIOSKOPDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cancelShowingButton
            // 
            this.cancelShowingButton.Location = new System.Drawing.Point(150, 100);
            this.cancelShowingButton.Name = "cancelShowingButton";
            this.cancelShowingButton.Size = new System.Drawing.Size(100, 25);
            this.cancelShowingButton.TabIndex = 2;
            this.cancelShowingButton.Text = "Otkaži";
            this.cancelShowingButton.UseVisualStyleBackColor = true;
            this.cancelShowingButton.Click += new System.EventHandler(this.cancelShowingButton_Click);
            // 
            // pROJEKCIJETableAdapter
            // 
            this.pROJEKCIJETableAdapter.ClearBeforeFill = true;
            // 
            // OtkaziProjekcijuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 161);
            this.Controls.Add(this.cancelShowingButton);
            this.Controls.Add(this.selectMovieComboBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.noteLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "OtkaziProjekcijuForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OTKAŽI PROJEKCIJU";
            this.Load += new System.EventHandler(this.OtkaziProjekcijuForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pROJEKCIJEBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bIOSKOPDataSet3BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bIOSKOPDataSet3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label noteLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox selectMovieComboBox;
        private System.Windows.Forms.Button cancelShowingButton;
        private System.Windows.Forms.BindingSource bIOSKOPDataSet3BindingSource;
        private BIOSKOPDataSet3 bIOSKOPDataSet3;
        private System.Windows.Forms.BindingSource pROJEKCIJEBindingSource;
        private BIOSKOPDataSet3TableAdapters.PROJEKCIJETableAdapter pROJEKCIJETableAdapter;
    }
}