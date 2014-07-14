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

// Florian
namespace PuG_Verwaltungssoftware
{
    public partial class mainWindow : Form
    {
        /*
         * ******************************
         *     Variablendeklarationen
         * ******************************
         * */
        
        private int loginMaId = 0;  // Mitarbeiter-Nr. des angemeldeten Users
        private int loginMaPosId = 0;   // Position-ID des angemeldeten Users
        private bool initMitarbeiter = false;
        private String loginMaVorname = String.Empty;   // Vorname des angemeldeten Users
        private String loginMaNachname = String.Empty;  // Nachname des angemeldeten Users

        private BindingSource bindingSourceMitarbeiter = new BindingSource();


        /*
         * ******************************
         *         Control Events
         * ******************************
         * */

        private void tabPageMitarbeiter_Enter(object sender, EventArgs e)
        {
            int dBConnectOk = c.openConnection();  // Datenbank oeffnen
            if(dBConnectOk == 0)
            {
                if (loginMaPosId == 1)
                {
                    // Mitarbeiter ist admin (chef)
                    c.displayData("SELECT mitarbeiter_id, vorname, nachname, geburtsdatum FROM mitarbeiter;", gridMitarbeiter);
                    c.closeConnection(); // Datenbank schliessen
                }
                else
                {
                    // Mitarbeiter ist "normaler" Benutzer
                    c.displayData("SELECT mitarbeiter_id, vorname, nachname, geburtsdatum FROM mitarbeiter WHERE mitarbeiter_id = '" + loginMaId + "';", gridMitarbeiter);
                    btMaLoeschen.Enabled = false;
                    btMaNeu.Enabled = false;
                    ddlMitarbeiterSuchen.Enabled = false;
                    tbMitarbeiterSuchen.Enabled = false;
                    c.closeConnection(); // Datenbank schliessen
                }
            
 
                // Headertexte anpassen
                DataTable gridMitarbeiterTable = (DataTable)(gridMitarbeiter.DataSource);
                gridMitarbeiterTable.Columns["mitarbeiter_id"].ColumnName = "Mitarbeiter-ID";
                gridMitarbeiterTable.Columns["vorname"].ColumnName        = "Vorname";
                gridMitarbeiterTable.Columns["nachname"].ColumnName       = "Nachname";
                gridMitarbeiterTable.Columns["geburtsdatum"].ColumnName   = "Geburtsdatum";
             
            
                // Binding Objekt zuweisen
                bindingSourceMitarbeiter.DataSource = gridMitarbeiter.DataSource;
                gridMitarbeiter.DataSource = bindingSourceMitarbeiter;

                if (initMitarbeiter == false)
                {
                    if (gridMitarbeiter.ColumnCount > 0)
                    {
                        for (int i = 0; i < gridMitarbeiter.ColumnCount; i++)
                        {
                            ddlMitarbeiterSuchen.Items.Add(gridMitarbeiter.Columns[i].HeaderText);
                        }
                        ddlMitarbeiterSuchen.SelectedIndex = 0;
                    }
                    initMitarbeiter = true;
                }
            }
        }


        private void gridMitarbeiter_SelectionChanged(object sender, EventArgs e)
        {
            int row = gridMitarbeiter.CurrentCell.RowIndex;
            int id = Convert.ToInt32(gridMitarbeiter.Rows[row].Cells["mitarbeiter_id"].Value);
            //MessageBox.Show(id.ToString());
        }


        private void btMaOeffnen_Click(object sender, EventArgs e)
        {
            mitarbeiterOeffnen();
        }


        private void btMaLoeschen_Click(object sender, EventArgs e)
        {
            mitarbeiterLoeschen();
        }


        private void btMaNeu_Click(object sender, EventArgs e)
        {
            neuerMitarbeiter();
        }


        private void ddlMitarbeiterSuchen_SelectedIndexChanged(object sender, EventArgs e)
        {
            myHelper.comboBoxSuchenSelectedIndexChanged(gridMitarbeiter, ddlMitarbeiterSuchen, tbMitarbeiterSuchen, bindingSourceMitarbeiter);
        }


