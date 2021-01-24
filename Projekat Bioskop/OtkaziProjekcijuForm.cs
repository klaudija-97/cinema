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
    public partial class OtkaziProjekcijuForm : Form
    {
        public OtkaziProjekcijuForm()
        {
            InitializeComponent();
        }

        private void cancelShowingButton_Click(object sender, EventArgs e)
        {
            string message = "Da li ste sigurni da želite da otkažete projekciju filma: " + selectMovieComboBox.Text;

            try
            {
                if (IsFieldValid())
                {
                    if (MessageBox.Show(message, "Otkazivanje", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        string izabranaProjekcija = selectMovieComboBox.Text;
                        int filmID;

                        using (var db = new BIOSKOPEntities())
                        {
                            FILMOVI film = new FILMOVI();
                            film = db.FILMOVIs.Where(f => f.naslov == izabranaProjekcija).FirstOrDefault();

                            filmID = film.film_id;
                        }

                        using (var db = new BIOSKOPEntities())
                        {
                            PRIKAZIVANJA otkazanaProjekcija = new PRIKAZIVANJA();

                            otkazanaProjekcija = db.PRIKAZIVANJAs.Where(p => p.id_filma == filmID && p.status_prikazivanja == 1).FirstOrDefault();
                            otkazanaProjekcija.kraj_prikazivanja = DateTime.Now;
                            otkazanaProjekcija.status_prikazivanja = 0;
                            db.SaveChanges();

                            RefreshComboBox();

                            MessageBox.Show("Izabrana projekcija je otkazana.", "Obavještenje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else
                    {
                        selectMovieComboBox.Text = "";
                        selectMovieComboBox.Focus();
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
            if (selectMovieComboBox.SelectedIndex == -1)
            {
                MessageBox.Show("Morate izabrati projekciju.", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                selectMovieComboBox.Text = "";
                selectMovieComboBox.Focus();
                return false;
            }
            else
                return true;
        }

        //učitavanje u comboBox

        private void OtkaziProjekcijuForm_Load(object sender, EventArgs e)
        {
            this.pROJEKCIJETableAdapter.Fill(this.bIOSKOPDataSet3.PROJEKCIJE);
            selectMovieComboBox.SelectedIndex = -1;
        }

        private void RefreshComboBox()
        {
            this.pROJEKCIJETableAdapter.Fill(this.bIOSKOPDataSet3.PROJEKCIJE);
            selectMovieComboBox.SelectedIndex = -1;
            selectMovieComboBox.Focus();
        }
    }
}
