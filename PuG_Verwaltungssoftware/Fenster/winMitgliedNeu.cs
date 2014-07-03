using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PuG_Verwaltungssoftware
{
    public partial class winMitgliedNeu : Form
    {

        public winMitgliedNeu()
        {
            InitializeComponent();

        }

        private void btSchliessen_Click(object sender, EventArgs e)
        {
            // Fenster schliessen
            if (tbVorname.Text.Trim().Length != 0 || tbNachname.Text.Trim().Length != 0 || tbStrasse.Text.Trim().Length != 0 || tbHausnummer.Text.Trim().Length != 0
                || tbOrt.Text.Trim().Length != 0 || tbPlz.Text.Trim().Length != 0 || tbVertragsdatum.Text.Trim().Length != 0 || tbKommentar.Text.Trim().Length != 0)
            {
                DialogResult dialogResult = MessageBox.Show("Wollen Sie das Fenster ohne zu Speichern schließen?", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (dialogResult == DialogResult.Yes)
                {
                    this.Close();
                }
            }
            else
            {
                this.Close();
            }
        }

    }
}
