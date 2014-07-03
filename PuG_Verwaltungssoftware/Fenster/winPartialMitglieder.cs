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
        private BindingSource bindingSourceMitglieder = new BindingSource();
        bool initMitglieder = false;

        private void tabPageMitglieder_Enter(object sender, EventArgs e)
        {
            int dBConnectOk = c.openConnection();  // Datenbank oeffnen
            // Mitglieder abfrage
            c.displayData("SELECT mitglieder_id, bezeichnung, vorname, nachname, geburtsdatum, gesperrt FROM mitglieder a, vertrag b WHERE a.vertrags_id = b.vertrags_id;", gridMitglieder);


            c.closeConnection(); // Datenbank schliessen
            if (dBConnectOk == 0)
            {
                // Headertexte anpassen
                DataTable gridMitgliederTable = (DataTable)(gridMitglieder.DataSource);
                gridMitgliederTable.Columns["mitglieder_id"].ColumnName = "ID";
                gridMitgliederTable.Columns["bezeichnung"].ColumnName = "Bezeichnung";
                gridMitgliederTable.Columns["vorname"].ColumnName = "Vorname";
                gridMitgliederTable.Columns["nachname"].ColumnName = "Nachname";
                gridMitgliederTable.Columns["geburtsdatum"].ColumnName = "Geburtsdatum";
                gridMitgliederTable.Columns["gesperrt"].ColumnName = "Gesperrt";

            }

            // Binding Objekt zuweisen
            bindingSourceMitglieder.DataSource = gridMitglieder.DataSource;
            gridMitglieder.DataSource = bindingSourceMitglieder;

            if (initMitglieder == false)
            {
                if (gridMitglieder.ColumnCount > 0)
                {
                    for (int i = 0; i < gridMitglieder.ColumnCount; i++)
                    {
                        if (gridMitglieder.Columns[i].HeaderText != "gesperrt") {
                            ddlMitgliederSuchen.Items.Add(gridMitglieder.Columns[i].HeaderText);
                        }
                    }
                    ddlMitgliederSuchen.SelectedIndex = 0;
                }
                initMitglieder = true;
            }

        }

        private void ddlMitgliederSuchen_SelectedIndexChanged(object sender, EventArgs e)
        {
            myHelper.comboBoxSuchenSelectedIndexChanged(gridMitglieder, ddlMitgliederSuchen, tbMitgliederSuchen, bindingSourceMitglieder);
        }

        private void tbMitgliederSuchen_TextChanged(object sender, EventArgs e)
        {
            myHelper.textBoxSuchenTextChanged(gridMitglieder, ddlMitgliederSuchen, tbMitgliederSuchen, bindingSourceMitglieder);
        }

        private void btMgOeffnen_Click(object sender, EventArgs e)
        {
            mitgliedOeffnen();
        }

        private void btMgNeu_Click(object sender, EventArgs e)
        {
            winMitgliedNeu window = new winMitgliedNeu(gridMitglieder);
            window.Show();
        }

        private void btMgLoeschen_Click(object sender, EventArgs e)
        {
            if (gridMitglieder.CurrentCell != null) // Wenn eine Zelle ausgewählt
            {
                foreach (DataGridViewRow row in gridMitglieder.SelectedRows) // Wegen Multiselect
                {
                    int id = Convert.ToInt32(gridMitglieder.Rows[row.Index].Cells["ID"].Value);

                    DialogResult dialogResult = MessageBox.Show("Wollen Sie das asugewählte Mitglied mit der ID '" + id + "' wirklich löschen?", "Information", MessageBoxButtons.YesNo);

                    if (dialogResult == DialogResult.Yes)
                    {
                        c.openConnection();
                        if (c.delete("DELETE FROM mitglieder WHERE mitglieder_id = '" + id + "';", "Mitglied", 1) == false)
                        {
                            MessageBox.Show("Mitglied kann nicht gelöscht werden, da des Mitglied in einem Kurs ist", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            gridMitglieder.Rows.RemoveAt(row.Index); // Row löschen
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

        private void mitgliedOeffnen()
        {
            if (gridMitglieder.CurrentCell != null) // Wenn eine Zelle ausgewählt
            {
                foreach (DataGridViewRow row in gridMitglieder.SelectedRows) // Damit mehrere Zeilen per Multiselect geöffnet werden können
                {
                    if (gridMitglieder.RowCount > 0) // Wenn Zeilenanzahl größer 0
                    {
                        int id = Convert.ToInt32(gridMitglieder.Rows[row.Index].Cells["ID"].Value);
                        winMitgliedOeffnen window = new winMitgliedOeffnen(id, gridMitglieder);
                        window.Show();

                    }
                }
            }
            else
            {
                DialogResult dialogResult = MessageBox.Show("Sie müssen zuvor eine Zeile oder mehrere Zeilen auswählen.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void gridMitgliederAktualisieren()
        {
            int dbConnect = c.openConnection();
            if (dbConnect == 0)
            {
                
                c.displayData("SELECT mitglieder_id, bezeichnung, vorname, nachname, geburtsdatum, gesperrt FROM mitglieder a, vertrag b WHERE a.vertrags_id = b.vertrags_id;", gridMitglieder);
                c.closeConnection();

                // Headertexte anpassen
                DataTable gridMitgliederTable = (DataTable)(gridMitglieder.DataSource);
                gridMitgliederTable.Columns["mitglieder_id"].ColumnName = "ID";
                gridMitgliederTable.Columns["bezeichnung"].ColumnName = "Bezeichnung";
                gridMitgliederTable.Columns["vorname"].ColumnName = "Vorname";
                gridMitgliederTable.Columns["nachname"].ColumnName = "Nachname";
                gridMitgliederTable.Columns["geburtsdatum"].ColumnName = "Geburtsdatum";
                gridMitgliederTable.Columns["gesperrt"].ColumnName = "Gesperrt";


                // Binding Objekt zuweisen
                bindingSourceMitglieder.DataSource = gridMitglieder.DataSource;
                gridMitglieder.DataSource = bindingSourceMitglieder;
            }
            else
            {
                MessageBox.Show("Verbindungsfehler!\nÜbersicht konnte nicht aktualisiert werden.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
