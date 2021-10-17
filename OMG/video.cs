using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace OMG
{
    public partial class video : Form
    {

        public video()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            Size size = this.Size;
            int width = size.Width;
            int height = size.Height;

            axWindowsMediaPlayer1.Width = width;
            axWindowsMediaPlayer1.Height = height;

            axWindowsMediaPlayer1.URL = (@".\error.mp4");
            axWindowsMediaPlayer1.Ctlcontrols.play();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {   
            this.Close();

            timer1.Stop();
        }

        private void axWindowsMediaPlayer1_ClickEvent(object sender, AxWMPLib._WMPOCXEvents_ClickEvent e)
        {
            
        }

        private void axWindowsMediaPlayer1_SizeChanged(object sender, EventArgs e)
        {
            Size size = this.Size;
            int width = size.Width;
            int height = size.Height;

            axWindowsMediaPlayer1.Width = width;
            axWindowsMediaPlayer1.Height = height;
        }

        private void axWindowsMediaPlayer1_ModeChange(object sender, AxWMPLib._WMPOCXEvents_ModeChangeEvent e)
        {
            Size size = this.Size;
            int width = size.Width;
            int height = size.Height;

            axWindowsMediaPlayer1.Width = width;
            axWindowsMediaPlayer1.Height = height;
        }

        private void axWindowsMediaPlayer1_Enter(object sender, EventArgs e)
        {
            Size size = this.Size;
            int width = size.Width;
            int height = size.Height;

            axWindowsMediaPlayer1.Width = width;
            axWindowsMediaPlayer1.Height = height;
        }

        private void axWindowsMediaPlayer1_PlayStateChange(object sender, AxWMPLib._WMPOCXEvents_PlayStateChangeEvent e)
        {
            Size size = this.Size;
            int width = size.Width;
            int height = size.Height;

            axWindowsMediaPlayer1.Width = width;
            axWindowsMediaPlayer1.Height = height;
        }

        private void axWindowsMediaPlayer1_PositionChange(object sender, AxWMPLib._WMPOCXEvents_PositionChangeEvent e)
        {
            Size size = this.Size;
            int width = size.Width;
            int height = size.Height;

            axWindowsMediaPlayer1.Width = width;
            axWindowsMediaPlayer1.Height = height;
        }

        private void axWindowsMediaPlayer1_StatusChange(object sender, EventArgs e)
        {
            Size size = this.Size;
            int width = size.Width;
            int height = size.Height;

            axWindowsMediaPlayer1.Width = width;
            axWindowsMediaPlayer1.Height = height;
        }

        private void axWindowsMediaPlayer1_Resize(object sender, EventArgs e)
        {
            Size size = this.Size;
            int width = size.Width;
            int height = size.Height;

            axWindowsMediaPlayer1.Width = width;
            axWindowsMediaPlayer1.Height = height;
        }
    }
}
