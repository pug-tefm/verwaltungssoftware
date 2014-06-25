using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PuG_Verwaltungssoftware.Klassen;

namespace PuG_Verwaltungssoftware
{
    public partial class mainWindow : Form
    {
        private void tabPageMitarbeiter_Enter(object sender, EventArgs e)
        {
            int dBConnectOk = c.openConnection();  // Datenbank oeffnen

            if (loginMaPosId == 1)
            {
                // Mitarbeiter ist admin (chef)
                c.displayData("SELECT mitarbeiter_id, vorname, nachname, geburtsdatum FROM mitarbeiter;", gridMitarbeiter);
            }
            else
            {
                // Mitarbeiter ist "normaler" Benutzer
                c.displayData("SELECT mitarbeiter_id, vorname, nachname, geburtsdatum FROM mitarbeiter WHERE mitarbeiter_id = '" + loginMaId + "';", gridMitarbeiter);
                btMaLoeschen.Enabled = false;
                btMaNeu.Enabled = false;
                ddlMitarbeiterSuchen.Enabled = false;
                tbMitarbeiterSuchen.Enabled = false;
            }
            c.closeConnection(); // Datenbank schliessen

            if (dBConnectOk == 0)
            {
                // Headertexte anpassen
                gridMitarbeiter.Columns["mitarbeiter_id"].HeaderText = "Mitarbeiter-Nr.";
                gridMitarbeiter.Columns["vorname"].HeaderText = "Vorname";
                gridMitarbeiter.Columns["nachname"].HeaderText = "Nachname";
                gridMitarbeiter.Columns["geburtsdatum"].HeaderText = "Geburtsdatum";
            }

            if (gridMitarbeiter.ColumnCount > 0)
            {
                for (int i = 0; i < gridMitarbeiter.ColumnCount; i++)
                {
                    ddlMitarbeiterSuchen.Items.Add(gridMitarbeiter.Columns[i].HeaderText);
                }
                ddlMitarbeiterSuchen.SelectedIndex = 0;
            }

            // Binding Objekt zuweisen
            //bindingSource.DataSource = (DataTable)gridMitarbeiter.DataSource;
            //gridMitarbeiter.DataSource = bindingSource;
        }


        private void gridMitarbeiter_SelectionChanged(object sender, EventArgs e)
        {
            int row = gridMitarbeiter.CurrentCell.RowIndex;
            int id = Convert.ToInt32(gridMitarbeiter.Rows[row].Cells["mitarbeiter_id"].Value);
            //MessageBox.Show(id.ToString());
        }


        private void btMaOeffnen_Click(object sender, EventArgs e)
        {
            if (gridMitarbeiter.RowCount > 0)
            {
                int row = gridMitarbeiter.CurrentCell.RowIndex;
                int id = Convert.ToInt32(gridMitarbeiter.Rows[row].Cells["mitarbeiter_id"].Value);
                winMitarbeiterOeffnen window = new winMitarbeiterOeffnen(id, gridMitarbeiter);
                window.Show();
            }
            else
            {
                MessageBox.Show("Sie müssen zuvor eine Zeile oder mehrere Zeilen auswählen.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }


        private void btMaLoeschen_Click(object sender, EventArgs e)
        {

            if (gridMitarbeiter.CurrentCell != null) // Wenn eine Zelle ausgewählt
            {
                foreach (DataGridViewRow row in gridMitarbeiter.SelectedRows) // Wegen Multiselect
                {
                    int id = Convert.ToInt32(gridMitarbeiter.Rows[row.Index].Cells["mitarbeiter_id"].Value);
                    if (id == loginMaId)
                    {
                        DialogResult dialogResultSelf = MessageBox.Show("Sie können sich nicht selbst löschen.", "Information", MessageBoxButtons.OK);
                        return;
                    }
                    DialogResult dialogResult = MessageBox.Show("Wollen Sie den ausgewählten Mitarbeiter mit der Mitarbeiter-Nr. '" + id + "' wirklich löschen?", "Information", MessageBoxButtons.YesNo);

                    if (dialogResult == DialogResult.Yes)
                    {
                        c.openConnection();
                        gridMitarbeiter.Rows.RemoveAt(row.Index); // Row löschen
                        c.delete("DELETE FROM mitarbeiter WHERE mitarbeiter_id = '" + id + "';", "Mitarbeiter");
                        c.closeConnection();
                    }
                }
            }
            else
            {
                DialogResult dialogResult = MessageBox.Show("Sie müssen zuvor eine Zeile oder mehrere Zeilen auswählen.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }


        private void btMaNeu_Click(object sender, EventArgs e)
        {
            winMitarbeiterNeu window = new winMitarbeiterNeu();
            window.Show();
        }


        private void ddlMitarbeiterSuchen_SelectedIndexChanged(object sender, EventArgs e)
        {
            c_Helper c = new c_Helper();
            c.comboBoxSuchenSelectedIndexChanged(gridMitarbeiter, ddlMitarbeiterSuchen, tbMitarbeiterSuchen, bindingSource);
        }


        private void tbMitarbeiterSuchen_TextChanged(object sender, EventArgs e)
        {
            c_Helper c = new c_Helper();
            c.textBoxSuchenTextChanged(gridMitarbeiter, ddlMitarbeiterSuchen, tbMitarbeiterSuchen, bindingSource);
        }


        private void gridMitarbeiter_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right) // Rechtsklick
            {
                // ContextMenuStrip mit ToolStipMenuItem erzeugen
                ContextMenuStrip myContextMenu = new ContextMenuStrip();
                ToolStripMenuItem toolStripItemOne = new ToolStripMenuItem("Aktualisieren");

                // Items hinzufügen
                myContextMenu.Items.Add(toolStripItemOne);

                // Handler der Items
                toolStripItemOne.Click += new EventHandler(toolStripItemOneMitarbeiter_Click);

                int currentMouseOverRow = gridMitarbeiter.HitTest(e.X, e.Y).RowIndex;

                if (currentMouseOverRow >= 0) // In der Tabelle
                {
                    // Nix
                }

                myContextMenu.Show(gridMitarbeiter, new Point(e.X, e.Y));
            }
        }

        private void toolStripItemOneMitarbeiter_Click(object sender, EventArgs args)
        {
            int dbConnect = c.openConnection();
            if (dbConnect == 0)
            {
                c.displayData("SELECT mitarbeiter_id, vorname, nachname, geburtsdatum FROM mitarbeiter;", gridMitarbeiter);
                c.closeConnection();
            }
            else
            {
                MessageBox.Show("Verbindungsfehler!\nÜbersicht konnte nicht aktualisiert werden.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

    }
}
