using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zadatak_Vjezba4
{
    public partial class Izracun_Student9 : Form
    {
        public Izracun_Student9()
        {
            InitializeComponent();
        }

        private void Izracun_Student9_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            float stranicaA = 0, stranicaB = 0, opseg = 0, povrsina = 0;

            float.TryParse(StranicaA.Text, out stranicaA);
            float.TryParse(StranicaB.Text, out stranicaB);

            if (stranicaA < 0) stranicaA = 0;
            if (stranicaB < 0) stranicaB = 0;

            povrsina = stranicaA *stranicaB;
            opseg = 2 * (stranicaA + stranicaB);

            StranicaA.Text = stranicaA.ToString();
            StranicaB.Text = stranicaB.ToString();
            Opseg.Text = Math.Round(opseg, 2).ToString();
            Povrsina.Text = Math.Round(povrsina, 2).ToString();


        }
    }
}
