using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projekat_Bioskop
{
    public partial class OtpustiRadnikaForm : Form
    {
        public OtpustiRadnikaForm()
        {
            InitializeComponent();
        }

        private void fireWorkerButton_Click(object sender, EventArgs e)
        {
            string message = "Da li ste sigurni da želite da otpustite radnika: " + selectWorkerComboBox.Text;

            try
            {
                if (IsFieldValid())
                {
                    if (MessageBox.Show(message, "Otpuštanje", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        string full = selectWorkerComboBox.Text;
                        string[] parts = full.Split(' ');

                        int l = parts.Length;
                        int k = parts[l - 1].Length;

                        int workerID = Int32.Parse(parts[l - 1].Substring(0, k - 1));

                        using (var db = new BIOSKOPEntities())
                        {
                            RADNICI otpusteniRadnik = new RADNICI();

                            otpusteniRadnik = db.RADNICIs.Where(r => r.radnik_id == workerID).FirstOrDefault();
                            otpusteniRadnik.kraj_zaposlenja = DateTime.Now;
                            db.SaveChanges();

                            RefreshComboBox();

                            MessageBox.Show("Izabrani radnik je otpušten.", "Obavještenje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else
                    {
                        selectWorkerComboBox.Text = "";
                        selectWorkerComboBox.Focus();
                    }
                }
            }
            catch
            {
                MessageBox.Show("Uneseni podaci nisu ispravni.", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //validacija

        private bool IsFieldValid()
        {
            if (selectWorkerComboBox.SelectedIndex == -1)
            {
                MessageBox.Show("Morate izabrati radnika.", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                selectWorkerComboBox.Text = "";
                selectWorkerComboBox.Focus();
                return false;
            }
            else
                return true;
        }

        private void OtpustiRadnikaForm_Load(object sender, EventArgs e)
        {
            this.zAPOSLENITableAdapter1.Fill(this.bIOSKOPDataSet5.ZAPOSLENI);
            selectWorkerComboBox.SelectedIndex = -1;
        }

        private void RefreshComboBox()
        {
            this.zAPOSLENITableAdapter1.Fill(this.bIOSKOPDataSet5.ZAPOSLENI);
            selectWorkerComboBox.SelectedIndex = -1;
            selectWorkerComboBox.Focus();
        }
    }
}
