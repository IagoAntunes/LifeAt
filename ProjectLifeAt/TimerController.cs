using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace ProjectLifeAt
{
    public partial class TimerController : UserControl
    {
        int opcao;
        int minutos;
        int segundos;

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]

        private static extern IntPtr CreateRoundRectRgn(
            int nLeft,
            int nTop,
            int nRight,
            int nBottom,
            int nWidthEllipse,
            int nHeightEllipse
        );




        public TimerController()
        {
            InitializeComponent();
            UserControl teste = new UserControl1();
            teste.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, teste.Width, teste.Height, 30, 30));
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if (btnStart.Text.Equals("Start"))
            {
                btnStart.Text = "Pause";
                timerCronometro.Enabled = true;
                
                if (minutos < 10)
                {
                    if (segundos < 10)
                    {
                        lblTempoCrono.Text = "0" + minutos + ":" + "0" + segundos;
                    }
                    else
                    {
                        lblTempoCrono.Text = "0" + minutos + ":" +  segundos;
                    }

                }
                else
                {
                    if (segundos < 10)
                    {
                        lblTempoCrono.Text = minutos + ":" + "0" + segundos;
                    }
                    else
                    {
                        lblTempoCrono.Text = minutos + ":" + "0" + segundos;
                    }
                }
            }else if(timerCronometro.Enabled == true)
            {
                btnStart.Text = "Start";
                timerCronometro.Enabled = false ;
            }
        }
    
      

        private void timer1_Tick(object sender, EventArgs e)
        {
            segundos--;
            if (minutos > 0)
            {
                if (segundos < 0)
                {
                    segundos = 59;
                    minutos--;
                }
            }
            if (minutos < 10 || segundos < 10)
            {
                if (segundos < 10 && minutos < 10)
                {
                    lblTempoCrono.Text = "0" + minutos + ":" + "0" + segundos;
                }
                else if (minutos < 10)
                {
                    lblTempoCrono.Text = "0" + minutos + ":" + segundos;
                }
                else if (segundos < 10)
                {
                    lblTempoCrono.Text = minutos + ":" + "0" + segundos;
                }

            }
            else
            {
                lblTempoCrono.Text = minutos + ":" + segundos;
            }


            if (minutos == 0 && segundos == 0)
            {
                timerCronometro.Enabled = false;

            }

        }

        private void guna2HtmlLabel2_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click_1(object sender, EventArgs e)
        {
            if (timerCronometro.Enabled == false)
            {
                minutos = 20;
                segundos = 0;
                lblTempoCrono.Text = minutos + ":" + segundos + "0";
            }
        }

        private void btnShort_Click(object sender, EventArgs e)
        {
            if (timerCronometro.Enabled == false)
            {
                minutos = 10;
                segundos = 0;
                lblTempoCrono.Text = minutos + ":" + segundos + "0";
            }
        }

        private void btnLong_Click(object sender, EventArgs e)
        {
            if (timerCronometro.Enabled == false)
            {
                minutos = 30;
                segundos = 0;
                lblTempoCrono.Text = minutos + ":" + segundos + "0";
            }
        }
    }
}
