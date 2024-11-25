using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NiOP_projekt1
{
    public partial class SilaTezeForm : Form
    {
        public SilaTezeForm()
        {
            InitializeComponent();
        }

        private void txtMasa_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnIzracunaj_Click(object sender, EventArgs e)
        {
            try
            {
                // Dohvaćanje unesene mase
                double masa = double.Parse(txtMasa.Text);

                if (masa <= 0)
                {
                    MessageBox.Show("Masa mora biti pozitivan broj!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Izračun sile teže (Fg = m * g)
                double g = 9.81; // Akceleracija sile teže (m/s^2)
                double silaTeze = masa * g;

                // Prikaz rezultata
                lblRezultat.Text = $"Sila teže: {silaTeze:F2} N"; // F2 formatira broj na 2 decimale
            }
            catch (FormatException)
            {
                MessageBox.Show("Unesite ispravnu numeričku vrijednost za masu!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
