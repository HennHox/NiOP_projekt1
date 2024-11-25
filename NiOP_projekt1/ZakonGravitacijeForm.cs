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
    public partial class ZakonGravitacijeForm : Form
    {
        public ZakonGravitacijeForm()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnIzracunaj_Click(object sender, EventArgs e)
        {
            try
            {
                // Dohvaćanje unosa
                double masa1 = double.Parse(txtMasa1.Text);
                double masa2 = double.Parse(txtMasa2.Text);
                double udaljenost = double.Parse(txtUdaljenost.Text);

                if (masa1 <= 0 || masa2 <= 0 || udaljenost <= 0)
                {
                    MessageBox.Show("Sve vrijednosti moraju biti pozitivni brojevi!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Izračun gravitacijske sile (Fg = G * (m1 * m2) / r^2)
                double G = 6.67430e-11; // Gravitacijska konstanta u (m^3⋅kg^−1⋅s^−2)
                double gravitacijskaSila = G * (masa1 * masa2) / Math.Pow(udaljenost, 2);

                // Prikaz rezultata
                lblRezultat.Text = $"Gravitacijska sila: {gravitacijskaSila:E2} N"; // E2 formatira broj u znanstveni zapis
            }
            catch (FormatException)
            {
                MessageBox.Show("Unesite ispravne numeričke vrijednosti!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
