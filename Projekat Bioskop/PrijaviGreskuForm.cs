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
    public partial class PrijaviGreskuForm : Form
    {
        public PrijaviGreskuForm()
        {
            InitializeComponent();
        }
        
        private void sendReportButton_Click(object sender, EventArgs e)
        {
            if (noteRichTextBox.Text == "")
            {
                MessageBox.Show("Polje za grešku ne smije biti prazno.", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (noteRichTextBox.Text.Length > 128)
            {
                MessageBox.Show("Maksimalan broj karaktera za opis greške je 128.", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                using (var db = new BIOSKOPEntities())
                {
                    GREŠKE novaGreska = new GREŠKE()
                    {
                        opis_greske = noteRichTextBox.Text.ToString()
                    };
                    db.GREŠKE.Add(novaGreska);
                    db.SaveChanges();
                }

                MessageBox.Show("Izvještaj poslat.", "Obavještenje", MessageBoxButtons.OK, MessageBoxIcon.Information);

                noteRichTextBox.Text = "";
            }
        }

        private void deleteTextButton_Click(object sender, EventArgs e)
        {
            noteRichTextBox.Text = "";
        }
    }
}
