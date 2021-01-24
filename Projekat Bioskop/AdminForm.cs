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
    public partial class AdminForm : Form
    {
        GREŠKE model = new GREŠKE();
        
        public AdminForm()
        {
            InitializeComponent();
            loadReportIDLabel.Hide();

            SetDates();
        }

        //dodavanje filma

        private void addMovieButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (AreMovieFieldsValid())
                {
                    using (var db = new BIOSKOPEntities())
                    {
                        FILMOVI noviFilm = new FILMOVI()
                        {
                            naslov = titleTextBox.Text.ToString(),
                            zanr = genreComboBox.SelectedItem.ToString(),
                            godina_izdanja = Int16.Parse(yearTextBox.Text.ToString()),
                            trajanje = Int16.Parse(runningTimeTextBox.Text.ToString()),
                            rezija = directorTextBox.Text.ToString(),
                            scenario = screenPlayTextBox.Text.ToString(),
                            producent = producerTextBox.Text.ToString(),
                            zemlja = countryTextBox.Text.ToString(),
                            jezik = languageTextBox.Text.ToString()
                        };

                        db.FILMOVIs.Add(noviFilm);
                        db.SaveChanges();

                        RefreshComboBox();

                        MessageBox.Show("Uspješno ste dodali film.", "Obavještenje", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        EmptyMovieFields();
                    }
                }
            }
            catch
            {
                MessageBox.Show("Uneseni podaci nisu ispravni.", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //validacija filma

        private bool AreMovieFieldsValid()
        {
            if (titleTextBox.Text == "" || genreComboBox.Text == "" || yearTextBox.Text == "" || runningTimeTextBox.Text == ""
                || directorTextBox.Text == "" || screenPlayTextBox.Text == "" || producerTextBox.Text == "" || countryTextBox.Text == ""
                || languageTextBox.Text == "")
            {
                MessageBox.Show("Sva polja moraju biti popunjena.", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            else if (!IsTitleValid())
            {
                titleTextBox.Focus();
                return false;
            }
            else if (!IsGenreValid())
            {
                genreComboBox.Focus();
                return false;
            }
            else if (!IsYearValid())
            {
                yearTextBox.Focus();
                return false;
            }
            else if (!IsRunningTimeValid())
            {
                runningTimeTextBox.Focus();
                return false;
            }
            else if (!IsDirectorValid())
            {
                directorTextBox.Focus();
                return false;
            }
            else if (!IsScreenPlayValid())
            {
                screenPlayTextBox.Focus();
                return false;
            }
            else if (!IsProducerValid())
            {
                producerTextBox.Focus();
                return false;
            }
            else if (!IsCountryValid())
            {
                countryTextBox.Focus();
                return false;
            }
            else if (!IsLanguageValid())
            {
                languageTextBox.Focus();
                return false;
            }
            else
                return true;
        }

        private bool IsTitleValid()
        {
            if (titleTextBox.Text.Length > 128)
            {
                MessageBox.Show("Naslov filma ne smije biti duži od 128 karaktera.", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            else
                return true;
        }

        private bool IsGenreValid()
        {
            if (genreComboBox.SelectedIndex == -1)
            {
                MessageBox.Show("Žanr filma mora biti jedan od ponuđenih.", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            else
                return true;
        }

        private bool IsYearValid()
        {
            int year;
            Int32.TryParse(yearTextBox.Text, out year);

            if (year < 1886 || year > 2019)
            {
                MessageBox.Show("Godina izdanja filma nije ispravna.", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            else
                return true;
        }

        private bool IsRunningTimeValid()
        {
            int time;
            Int32.TryParse(runningTimeTextBox.Text, out time);

            if (time < 80 || time > 180)
            {
                MessageBox.Show("Trajanje filma mora da bude između 80 i 180 minuta.", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            else
                return true;
        }

        private bool IsDirectorValid()
        {
            if (directorTextBox.Text.Length > 128)
            {
                MessageBox.Show("Režija filma ne smije biti duža od 128 karaktera.", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            else
                return true;
        }

        private bool IsScreenPlayValid()
        {
            if (screenPlayTextBox.Text.Length > 128)
            {
                MessageBox.Show("Scenario filma ne smije biti duži od 128 karaktera.", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            else
                return true;
        }

        private bool IsProducerValid()
        {
            if (producerTextBox.Text.Length > 128)
            {
                MessageBox.Show("Producent filma ne smije biti duži od 128 karaktera.", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            else
                return true;
        }

        private bool IsCountryValid()
        {
            if (countryTextBox.Text.Length > 32)
            {
                MessageBox.Show("Zemlja filma ne smije biti duža od 32 karaktera.", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            else
                return true;
        }

        private bool IsLanguageValid()
        {
            if (languageTextBox.Text.Length > 32)
            {
                MessageBox.Show("Jezik filma ne smije biti duži od 32 karaktera.", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            else
                return true;
        }

        //prikazivanja

        private void startButton_Click(object sender, EventArgs e)
        {
            int movieID;

            try
            {
                if (AreShowingsFieldsValid())
                {
                    DateTime startDate = DateTime.Parse(startOfShowingsDateTimePicker.Text);
                    DateTime endDate = DateTime.Parse(endOfShowingsDateTimePicker.Text);

                    string izabraniFilm = selectMovieComboBox.Text;

                    using (var db = new BIOSKOPEntities())
                    {
                        FILMOVI film = new FILMOVI();
                        film = db.FILMOVIs.Where(f => f.naslov == izabraniFilm).FirstOrDefault();

                        movieID = film.film_id;
                    }

                    using (var db = new BIOSKOPEntities())
                    {
                        PRIKAZIVANJA prikazivanje = new PRIKAZIVANJA()
                        {
                            id_filma = movieID,
                            pocetak_prikazivanja = startDate,
                            kraj_prikazivanja = endDate,
                            status_prikazivanja = 1
                        };

                        db.PRIKAZIVANJAs.Add(prikazivanje);
                        db.SaveChanges();

                        MessageBox.Show("Uspješno ste zakazali prikazivanje.", "Obavještenje", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        EmptyShowingsFields();
                    }
                }
            }
            catch
            {
                MessageBox.Show("Uneseni podaci nisu ispravni.", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                selectMovieComboBox.Text = "";
                selectMovieComboBox.Focus();
            }
        }

        private void endButton_Click(object sender, EventArgs e)
        {
            OtkaziProjekcijuForm otkaziProjekciju = new OtkaziProjekcijuForm();

            otkaziProjekciju.ShowDialog();
        }
        
        //validacija prikazivanja

        private bool AreShowingsFieldsValid()
        {
            if (selectMovieComboBox.SelectedIndex == -1)
            {
                MessageBox.Show("Morate izabrati film.", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            else if (!IsEndDateValid())
            {
                MessageBox.Show("Datum završetka nije ispravan.", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else
                return true;
        }
        
        private bool IsEndDateValid()
        {
            if (endOfShowingsDateTimePicker.Value <= startOfShowingsDateTimePicker.Value)
                return false;
            else
                return true;
        }

        //dodavanje korisnika 

        private void addUserButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (AreUserFieldsValid())
                {
                    if (passwordTextBox.Text != repeatPasswordTextBox.Text)
                    {
                        MessageBox.Show("Lozinke se ne poklapaju.", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        repeatPasswordTextBox.Text = "";
                        repeatPasswordTextBox.Focus();
                    }
                    else
                    {
                        using (var db = new BIOSKOPEntities())
                        {
                            KORISNICI noviKorisnik = new KORISNICI()
                            {
                                korisnickoIme = usernameTextBox.Text.ToString(),
                                lozinka = passwordTextBox.Text.ToString(),
                                tip = "Radnik"
                            };
                            db.KORISNICIs.Add(noviKorisnik);
                            db.SaveChanges();

                            MessageBox.Show("Uspješno ste registrovali korisnika.", "Registracija", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            EmptyUserFields();
                        }
                    }
                }
            }
            catch
            {
                MessageBox.Show("Uneseni podaci nisu ispravni.", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        //validacija korisnika

        private bool AreUserFieldsValid()
        {
            if (usernameTextBox.Text == "" || passwordTextBox.Text == "" || repeatPasswordTextBox.Text == "")
            {
                MessageBox.Show("Sva polja moraju biti popunjena.", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            else if (!IsUserValid())
            {
                usernameTextBox.Focus();
                return false;
            }
            else if (!IsPasswordValid())
            {
                passwordTextBox.Focus();
                return false;
            }
            else
                return true;
        }

        private bool IsUserValid()
        {
            if (usernameTextBox.Text.Length > 20)
            {
                MessageBox.Show("Korisničko ime ne smije biti duže od 20 karaktera.", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            else
                return true;
        }

        private bool IsPasswordValid()
        {
            if (passwordTextBox.Text.Length < 6 || passwordTextBox.Text.Length > 20)
            {
                MessageBox.Show("Lozinka mora sadržati bar 6 karaktera, a ne smije biti duža od 20 karaktera.", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            else
                return true;
        }

        //dodavanje radnika 

        private void addWorkerButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (AreWorkerFieldsValid())
                {
                    DateTime dateOfBirth = dateOfBirthDateTimePicker.Value.Date;
                    DateTime startWork = workStartDateTimePicker.Value.Date;

                    int userID;

                    using (var db = new BIOSKOPEntities())
                    {
                        KORISNICI korisnik = new KORISNICI();
                        korisnik = db.KORISNICIs.Where(k => k.korisnickoIme == workerUsernameTextBox.Text).FirstOrDefault();

                        userID = korisnik.korisnik_id;
                    }

                    using (var db = new BIOSKOPEntities())
                    {
                        RADNICI noviRadnik = new RADNICI()
                        {
                            ime = firstNameTextBox.Text.ToString(),
                            prezime = lastNameTextBox.Text.ToString(),
                            datum_rodjenja = dateOfBirth,
                            adresa = addressTextBox.Text.ToString(),
                            telefon = telephoneTextBox.Text.ToString(),
                            datum_zaposlenja = startWork,
                            kraj_zaposlenja = null,
                            id_korisnika = userID
                        };
                        db.RADNICIs.Add(noviRadnik);
                        db.SaveChanges();

                        MessageBox.Show("Uspješno ste dodali radnika.", "Obavještenje", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        EmptyWorkerFields();
                    }
                }
            }
            catch
            {
                MessageBox.Show("Uneseni podaci nisu ispravni.", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void fireWorkerButton_Click(object sender, EventArgs e)
        {
            OtpustiRadnikaForm otpustiRadnika = new OtpustiRadnikaForm();

            otpustiRadnika.ShowDialog();
        }

        //validacija radnika

        private bool AreWorkerFieldsValid()
        {
            if (firstNameTextBox.Text == "" || lastNameTextBox.Text == "" || addressTextBox.Text == "" || telephoneTextBox.Text == ""
                || workerUsernameTextBox.Text == "")
            {
                MessageBox.Show("Sva polja moraju biti popunjena.", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            else if (!IsFirstNameValid())
            {
                firstNameTextBox.Focus();
                return false;
            }
            else if (!IsLastNameValid())
            {
                lastNameTextBox.Focus();
                return false;
            }
            else if (!IsAddressValid())
            {
                addressTextBox.Focus();
                return false;
            }
            else if (!IsTelephoneValid())
            {
                telephoneTextBox.Focus();
                return false;
            }
            else if (!IsWorkerUsernameValid())
            {
                workerUsernameTextBox.Focus();
                return false;
            }
            else
                return true;
        }

        private bool IsFirstNameValid()
        {
            if (firstNameTextBox.Text.Length > 32)
            {
                MessageBox.Show("Ime radnika ne smije biti duže od 32 karaktera.", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            else
                return true;
        }

        private bool IsLastNameValid()
        {
            if (lastNameTextBox.Text.Length > 32)
            {
                MessageBox.Show("Prezime radnika ne smije biti duže od 32 karaktera.", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            else
                return true;
        }

        private bool IsAddressValid()
        {
            if (addressTextBox.Text.Length > 64)
            {
                MessageBox.Show("Adresa ne smije biti duža od 64 karaktera.", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            else
                return true;
        }

        private bool IsTelephoneValid()
        {
            if (telephoneTextBox.Text.Length > 16)
            {
                MessageBox.Show("Broj telefona ne smije biti duži od 16 karaktera.", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            else
                return true;
        }

        private bool IsWorkerUsernameValid()
        {
            if (firstNameTextBox.Text.Length > 32)
            {
                MessageBox.Show("Korisničko ime radnika ne smije biti duže od 20 karaktera.", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            else
                return true;
        }

        //brisanje greske 

        private void deleteReportButton_Click(object sender, EventArgs e)
        {
            try
            {
                using (var db = new BIOSKOPEntities())
                {
                    GREŠKE izbrisiGresku = new GREŠKE();

                    int id_greske = Int32.Parse(loadReportIDLabel.Text.ToString());
                    izbrisiGresku = db.GREŠKE.Where(k => k.greska_id == id_greske).FirstOrDefault();
                    db.GREŠKE.Remove(izbrisiGresku);
                    db.SaveChanges();
                }

                loadReportIDLabel.Text = "";
                loadReportIDLabel.Hide();
                RefreshDataGrid();
            }
            catch
            {
                MessageBox.Show("Morate odbrati grešku.", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }          
        }
        
        private void reportsDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (reportsDataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {  
                    loadReportIDLabel.Text = reportsDataGridView.Rows[e.RowIndex].Cells[0].Value.ToString();
                    loadReportIDLabel.Show();
                }
            }
            catch
            {
                throw new Exception();
            }
        }
        
        //učitavanje iz baze

        private void AdminForm_Load(object sender, EventArgs e)
        {
            this.fILMOVITableAdapter.Fill(this.bIOSKOPDataSet.FILMOVI);
            selectMovieComboBox.SelectedIndex = -1;

            reportsDataGridView.AutoGenerateColumns = false;
            using (BIOSKOPEntities db = new BIOSKOPEntities())
            {
                reportsDataGridView.DataSource = db.GREŠKE.ToList<GREŠKE>();
            }

            reportsDataGridView.Columns[0].Width = 101;
            reportsDataGridView.Columns[1].Width = 352;
        }

        private void RefreshDataGrid()
        {
            reportsDataGridView.AutoGenerateColumns = false;
            using (BIOSKOPEntities db = new BIOSKOPEntities())
            {
                reportsDataGridView.DataSource = db.GREŠKE.ToList<GREŠKE>();
            }
        }

        //ostale metode

        private void EmptyMovieFields()
        {
            titleTextBox.Text = "";
            titleTextBox.Focus();
            genreComboBox.SelectedIndex = -1;
            yearTextBox.Text = "";
            runningTimeTextBox.Text = "";
            directorTextBox.Text = "";
            screenPlayTextBox.Text = "";
            producerTextBox.Text = "";
            countryTextBox.Text = "";
            languageTextBox.Text = "";
        }

        private void EmptyUserFields()
        {
            usernameTextBox.Text = "";
            usernameTextBox.Focus();
            passwordTextBox.Text = "";
            repeatPasswordTextBox.Text = "";
        }

        private void EmptyWorkerFields()
        {
            firstNameTextBox.Text = "";
            firstNameTextBox.Focus();
            lastNameTextBox.Text = "";
            dateOfBirthDateTimePicker.ResetText();
            addressTextBox.Text = "";
            telephoneTextBox.Text = "";
            workStartDateTimePicker.ResetText();
            workerUsernameTextBox.Text = "";
        }

        private void EmptyShowingsFields()
        {
            selectMovieComboBox.Text = "";
            selectMovieComboBox.Focus();
            startOfShowingsDateTimePicker.ResetText();
            endOfShowingsDateTimePicker.ResetText();
        }
        
        private void SetDates()
        {
            DateTime today = DateTime.Now;
            
            //dodavanje radnika

            workStartDateTimePicker.MaxDate = today;
            workStartDateTimePicker.Value = today;

            //prikazivanja
            
            DateTime startDateMin = today.AddDays(3);

            startOfShowingsDateTimePicker.Value = startDateMin.Date;
            startOfShowingsDateTimePicker.MinDate = startDateMin.Date;
            
            DateTime endDateMin = startDateMin.AddDays(1);

            endOfShowingsDateTimePicker.Value = endDateMin.Date;
            endOfShowingsDateTimePicker.MinDate = endDateMin.Date;
        }

        private void RefreshComboBox()
        {
            this.fILMOVITableAdapter.Fill(this.bIOSKOPDataSet.FILMOVI);
            selectMovieComboBox.SelectedIndex = -1;
            selectMovieComboBox.Focus();
        }
    }
}
