namespace Projekat_Bioskop
{
    partial class PrijaviGreskuForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PrijaviGreskuForm));
            this.noteRichTextBox = new System.Windows.Forms.RichTextBox();
            this.noteLabel = new System.Windows.Forms.Label();
            this.sendReportButton = new System.Windows.Forms.Button();
            this.deleteTextButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // noteRichTextBox
            // 
            this.noteRichTextBox.Location = new System.Drawing.Point(12, 40);
            this.noteRichTextBox.Name = "noteRichTextBox";
            this.noteRichTextBox.Size = new System.Drawing.Size(360, 61);
            this.noteRichTextBox.TabIndex = 0;
            this.noteRichTextBox.Text = "";
            // 
            // noteLabel
            // 
            this.noteLabel.AutoSize = true;
            this.noteLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.noteLabel.Location = new System.Drawing.Point(10, 15);
            this.noteLabel.Name = "noteLabel";
            this.noteLabel.Size = new System.Drawing.Size(294, 16);
            this.noteLabel.TabIndex = 0;
            this.noteLabel.Text = "Unesite opis greške. Maksimalno 128 karaktera.";
            // 
            // sendReportButton
            // 
            this.sendReportButton.Location = new System.Drawing.Point(13, 110);
            this.sendReportButton.Name = "sendReportButton";
            this.sendReportButton.Size = new System.Drawing.Size(100, 25);
            this.sendReportButton.TabIndex = 1;
            this.sendReportButton.Text = "Pošalji";
            this.sendReportButton.UseVisualStyleBackColor = true;
            this.sendReportButton.Click += new System.EventHandler(this.sendReportButton_Click);
            // 
            // deleteTextButton
            // 
            this.deleteTextButton.Location = new System.Drawing.Point(272, 110);
            this.deleteTextButton.Name = "deleteTextButton";
            this.deleteTextButton.Size = new System.Drawing.Size(100, 25);
            this.deleteTextButton.TabIndex = 2;
            this.deleteTextButton.Text = "Obriši tekst";
            this.deleteTextButton.UseVisualStyleBackColor = true;
            this.deleteTextButton.Click += new System.EventHandler(this.deleteTextButton_Click);
            // 
            // PrijaviGreskuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 146);
            this.Controls.Add(this.deleteTextButton);
            this.Controls.Add(this.sendReportButton);
            this.Controls.Add(this.noteLabel);
            this.Controls.Add(this.noteRichTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PrijaviGreskuForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PRIJAVI GREŠKU";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox noteRichTextBox;
        private System.Windows.Forms.Label noteLabel;
        private System.Windows.Forms.Button sendReportButton;
        private System.Windows.Forms.Button deleteTextButton;
    }
}