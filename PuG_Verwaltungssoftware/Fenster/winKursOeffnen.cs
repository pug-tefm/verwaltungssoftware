﻿using PuG_Verwaltungssoftware.Klassen;
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
        private bool speichernBool = false;
        private bool bearbeitenBool = false;
        private c_Kurse myKurs;
        private DataGridView myDataGridViewKurse;

        public winKursOeffnen(ref c_Kurse myKurse, ref DataGridView dataGridViewKurse)
        {
            InitializeComponent();

            //Unsichtbar machen 
            cbKursleiter.Visible = false;
            dtpDatumBis.Visible = false;
            dtpDatumVon.Visible = false;
            cbWochentag.Visible = false;

            myKurs = myKurse;
            myDataGridViewKurse = dataGridViewKurse;

            tbKursleiter.Text = myKurs.getKursleiter();
            tbBezeichnung.Text = myKurs.getBezeichnung();
            tbPreis.Text = myKurs.getPreis().ToString("N2");
            tbAktTeilnehmer.Text = myKurs.getAktTeilnehmer().ToString();
            tbMaxTeilnehmer.Text = myKurs.getMaxTeilnehmer().ToString();
            tbDatumVon.Text = myKurs.getDatumVon().Date.ToString("dd.MM.yyyy");
            tbDatumBis.Text = myKurs.getDatumBis().Date.ToString("dd.MM.yyyy");
            tbWochentag.Text = c_Helper.umwandlungIntInWochentag(myKurs.getWochentag());
            tbUhrzeitVon.Text = myKurs.getUhrzeitVon().TimeOfDay.ToString("hh\\:mm");
            tbUhrzeitBis.Text = myKurs.getUhrzeitBis().TimeOfDay.ToString("hh\\:mm");
        }

        private void btSchliessen_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void winKursOeffnen_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (bearbeitenBool == true)
            {
                // Wurden Daten geändert ?
                if (myKurs.getKursleiter() != cbKursleiter.Text || myKurs.getBezeichnung() != tbBezeichnung.Text
                  || myKurs.getPreis() != double.Parse(tbPreis.Text) || myKurs.getMaxTeilnehmer() != int.Parse(tbMaxTeilnehmer.Text)
                  || myKurs.getDatumVon().Date != dtpDatumVon.Value.Date || myKurs.getDatumBis().Date != dtpDatumBis.Value.Date
                  || myKurs.getWochentag() != c_Helper.umwandlungWochentagInInt(cbWochentag.SelectedItem.ToString())
                  || myKurs.getUhrzeitVon().TimeOfDay != dtpUhrzeitVon.Value.TimeOfDay || myKurs.getUhrzeitBis().TimeOfDay != dtpUhrzeitBis.Value.TimeOfDay)
                {
                    DialogResult dialogResult = MessageBox.Show("Wollen Sie das Fenster ohne zu Speichern schließen?", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (dialogResult == DialogResult.No)
                    {
                        e.Cancel = true;
                    }
                }
            }
        }

        private void btBearbeiten_Click(object sender, EventArgs e)
        {
            bearbeitenBool = true;

            tbKursleiter.Visible = false;
            tbDatumVon.Visible = false;
            tbDatumBis.Visible = false;
            tbWochentag.Visible = false;
            tbUhrzeitVon.Visible = false;
            tbUhrzeitBis.Visible = false;

            cbKursleiter.Visible = true;
            cbKursleiter.Items.Add(myKurs.getKursleiter());
            cbKursleiter.SelectedIndex = 0;

            dtpDatumVon.Visible = true;
            dtpDatumVon.Value = myKurs.getDatumVon();

            dtpDatumBis.Visible = true;
            dtpDatumBis.Value = myKurs.getDatumBis();

            cbWochentag.Visible = true;

            dtpUhrzeitVon.Visible = true;
            dtpUhrzeitVon.Value = myKurs.getUhrzeitVon();

            dtpUhrzeitBis.Visible = true;
            dtpUhrzeitBis.Value = myKurs.getUhrzeitBis();

            tbBezeichnung.ReadOnly = false;
            tbPreis.ReadOnly = false;
            tbMaxTeilnehmer.ReadOnly = false;
            tbWochentag.ReadOnly = false;
            tbUhrzeitVon.ReadOnly = false;
            tbUhrzeitBis.ReadOnly = false;
        }

        private void btSpeichern_Click(object sender, EventArgs e)
        {
            speichernBool = true;

            if (bearbeitenBool == true)
            {
                bool fehlerGefunden = false;

                // Fehlerüberprüfung Anfang
                bool fehlerBezeichnung = c_Helper.wrongCharNumberExtra(tbBezeichnung.Text);
                if (fehlerBezeichnung == true)
                {
                    fehlerGefunden = true;
                    MessageBox.Show("'" + tbBezeichnung.Text + "' Bitte Eingabe überprüfen", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                bool fehlerPreis = c_Helper.numFormatPunktKomma(tbPreis.Text);
                if (fehlerPreis == true)
                {
                    fehlerGefunden = true;
                    MessageBox.Show("'" + tbPreis.Text + "' Bitte Eingabe überprüfen", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                bool fehlerMaxTeilnehmer = c_Helper.numFormat(tbMaxTeilnehmer.Text);
                if (fehlerMaxTeilnehmer == true)
                {
                    fehlerGefunden = true;
                    MessageBox.Show("'" + tbMaxTeilnehmer.Text + "' Bitte Eingabe überprüfen", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                if (dtpDatumVon.Value.Date > dtpDatumBis.Value.Date)
                {
                    fehlerGefunden = true;
                    MessageBox.Show("Von Datum kann nicht größer als Bis Datum sein", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                if (dtpUhrzeitVon.Value.TimeOfDay > dtpUhrzeitBis.Value.TimeOfDay)
                {
                    fehlerGefunden = true;
                    MessageBox.Show("Von Uhrzeit kann nicht größer als Bis Uhrzeit sein", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                // Fehlerüberprüfung Ende

                if (fehlerGefunden == true)
                {
                    MessageBox.Show("Datensatz wurde nicht gespeichert", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    int rowIndex = myDataGridViewKurse.CurrentCell.RowIndex;

                    if (myKurs.getKursleiter() != cbKursleiter.Text)
                    {
                        myKurs.setKursleiter(cbKursleiter.Text);
                        myDataGridViewKurse.Rows[rowIndex].Cells["Kursleiter"].Value = cbKursleiter.Text;
                    }

                    if (myKurs.getBezeichnung() != tbBezeichnung.Text)
                    {
                        myKurs.setBezeichnung(tbBezeichnung.Text);
                        myDataGridViewKurse.Rows[rowIndex].Cells["Bezeichnung"].Value = tbBezeichnung.Text;
                    }

                    if (myKurs.getPreis().ToString() != tbPreis.Text)
                    {
                        string newText = tbPreis.Text.Replace(".", ",");
                        myKurs.setPreis(Math.Round(double.Parse(Convert.ToDecimal(newText).ToString()), 2));
                        myDataGridViewKurse.Rows[rowIndex].Cells["Preis"].Value = double.Parse(newText);
                        tbPreis.Text = myKurs.getPreis().ToString("N2");
                    }

                    if (myKurs.getMaxTeilnehmer().ToString() != tbMaxTeilnehmer.Text)
                    {
                        myKurs.setMaxTeilnehmer(int.Parse(tbMaxTeilnehmer.Text.ToString()));
                        myDataGridViewKurse.Rows[rowIndex].Cells["Max. Teilnehmer"].Value = int.Parse(tbMaxTeilnehmer.Text);
                    }

                    if (myKurs.getDatumVon().Date != dtpDatumVon.Value.Date || myKurs.getDatumBis().Date != dtpDatumBis.Value.Date
                      || c_Helper.umwandlungIntInWochentag(myKurs.getWochentag()) != cbWochentag.SelectedItem.ToString())
                    {
                        DateTime myDateTimeVon = dtpDatumVon.Value.Date;
                        DateTime myDateTimeBis = dtpDatumBis.Value.Date;
                        String wochentag = c_Helper.umwandlungWochentagGerToEng(cbWochentag.Text);

                        while (dtpDatumVon.Value.DayOfWeek.ToString() != wochentag)
                        {
                            myDateTimeVon = myDateTimeVon.AddDays(+1);
                            if (myDateTimeVon.DayOfWeek.ToString() == wochentag)
                            {
                                dtpDatumVon.Value = myDateTimeVon.Date;
                                break;
                            }
                        }

                        while (dtpDatumBis.Value.DayOfWeek.ToString() != wochentag)
                        {
                            myDateTimeBis = myDateTimeBis.AddDays(-1);
                            if (myDateTimeBis.DayOfWeek.ToString() == wochentag)
                            {
                                dtpDatumBis.Value = myDateTimeBis.Date;
                                break;
                            }
                        }
                    }

                    if (myKurs.getDatumVon().Date != dtpDatumVon.Value.Date)
                    {
                        myKurs.setDatumVon(dtpDatumVon.Value.Date);
                        myDataGridViewKurse.Rows[rowIndex].Cells["Datum Von"].Value = dtpDatumVon.Value.Date;
                    }

                    if (myKurs.getDatumBis().Date != dtpDatumBis.Value.Date)
                    {
                        myKurs.setDatumBis(dtpDatumBis.Value.Date);
                        myDataGridViewKurse.Rows[rowIndex].Cells["Datum Bis"].Value = dtpDatumBis.Value.Date;
                    }

                    if (c_Helper.umwandlungIntInWochentag(myKurs.getWochentag()) != cbWochentag.SelectedItem.ToString())
                    {
                        myKurs.setWochentag(c_Helper.umwandlungWochentagInInt(cbWochentag.Text));
                        myDataGridViewKurse.Rows[rowIndex].Cells["Wochentag"].Value = cbWochentag.Text;
                    }

                    if (myKurs.getUhrzeitVon().TimeOfDay != dtpUhrzeitVon.Value.TimeOfDay)
                    {
                        myKurs.setUhrzeitVon(DateTime.Parse(dtpUhrzeitVon.Value.TimeOfDay.ToString()));
                        myDataGridViewKurse.Rows[rowIndex].Cells["Uhrzeit Von"].Value = dtpUhrzeitVon.Value.TimeOfDay;
                    }

                    if (myKurs.getUhrzeitBis().TimeOfDay != dtpUhrzeitBis.Value.TimeOfDay)
                    {
                        myKurs.setUhrzeitBis(DateTime.Parse(dtpUhrzeitBis.Value.TimeOfDay.ToString()));
                        myDataGridViewKurse.Rows[rowIndex].Cells["Uhrzeit Bis"].Value = dtpUhrzeitBis.Value.TimeOfDay;
                    }

                    //c_DBConnect myConnection = new c_DBConnect();
                    //myConnection.openConnection();
                    //String query = "UPDATE kurse SET bezeichnung=" + myKurs.getBezeichnung() + ", kursleiter= " + myKurs.getKursleiter() +
                    //        ", preis=" + myKurs.getPreis() + ", max_teilnehmer=" + myKurs.getMaxTeilnehmer() +
                    //        ", datum_von=" + myKurs.getDatumVon() + ", datum_bis=" + myKurs.getDatumBis() + ", wochentag=" + myKurs.getWochentag() +
                    //        ", uhrzeit_von=" + myKurs.getUhrzeitVon() + ", uhrzeit_bis=" + myKurs.getUhrzeitBis() +
                    //        "WHERE kurs_id = '" + myKurs.getKursId() + "'";
                    //myConnection.update(query, "Kurs");
                    //myConnection.closeConnection();

                    myDataGridViewKurse.Refresh();

                    cbKursleiter.Visible = false;
                    dtpDatumVon.Visible = false;
                    dtpDatumBis.Visible = false;
                    cbWochentag.Visible = false;
                    dtpUhrzeitVon.Visible = false;
                    dtpUhrzeitBis.Visible = false;

                    tbKursleiter.Visible = true;
                    tbKursleiter.Text = myKurs.getKursleiter();

                    tbDatumVon.Visible = true;
                    tbDatumVon.Text = myKurs.getDatumVon().Date.ToString("dd.MM.yyyy");

                    tbDatumBis.Visible = true;
                    tbDatumBis.Text = myKurs.getDatumBis().Date.ToString("dd.MM.yyyy");

                    tbWochentag.Visible = true;
                    tbWochentag.Text = c_Helper.umwandlungIntInWochentag(myKurs.getWochentag());

                    tbUhrzeitVon.Visible = true;
                    tbUhrzeitVon.Text = myKurs.getUhrzeitVon().TimeOfDay.ToString("hh\\:mm");

                    tbUhrzeitBis.Visible = true;
                    tbUhrzeitBis.Text = myKurs.getUhrzeitBis().TimeOfDay.ToString("hh\\:mm");

                    tbBezeichnung.ReadOnly = true;
                    tbPreis.ReadOnly = true;
                    tbMaxTeilnehmer.ReadOnly = true;
                    tbWochentag.ReadOnly = true;
                    tbUhrzeitVon.ReadOnly = true;
                    tbUhrzeitBis.ReadOnly = true;

                    bearbeitenBool = false;
                }
            }
            speichernBool = false;
        }

        private void gueltigerWochentagPruefen()
        {
            cbWochentag.Items.Clear();

            // Nur gültige Wochentag auswählbar machen
            TimeSpan myTimeSpan = dtpDatumBis.Value.Date - dtpDatumVon.Value.Date;
            if (myTimeSpan.Days < 7)
            {
                cbWochentag.Items.Clear();
                DateTime myDateTime = dtpDatumVon.Value.Date;
                while (myDateTime.Date <= dtpDatumBis.Value.Date)
                {
                    String myString = c_Helper.umwandlungWochentagEngToGer(myDateTime.DayOfWeek.ToString());
                    cbWochentag.Items.Add(myString);
                    myDateTime = myDateTime.AddDays(+1);
                }

                if (cbWochentag.SelectedIndex != -1)
                {
                    cbWochentag.SelectedItem = c_Helper.umwandlungIntInWochentag(myKurs.getWochentag());
                }
                else
                {
                    if (cbWochentag.Items.Count != 0)
                    {
                        cbWochentag.SelectedIndex = 0;
                    }
                }
            }
            else
            {
                cbWochentag.Items.Add("Montag");
                cbWochentag.Items.Add("Dienstag");
                cbWochentag.Items.Add("Mittwoch");
                cbWochentag.Items.Add("Donnerstag");
                cbWochentag.Items.Add("Freitag");
                cbWochentag.Items.Add("Samstag");
                cbWochentag.Items.Add("Sonntag");

                if (cbWochentag.Items.Count != -1)
                {
                    if (speichernBool == true)
                    {
                        //cbWochentag.SelectedItem = cbWochentag.SelectedItem.ToString();
                    }
                    else
                    {
                        cbWochentag.SelectedItem = c_Helper.umwandlungIntInWochentag(myKurs.getWochentag());
                    }
                }
            }
        }

        private void dtpDatumVon_ValueChanged(object sender, EventArgs e)
        {
            gueltigerWochentagPruefen();
        }

        private void dtpDatumBis_ValueChanged(object sender, EventArgs e)
        {
            gueltigerWochentagPruefen();
        }
    }
}
