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
    public partial class ProdajaForm : Form
    {
        public ProdajaForm()
        {
            InitializeComponent();
            LoadTicket();
        }

        public void LoadTicket()
        {
            movieTitleLabel.Text = RadnikForm.naslovFilma;
            loadDateLabel.Text = RadnikForm.datumPrikazivanja;
            loadTimeLabel.Text = RadnikForm.terminPrikazivanja;
            loadRowLabel.Text = RadnikForm.red;
            loadSeatLabel.Text = RadnikForm.sjediste.ToString();
            loadHallLabel.Text = RadnikForm.prostorija;
        }
    }
}
