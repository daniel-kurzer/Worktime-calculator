using System;
using System.Drawing;
using System.Windows.Forms;

namespace WorkTimeCalculator
{
    public partial class FormStartseite : Form
    {
        public FormStartseite()
        {
            InitializeComponent();
            this.Text = "Work Time Calculator";
            this.Size = new Size(880, 620);
            this.StartPosition = FormStartPosition.CenterScreen;

            // MenüItem WorkTimeCalculator 

            worktimecalculatorToolStripMenuItem.Click += new System.EventHandler(worktimecalculatorToolStripMenuItem_Click);

            void worktimecalculatorToolStripMenuItem_Click(object sender, EventArgs e)
            {
                FormRechner form2 = new FormRechner();
                form2.Show();
            }

            // MenüItem Beenden

            beendenToolStripMenuItem.Click += new System.EventHandler(beendenToolStripMenuItem_Click);

            void beendenToolStripMenuItem_Click (object sender, EventArgs e)
            {
                this.Close();
            }

            // Form2 Button

            button1.Click += new System.EventHandler(button1_Click);

            void button1_Click(object sender, EventArgs e)
            {
                FormRechner form2 = new FormRechner();
                form2.Show();
            }

            // Anwendung beenden Button

            button2.Click += new System.EventHandler(button2_Click);

            void button2_Click(object sender, EventArgs e)
            {
                this.Close();
            }

            // Fenster minimieren

            fensterMinimierenToolStripMenuItem.Click += new System.EventHandler(fensterMinimierenToolStripMenuItem_Click);

            void fensterMinimierenToolStripMenuItem_Click (Object sender, EventArgs e) 
            { 
                this.WindowState = FormWindowState.Minimized;
            }

            // Fenster Standart herstellen 

            fensterStandartToolStripMenuItem.Click += new System.EventHandler(fensterStandartToolStripMenuItem_Click);

            void fensterStandartToolStripMenuItem_Click (System.Object sender, EventArgs e)
            {
                this.WindowState = FormWindowState.Normal;
                this.Size = new Size(880, 620);
            }

            // Fenster maximieren 

            fensterMaximierenToolStripMenuItem.Click += new System.EventHandler(fensterMaximierenToolStripMenuItem_Click);

            void fensterMaximierenToolStripMenuItem_Click (System.Object sender, EventArgs e) 
            {
                this.WindowState = FormWindowState.Maximized;
            }
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
