using System;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace WorkTimeCalculator
{
    public partial class FormRechner : Form
    {
        public FormRechner()
        {
            InitializeComponent();
            this.Text = "Work Time Calculator";
            this.Size = new Size(880, 620);
            this.StartPosition = FormStartPosition.CenterScreen;
            dateTimePicker1.Value = DateTime.Now;

            // Arbeitszeiten bearbeiten (MenüBar-Item)

            menüToolStripMenuItemForm2.Click += new System.EventHandler(menüToolStripMenuItemForm2_Click);

            void menüToolStripMenuItemForm2_Click(object sender, EventArgs e) 
            {
                FormBearbeiten form3 = new FormBearbeiten();
                form3.Show();
            }

            // Berechnen der Eingaben über Berechnen-Button

            btnBerechnen.Click += new System.EventHandler(btnBerechnen_Click);

            void btnBerechnen_Click (object sender, EventArgs e)
            {
                if (!IsValidTime(textBoxBeginn.Text) || !IsValidMinute(textBoxPause1.Text) ||
                !IsValidMinute(textBoxPause2.Text) || !IsValidMinute(textBoxPause3.Text) ||
                !IsValidTime(textBoxEnde.Text))
                {
                    MessageBox.Show("Bitte geben Sie gültige Werte ein.\nDer Arbeitsbeginn & -ende sind als Uhrzeit einzutragen.\nDie Pausen sind in Minuten einzutragen.");
                    return;
                }

                DateTime beginTime = DateTime.Parse(textBoxBeginn.Text);
                int pause1Minutes = int.Parse(textBoxPause1.Text);
                int pause2Minutes = int.Parse(textBoxPause2.Text);
                int pause3Minutes = int.Parse(textBoxPause3.Text);
                DateTime endTime = DateTime.Parse(textBoxEnde.Text);

                int totalPauseMinutes = pause1Minutes + pause2Minutes + pause3Minutes;

                TimeSpan totalWorkTime = endTime - beginTime;
                
                double totalWorkHours = totalWorkTime.TotalHours - (totalPauseMinutes / 60.0);

                lblBruttoDisplay.Text = totalWorkTime.ToString(@"hh\:mm") + " Stunden";
                lblPauseDisplay.Text = totalPauseMinutes.ToString() + " Minuten";
                lblNettoDisplay.Text = totalWorkHours.ToString(@"0.00") + " Stunden";

                if (endTime < beginTime)
                {
                    lblBruttoDisplay.Text = "Fehler";
                    lblPauseDisplay.Text = "Fehler";
                    lblNettoDisplay.Text = "Fehler";
                    MessageBox.Show("Ihr eingetragener Wert des Arbeitsendes liegt unter dem des Arbeitsbeginns.\n Bitte überprüfen Sie Ihre Eingaben.");
                }

                DateTime CurrentDate = DateTime.Now;

                if (dateTimePicker1.Value > CurrentDate)
                {
                    MessageBox.Show("Gewählter Zeitpunkt liegt in der Zukunft.\n Bitte heutigen oder bereits vergangenen Zeitpunkt wählen.");
                    dateTimePicker1.Focus();
                }
            }

            bool IsValidTime(string input)
            {
                DateTime Time;
                return DateTime.TryParse(input, out Time);
            }

            bool IsValidMinute(string input)
            {
                int Minutes;
                return int.TryParse(input, out Minutes);
            }

            // Eingaben auf Ziffern begrenzen & Doppelpunkt nach zwei Ziffern bei Uhrzeiten einsetzen

            this.textBoxBeginn.KeyPress += new KeyPressEventHandler(textBox_KeyPress);
            this.textBoxPause1.KeyPress += new KeyPressEventHandler(textBox_KeyPress);
            this.textBoxPause2.KeyPress += new KeyPressEventHandler(textBox_KeyPress);
            this.textBoxPause3.KeyPress += new KeyPressEventHandler(textBox_KeyPress);
            this.textBoxEnde.KeyPress += new KeyPressEventHandler(textBox_KeyPress);

            void textBox_KeyPress(object sender, KeyPressEventArgs e)
            {
                TextBox textBox = sender as TextBox;

                if (textBox.Name == "textBoxBeginn" || textBox.Name == "textBoxEnde")
                {
                    if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != ':')
                    {
                        e.Handled = true;
                    }

                    if (textBox.Text.Length == 2 && e.KeyChar != ':' && !char.IsControl(e.KeyChar))
                    {
                        textBox.Text += ":" + e.KeyChar;
                        e.Handled = true;
                        textBox.SelectionStart = textBox.Text.Length;
                    }
                    if (textBox.Text.Length >= 5 && !char.IsControl(e.KeyChar))
                    {
                        e.Handled = true;
                    }
                }
                else
                {
                    if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                    {
                        e.Handled = true;
                    }
                }
            }

            // Übermittlung der Werte an MySQL Datenbank

            btnTransmitData.Click += new System.EventHandler(btnTransmitData_Click);

            void btnTransmitData_Click(object sender, System.EventArgs e)
            {
                string connString = "server=localhost;uid=root;pwd=123456;database=arbeitszeitenrechner";

                try
                {
                    using (MySqlConnection connection = new MySqlConnection(connString))
                    {
                        connection.Open();

                        // Überprüfung der Benutzereingaben
                        if (!IsValidInput())
                        {
                            Console.WriteLine("Ungültige Eingaben. Bitte überprüfen Sie Ihre Eingaben.");
                            return;
                        }

                        string query = "INSERT INTO arbeitszeiten (Datum, Arbeitsbeginn, Pause, Arbeitsende, Nettoarbeitszeit) VALUES (@Datum, @Arbeitsbeginn, @Pause, @Arbeitsende, @Nettoarbeitszeit)";

                        using (MySqlCommand command = new MySqlCommand(query, connection))
                        {
                            // Parameter für Datum und Zeit
                            command.Parameters.AddWithValue("@Datum", dateTimePicker1.Value);
                            command.Parameters.AddWithValue("@Arbeitsbeginn", textBoxBeginn.Text);
                            command.Parameters.AddWithValue("@Pause", CalculateTotalPause().ToString());
                            command.Parameters.AddWithValue("@Arbeitsende", textBoxEnde.Text);
                            command.Parameters.AddWithValue("@Nettoarbeitszeit", CalculateNetWorkingTime().ToString());

                            command.ExecuteNonQuery();
                        }
                    }
                    MessageBox.Show("Ihre Daten wurden erfolgreich übermittelt.");
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

            // Methode zur Überprüfung der Benutzereingaben
            bool IsValidInput()
            {
                // Überprüfung, ob die Startzeit und Endzeit nicht leer sind
                if (string.IsNullOrWhiteSpace(textBoxBeginn.Text) || string.IsNullOrWhiteSpace(textBoxEnde.Text))
                {
                    return false;
                }

                // Überprüfung, ob die Endzeit nach der Startzeit liegt
                DateTime beginTime, endTime;
                if (!DateTime.TryParse(textBoxBeginn.Text, out beginTime) || !DateTime.TryParse(textBoxEnde.Text, out endTime))
                {
                    return false;
                }
                if (beginTime >= endTime)
                {
                    return false;
                }
                return true;
            }

            // Methode zur Berechnung der Gesamtpausezeit
            int CalculateTotalPause()
            {
                int pause1Minutes = int.Parse(textBoxPause1.Text);
                int pause2Minutes = int.Parse(textBoxPause2.Text);
                int pause3Minutes = int.Parse(textBoxPause3.Text);

                int FromMinutes = pause1Minutes + pause2Minutes + pause3Minutes;

                return FromMinutes;
            }

            // Methode zur Berechnung der Nettoarbeitszeit
            string CalculateNetWorkingTime()
            {
                DateTime beginTime = DateTime.Parse(textBoxBeginn.Text);
                DateTime endTime = DateTime.Parse(textBoxEnde.Text);

                int totalPauseMinutes = CalculateTotalPause();

                TimeSpan totalWorkTime = endTime - beginTime;
                double netWorkingTimeInHours = (totalWorkTime.TotalMinutes - totalPauseMinutes) / 60.0;

                return netWorkingTimeInHours.ToString("0.00");
            }

        }
    }
}