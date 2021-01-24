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
    public partial class RadnikForm : Form
    {
        public static string naslovFilma = "";
        public static string datumPrikazivanja;
        public static string terminPrikazivanja = "";
        public static string red = "";
        public static int sjediste;
        public static string prostorija = "";
        public static string status = "";

        public static int seatStatus;

        public static DateTime startDate;
        public static DateTime endDate;

        public RadnikForm()
        {
            InitializeComponent();
            HideItems();
            HideSellingItems();
            DisableSeatButtons();
        }

        private void chooseMovieButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (IsMovieValid())
                {
                    ShowItems();

                    GetDates();

                    List<DateTime> dates = new List<DateTime>();
                  
                    for (var dt = startDate; dt <= endDate; dt = dt.AddDays(1))
                    {
                        dates.Add(dt);
                    }

                    selectDateComboBox.DataSource = dates;
                    selectDateComboBox.SelectedIndex = -1;
                }
                else
                {
                    selectMovieComboBox.Text = "";
                    selectMovieComboBox.Focus();
                }
            }
            catch
            {
                MessageBox.Show("Uneseni podaci nisu ispravni.", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool IsMovieValid()
        {
            if (selectMovieComboBox.SelectedIndex == -1)
            {
                MessageBox.Show("Morate odabrati film.", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            else
                return true;
        }

        private void selectMovieButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (AreMovieFieldsValid())
                {
                    naslovFilma = selectMovieComboBox.Text;
                    datumPrikazivanja = selectDateComboBox.Text;
                    terminPrikazivanja = selectTimeComboBox.Text;

                    EnableSeatButtons();
                }
            }
            catch
            {
                MessageBox.Show("Odaberite film!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private bool AreMovieFieldsValid()
        {
            if (selectMovieComboBox.SelectedIndex == -1)
            {
                MessageBox.Show("Morate odabrati film.", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            else if (selectDateComboBox.SelectedIndex == -1)
            {
                MessageBox.Show("Morate odabrati datum.", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            else if (selectTimeComboBox.SelectedIndex == -1)
            {
                MessageBox.Show("Morate odabrati termin.", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            else
                return true;
            
        }

        private void removeSelectionButton_Click(object sender, EventArgs e)
        {
            naslovFilma = "";
            datumPrikazivanja = "";
            terminPrikazivanja = "";
            selectMovieComboBox.SelectedIndex = -1;
            selectDateComboBox.SelectedIndex = -1;
            selectTimeComboBox.SelectedIndex = -1;
            
            HideItems();
            HideSellingItems();
            DisableSeatButtons();
        }

        private void sellTicketButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (loadStatusLabel.Text == "slobodno")
                {
                    int filmID, projekcijaID;
                    string izabranaProjekcija = selectMovieComboBox.Text;

                    using (var db = new BIOSKOPEntities())
                    {
                        FILMOVI film = new FILMOVI();
                        film = db.FILMOVIs.Where(f => f.naslov == izabranaProjekcija).FirstOrDefault();

                        filmID = film.film_id;
                    }

                    using (var db = new BIOSKOPEntities())
                    {
                        PRIKAZIVANJA projekcija = new PRIKAZIVANJA();
                        projekcija = db.PRIKAZIVANJAs.Where(p => p.id_filma == filmID).FirstOrDefault();

                        projekcijaID = projekcija.prikazivanje_id;
                    }

                    using (var db = new BIOSKOPEntities())
                    {
                        PRODATE_KARTE prodata = new PRODATE_KARTE()
                        {
                            prostorija = loadHallLabel.Text.ToString(),
                            broj_reda = loadRowLabel.Text.ToString(),
                            broj_sjedista = Int16.Parse(loadSeatLabel.Text.ToString()),
                            datum = datumPrikazivanja,
                            termin = terminPrikazivanja,
                            id_prikazivanja = projekcijaID,
                            status_sjedista = "zauzeto"
                        };

                        db.PRODATE_KARTE.Add(prodata);
                        db.SaveChanges();
                    }

                    ProdajaForm prodaja = new ProdajaForm();
                    prodaja.ShowDialog();

                    HideSellingItems();
                    HideItems();
                    DisableSeatButtons();
                    selectMovieComboBox.Text = "";
                    selectMovieComboBox.Focus();
                    selectDateComboBox.Text = "";
                    selectTimeComboBox.Text = "";
                    selectTimeComboBox.SelectedIndex = -1;
                }
                else if (loadStatusLabel.Text == "zauzeto")
                {
                    MessageBox.Show("Odabrano mjesto je zauzeto!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch
            {
                MessageBox.Show("Uneseni podaci nisu ispravni.", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }     
        }

        private void reportErrorButton_Click(object sender, EventArgs e)
        {
            PrijaviGreskuForm prijaviGresku = new PrijaviGreskuForm();
            prijaviGresku.ShowDialog(this);
        }

        //sjedišta u prvom redu - PARTER

        private void buttonI1_Click(object sender, EventArgs e)
        {
            SetSeatStatus("prvi", 1, "parter", datumPrikazivanja, terminPrikazivanja);

            CheckSeatStatus();
            
            SetSeatDetails("prvi", 1, "parter", status);
            
            ShowSellingItems();
            SetLabelText();
        }

        private void buttonI2_Click(object sender, EventArgs e)
        {
            SetSeatStatus("prvi", 2, "parter", datumPrikazivanja, terminPrikazivanja);

            CheckSeatStatus();

            SetSeatDetails("prvi", 2, "parter", status);

            ShowSellingItems();
            SetLabelText();
        }

        private void buttonI3_Click(object sender, EventArgs e)
        {
            SetSeatStatus("prvi", 3, "parter", datumPrikazivanja, terminPrikazivanja);

            CheckSeatStatus();

            SetSeatDetails("prvi", 3, "parter", status);

            ShowSellingItems();
            SetLabelText();
        }

        private void buttonI4_Click(object sender, EventArgs e)
        {
            SetSeatStatus("prvi", 4, "parter", datumPrikazivanja, terminPrikazivanja);

            CheckSeatStatus();

            SetSeatDetails("prvi", 4, "parter", status);

            ShowSellingItems();
            SetLabelText();
        }

        private void buttonI5_Click(object sender, EventArgs e)
        {
            SetSeatStatus("prvi", 5, "parter", datumPrikazivanja, terminPrikazivanja);

            CheckSeatStatus();

            SetSeatDetails("prvi", 5, "parter", status);

            ShowSellingItems();
            SetLabelText();
        }

        private void buttonI6_Click(object sender, EventArgs e)
        {
            SetSeatStatus("prvi", 6, "parter", datumPrikazivanja, terminPrikazivanja);

            CheckSeatStatus();

            SetSeatDetails("prvi", 6, "parter", status);

            ShowSellingItems();
            SetLabelText();
        }

        private void buttonI7_Click(object sender, EventArgs e)
        {
            SetSeatStatus("prvi", 7, "parter", datumPrikazivanja, terminPrikazivanja);

            CheckSeatStatus();

            SetSeatDetails("prvi", 7, "parter", status);

            ShowSellingItems();
            SetLabelText();
        }

        private void buttonI8_Click(object sender, EventArgs e)
        {
            SetSeatStatus("prvi", 8, "parter", datumPrikazivanja, terminPrikazivanja);

            CheckSeatStatus();

            SetSeatDetails("prvi", 8, "parter", status);

            ShowSellingItems();
            SetLabelText();
        }

        private void buttonI9_Click(object sender, EventArgs e)
        {
            SetSeatStatus("prvi", 9, "parter", datumPrikazivanja, terminPrikazivanja);

            CheckSeatStatus();

            SetSeatDetails("prvi", 9, "parter", status);

            ShowSellingItems();
            SetLabelText();
        }

        private void buttonI10_Click(object sender, EventArgs e)
        {
            SetSeatStatus("prvi", 10, "parter", datumPrikazivanja, terminPrikazivanja);

            CheckSeatStatus();

            SetSeatDetails("prvi", 10, "parter", status);

            ShowSellingItems();
            SetLabelText();
        }

        //sjedišta u drugom redu - PARTER

        private void buttonII1_Click(object sender, EventArgs e)
        {
            SetSeatStatus("drugi", 1, "parter", datumPrikazivanja, terminPrikazivanja);

            CheckSeatStatus();

            SetSeatDetails("drugi", 1, "parter", status);

            ShowSellingItems();
            SetLabelText();
        }

        private void buttonII2_Click(object sender, EventArgs e)
        {
            SetSeatStatus("drugi", 2, "parter", datumPrikazivanja, terminPrikazivanja);

            CheckSeatStatus();

            SetSeatDetails("drugi", 2, "parter", status);

            ShowSellingItems();
            SetLabelText();
        }

        private void buttonII3_Click(object sender, EventArgs e)
        {
            SetSeatStatus("drugi", 3, "parter", datumPrikazivanja, terminPrikazivanja);

            CheckSeatStatus();

            SetSeatDetails("drugi", 3, "parter", status);

            ShowSellingItems();
            SetLabelText();
        }

        private void buttonII4_Click(object sender, EventArgs e)
        {
            SetSeatStatus("drugi", 4, "parter", datumPrikazivanja, terminPrikazivanja);

            CheckSeatStatus();

            SetSeatDetails("drugi", 4, "parter", status);

            ShowSellingItems();
            SetLabelText();
        }

        private void buttonII5_Click(object sender, EventArgs e)
        {
            SetSeatStatus("drugi", 5, "parter", datumPrikazivanja, terminPrikazivanja);

            CheckSeatStatus();

            SetSeatDetails("drugi", 5, "parter", status);

            ShowSellingItems();
            SetLabelText();
        }

        private void buttonII6_Click(object sender, EventArgs e)
        {
            SetSeatStatus("drugi", 6, "parter", datumPrikazivanja, terminPrikazivanja);

            CheckSeatStatus();

            SetSeatDetails("drugi", 6, "parter", status);

            ShowSellingItems();
            SetLabelText();
        }

        private void buttonII7_Click(object sender, EventArgs e)
        {
            SetSeatStatus("drugi", 7, "parter", datumPrikazivanja, terminPrikazivanja);

            CheckSeatStatus();

            SetSeatDetails("drugi", 7, "parter", status);

            ShowSellingItems();
            SetLabelText();
        }

        private void buttonII8_Click(object sender, EventArgs e)
        {
            SetSeatStatus("drugi", 8, "parter", datumPrikazivanja, terminPrikazivanja);

            CheckSeatStatus();

            SetSeatDetails("drugi", 8, "parter", status);

            ShowSellingItems();
            SetLabelText();
        }

        private void buttonII9_Click(object sender, EventArgs e)
        {
            SetSeatStatus("drugi", 9, "parter", datumPrikazivanja, terminPrikazivanja);

            CheckSeatStatus();

            SetSeatDetails("drugi", 9, "parter", status);

            ShowSellingItems();
            SetLabelText();
        }

        private void buttonII10_Click(object sender, EventArgs e)
        {
            SetSeatStatus("drugi", 10, "parter", datumPrikazivanja, terminPrikazivanja);

            CheckSeatStatus();

            SetSeatDetails("drugi", 10, "parter", status);

            ShowSellingItems();
            SetLabelText();
        }

        private void buttonII11_Click(object sender, EventArgs e)
        {
            SetSeatStatus("drugi", 11, "parter", datumPrikazivanja, terminPrikazivanja);

            CheckSeatStatus();

            SetSeatDetails("drugi", 11, "parter", status);

            ShowSellingItems();
            SetLabelText();
        }

        //sjedišta u trećem redu - PARTER

        private void buttonIII1_Click(object sender, EventArgs e)
        {
            SetSeatStatus("treći", 1, "parter", datumPrikazivanja, terminPrikazivanja);

            CheckSeatStatus();

            SetSeatDetails("treći", 1, "parter", status);

            ShowSellingItems();
            SetLabelText();
        }

        private void buttonIII2_Click(object sender, EventArgs e)
        {
            SetSeatStatus("treći", 2, "parter", datumPrikazivanja, terminPrikazivanja);

            CheckSeatStatus();

            SetSeatDetails("treći", 2, "parter", status);

            ShowSellingItems();
            SetLabelText();
        }

        private void buttonIII3_Click(object sender, EventArgs e)
        {
            SetSeatStatus("treći", 3, "parter", datumPrikazivanja, terminPrikazivanja);

            CheckSeatStatus();

            SetSeatDetails("treći", 3, "parter", status);

            ShowSellingItems();
            SetLabelText();
        }

        private void buttonIII4_Click(object sender, EventArgs e)
        {
            SetSeatStatus("treći", 4, "parter", datumPrikazivanja, terminPrikazivanja);

            CheckSeatStatus();

            SetSeatDetails("treći", 4, "parter", status);

            ShowSellingItems();
            SetLabelText();
        }

        private void buttonIII5_Click(object sender, EventArgs e)
        {
            SetSeatStatus("treći", 5, "parter", datumPrikazivanja, terminPrikazivanja);

            CheckSeatStatus();

            SetSeatDetails("treći", 5, "parter", status);

            ShowSellingItems();
            SetLabelText();
        }

        private void buttonIII6_Click(object sender, EventArgs e)
        {
            SetSeatStatus("treći", 6, "parter", datumPrikazivanja, terminPrikazivanja);

            CheckSeatStatus();

            SetSeatDetails("treći", 6, "parter", status);

            ShowSellingItems();
            SetLabelText();
        }

        private void buttonIII7_Click(object sender, EventArgs e)
        {
            SetSeatStatus("treći", 7, "parter", datumPrikazivanja, terminPrikazivanja);

            CheckSeatStatus();

            SetSeatDetails("treći", 7, "parter", status);

            ShowSellingItems();
            SetLabelText();
        }

        private void buttonIII8_Click(object sender, EventArgs e)
        {
            SetSeatStatus("treći", 8, "parter", datumPrikazivanja, terminPrikazivanja);

            CheckSeatStatus();

            SetSeatDetails("treći", 8, "parter", status);

            ShowSellingItems();
            SetLabelText();
        }

        private void buttonIII9_Click(object sender, EventArgs e)
        {
            SetSeatStatus("treći", 9, "parter", datumPrikazivanja, terminPrikazivanja);

            CheckSeatStatus();

            SetSeatDetails("treći", 9, "parter", status);

            ShowSellingItems();
            SetLabelText();
        }

        private void buttonIII10_Click(object sender, EventArgs e)
        {
            SetSeatStatus("treći", 10, "parter", datumPrikazivanja, terminPrikazivanja);

            CheckSeatStatus();

            SetSeatDetails("treći", 10, "parter", status);

            ShowSellingItems();
            SetLabelText();
        }

        //sjedišta u četvrtom redu - PARTER

        private void buttonIV1_Click(object sender, EventArgs e)
        {
            SetSeatStatus("četvrti", 1, "parter", datumPrikazivanja, terminPrikazivanja);

            CheckSeatStatus();

            SetSeatDetails("četvrti", 1, "parter", status);

            ShowSellingItems();
            SetLabelText();
        }

        private void buttonIV2_Click(object sender, EventArgs e)
        {
            SetSeatStatus("četvrti", 2, "parter", datumPrikazivanja, terminPrikazivanja);

            CheckSeatStatus();

            SetSeatDetails("četvrti", 2, "parter", status);

            ShowSellingItems();
            SetLabelText();
        }

        private void buttonIV3_Click(object sender, EventArgs e)
        {
            SetSeatStatus("četvrti", 3, "parter", datumPrikazivanja, terminPrikazivanja);

            CheckSeatStatus();

            SetSeatDetails("četvrti", 3, "parter", status);

            ShowSellingItems();
            SetLabelText();
        }

        private void buttonIV4_Click(object sender, EventArgs e)
        {
            SetSeatStatus("četvrti", 4, "parter", datumPrikazivanja, terminPrikazivanja);

            CheckSeatStatus();

            SetSeatDetails("četvrti", 4, "parter", status);

            ShowSellingItems();
            SetLabelText();
        }

        private void buttonIV5_Click(object sender, EventArgs e)
        {
            SetSeatStatus("četvrti", 5, "parter", datumPrikazivanja, terminPrikazivanja);

            CheckSeatStatus();

            SetSeatDetails("četvrti", 5, "parter", status);

            ShowSellingItems();
            SetLabelText();
        }

        private void buttonIV6_Click(object sender, EventArgs e)
        {
            SetSeatStatus("četvrti", 6, "parter", datumPrikazivanja, terminPrikazivanja);

            CheckSeatStatus();

            SetSeatDetails("četvrti", 6, "parter", status);

            ShowSellingItems();
            SetLabelText();
        }

        private void buttonIV7_Click(object sender, EventArgs e)
        {
            SetSeatStatus("četvrti", 7, "parter", datumPrikazivanja, terminPrikazivanja);

            CheckSeatStatus();

            SetSeatDetails("četvrti", 7, "parter", status);

            ShowSellingItems();
            SetLabelText();
        }

        private void buttonIV8_Click(object sender, EventArgs e)
        {
            SetSeatStatus("četvrti", 8, "parter", datumPrikazivanja, terminPrikazivanja);

            CheckSeatStatus();

            SetSeatDetails("četvrti", 8, "parter", status);

            ShowSellingItems();
            SetLabelText();
        }

        private void buttonIV9_Click(object sender, EventArgs e)
        {
            SetSeatStatus("četvrti", 9, "parter", datumPrikazivanja, terminPrikazivanja);

            CheckSeatStatus();

            SetSeatDetails("četvrti", 9, "parter", status);

            ShowSellingItems();
            SetLabelText();
        }

        private void buttonIV10_Click(object sender, EventArgs e)
        {
            SetSeatStatus("četvrti", 10, "parter", datumPrikazivanja, terminPrikazivanja);

            CheckSeatStatus();

            SetSeatDetails("četvrti", 10, "parter", status);

            ShowSellingItems();
            SetLabelText();
        }

        private void buttonIV11_Click(object sender, EventArgs e)
        {
            SetSeatStatus("četvrti", 11, "parter", datumPrikazivanja, terminPrikazivanja);

            CheckSeatStatus();

            SetSeatDetails("četvrti", 11, "parter", status);

            ShowSellingItems();
            SetLabelText();
        }

        //sjedišta u petom redu - PARTER

        private void buttonV1_Click(object sender, EventArgs e)
        {
            SetSeatStatus("peti", 1, "parter", datumPrikazivanja, terminPrikazivanja);

            CheckSeatStatus();

            SetSeatDetails("peti", 1, "parter", status);

            ShowSellingItems();
            SetLabelText();
        }

        private void buttonV2_Click(object sender, EventArgs e)
        {
            SetSeatStatus("peti", 2, "parter", datumPrikazivanja, terminPrikazivanja);

            CheckSeatStatus();

            SetSeatDetails("peti", 2, "parter", status);

            ShowSellingItems();
            SetLabelText();
        }

        private void buttonV3_Click(object sender, EventArgs e)
        {
            SetSeatStatus("peti", 3, "parter", datumPrikazivanja, terminPrikazivanja);

            CheckSeatStatus();

            SetSeatDetails("peti", 3, "parter", status);

            ShowSellingItems();
            SetLabelText();
        }

        private void buttonV4_Click(object sender, EventArgs e)
        {
            SetSeatStatus("peti", 4, "parter", datumPrikazivanja, terminPrikazivanja);

            CheckSeatStatus();

            SetSeatDetails("peti", 4, "parter", status);

            ShowSellingItems();
            SetLabelText();
        }

        private void buttonV5_Click(object sender, EventArgs e)
        {
            SetSeatStatus("peti", 5, "parter", datumPrikazivanja, terminPrikazivanja);

            CheckSeatStatus();

            SetSeatDetails("peti", 5, "parter", status);

            ShowSellingItems();
            SetLabelText();
        }

        private void buttonV6_Click(object sender, EventArgs e)
        {
            SetSeatStatus("peti", 6, "parter", datumPrikazivanja, terminPrikazivanja);

            CheckSeatStatus();

            SetSeatDetails("peti", 6, "parter", status);

            ShowSellingItems();
            SetLabelText();
        }

        private void buttonV7_Click(object sender, EventArgs e)
        {
            SetSeatStatus("peti", 7, "parter", datumPrikazivanja, terminPrikazivanja);

            CheckSeatStatus();

            SetSeatDetails("peti", 7, "parter", status);

            ShowSellingItems();
            SetLabelText();
        }

        private void buttonV8_Click(object sender, EventArgs e)
        {
            SetSeatStatus("peti", 8, "parter", datumPrikazivanja, terminPrikazivanja);

            CheckSeatStatus();

            SetSeatDetails("peti", 8, "parter", status);

            ShowSellingItems();
            SetLabelText();
        }

        private void buttonV9_Click(object sender, EventArgs e)
        {
            SetSeatStatus("peti", 9, "parter", datumPrikazivanja, terminPrikazivanja);

            CheckSeatStatus();

            SetSeatDetails("peti", 9, "parter", status);

            ShowSellingItems();
            SetLabelText();
        }

        private void buttonV10_Click(object sender, EventArgs e)
        {
            SetSeatStatus("peti", 10, "parter", datumPrikazivanja, terminPrikazivanja);

            CheckSeatStatus();

            SetSeatDetails("peti", 10, "parter", status);

            ShowSellingItems();
            SetLabelText();
        }

        //sjedišta u šestom redu - PARTER

        private void buttonVI1_Click(object sender, EventArgs e)
        {
            SetSeatStatus("šesti", 1, "parter", datumPrikazivanja, terminPrikazivanja);

            CheckSeatStatus();

            SetSeatDetails("šesti", 1, "parter", status);

            ShowSellingItems();
            SetLabelText();
        }

        private void buttonVI2_Click(object sender, EventArgs e)
        {
            SetSeatStatus("šesti", 2, "parter", datumPrikazivanja, terminPrikazivanja);

            CheckSeatStatus();

            SetSeatDetails("šesti", 2, "parter", status);

            ShowSellingItems();
            SetLabelText();
        }

        private void buttonVI3_Click(object sender, EventArgs e)
        {
            SetSeatStatus("šesti", 3, "parter", datumPrikazivanja, terminPrikazivanja);

            CheckSeatStatus();

            SetSeatDetails("šesti", 3, "parter", status);

            ShowSellingItems();
            SetLabelText();
        }

        private void buttonVI4_Click(object sender, EventArgs e)
        {
            SetSeatStatus("šesti", 4, "parter", datumPrikazivanja, terminPrikazivanja);

            CheckSeatStatus();

            SetSeatDetails("šesti", 4, "parter", status);

            ShowSellingItems();
            SetLabelText();
        }

        private void buttonVI5_Click(object sender, EventArgs e)
        {
            SetSeatStatus("šesti", 5, "parter", datumPrikazivanja, terminPrikazivanja);

            CheckSeatStatus();

            SetSeatDetails("šesti", 5, "parter", status);

            ShowSellingItems();
            SetLabelText();
        }

        private void buttonVI6_Click(object sender, EventArgs e)
        {
            SetSeatStatus("šesti", 6, "parter", datumPrikazivanja, terminPrikazivanja);

            CheckSeatStatus();

            SetSeatDetails("šesti", 6, "parter", status);

            ShowSellingItems();
            SetLabelText();
        }

        private void buttonVI7_Click(object sender, EventArgs e)
        {
            SetSeatStatus("šesti", 7, "parter", datumPrikazivanja, terminPrikazivanja);

            CheckSeatStatus();

            SetSeatDetails("šesti", 7, "parter", status);

            ShowSellingItems();
            SetLabelText();
        }

        private void buttonVI8_Click(object sender, EventArgs e)
        {
            SetSeatStatus("šesti", 8, "parter", datumPrikazivanja, terminPrikazivanja);

            CheckSeatStatus();

            SetSeatDetails("šesti", 8, "parter", status);

            ShowSellingItems();
            SetLabelText();
        }

        private void buttonVI9_Click(object sender, EventArgs e)
        {
            SetSeatStatus("šesti", 9, "parter", datumPrikazivanja, terminPrikazivanja);

            CheckSeatStatus();

            SetSeatDetails("šesti", 9, "parter", status);

            ShowSellingItems();
            SetLabelText();
        }

        private void buttonVI10_Click(object sender, EventArgs e)
        {
            SetSeatStatus("šesti", 10, "parter", datumPrikazivanja, terminPrikazivanja);

            CheckSeatStatus();

            SetSeatDetails("šesti", 10, "parter", status);

            ShowSellingItems();
            SetLabelText();
        }

        private void buttonVI11_Click(object sender, EventArgs e)
        {
            SetSeatStatus("šesti", 11, "parter", datumPrikazivanja, terminPrikazivanja);

            CheckSeatStatus();

            SetSeatDetails("šesti", 11, "parter", status);

            ShowSellingItems();
            SetLabelText();
        }

        //sjedišta u sedmom redu - PARTER

        private void buttonVII1_Click(object sender, EventArgs e)
        {
            SetSeatStatus("sedmi", 1, "parter", datumPrikazivanja, terminPrikazivanja);

            CheckSeatStatus();

            SetSeatDetails("sedmi", 1, "parter", status);

            ShowSellingItems();
            SetLabelText();
        }

        private void buttonVII2_Click(object sender, EventArgs e)
        {
            SetSeatStatus("sedmi", 2, "parter", datumPrikazivanja, terminPrikazivanja);

            CheckSeatStatus();

            SetSeatDetails("sedmi", 2, "parter", status);

            ShowSellingItems();
            SetLabelText();
        }

        private void buttonVII3_Click(object sender, EventArgs e)
        {
            SetSeatStatus("sedmi", 3, "parter", datumPrikazivanja, terminPrikazivanja);

            CheckSeatStatus();

            SetSeatDetails("sedmi", 3, "parter", status);

            ShowSellingItems();
            SetLabelText();
        }

        private void buttonVII4_Click(object sender, EventArgs e)
        {
            SetSeatStatus("sedmi", 4, "parter", datumPrikazivanja, terminPrikazivanja);

            CheckSeatStatus();

            SetSeatDetails("sedmi", 4, "parter", status);

            ShowSellingItems();
            SetLabelText();
        }

        private void buttonVII5_Click(object sender, EventArgs e)
        {
            SetSeatStatus("sedmi", 5, "parter", datumPrikazivanja, terminPrikazivanja);

            CheckSeatStatus();

            SetSeatDetails("sedmi", 5, "parter", status);

            ShowSellingItems();
            SetLabelText();
        }

        private void buttonVII6_Click(object sender, EventArgs e)
        {
            SetSeatStatus("sedmi", 6, "parter", datumPrikazivanja, terminPrikazivanja);

            CheckSeatStatus();

            SetSeatDetails("sedmi", 6, "parter", status);

            ShowSellingItems();
            SetLabelText();
        }

        private void buttonVII7_Click(object sender, EventArgs e)
        {
            SetSeatStatus("sedmi", 7, "parter", datumPrikazivanja, terminPrikazivanja);

            CheckSeatStatus();

            SetSeatDetails("sedmi", 7, "parter", status);

            ShowSellingItems();
            SetLabelText();
        }

        private void buttonVII8_Click(object sender, EventArgs e)
        {
            SetSeatStatus("sedmi", 8, "parter", datumPrikazivanja, terminPrikazivanja);

            CheckSeatStatus();

            SetSeatDetails("sedmi", 8, "parter", status);

            ShowSellingItems();
            SetLabelText();
        }

        private void buttonVII9_Click(object sender, EventArgs e)
        {
            SetSeatStatus("sedmi", 9, "parter", datumPrikazivanja, terminPrikazivanja);

            CheckSeatStatus();

            SetSeatDetails("sedmi", 9, "parter", status);

            ShowSellingItems();
            SetLabelText();
        }

        private void buttonVII10_Click(object sender, EventArgs e)
        {
            SetSeatStatus("sedmi", 10, "parter", datumPrikazivanja, terminPrikazivanja);

            CheckSeatStatus();

            SetSeatDetails("sedmi", 10, "parter", status);

            ShowSellingItems();
            SetLabelText();
        }
        
        //sjedišta u osmom redu - PARTER

        private void buttonVIII1_Click(object sender, EventArgs e)
        {
            SetSeatStatus("osmi", 1, "parter", datumPrikazivanja, terminPrikazivanja);

            CheckSeatStatus();

            SetSeatDetails("osmi", 1, "parter", status);

            ShowSellingItems();
            SetLabelText();
        }

        private void buttonVIII2_Click(object sender, EventArgs e)
        {
            SetSeatStatus("osmi", 2, "parter", datumPrikazivanja, terminPrikazivanja);

            CheckSeatStatus();

            SetSeatDetails("osmi", 2, "parter", status);

            ShowSellingItems();
            SetLabelText();
        }

        private void buttonVIII3_Click(object sender, EventArgs e)
        {
            SetSeatStatus("osmi", 3, "parter", datumPrikazivanja, terminPrikazivanja);

            CheckSeatStatus();

            SetSeatDetails("osmi", 3, "parter", status);

            ShowSellingItems();
            SetLabelText();
        }

        private void buttonVIII4_Click(object sender, EventArgs e)
        {
            SetSeatStatus("osmi", 4, "parter", datumPrikazivanja, terminPrikazivanja);

            CheckSeatStatus();

            SetSeatDetails("osmi", 4, "parter", status);

            ShowSellingItems();
            SetLabelText();
        }

        private void buttonVIII5_Click(object sender, EventArgs e)
        {
            SetSeatStatus("osmi", 5, "parter", datumPrikazivanja, terminPrikazivanja);

            CheckSeatStatus();

            SetSeatDetails("osmi", 5, "parter", status);

            ShowSellingItems();
            SetLabelText();
        }

        private void buttonVIII6_Click(object sender, EventArgs e)
        {
            SetSeatStatus("osmi", 6, "parter", datumPrikazivanja, terminPrikazivanja);

            CheckSeatStatus();

            SetSeatDetails("osmi", 6, "parter", status);

            ShowSellingItems();
            SetLabelText();
        }

        private void buttonVIII7_Click(object sender, EventArgs e)
        {
            SetSeatStatus("osmi", 7, "parter", datumPrikazivanja, terminPrikazivanja);

            CheckSeatStatus();

            SetSeatDetails("osmi", 7, "parter", status);

            ShowSellingItems();
            SetLabelText();
        }

        private void buttonVIII8_Click(object sender, EventArgs e)
        {
            SetSeatStatus("osmi", 8, "parter", datumPrikazivanja, terminPrikazivanja);

            CheckSeatStatus();

            SetSeatDetails("osmi", 8, "parter", status);

            ShowSellingItems();
            SetLabelText();
        }

        private void buttonVIII9_Click(object sender, EventArgs e)
        {
            SetSeatStatus("osmi", 9, "parter", datumPrikazivanja, terminPrikazivanja);

            CheckSeatStatus();

            SetSeatDetails("osmi", 9, "parter", status);

            ShowSellingItems();
            SetLabelText();
        }

        private void buttonVIII10_Click(object sender, EventArgs e)
        {
            SetSeatStatus("osmi", 10, "parter", datumPrikazivanja, terminPrikazivanja);

            CheckSeatStatus();

            SetSeatDetails("osmi", 10, "parter", status);

            ShowSellingItems();
            SetLabelText();
        }

        private void buttonVIII11_Click(object sender, EventArgs e)
        {
            SetSeatStatus("osmi", 11, "parter", datumPrikazivanja, terminPrikazivanja);

            CheckSeatStatus();

            SetSeatDetails("osmi", 11, "parter", status);

            ShowSellingItems();
            SetLabelText();
        }

        //sjedišta u devetom redu - PARTER

        private void buttonIX1_Click(object sender, EventArgs e)
        {
            SetSeatStatus("deveti", 1, "parter", datumPrikazivanja, terminPrikazivanja);

            CheckSeatStatus();

            SetSeatDetails("deveti", 1, "parter", status);

            ShowSellingItems();
            SetLabelText();
        }

        private void buttonIX2_Click(object sender, EventArgs e)
        {
            SetSeatStatus("deveti", 2, "parter", datumPrikazivanja, terminPrikazivanja);

            CheckSeatStatus();

            SetSeatDetails("deveti", 2, "parter", status);

            ShowSellingItems();
            SetLabelText();
        }

        private void buttonIX3_Click(object sender, EventArgs e)
        {
            SetSeatStatus("deveti", 3, "parter", datumPrikazivanja, terminPrikazivanja);

            CheckSeatStatus();

            SetSeatDetails("deveti", 3, "parter", status);

            ShowSellingItems();
            SetLabelText();
        }

        private void buttonIX4_Click(object sender, EventArgs e)
        {
            SetSeatStatus("deveti", 4, "parter", datumPrikazivanja, terminPrikazivanja);

            CheckSeatStatus();

            SetSeatDetails("deveti", 4, "parter", status);

            ShowSellingItems();
            SetLabelText();
        }

        private void buttonIX5_Click(object sender, EventArgs e)
        {
            SetSeatStatus("deveti", 5, "parter", datumPrikazivanja, terminPrikazivanja);

            CheckSeatStatus();

            SetSeatDetails("deveti", 5, "parter", status);

            ShowSellingItems();
            SetLabelText();
        }

        private void buttonIX6_Click(object sender, EventArgs e)
        {
            SetSeatStatus("deveti", 6, "parter", datumPrikazivanja, terminPrikazivanja);

            CheckSeatStatus();

            SetSeatDetails("deveti", 6, "parter", status);

            ShowSellingItems();
            SetLabelText();
        }

        private void buttonIX7_Click(object sender, EventArgs e)
        {
            SetSeatStatus("deveti", 7, "parter", datumPrikazivanja, terminPrikazivanja);

            CheckSeatStatus();

            SetSeatDetails("deveti", 7, "parter", status);

            ShowSellingItems();
            SetLabelText();
        }

        private void buttonIX8_Click(object sender, EventArgs e)
        {
            SetSeatStatus("deveti", 8, "parter", datumPrikazivanja, terminPrikazivanja);

            CheckSeatStatus();

            SetSeatDetails("deveti", 8, "parter", status);

            ShowSellingItems();
            SetLabelText();
        }

        private void buttonIX9_Click(object sender, EventArgs e)
        {
            SetSeatStatus("deveti", 9, "parter", datumPrikazivanja, terminPrikazivanja);

            CheckSeatStatus();

            SetSeatDetails("deveti", 9, "parter", status);

            ShowSellingItems();
            SetLabelText();
        }

        private void buttonIX10_Click(object sender, EventArgs e)
        {
            SetSeatStatus("deveti", 10, "parter", datumPrikazivanja, terminPrikazivanja);

            CheckSeatStatus();

            SetSeatDetails("deveti", 10, "parter", status);

            ShowSellingItems();
            SetLabelText();
        }

        //sjedišta u prvom redu - BALKON

        private void buttonBI1_Click(object sender, EventArgs e)
        {
            SetSeatStatus("prvi", 1, "balkon", datumPrikazivanja, terminPrikazivanja);

            CheckSeatStatus();

            SetSeatDetails("prvi", 1, "balkon", status);

            ShowSellingItems();
            SetLabelText();
        }

        private void buttonBI2_Click(object sender, EventArgs e)
        {
            SetSeatStatus("prvi", 2, "balkon", datumPrikazivanja, terminPrikazivanja);

            CheckSeatStatus();

            SetSeatDetails("prvi", 2, "balkon", status);

            ShowSellingItems();
            SetLabelText();
        }
        
        private void buttonBI3_Click(object sender, EventArgs e)
        {
            SetSeatStatus("prvi", 3, "balkon", datumPrikazivanja, terminPrikazivanja);

            CheckSeatStatus();

            SetSeatDetails("prvi", 3, "balkon", status);

            ShowSellingItems();
            SetLabelText();
        }

        private void buttonBI4_Click(object sender, EventArgs e)
        {
            SetSeatStatus("prvi", 4, "balkon", datumPrikazivanja, terminPrikazivanja);

            CheckSeatStatus();

            SetSeatDetails("prvi", 4, "balkon", status);

            ShowSellingItems();
            SetLabelText();
        }

        private void buttonBI5_Click(object sender, EventArgs e)
        {
            SetSeatStatus("prvi", 5, "balkon", datumPrikazivanja, terminPrikazivanja);

            CheckSeatStatus();

            SetSeatDetails("prvi", 5, "balkon", status);

            ShowSellingItems();
            SetLabelText();
        }

        private void buttonBI6_Click(object sender, EventArgs e)
        {
            SetSeatStatus("prvi", 6, "balkon", datumPrikazivanja, terminPrikazivanja);

            CheckSeatStatus();

            SetSeatDetails("prvi", 6, "balkon", status);

            ShowSellingItems();
            SetLabelText();
        }

        private void buttonBI7_Click(object sender, EventArgs e)
        {
            SetSeatStatus("prvi", 7, "balkon", datumPrikazivanja, terminPrikazivanja);

            CheckSeatStatus();

            SetSeatDetails("prvi", 7, "balkon", status);

            ShowSellingItems();
            SetLabelText();
        }

        //sjedišta u drugom redu - BALKON
       
        private void buttonBII1_Click(object sender, EventArgs e)
        {
            SetSeatStatus("drugi", 1, "balkon", datumPrikazivanja, terminPrikazivanja);

            CheckSeatStatus();

            SetSeatDetails("drugi", 1, "balkon", status);

            ShowSellingItems();
            SetLabelText();
        }

        private void buttonBII2_Click(object sender, EventArgs e)
        {
            SetSeatStatus("drugi", 2, "balkon", datumPrikazivanja, terminPrikazivanja);

            CheckSeatStatus();

            SetSeatDetails("drugi", 2, "balkon", status);

            ShowSellingItems();
            SetLabelText();
        }

        private void buttonBII3_Click(object sender, EventArgs e)
        {
            SetSeatStatus("drugi", 3, "balkon", datumPrikazivanja, terminPrikazivanja);

            CheckSeatStatus();

            SetSeatDetails("drugi", 3, "balkon", status);

            ShowSellingItems();
            SetLabelText();
        }

        private void buttonBII4_Click(object sender, EventArgs e)
        {
            SetSeatStatus("drugi", 4, "balkon", datumPrikazivanja, terminPrikazivanja);

            CheckSeatStatus();

            SetSeatDetails("drugi", 4, "balkon", status);

            ShowSellingItems();
            SetLabelText();
        }

        private void buttonBII5_Click(object sender, EventArgs e)
        {
            SetSeatStatus("drugi", 5, "balkon", datumPrikazivanja, terminPrikazivanja);

            CheckSeatStatus();

            SetSeatDetails("drugi", 5, "balkon", status);

            ShowSellingItems();
            SetLabelText();
        }

        private void buttonBII6_Click(object sender, EventArgs e)
        {
            SetSeatStatus("drugi", 6, "balkon", datumPrikazivanja, terminPrikazivanja);

            CheckSeatStatus();

            SetSeatDetails("drugi", 6, "balkon", status);

            ShowSellingItems();
            SetLabelText();
        }

        private void buttonBII7_Click(object sender, EventArgs e)
        {
            SetSeatStatus("drugi", 7, "balkon", datumPrikazivanja, terminPrikazivanja);

            CheckSeatStatus();

            SetSeatDetails("drugi", 7, "balkon", status);

            ShowSellingItems();
            SetLabelText();
        }

        private void buttonBII8_Click(object sender, EventArgs e)
        {
            SetSeatStatus("drugi", 8, "balkon", datumPrikazivanja, terminPrikazivanja);

            CheckSeatStatus();

            SetSeatDetails("drugi", 8, "balkon", status);

            ShowSellingItems();
            SetLabelText();
        }

        //sjedišta u trećem redu - BALKON

        private void buttonBIII1_Click(object sender, EventArgs e)
        {
            SetSeatStatus("treći", 1, "balkon", datumPrikazivanja, terminPrikazivanja);

            CheckSeatStatus();

            SetSeatDetails("treći", 1, "balkon", status);

            ShowSellingItems();
            SetLabelText();
        }

        private void buttonBIII2_Click(object sender, EventArgs e)
        {
            SetSeatStatus("treći", 2, "balkon", datumPrikazivanja, terminPrikazivanja);

            CheckSeatStatus();

            SetSeatDetails("treći", 2, "balkon", status);

            ShowSellingItems();
            SetLabelText();
        }

        private void buttonBIII3_Click(object sender, EventArgs e)
        {
            SetSeatStatus("treći", 3, "balkon", datumPrikazivanja, terminPrikazivanja);

            CheckSeatStatus();

            SetSeatDetails("treći", 3, "balkon", status);

            ShowSellingItems();
            SetLabelText();
        }

        private void buttonBIII4_Click(object sender, EventArgs e)
        {
            SetSeatStatus("treći", 4, "balkon", datumPrikazivanja, terminPrikazivanja);

            CheckSeatStatus();

            SetSeatDetails("treći", 4, "balkon", status);

            ShowSellingItems();
            SetLabelText();
        }

        private void buttonBIII5_Click(object sender, EventArgs e)
        {
            SetSeatStatus("treći", 5, "balkon", datumPrikazivanja, terminPrikazivanja);

            CheckSeatStatus();

            SetSeatDetails("treći", 5, "balkon", status);

            ShowSellingItems();
            SetLabelText();
        }

        private void buttonBIII6_Click(object sender, EventArgs e)
        {
            SetSeatStatus("treći", 6, "balkon", datumPrikazivanja, terminPrikazivanja);

            CheckSeatStatus();

            SetSeatDetails("treći", 6, "balkon", status);

            ShowSellingItems();
            SetLabelText();
        }

        private void buttonBIII7_Click(object sender, EventArgs e)
        {
            SetSeatStatus("treći", 7, "balkon", datumPrikazivanja, terminPrikazivanja);

            CheckSeatStatus();

            SetSeatDetails("treći", 7, "balkon", status);

            ShowSellingItems();
            SetLabelText();
        }

        private void buttonBIII8_Click(object sender, EventArgs e)
        {
            SetSeatStatus("treći", 8, "balkon", datumPrikazivanja, terminPrikazivanja);

            CheckSeatStatus();

            SetSeatDetails("treći", 8, "balkon", status);

            ShowSellingItems();
            SetLabelText();
        }

        private void buttonBIII9_Click(object sender, EventArgs e)
        {
            SetSeatStatus("treći", 9, "balkon", datumPrikazivanja, terminPrikazivanja);

            CheckSeatStatus();

            SetSeatDetails("treći", 9, "balkon", status);

            ShowSellingItems();
            SetLabelText();
        }

        //sjedišta u četvrtom redu - BALKON

        private void buttonBIV1_Click(object sender, EventArgs e)
        {
            SetSeatStatus("četvrti", 1, "balkon", datumPrikazivanja, terminPrikazivanja);

            CheckSeatStatus();

            SetSeatDetails("četvrti", 1, "balkon", status);

            ShowSellingItems();
            SetLabelText();
        }

        private void buttonBIV2_Click(object sender, EventArgs e)
        {
            SetSeatStatus("četvrti", 2, "balkon", datumPrikazivanja, terminPrikazivanja);

            CheckSeatStatus();

            SetSeatDetails("četvrti", 2, "balkon", status);

            ShowSellingItems();
            SetLabelText();
        }

        private void buttonBIV3_Click(object sender, EventArgs e)
        {
            SetSeatStatus("četvrti", 3, "balkon", datumPrikazivanja, terminPrikazivanja);

            CheckSeatStatus();

            SetSeatDetails("četvrti", 3, "balkon", status);

            ShowSellingItems();
            SetLabelText();
        }

        private void buttonBIV4_Click(object sender, EventArgs e)
        {
            SetSeatStatus("četvrti", 4, "balkon", datumPrikazivanja, terminPrikazivanja);

            CheckSeatStatus();

            SetSeatDetails("četvrti", 4, "balkon", status);

            ShowSellingItems();
            SetLabelText();
        }

        private void buttonBIV5_Click(object sender, EventArgs e)
        {
            SetSeatStatus("četvrti", 5, "balkon", datumPrikazivanja, terminPrikazivanja);

            CheckSeatStatus();

            SetSeatDetails("četvrti", 5, "balkon", status);

            ShowSellingItems();
            SetLabelText();
        }

        private void buttonBIV6_Click(object sender, EventArgs e)
        {
            SetSeatStatus("četvrti", 6, "balkon", datumPrikazivanja, terminPrikazivanja);

            CheckSeatStatus();

            SetSeatDetails("četvrti", 6, "balkon", status);

            ShowSellingItems();
            SetLabelText();
        }

        private void buttonBIV7_Click(object sender, EventArgs e)
        {
            SetSeatStatus("četvrti", 7, "balkon", datumPrikazivanja, terminPrikazivanja);

            CheckSeatStatus();

            SetSeatDetails("četvrti", 7, "balkon", status);

            ShowSellingItems();
            SetLabelText();
        }

        private void buttonBIV8_Click(object sender, EventArgs e)
        {
            SetSeatStatus("četvrti", 8, "balkon", datumPrikazivanja, terminPrikazivanja);

            CheckSeatStatus();

            SetSeatDetails("četvrti", 8, "balkon", status);

            ShowSellingItems();
            SetLabelText();
        }

        private void buttonBIV9_Click(object sender, EventArgs e)
        {
            SetSeatStatus("četvrti", 9, "balkon", datumPrikazivanja, terminPrikazivanja);

            CheckSeatStatus();

            SetSeatDetails("četvrti", 9, "balkon", status);

            ShowSellingItems();
            SetLabelText();
        }

        private void buttonBIV10_Click(object sender, EventArgs e)
        {
            SetSeatStatus("četvrti", 10, "balkon", datumPrikazivanja, terminPrikazivanja);

            CheckSeatStatus();

            SetSeatDetails("četvrti", 10, "balkon", status);

            ShowSellingItems();
            SetLabelText();
        }

        //sjedišta u petom redu - BALKON

        private void buttonBV1_Click(object sender, EventArgs e)
        {
            SetSeatStatus("peti", 1, "balkon", datumPrikazivanja, terminPrikazivanja);

            CheckSeatStatus();

            SetSeatDetails("peti", 1, "balkon", status);

            ShowSellingItems();
            SetLabelText();
        }

        private void buttonBV2_Click(object sender, EventArgs e)
        {
            SetSeatStatus("peti", 2, "balkon", datumPrikazivanja, terminPrikazivanja);

            CheckSeatStatus();

            SetSeatDetails("peti", 2, "balkon", status);

            ShowSellingItems();
            SetLabelText();
        }

        private void buttonBV3_Click(object sender, EventArgs e)
        {
            SetSeatStatus("peti", 3, "balkon", datumPrikazivanja, terminPrikazivanja);

            CheckSeatStatus();

            SetSeatDetails("peti", 3, "balkon", status);

            ShowSellingItems();
            SetLabelText();
        }

        private void buttonBV4_Click(object sender, EventArgs e)
        {
            SetSeatStatus("peti", 4, "balkon", datumPrikazivanja, terminPrikazivanja);

            CheckSeatStatus();

            SetSeatDetails("peti", 4, "balkon", status);

            ShowSellingItems();
            SetLabelText();
        }

        private void buttonBV5_Click(object sender, EventArgs e)
        {
            SetSeatStatus("peti", 5, "balkon", datumPrikazivanja, terminPrikazivanja);

            CheckSeatStatus();

            SetSeatDetails("peti", 5, "balkon", status);

            ShowSellingItems();
            SetLabelText();
        }

        private void buttonBV6_Click(object sender, EventArgs e)
        {
            SetSeatStatus("peti", 6, "balkon", datumPrikazivanja, terminPrikazivanja);

            CheckSeatStatus();

            SetSeatDetails("peti", 6, "balkon", status);

            ShowSellingItems();
            SetLabelText();
        }

        private void buttonBV7_Click(object sender, EventArgs e)
        {
            SetSeatStatus("peti", 7, "balkon", datumPrikazivanja, terminPrikazivanja);

            CheckSeatStatus();

            SetSeatDetails("peti", 7, "balkon", status);

            ShowSellingItems();
            SetLabelText();
        }

        private void buttonBV8_Click(object sender, EventArgs e)
        {
            SetSeatStatus("peti", 8, "balkon", datumPrikazivanja, terminPrikazivanja);

            CheckSeatStatus();

            SetSeatDetails("peti", 8, "balkon", status);

            ShowSellingItems();
            SetLabelText();
        }

        private void buttonBV9_Click(object sender, EventArgs e)
        {
            SetSeatStatus("peti", 9, "balkon", datumPrikazivanja, terminPrikazivanja);

            CheckSeatStatus();

            SetSeatDetails("peti", 9, "balkon", status);

            ShowSellingItems();
            SetLabelText();
        }

        private void buttonBV10_Click(object sender, EventArgs e)
        {
            SetSeatStatus("peti", 10, "balkon", datumPrikazivanja, terminPrikazivanja);

            CheckSeatStatus();

            SetSeatDetails("peti", 10, "balkon", status);

            ShowSellingItems();
            SetLabelText();
        }

        private void buttonBV11_Click(object sender, EventArgs e)
        {
            SetSeatStatus("peti", 11, "balkon", datumPrikazivanja, terminPrikazivanja);

            CheckSeatStatus();

            SetSeatDetails("peti", 11, "balkon", status);

            ShowSellingItems();
            SetLabelText();
        }

        //sjedišta u šestom redu - BALKON

        private void buttonBVI1_Click(object sender, EventArgs e)
        {
            SetSeatStatus("šesti", 1, "balkon", datumPrikazivanja, terminPrikazivanja);

            CheckSeatStatus();

            SetSeatDetails("šesti", 1, "balkon", status);

            ShowSellingItems();
            SetLabelText();
        }

        private void buttonBVI2_Click(object sender, EventArgs e)
        {
            SetSeatStatus("šesti", 2, "balkon", datumPrikazivanja, terminPrikazivanja);

            CheckSeatStatus();

            SetSeatDetails("šesti", 2, "balkon", status);

            ShowSellingItems();
            SetLabelText();
        }

        private void buttonBVI3_Click(object sender, EventArgs e)
        {
            SetSeatStatus("šesti", 3, "balkon", datumPrikazivanja, terminPrikazivanja);

            CheckSeatStatus();

            SetSeatDetails("šesti", 3, "balkon", status);

            ShowSellingItems();
            SetLabelText();
        }

        private void buttonBVI4_Click(object sender, EventArgs e)
        {
            SetSeatStatus("šesti", 4, "balkon", datumPrikazivanja, terminPrikazivanja);

            CheckSeatStatus();

            SetSeatDetails("šesti", 4, "balkon", status);

            ShowSellingItems();
            SetLabelText();
        }

        private void buttonBVI5_Click(object sender, EventArgs e)
        {
            SetSeatStatus("šesti", 5, "balkon", datumPrikazivanja, terminPrikazivanja);

            CheckSeatStatus();

            SetSeatDetails("šesti", 5, "balkon", status);

            ShowSellingItems();
            SetLabelText();
        }

        private void buttonBVI6_Click(object sender, EventArgs e)
        {
            SetSeatStatus("šesti", 6, "balkon", datumPrikazivanja, terminPrikazivanja);

            CheckSeatStatus();

            SetSeatDetails("šesti", 6, "balkon", status);

            ShowSellingItems();
            SetLabelText();
        }

        private void buttonBVI7_Click(object sender, EventArgs e)
        {
            SetSeatStatus("šesti", 7, "balkon", datumPrikazivanja, terminPrikazivanja);

            CheckSeatStatus();

            SetSeatDetails("šesti", 7, "balkon", status);

            ShowSellingItems();
            SetLabelText();
        }

        private void buttonBVI8_Click(object sender, EventArgs e)
        {
            SetSeatStatus("šesti", 8, "balkon", datumPrikazivanja, terminPrikazivanja);

            CheckSeatStatus();

            SetSeatDetails("šesti", 8, "balkon", status);

            ShowSellingItems();
            SetLabelText();
        }

        private void buttonBVI9_Click(object sender, EventArgs e)
        {
            SetSeatStatus("šesti", 9, "balkon", datumPrikazivanja, terminPrikazivanja);

            CheckSeatStatus();

            SetSeatDetails("šesti", 9, "balkon", status);

            ShowSellingItems();
            SetLabelText();
        }

        private void buttonBVI10_Click(object sender, EventArgs e)
        {
            SetSeatStatus("šesti", 10, "balkon", datumPrikazivanja, terminPrikazivanja);

            CheckSeatStatus();

            SetSeatDetails("šesti", 10, "balkon", status);

            ShowSellingItems();
            SetLabelText();
        }

        private void buttonBVI11_Click(object sender, EventArgs e)
        {
            SetSeatStatus("šesti", 11, "balkon", datumPrikazivanja, terminPrikazivanja);

            CheckSeatStatus();

            SetSeatDetails("šesti", 11, "balkon", status);

            ShowSellingItems();
            SetLabelText();
        }

        private void buttonBVI12_Click(object sender, EventArgs e)
        {
            SetSeatStatus("šesti", 12, "balkon", datumPrikazivanja, terminPrikazivanja);

            CheckSeatStatus();

            SetSeatDetails("šesti", 12, "balkon", status);

            ShowSellingItems();
            SetLabelText();
        }

        //sjedišta u sedmom redu - BALKON

        private void buttonBVII1_Click(object sender, EventArgs e)
        {
            SetSeatStatus("sedmi", 1, "balkon", datumPrikazivanja, terminPrikazivanja);

            CheckSeatStatus();

            SetSeatDetails("sedmi", 1, "balkon", status);

            ShowSellingItems();
            SetLabelText();
        }

        private void buttonBVII2_Click(object sender, EventArgs e)
        {
            SetSeatStatus("sedmi", 2, "balkon", datumPrikazivanja, terminPrikazivanja);

            CheckSeatStatus();

            SetSeatDetails("sedmi", 2, "balkon", status);

            ShowSellingItems();
            SetLabelText();
        }

        private void buttonBVII3_Click(object sender, EventArgs e)
        {
            SetSeatStatus("sedmi", 3, "balkon", datumPrikazivanja, terminPrikazivanja);

            CheckSeatStatus();

            SetSeatDetails("sedmi", 3, "balkon", status);

            ShowSellingItems();
            SetLabelText();
        }

        private void buttonBVII4_Click(object sender, EventArgs e)
        {
            SetSeatStatus("sedmi", 4, "balkon", datumPrikazivanja, terminPrikazivanja);

            CheckSeatStatus();

            SetSeatDetails("sedmi", 4, "balkon", status);

            ShowSellingItems();
            SetLabelText();
        }

        private void buttonBVII5_Click(object sender, EventArgs e)
        {
            SetSeatStatus("sedmi", 5, "balkon", datumPrikazivanja, terminPrikazivanja);

            CheckSeatStatus();

            SetSeatDetails("sedmi", 5, "balkon", status);

            ShowSellingItems();
            SetLabelText();
        }

        private void buttonBVII6_Click(object sender, EventArgs e)
        {
            SetSeatStatus("sedmi", 6, "balkon", datumPrikazivanja, terminPrikazivanja);

            CheckSeatStatus();

            SetSeatDetails("sedmi", 6, "balkon", status);

            ShowSellingItems();
            SetLabelText();
        }

        private void buttonBVII7_Click(object sender, EventArgs e)
        {
            SetSeatStatus("sedmi", 7, "balkon", datumPrikazivanja, terminPrikazivanja);

            CheckSeatStatus();

            SetSeatDetails("sedmi", 7, "balkon", status);

            ShowSellingItems();
            SetLabelText();
        }

        private void buttonBVII8_Click(object sender, EventArgs e)
        {
            SetSeatStatus("sedmi", 8, "balkon", datumPrikazivanja, terminPrikazivanja);

            CheckSeatStatus();

            SetSeatDetails("sedmi", 8, "balkon", status);

            ShowSellingItems();
            SetLabelText();
        }

        private void buttonBVII9_Click(object sender, EventArgs e)
        {
            SetSeatStatus("sedmi", 9, "balkon", datumPrikazivanja, terminPrikazivanja);

            CheckSeatStatus();

            SetSeatDetails("sedmi", 9, "balkon", status);

            ShowSellingItems();
            SetLabelText();
        }

        private void buttonBVII10_Click(object sender, EventArgs e)
        {
            SetSeatStatus("sedmi", 10, "balkon", datumPrikazivanja, terminPrikazivanja);

            CheckSeatStatus();

            SetSeatDetails("sedmi", 10, "balkon", status);

            ShowSellingItems();
            SetLabelText();
        }

        private void buttonBVII11_Click(object sender, EventArgs e)
        {
            SetSeatStatus("sedmi", 11, "balkon", datumPrikazivanja, terminPrikazivanja);

            CheckSeatStatus();

            SetSeatDetails("sedmi", 11, "balkon", status);

            ShowSellingItems();
            SetLabelText();
        }

        private void buttonBVII12_Click(object sender, EventArgs e)
        {
            SetSeatStatus("sedmi", 12, "balkon", datumPrikazivanja, terminPrikazivanja);

            CheckSeatStatus();

            SetSeatDetails("sedmi", 12, "balkon", status);

            ShowSellingItems();
            SetLabelText();
        }

        private void buttonBVII13_Click(object sender, EventArgs e)
        {
            SetSeatStatus("sedmi", 13, "balkon", datumPrikazivanja, terminPrikazivanja);

            CheckSeatStatus();

            SetSeatDetails("sedmi", 13, "balkon", status);

            ShowSellingItems();
            SetLabelText();
        }

        //ostale metode

        private void DisableSeatButtons()
        {
            //parter

            buttonI1.Enabled = false;
            buttonI2.Enabled = false;
            buttonI3.Enabled = false;
            buttonI4.Enabled = false;
            buttonI5.Enabled = false;
            buttonI6.Enabled = false;
            buttonI7.Enabled = false;
            buttonI8.Enabled = false;
            buttonI9.Enabled = false;
            buttonI10.Enabled = false;

            buttonII1.Enabled = false;
            buttonII2.Enabled = false;
            buttonII3.Enabled = false;
            buttonII4.Enabled = false;
            buttonII5.Enabled = false;
            buttonII6.Enabled = false;
            buttonII7.Enabled = false;
            buttonII8.Enabled = false;
            buttonII9.Enabled = false;
            buttonII10.Enabled = false;
            buttonII11.Enabled = false;

            buttonIII1.Enabled = false;
            buttonIII2.Enabled = false;
            buttonIII3.Enabled = false;
            buttonIII4.Enabled = false;
            buttonIII5.Enabled = false;
            buttonIII6.Enabled = false;
            buttonIII7.Enabled = false;
            buttonIII8.Enabled = false;
            buttonIII9.Enabled = false;
            buttonIII10.Enabled = false;

            buttonIV1.Enabled = false;
            buttonIV2.Enabled = false;
            buttonIV3.Enabled = false;
            buttonIV4.Enabled = false;
            buttonIV5.Enabled = false;
            buttonIV6.Enabled = false;
            buttonIV7.Enabled = false;
            buttonIV8.Enabled = false;
            buttonIV9.Enabled = false;
            buttonIV10.Enabled = false;
            buttonIV11.Enabled = false;

            buttonV1.Enabled = false;
            buttonV2.Enabled = false;
            buttonV3.Enabled = false;
            buttonV4.Enabled = false;
            buttonV5.Enabled = false;
            buttonV6.Enabled = false;
            buttonV7.Enabled = false;
            buttonV8.Enabled = false;
            buttonV9.Enabled = false;
            buttonV10.Enabled = false;

            buttonVI1.Enabled = false;
            buttonVI2.Enabled = false;
            buttonVI3.Enabled = false;
            buttonVI4.Enabled = false;
            buttonVI5.Enabled = false;
            buttonVI6.Enabled = false;
            buttonVI7.Enabled = false;
            buttonVI8.Enabled = false;
            buttonVI9.Enabled = false;
            buttonVI10.Enabled = false;
            buttonVI11.Enabled = false;

            buttonVII1.Enabled = false;
            buttonVII2.Enabled = false;
            buttonVII3.Enabled = false;
            buttonVII4.Enabled = false;
            buttonVII5.Enabled = false;
            buttonVII6.Enabled = false;
            buttonVII7.Enabled = false;
            buttonVII8.Enabled = false;
            buttonVII9.Enabled = false;
            buttonVII10.Enabled = false;

            buttonVIII1.Enabled = false;
            buttonVIII2.Enabled = false;
            buttonVIII3.Enabled = false;
            buttonVIII4.Enabled = false;
            buttonVIII5.Enabled = false;
            buttonVIII6.Enabled = false;
            buttonVIII7.Enabled = false;
            buttonVIII8.Enabled = false;
            buttonVIII9.Enabled = false;
            buttonVIII10.Enabled = false;
            buttonVIII11.Enabled = false;

            buttonIX1.Enabled = false;
            buttonIX2.Enabled = false;
            buttonIX3.Enabled = false;
            buttonIX4.Enabled = false;
            buttonIX5.Enabled = false;
            buttonIX6.Enabled = false;
            buttonIX7.Enabled = false;
            buttonIX8.Enabled = false;
            buttonIX9.Enabled = false;
            buttonIX10.Enabled = false;

            //balkon

            buttonBI1.Enabled = false;
            buttonBI2.Enabled = false;
            buttonBI3.Enabled = false;
            buttonBI4.Enabled = false;
            buttonBI5.Enabled = false;
            buttonBI6.Enabled = false;
            buttonBI7.Enabled = false;

            buttonBII1.Enabled = false;
            buttonBII2.Enabled = false;
            buttonBII3.Enabled = false;
            buttonBII4.Enabled = false;
            buttonBII5.Enabled = false;
            buttonBII6.Enabled = false;
            buttonBII7.Enabled = false;
            buttonBII8.Enabled = false;

            buttonBIII1.Enabled = false;
            buttonBIII2.Enabled = false;
            buttonBIII3.Enabled = false;
            buttonBIII4.Enabled = false;
            buttonBIII5.Enabled = false;
            buttonBIII6.Enabled = false;
            buttonBIII7.Enabled = false;
            buttonBIII8.Enabled = false;
            buttonBIII9.Enabled = false;

            buttonBIV1.Enabled = false;
            buttonBIV2.Enabled = false;
            buttonBIV3.Enabled = false;
            buttonBIV4.Enabled = false;
            buttonBIV5.Enabled = false;
            buttonBIV6.Enabled = false;
            buttonBIV7.Enabled = false;
            buttonBIV8.Enabled = false;
            buttonBIV9.Enabled = false;
            buttonBIV10.Enabled = false;

            buttonBV1.Enabled = false;
            buttonBV2.Enabled = false;
            buttonBV3.Enabled = false;
            buttonBV4.Enabled = false;
            buttonBV5.Enabled = false;
            buttonBV6.Enabled = false;
            buttonBV7.Enabled = false;
            buttonBV8.Enabled = false;
            buttonBV9.Enabled = false;
            buttonBV10.Enabled = false;
            buttonBV11.Enabled = false;

            buttonBVI1.Enabled = false;
            buttonBVI2.Enabled = false;
            buttonBVI3.Enabled = false;
            buttonBVI4.Enabled = false;
            buttonBVI5.Enabled = false;
            buttonBVI6.Enabled = false;
            buttonBVI7.Enabled = false;
            buttonBVI8.Enabled = false;
            buttonBVI9.Enabled = false;
            buttonBVI10.Enabled = false;
            buttonBVI11.Enabled = false;
            buttonBVI12.Enabled = false;

            buttonBVII1.Enabled = false;
            buttonBVII2.Enabled = false;
            buttonBVII3.Enabled = false;
            buttonBVII4.Enabled = false;
            buttonBVII5.Enabled = false;
            buttonBVII6.Enabled = false;
            buttonBVII7.Enabled = false;
            buttonBVII8.Enabled = false;
            buttonBVII9.Enabled = false;
            buttonBVII10.Enabled = false;
            buttonBVII11.Enabled = false;
            buttonBVII12.Enabled = false;
            buttonBVII13.Enabled = false;
        }

        private void EnableSeatButtons()
        {
            //parter
            buttonI1.Enabled = true;
            buttonI2.Enabled = true;
            buttonI3.Enabled = true;
            buttonI4.Enabled = true;
            buttonI5.Enabled = true;
            buttonI6.Enabled = true;
            buttonI7.Enabled = true;
            buttonI8.Enabled = true;
            buttonI9.Enabled = true;
            buttonI10.Enabled = true;

            buttonII1.Enabled = true;
            buttonII2.Enabled = true;
            buttonII3.Enabled = true;
            buttonII4.Enabled = true;
            buttonII5.Enabled = true;
            buttonII6.Enabled = true;
            buttonII7.Enabled = true;
            buttonII8.Enabled = true;
            buttonII9.Enabled = true;
            buttonII10.Enabled = true;
            buttonII11.Enabled = true;

            buttonIII1.Enabled = true;
            buttonIII2.Enabled = true;
            buttonIII3.Enabled = true;
            buttonIII4.Enabled = true;
            buttonIII5.Enabled = true;
            buttonIII6.Enabled = true;
            buttonIII7.Enabled = true;
            buttonIII8.Enabled = true;
            buttonIII9.Enabled = true;
            buttonIII10.Enabled = true;

            buttonIV1.Enabled = true;
            buttonIV2.Enabled = true;
            buttonIV3.Enabled = true;
            buttonIV4.Enabled = true;
            buttonIV5.Enabled = true;
            buttonIV6.Enabled = true;
            buttonIV7.Enabled = true;
            buttonIV8.Enabled = true;
            buttonIV9.Enabled = true;
            buttonIV10.Enabled = true;
            buttonIV11.Enabled = true;

            buttonV1.Enabled = true;
            buttonV2.Enabled = true;
            buttonV3.Enabled = true;
            buttonV4.Enabled = true;
            buttonV5.Enabled = true;
            buttonV6.Enabled = true;
            buttonV7.Enabled = true;
            buttonV8.Enabled = true;
            buttonV9.Enabled = true;
            buttonV10.Enabled = true;

            buttonVI1.Enabled = true;
            buttonVI2.Enabled = true;
            buttonVI3.Enabled = true;
            buttonVI4.Enabled = true;
            buttonVI5.Enabled = true;
            buttonVI6.Enabled = true;
            buttonVI7.Enabled = true;
            buttonVI8.Enabled = true;
            buttonVI9.Enabled = true;
            buttonVI10.Enabled = true;
            buttonVI11.Enabled = true;

            buttonVII1.Enabled = true;
            buttonVII2.Enabled = true;
            buttonVII3.Enabled = true;
            buttonVII4.Enabled = true;
            buttonVII5.Enabled = true;
            buttonVII6.Enabled = true;
            buttonVII7.Enabled = true;
            buttonVII8.Enabled = true;
            buttonVII9.Enabled = true;
            buttonVII10.Enabled = true;

            buttonVIII1.Enabled = true;
            buttonVIII2.Enabled = true;
            buttonVIII3.Enabled = true;
            buttonVIII4.Enabled = true;
            buttonVIII5.Enabled = true;
            buttonVIII6.Enabled = true;
            buttonVIII7.Enabled = true;
            buttonVIII8.Enabled = true;
            buttonVIII9.Enabled = true;
            buttonVIII10.Enabled = true;
            buttonVIII11.Enabled = true;

            buttonIX1.Enabled = true;
            buttonIX2.Enabled = true;
            buttonIX3.Enabled = true;
            buttonIX4.Enabled = true;
            buttonIX5.Enabled = true;
            buttonIX6.Enabled = true;
            buttonIX7.Enabled = true;
            buttonIX8.Enabled = true;
            buttonIX9.Enabled = true;
            buttonIX10.Enabled = true;

            //balkon

            buttonBI1.Enabled = true;
            buttonBI2.Enabled = true;
            buttonBI3.Enabled = true;
            buttonBI4.Enabled = true;
            buttonBI5.Enabled = true;
            buttonBI6.Enabled = true;
            buttonBI7.Enabled = true;

            buttonBII1.Enabled = true;
            buttonBII2.Enabled = true;
            buttonBII3.Enabled = true;
            buttonBII4.Enabled = true;
            buttonBII5.Enabled = true;
            buttonBII6.Enabled = true;
            buttonBII7.Enabled = true;
            buttonBII8.Enabled = true;

            buttonBIII1.Enabled = true;
            buttonBIII2.Enabled = true;
            buttonBIII3.Enabled = true;
            buttonBIII4.Enabled = true;
            buttonBIII5.Enabled = true;
            buttonBIII6.Enabled = true;
            buttonBIII7.Enabled = true;
            buttonBIII8.Enabled = true;
            buttonBIII9.Enabled = true;

            buttonBIV1.Enabled = true;
            buttonBIV2.Enabled = true;
            buttonBIV3.Enabled = true;
            buttonBIV4.Enabled = true;
            buttonBIV5.Enabled = true;
            buttonBIV6.Enabled = true;
            buttonBIV7.Enabled = true;
            buttonBIV8.Enabled = true;
            buttonBIV9.Enabled = true;
            buttonBIV10.Enabled = true;

            buttonBV1.Enabled = true;
            buttonBV2.Enabled = true;
            buttonBV3.Enabled = true;
            buttonBV4.Enabled = true;
            buttonBV5.Enabled = true;
            buttonBV6.Enabled = true;
            buttonBV7.Enabled = true;
            buttonBV8.Enabled = true;
            buttonBV9.Enabled = true;
            buttonBV10.Enabled = true;
            buttonBV11.Enabled = true;

            buttonBVI1.Enabled = true;
            buttonBVI2.Enabled = true;
            buttonBVI3.Enabled = true;
            buttonBVI4.Enabled = true;
            buttonBVI5.Enabled = true;
            buttonBVI6.Enabled = true;
            buttonBVI7.Enabled = true;
            buttonBVI8.Enabled = true;
            buttonBVI9.Enabled = true;
            buttonBVI10.Enabled = true;
            buttonBVI11.Enabled = true;
            buttonBVI12.Enabled = true;

            buttonBVII1.Enabled = true;
            buttonBVII2.Enabled = true;
            buttonBVII3.Enabled = true;
            buttonBVII4.Enabled = true;
            buttonBVII5.Enabled = true;
            buttonBVII6.Enabled = true;
            buttonBVII7.Enabled = true;
            buttonBVII8.Enabled = true;
            buttonBVII9.Enabled = true;
            buttonBVII10.Enabled = true;
            buttonBVII11.Enabled = true;
            buttonBVII12.Enabled = true;
            buttonBVII13.Enabled = true;
        }

        private void HideSellingItems()
        {
            rowLabel.Hide();
            loadRowLabel.Hide();
            seatLabel.Hide();
            loadSeatLabel.Hide();
            hallLabel.Hide();
            loadHallLabel.Hide();
            statusLabel.Hide();
            loadStatusLabel.Hide();
            sellTicketButton.Hide();
        }

        private void ShowSellingItems()
        {
            rowLabel.Show();
            loadRowLabel.Show();
            seatLabel.Show();
            loadSeatLabel.Show();
            hallLabel.Show();
            loadHallLabel.Show();
            statusLabel.Show();
            loadStatusLabel.Show();
            sellTicketButton.Show();
        }

        private void HideItems()
        {
            selectDateLabel.Hide();
            selectDateComboBox.Hide();
            selectTimeLabel.Hide();
            selectTimeComboBox.Hide();
            selectMovieButton.Hide();
            removeSelectionButton.Hide();
        }

        private void ShowItems()
        {
            selectDateLabel.Show();
            selectDateComboBox.Show();
            selectTimeLabel.Show();
            selectTimeComboBox.Show();
            selectMovieButton.Show();
            removeSelectionButton.Show();
        }

        private void SetSeatDetails(string _red, int _sjediste, string _prostorija, string _status)
        {
            red = _red;
            sjediste = _sjediste;
            prostorija = _prostorija;
            status = _status;
        }

        private void SetLabelText()
        {
            loadRowLabel.Text = red;
            loadSeatLabel.Text = sjediste.ToString();
            loadHallLabel.Text = prostorija;
            loadStatusLabel.Text = status;
        }

        private void RadnikForm_Load(object sender, EventArgs e)
        {
            this.pROJEKCIJETableAdapter1.Fill(this.bIOSKOPDataSet3.PROJEKCIJE);
            selectMovieComboBox.SelectedIndex = -1;
        }

        private void GetDates()
        {
            int filmID;
            string izabranaProjekcija = selectMovieComboBox.Text;

            using (var db = new BIOSKOPEntities())
            {
                FILMOVI film = new FILMOVI();
                film = db.FILMOVIs.Where(f => f.naslov == izabranaProjekcija).FirstOrDefault();

                filmID = film.film_id;
            }

            using (var db = new BIOSKOPEntities())
            {
                PRIKAZIVANJA projekcija = new PRIKAZIVANJA();
                projekcija = db.PRIKAZIVANJAs.Where(p => p.id_filma == filmID && p.status_prikazivanja == 1).FirstOrDefault();

                startDate = projekcija.pocetak_prikazivanja;
                endDate = projekcija.kraj_prikazivanja;
            }
        }

        private void SetSeatStatus(string row, int seat, string hall, string date, string time)
        {
            int filmID, projekcijaID;
            string izabranaProjekcija = selectMovieComboBox.Text;

            using (var db = new BIOSKOPEntities())
            {
                FILMOVI film = new FILMOVI();
                film = db.FILMOVIs.Where(f => f.naslov == izabranaProjekcija).FirstOrDefault();

                filmID = film.film_id;
            }
            
            using (var db = new BIOSKOPEntities())
            {
                PRIKAZIVANJA projekcija = new PRIKAZIVANJA();
                projekcija = db.PRIKAZIVANJAs.Where(p => p.id_filma == filmID).FirstOrDefault();

                projekcijaID = projekcija.prikazivanje_id;
            }

            using (var db = new BIOSKOPEntities())
            {
                PRODATE_KARTE karte = new PRODATE_KARTE();
                seatStatus = db.PRODATE_KARTE.Where(pk => pk.id_prikazivanja == projekcijaID && pk.broj_reda == row &&
                pk.broj_sjedista == seat && pk.prostorija == hall && pk.datum == date && pk.termin == time).Count();
            }
        }

        private void CheckSeatStatus()
        {
            if (seatStatus == 0)
            {
                status = "slobodno";
            }
            else
                status = "zauzeto";
        }
    }
}
