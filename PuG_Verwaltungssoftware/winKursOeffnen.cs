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
    public partial class winKursOeffnen : Form
    {
        bool editMode = false;
        bool save = false;

        public winKursOeffnen()
        {
            InitializeComponent();
            
            // DateTimePicker unsichtbar machen
            //dtpDatum.Visible = false;

        }

        private void btSchliessen_Click(object sender, EventArgs e)
        {
            // Fenster schliessen
            if (editMode == true)
            {
                // MessageBox schliessen ohne speichern
                // ######## unvollständig ##########
                DialogResult dialogResult = MessageBox.Show("Wollen Sie das Fenster ohne zu Speichern schließen?", "Information", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    this.Close();
                }
                else
                {

                }
            }
            else
            {
                this.Close();
            }
            
        }

        private void btBearbeiten_Click(object sender, EventArgs e)
        {
            // Globale Variable true setzen
            editMode = true;
            
            // Textboxen readOnly --> false
            foreach (Control c in this.Controls)
            {
                if (c.GetType() == typeof(TextBox))
                {
                    ((TextBox)c).ReadOnly = false;
                };
            }

            // Textbox Datum visible false und datepicker visible true und Position setzen
            int xVal = tbPreis.Location.X;
            int yVal = tbPreis.Location.Y;

            //dtpDatum.Visible = true;
            tbPreis.Visible = false;
            //dtpDatum.Location.X = xVal;
            //dtpDatum.Location.Y = yVal;
        }

        private void btSpeichern_Click(object sender, EventArgs e)
        {
            // Globale Variable true setzen
            save = true;
        }
    }
}