        private void tbMitarbeiterSuchen_TextChanged(object sender, EventArgs e)
        {
            myHelper.textBoxSuchenTextChanged(gridMitarbeiter, ddlMitarbeiterSuchen, tbMitarbeiterSuchen, bindingSourceMitarbeiter);
        }


        private void gridMitarbeiter_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right) // Rechtsklick
            {
                // ContextMenuStrip mit ToolStipMenuItem erzeugen
                ContextMenuStrip myContextMenu = new ContextMenuStrip();
                ToolStripMenuItem toolStripItemNeuMA = new ToolStripMenuItem("Neu");
                ToolStripMenuItem toolStripItemOeffnenMA = new ToolStripMenuItem("Öffnen");
                ToolStripMenuItem toolStripItemLoeschenMA = new ToolStripMenuItem("Löschen");
                ToolStripMenuItem toolStripItemAktualisierenMA = new ToolStripMenuItem("Aktualisieren (F5)");

                // Items hinzufügen
                myContextMenu.Items.Add(toolStripItemNeuMA);
                myContextMenu.Items.Add(toolStripItemOeffnenMA);
                myContextMenu.Items.Add(toolStripItemLoeschenMA);
                myContextMenu.Items.Add("-");
                myContextMenu.Items.Add(toolStripItemAktualisierenMA);

                // Bild hinzufuegen
                toolStripItemNeuMA.Image = PuG_Verwaltungssoftware.Properties.Resources.pug_add;
                toolStripItemOeffnenMA.Image = PuG_Verwaltungssoftware.Properties.Resources.pug_open;
                toolStripItemLoeschenMA.Image = PuG_Verwaltungssoftware.Properties.Resources.pug_delete;
                toolStripItemAktualisierenMA.Image = PuG_Verwaltungssoftware.Properties.Resources.pug_refresh;

                // Handler der Items
                toolStripItemNeuMA.Click += new EventHandler(toolStripItemNeuMA_Click);
                toolStripItemOeffnenMA.Click += new EventHandler(toolStripItemOeffnenMA_Click);
                toolStripItemLoeschenMA.Click += new EventHandler(toolStripItemLoeschenMA_Click);
                toolStripItemAktualisierenMA.Click += new EventHandler(toolStripItemAktualisierenMA_Click);

                int currentMouseOverRow = gridMitarbeiter.HitTest(e.X, e.Y).RowIndex;

                if (currentMouseOverRow >= 0) // In der Tabelle
                {
                    // Nix
                }

                myContextMenu.Show(gridMitarbeiter, new Point(e.X, e.Y));
            }
        }

        private void toolStripItemAktualisierenMA_Click(object sender, EventArgs args)
        {
            gridMitarbeiterAktualisieren();
        }

        private void toolStripItemNeuMA_Click(object sender, EventArgs args)
        {
            neuerMitarbeiter();
        }

        private void toolStripItemOeffnenMA_Click(object sender, EventArgs args)
        {
            mitarbeiterOeffnen();
        }

        private void toolStripItemLoeschenMA_Click(object sender, EventArgs args)
        {
            mitarbeiterLoeschen();
        }

        private void gridMitarbeiter_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            mitarbeiterOeffnen();
        }

        private void gridMitarbeiter_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Delete) // Entfernen Taste = Mitarbeiter löschen
            {
                mitarbeiterLoeschen();
            }

            if (e.KeyData == (Keys.Control | Keys.N)) // Steuerung + N = Neuen Miarbeiter
            {
                neuerMitarbeiter();
            }

            if(e.KeyData == (Keys.Control | Keys.O))  // Steuerung + O = Mitarbeiter öffnen
            {
                mitarbeiterOeffnen();
            }

            if (e.KeyData == Keys.F5) // Aktualisieren
            {
                gridMitarbeiterAktualisieren();
            }
        }


        /*
         * ******************************
         *        Eigene Methoden
         * ******************************
         * */

        private void mitarbeiterOeffnen()
        {
            if (gridMitarbeiter.CurrentCell != null) // Wenn eine Zelle ausgewählt
            {
                foreach (DataGridViewRow row in gridMitarbeiter.SelectedRows) // Damit mehrere Zeilen per Multiselect geöffnet werden können
                {
                    if (gridMitarbeiter.RowCount > 0) // Wenn Zeilenanzahl größer 0
                    {
                        int id = Convert.ToInt32(gridMitarbeiter.Rows[row.Index].Cells["Mitarbeiter-ID"].Value);
                        winMitarbeiterOeffnen window = new winMitarbeiterOeffnen(id, loginMaId, loginMaPosId, gridMitarbeiter);
                        window.Show();

                    }
                }
            }
            else
            {
                DialogResult dialogResult = MessageBox.Show("Sie müssen zuvor eine Zeile oder mehrere Zeilen auswählen.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void neuerMitarbeiter()
        {
            winMitarbeiterNeu window = new winMitarbeiterNeu(loginMaPosId, loginMaPosId, gridMitarbeiter);
            window.Show();
        }

        private void gridMitarbeiterAktualisieren()
        {
            int dbConnect = c.openConnection();
            if (dbConnect == 0)
            {
                c.displayData("SELECT mitarbeiter_id, vorname, nachname, geburtsdatum FROM mitarbeiter;", gridMitarbeiter);
                c.closeConnection();

                // Headertexte anpassen
                DataTable gridMitarbeiterTable = (DataTable)(gridMitarbeiter.DataSource);
                gridMitarbeiterTable.Columns["mitarbeiter_id"].ColumnName = "Mitarbeiter-ID";
                gridMitarbeiterTable.Columns["vorname"].ColumnName = "Vorname";
                gridMitarbeiterTable.Columns["nachname"].ColumnName = "Nachname";
                gridMitarbeiterTable.Columns["geburtsdatum"].ColumnName = "Geburtsdatum";


                // Binding Objekt zuweisen
                bindingSourceMitarbeiter.DataSource = gridMitarbeiter.DataSource;
                gridMitarbeiter.DataSource = bindingSourceMitarbeiter;
            }
            else
            {
                MessageBox.Show("Verbindungsfehler!\nÜbersicht konnte nicht aktualisiert werden.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void mitarbeiterLoeschen()
        {
            if (gridMitarbeiter.CurrentCell != null) // Wenn eine Zelle ausgewählt
            {
                foreach (DataGridViewRow row in gridMitarbeiter.SelectedRows) // Wegen Multiselect
                {
                    int id = Convert.ToInt32(gridMitarbeiter.Rows[row.Index].Cells["Mitarbeiter-ID"].Value);
                    if (id == 1)
                    {
                        DialogResult dialogResultSelf = MessageBox.Show("Der Mitarbeiter mit der Mitarbeiter-ID. '1' kann nicht gelöscht werden.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    if (id == loginMaId)
                    {
                        DialogResult dialogResultSelf = MessageBox.Show("Sie können sich nicht selbst löschen.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    DialogResult dialogResult = MessageBox.Show("Wollen Sie den ausgewählten Mitarbeiter mit der Mitarbeiter-Nr. '" + id + "' wirklich löschen?", "Achtung", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                    if (dialogResult == DialogResult.Yes)
                    {
                        c.openConnection();
                        if (c.delete("DELETE FROM mitarbeiter WHERE mitarbeiter_id = '" + id + "';", "Mitarbeiter", 1) == false)
                        {
                            MessageBox.Show("Mitarbeiter kann nicht gelöscht werden, da der Mitarbeiter ein Kursleiter ist", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            gridMitarbeiter.Rows.RemoveAt(row.Index); // Row löschen
                        }
                        c.closeConnection();
                    }
                }
            }
            else
            {
                DialogResult dialogResult = MessageBox.Show("Sie müssen zuvor eine Zeile oder mehrere Zeilen auswählen.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

    }
}
