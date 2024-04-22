using System;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Data;

namespace WorkTimeCalculator
{
    public partial class FormBearbeiten : Form
    {
        MySqlConnection con = new MySqlConnection("datasource=localhost;port=3306;username=root;password=123456;database=arbeitszeitenrechner");
        MySqlCommand cmd;
        MySqlDataAdapter adapt;

        public FormBearbeiten()
        {
            InitializeComponent();
            this.Text = "eingetragene Arbeitszeiten";
            this.Size = new Size(880, 620);
            this.StartPosition = FormStartPosition.CenterScreen;
            
            DisplayData();

            // Aktualisieren Button
            btnAktualisieren.Click += new System.EventHandler(btnAktualisieren_Click);

            void btnAktualisieren_Click (object sender, EventArgs e)
            {
                LoadData();
            }

            // Bearbeiten Button
            btnBearbeiten.Click += new System.EventHandler(btnBearbeiten_Click);

            void btnBearbeiten_Click (object sender, EventArgs e)
            {
                UpdateValue();
            }

            // Löschen Button
            btnLöschen.Click += new System.EventHandler(btnLöschen_Click);

            void btnLöschen_Click(object sender, EventArgs e)
            {
                DeleteValue();
            }

        }

        // DataGridView mit Daten füllen & anzeigen
        private void DisplayData()
        {
            con.Open();
            DataTable dt = new DataTable();
            adapt = new MySqlDataAdapter("select * from arbeitszeiten;", con);
            adapt.Fill(dt);
            dataGridView1.DataSource = dt;
            DataGridViewColumn column0 = dataGridView1.Columns[0];
            column0.Width = 157;
            DataGridViewColumn column1 = dataGridView1.Columns[1];
            column1.Width = 160;
            DataGridViewColumn column2 = dataGridView1.Columns[2];
            column2.Width = 160;
            DataGridViewColumn column3 = dataGridView1.Columns[3];
            column3.Width = 160;
            DataGridViewColumn column4 = dataGridView1.Columns[4];
            column4.Width = 160;
            con.Close();
        }

