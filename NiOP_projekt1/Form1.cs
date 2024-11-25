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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSilaTeze_Click(object sender, EventArgs e)
        {
            SilaTezeForm silaTezeForm = new SilaTezeForm();
            silaTezeForm.Show();
        }

        private void btnZakonGravitacije_Click(object sender, EventArgs e)
        {
            ZakonGravitacijeForm zakonGravitacijeForm = new ZakonGravitacijeForm();
            zakonGravitacijeForm.Show();
        }
    }
}
