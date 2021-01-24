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
    public partial class PrijavaForm : Form
    {
        BIOSKOPEntities bioskop = new BIOSKOPEntities();

        public PrijavaForm()
        {
            InitializeComponent();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (AreLoginFieldsValid())
                {
                    int flag = 0;
                    string tipKorisnika = "";

                    foreach (var korisnik in bioskop.KORISNICIs)
                    {
                        if (korisnik.korisnickoIme == usernameTextBox.Text.ToString() && korisnik.lozinka == passwordTextBox.Text.ToString())
                        {
                            flag = 1;
                            tipKorisnika = korisnik.tip;
                        }
                    }

                    if (flag == 0)
                    {
                        MessageBox.Show("Korisničko ime i/ili lozinka nisu ispravni.", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        usernameTextBox.Focus();
                        passwordTextBox.Text = "";
                    }
                    else if (flag == 1 && tipKorisnika == "Administrator")
                    {
                        AdminForm admin = new AdminForm();
                        this.Hide();
                        admin.Show();

                        admin.FormClosed += AdminForm_FormClosed;

                        IsprazniLoginPolja();
                    }
                    else if (flag == 1 && tipKorisnika == "Radnik")
                    {
                        RadnikForm radnik = new RadnikForm();
                        this.Hide();
                        radnik.Show();

                        radnik.FormClosed += RadnikForm_FormClosed;

                        IsprazniLoginPolja();
                    }
                }
            }
            catch
            {
                MessageBox.Show("Uneseni podaci nisu ispravni.", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //validacija korisnika

        private bool AreLoginFieldsValid()
        {
            if (usernameTextBox.Text == "" || passwordTextBox.Text == "")
            {
                MessageBox.Show("Sva polja moraju biti popunjena.", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            else
                return true;
        }
        
        public void AdminForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Show();
        }

        public void RadnikForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Show();
        }

        public void IsprazniLoginPolja()
        {
            usernameTextBox.Text = "";
            passwordTextBox.Text = "";
        }
    }
}
