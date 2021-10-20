using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace ProjectLifeAt
{
    public partial class Form1 : Form
    {
        int opcao;
        int minutos;
        int segundos;
        Boolean panelTimerON = false;

        Random rnd = new Random();
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]

        private static extern IntPtr CreateRoundRectRgn(
            int nLeft,
            int nTop,
            int nRight,
            int nBottom,
            int nWidthEllipse,
            int nHeightEllipse
            );

        public string videoPath,videoTitle,aux;
        public Form1()
        {
            InitializeComponent();
            axWindowsMediaPlayer1.uiMode = "none";

            opcoesPanel.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, opcoesPanel.Width, opcoesPanel.Height, 30, 30));
            panelTools.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panelTools.Width, panelTools.Height, 20, 20));
            panelTimerM.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panelTimerM.Width, panelTimerM.Height, 10, 10));
        }
        string _ytUrl;

        private void panelButons_Paint(object sender, PaintEventArgs e)
        {
           
        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            opcoesPanel.Visible = false;
            panelTools.Location = new Point(12, 105);
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            opcoesPanel.Visible = true;
            panelTools.Location = new Point(279, 105);
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            if (panelTimerON == false)
            {
                panelTimer.Visible = true;
                panelTimerON = true;
                if (timerCronometro.Enabled == true)
                {
                    lblTimerMinimize.Visible = false;
                    panelTimerM.Visible = false;
                }
            }
            else {
                panelTimer.Visible = false;
                panelTimerON = false;
                if (timerCronometro.Enabled == true)
                {
                    lblTimerMinimize.Visible = true;
                    panelTimerM.Visible = true;
                }
            }
        }

        private void btnMusica2_Click(object sender, EventArgs e)
        {
            String[] path = new String[2];
            String[] title = new string[2];
            path[0] = "C:\\Users\\iagoa\\Videos\\Peru.mp4";
            title[0] = "Peru.mp4";

            int nRandom = rnd.Next(1);
            videoPath = path[nRandom];
            videoTitle = title[nRandom];

            lblTeste.Text = videoTitle.ToString();
            axWindowsMediaPlayer1.URL = videoPath;
        }

        private void guna2Panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void btnPomodoro_Click(object sender, EventArgs e)
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

        private void btnStart_Click(object sender, EventArgs e)
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
                        lblTempoCrono.Text = "0" + minutos + ":" + segundos;
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
            }
            else if (timerCronometro.Enabled == true)
            {
                btnStart.Text = "Start";
                timerCronometro.Enabled = false;
            }
        }

        private void timerCronometro_Tick(object sender, EventArgs e)
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
            lblTimerMinimize.Text = lblTempoCrono.Text;
        }

        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {
            panelTimer.Visible = false;
            if(timerCronometro.Enabled == true) {
                lblTimerMinimize.Visible = true;
                panelTimerM.Visible = true;
            }

        }

        private void axWindowsMediaPlayer1_Enter(object sender, EventArgs e)
        {

        }

        private void btnMusica2_Click_1(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel3_Click(object sender, EventArgs e)
        {

        }


        private void btnMusica1_Click(object sender, EventArgs e)
        {
            String[] path = new String[2];
            String[] title = new string[2];
            path[0] = "C:\\Users\\iagoa\\Videos\\videoplayback.mp4";
            path[1] = "C:\\Users\\iagoa\\Videos\\Beach.mp4";
            title[0] = "videoplayback.mp4";
            title[1] = "Beach.mp4";

            int nRandom = rnd.Next(2);
            videoPath = path[nRandom];
            videoTitle = title[nRandom];

            lblTeste.Text = videoTitle.ToString();
            axWindowsMediaPlayer1.URL = videoPath;




            //videoPath = "C:\\Users\\iagoa\\Downloads\\videoplayback.mp4";
            //videoTitle = "videoplayback.mp4";
            //lblTeste.Text = videoTitle.ToString();
            //axWindowsMediaPlayer1.URL = videoPath;
        }
    }
}
