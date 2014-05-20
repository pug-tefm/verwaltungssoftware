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
    public partial class LogInWindow : Form
    {
        public LogInWindow()
        {
            InitializeComponent();
        }

        private void btSchliessen_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btAnmelden_Click(object sender, EventArgs e)
        {
            // Anmeldedaten pruefen


            // Fenster schließen und Hauptfenster oeffnen
            this.Hide();
            mainWindow window = new mainWindow();
            window.Show();
        }
    }
}
