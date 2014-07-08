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

// Erik
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
                gridMitgliederTable.Columns["mitglieder_id"].ColumnName = "Mitglieder-ID";
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

        private void gridMitglieder_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            mitgliedOeffnen();
        }

        private void gridMitglieder_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right) // Rechtsklick
            {
                // ContextMenuStrip mit ToolStipMenuItem erzeugen
                ContextMenuStrip myContextMenu = new ContextMenuStrip();
                ToolStripMenuItem toolStripItemNeuMG = new ToolStripMenuItem("Neu");
                ToolStripMenuItem toolStripItemOeffnenMG = new ToolStripMenuItem("Öffnen");
                ToolStripMenuItem toolStripItemLoeschenMG = new ToolStripMenuItem("Löschen");
                ToolStripMenuItem toolStripItemAktualisierenMG = new ToolStripMenuItem("Aktualisieren (F5)");

                // Items hinzufügen
                myContextMenu.Items.Add(toolStripItemNeuMG);
                myContextMenu.Items.Add(toolStripItemOeffnenMG);
                myContextMenu.Items.Add(toolStripItemLoeschenMG);
                myContextMenu.Items.Add("-");
                myContextMenu.Items.Add(toolStripItemAktualisierenMG);

                // Bild hinzufuegen
                toolStripItemNeuMG.Image = PuG_Verwaltungssoftware.Properties.Resources.pug_add;
                toolStripItemOeffnenMG.Image = PuG_Verwaltungssoftware.Properties.Resources.pug_open;
                toolStripItemLoeschenMG.Image = PuG_Verwaltungssoftware.Properties.Resources.pug_delete;
                toolStripItemAktualisierenMG.Image = PuG_Verwaltungssoftware.Properties.Resources.pug_refresh;

                // Handler der Items
                toolStripItemNeuMG.Click += new EventHandler(toolStripItemNeuMG_Click);
                toolStripItemOeffnenMG.Click += new EventHandler(toolStripItemOeffnenMG_Click);
                toolStripItemLoeschenMG.Click += new EventHandler(toolStripItemLoeschenMG_Click);
                toolStripItemAktualisierenMG.Click += new EventHandler(toolStripItemAktualisierenMG_Click);

                int currentMouseOverRow = gridMitglieder.HitTest(e.X, e.Y).RowIndex;

                if (currentMouseOverRow >= 0) // In der Tabelle
                {
                    // Nix
                }

                myContextMenu.Show(gridMitglieder, new Point(e.X, e.Y));
            }
        }

        private void toolStripItemNeuMG_Click(object sender, EventArgs args)
        {
            mitgliedNeu();
        }

        private void toolStripItemLoeschenMG_Click(object sender, EventArgs args)
        {
            mitgliedLoeschen();
        }

        private void toolStripItemOeffnenMG_Click(object sender, EventArgs args)
        {
            mitgliedOeffnen();
        }

        private void btMgOeffnen_Click(object sender, EventArgs e)
        {
            mitgliedOeffnen();
        }

        private void btMgNeu_Click(object sender, EventArgs e)
        {
            mitgliedNeu();
        }

        private void btMgLoeschen_Click(object sender, EventArgs e)
        {
            mitgliedLoeschen();
        }

        private void toolStripItemAktualisierenMG_Click(object sender, EventArgs args)
        {
            mitgliederAktualisieren();
        }


        /************ Methoden ****************/

        private void mitgliedOeffnen()
        {
            if (gridMitglieder.CurrentCell != null) // Wenn eine Zelle ausgewählt
            {
                foreach (DataGridViewRow row in gridMitglieder.SelectedRows) // Damit mehrere Zeilen per Multiselect geöffnet werden können
                {
                    if (gridMitglieder.RowCount > 0) // Wenn Zeilenanzahl größer 0
                    {
                        int id = Convert.ToInt32(gridMitglieder.Rows[row.Index].Cells["Mitglieder-ID"].Value);
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

        private void mitgliederAktualisieren()
        {
            int dbConnect = c.openConnection();
            if (dbConnect == 0)
            {
                
                c.displayData("SELECT mitglieder_id, bezeichnung, vorname, nachname, geburtsdatum, gesperrt FROM mitglieder a, vertrag b WHERE a.vertrags_id = b.vertrags_id;", gridMitglieder);
                c.closeConnection();

                // Headertexte anpassen
                DataTable gridMitgliederTable = (DataTable)(gridMitglieder.DataSource);
                gridMitgliederTable.Columns["mitglieder_id"].ColumnName = "Mitglieder-ID";
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

        private void mitgliedNeu()
        {
            winMitgliedNeu window = new winMitgliedNeu(gridMitglieder);
            window.Show();
        }

        private void mitgliedLoeschen()
        {
            if (gridMitglieder.CurrentCell != null) // Wenn eine Zelle ausgewählt
            {
                foreach (DataGridViewRow row in gridMitglieder.SelectedRows) // Wegen Multiselect
                {
                    int id = Convert.ToInt32(gridMitglieder.Rows[row.Index].Cells["Mitglieder-ID"].Value);

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

    }
}
