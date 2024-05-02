using System;
using System.Windows.Forms;

namespace Vozeca_ploscad_nadgradnja
{
    public partial class Form1: Form
    {
        private bool se_giblje = false;
        private bool giblje_desno = false;
        private bool se_giblje_vodoravno = false;
        private bool giblje_gor = true;
        private const int PREMIK = 5;

        public Form1()
        {
            InitializeComponent();
        }

        private void Gumb_Click(object sender, EventArgs e)
        {
            se_giblje = !se_giblje;
            if (se_giblje)
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
            if (se_giblje_vodoravno)    // Ploščad se premika v vodoravni smeri
            {
                if (giblje_desno)    // Ploščad se premika v desno
                {
                    if (ploscad.Right + PREMIK < 300)
                        ploscad.Left += PREMIK;
                    else
                    {
                        se_giblje_vodoravno = false;
                        giblje_desno = false;
                    }

                }
                else    // Ploščad se premika v levo
                {
                    if (ploscad.Left - PREMIK > 10)
                        ploscad.Left -= PREMIK;
                    else
                    {
                        se_giblje_vodoravno = false;
                        giblje_desno = true;
                    }
                }
            }
            else    // Ploščad se premika v navpični smeri
            {
                if (giblje_gor)    // Ploščad se premika gor
                {
                    if (ploscad.Top - PREMIK > 10)
                        ploscad.Top -= PREMIK;
                    else
                    {
                        se_giblje_vodoravno = true;
                        giblje_gor = false;
                    }
                }
                else    // Ploščad se premika dol
                {
                    if (ploscad.Bottom + PREMIK < 300)
                        ploscad.Top += PREMIK;
                    else
                    {
                        se_giblje_vodoravno = true;
                        giblje_gor = true;
                    }
                }
            }
        }
    }
}