        // Daten aktualisieren über Button
        private void LoadData()
        {
            try
            {
                con.Open();
                DataTable dt = new DataTable();
                adapt = new MySqlDataAdapter("select * from arbeitszeiten;", con);
                dt.Clear();
                adapt.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Fehler beim Laden der Daten: " + ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        // Neu eingetragene Werte an Datenbank übergeben
        private void UpdateValue()
        {
            if (dataGridView1.SelectedCells.Count > 0)
            {
                DataGridViewCell cell = dataGridView1.SelectedCells[0];
                string columnName = dataGridView1.Columns[cell.ColumnIndex].Name;
                object newValue = cell.Value;
                DataGridViewRow row = dataGridView1.Rows[cell.RowIndex];

                // Datum
                DateTime arbeitsdatum;
                if (!DateTime.TryParse(row.Cells["Datum"].Value.ToString(), out arbeitsdatum))
                {
                    MessageBox.Show("Ungültiges Datumsformat für Datum.");
                    return;
                }

                // Arbeitsbeginn
                DateTime arbeitsbeginn;
                if (!DateTime.TryParse(row.Cells["Arbeitsbeginn"].Value.ToString(), out arbeitsbeginn))
                {
                    MessageBox.Show("Ungültiges Zeitformat für Arbeitsbeginn.");
                    return;
                }

                // Pause
                string pause = row.Cells["Pause"].Value.ToString();

                // Arbeitsende
                DateTime arbeitsende;
                if (!DateTime.TryParse(row.Cells["Arbeitsende"].Value.ToString(), out arbeitsende))
                {
                    MessageBox.Show("Ungültiges Zeitformat für Arbeitsende.");
                    return;
                }

                // Nettoarbeitszeit
                string nettoarbeitszeit = row.Cells["Nettoarbeitszeit"].Value.ToString();

                if (columnName == "Arbeitsbeginn" || columnName == "Arbeitsende" || columnName == "Pause")
                {
                    // Berechnung der Nettoarbeitszeit
                    TimeSpan pausenzeit = TimeSpan.Parse(pause);
                    TimeSpan arbeitszeit = arbeitsende - arbeitsbeginn - pausenzeit;
                    
                    if (!TimeSpan.TryParse(pause, out pausenzeit))
                    {
                        // Fehlerbehandlung für ungültiges Format der Pause
                        MessageBox.Show("Ungültiges Zeitformat für Pause.");
                        return;
                    }

                    // Konvertierung der Nettoarbeitszeit in das richtige Format für die Datenbank (varchar(255))
                    string nettoarbeitszeitString = nettoarbeitszeit.ToString();

                    // Update database
                    string updateQuery = "UPDATE arbeitszeiten SET Arbeitsbeginn = @Arbeitsbeginn, Arbeitsende = @Arbeitsende, Pause = @Pause, Nettoarbeitszeit = @Nettoarbeitszeit WHERE Datum = @Datum";
                    using (MySqlConnection con = new MySqlConnection("datasource=localhost;port=3306;username=root;password=123456;database=arbeitszeitenrechner"))
                    {
                        MySqlCommand command = new MySqlCommand(updateQuery, con);
                        command.Parameters.AddWithValue("@Arbeitsbeginn", arbeitsbeginn);
                        command.Parameters.AddWithValue("@Arbeitsende", arbeitsende);
                        command.Parameters.AddWithValue("@Pause", pause);
                        command.Parameters.AddWithValue("@Nettoarbeitszeit", nettoarbeitszeitString);
                        command.Parameters.AddWithValue("@Datum", arbeitsdatum);

                        try
                        {
                            con.Open();
                            int result = command.ExecuteNonQuery();
                            if (result > 0)
                            {
                                MessageBox.Show("Daten erfolgreich aktualisiert.");
                            }
                            else
                            {
                                MessageBox.Show("Aktualisierung fehlgeschlagen.");
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Fehler beim Aktualisieren der Daten: " + ex.Message);
                        }
                    }
                }
                else
                {
                    string updateQuery = $"UPDATE arbeitszeiten SET {columnName} = @NewValue WHERE Datum = @Datum";
                    using (MySqlConnection con = new MySqlConnection("datasource=localhost;port=3306;username=root;password=123456;database=arbeitszeitenrechner"))
                    {
                        MySqlCommand command = new MySqlCommand(updateQuery, con);
                        command.Parameters.AddWithValue("@NewValue", newValue);
                        command.Parameters.AddWithValue("@Datum", arbeitsdatum);

                        try
                        {
                            con.Open();
                            int result = command.ExecuteNonQuery();
                            if (result > 0)
                            {
                                MessageBox.Show("Daten erfolgreich aktualisiert.");
                            }
                            else
                            {
                                MessageBox.Show("Aktualisierung fehlgeschlagen.");
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Fehler beim Aktualisieren der Daten: " + ex.Message);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Bitte wählen Sie mindestens eine Zelle zum Aktualisieren aus.");
            }
        }


        // Werte einzelner Zellen oder ganzen Zeile löschen & an Datenbank übergeben
        private void DeleteValue()
        {
            // Überprüfung, ob Zeile ausgewählt ist
            if (dataGridView1.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow row in dataGridView1.SelectedRows)
                {
                    // Löschen der Zeile aus der Datenbank
                    string deleteQuery = "DELETE FROM arbeitszeiten WHERE Datum = @Datum OR Arbeitsbeginn = @Arbeitsbeginn OR Pause = @Pause OR Arbeitsende = @Arbeitsende OR Nettoarbeitszeit = @Nettoarbeitszeit";
                    MySqlCommand command = new MySqlCommand(deleteQuery, con);
                    command.Parameters.AddWithValue("@Datum", row.Cells["Datum"].Value);
                    command.Parameters.AddWithValue("@Arbeitsbeginn", row.Cells["Arbeitsbeginn"].Value);
                    command.Parameters.AddWithValue("@Pause", row.Cells["Pause"].Value);
                    command.Parameters.AddWithValue("@Arbeitsende", row.Cells["Arbeitsende"].Value);
                    command.Parameters.AddWithValue("@Nettoarbeitszeit", row.Cells["Nettoarbeitszeit"].Value);

                    con.Open();
                    int rowsAffected = command.ExecuteNonQuery();
                    con.Close();

                    // Entfernen der Zeile aus der DataGridView, wenn die Datenbankaktualisierung erfolgreich war
                    if (rowsAffected > 0)
                    {
                        dataGridView1.Rows.Remove(row);
                    }
                }
            }
            else if (dataGridView1.SelectedCells.Count > 0)
            {
                // Löschen einzelner Zellen
                foreach (DataGridViewCell cell in dataGridView1.SelectedCells)
                {
                    string columnName = dataGridView1.Columns[cell.ColumnIndex].Name;
                    cell.Value = DBNull.Value;

                    string updateQuery = $"UPDATE arbeitszeiten SET {columnName} = NULL WHERE Datum = @Datum OR Arbeitsbeginn = @Arbeitsbeginn OR Pause = @Pause OR Arbeitsende = @Arbeitsende OR Nettoarbeitszeit = @Nettoarbeitszeit";
                    MySqlCommand command = new MySqlCommand(updateQuery, con);
                    DataGridViewRow row = cell.OwningRow;
                    command.Parameters.AddWithValue("@Datum", row.Cells["Datum"].Value);
                    command.Parameters.AddWithValue("@Arbeitsbeginn", row.Cells["Arbeitsbeginn"].Value);
                    command.Parameters.AddWithValue("@Pause", row.Cells["Pause"].Value);
                    command.Parameters.AddWithValue("@Arbeitsende", row.Cells["Arbeitsende"].Value);
                    command.Parameters.AddWithValue("@Nettoarbeitszeit", row.Cells["Nettoarbeitszeit"].Value);

                    con.Open();
                    command.ExecuteNonQuery();
                    con.Close();
                }
            }
            else
            {
                MessageBox.Show("Bitte wählen Sie mindestens eine Zelle oder Zeile zum Löschen aus.");
            }
        }
        private void FormBearbeiten_Load(object sender, EventArgs e)
        {

        }
    }
}