using System;
using System.Drawing;
using System.Windows.Forms;

namespace Izmenjava_barv_nadgradnja
{
    public partial class Form1: Form
    {
        bool aktivno = true;
        Random random = new Random();
        int ind_barve;
        Color barva;
        static Color[] barve = new Color[] { Color.Orange, Color.Purple, Color.Green, Color.Red, Color.Blue, Color.Yellow, Color.Cyan, Color.Lime, Color.Brown, Color.Black, Color.White, Color.Pink, Color.Gray };
        int[] stevci_barv = new int[barve.Length];

        public Form1()
        {
            InitializeComponent();
        }

        private void Gumb_Click(object sender, EventArgs e)
        {
            aktivno = !aktivno;
            if (aktivno)
            {
                Gumb.Text = "Ustavi";
                timer.Enabled = true;
            }
            else
            {
                Gumb.Text = "Začni";
                timer.Enabled = false;
            }
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            ind_barve = random.Next(barve.Length);
            barva = barve[ind_barve];
            stevci_barv[ind_barve]++;
            pictureBox.BackColor = barva;
            label.Text = $"Barva {barva.Name} se je pojavila {stevci_barv[ind_barve]}-krat";
        }
    }
}