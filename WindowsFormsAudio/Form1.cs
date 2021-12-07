using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAudio
{
    public partial class Form1 : Form
    {
        bool expectation; //  чтобы события не перебивали друг друга
        
        public Form1()
        {
            InitializeComponent();

            slidePanel.MouseEnter += async (s, a) =>  // панель выезжает
            {
                while (!expectation && slidePanel.Location.X < BackPanel.Location.X)
                {
                    expectation = true;
                       await Task.Delay(1);
                    slidePanel.Location = new Point(slidePanel.Location.X - slidePanel.Location.X/8+1, slidePanel.Location.Y);
                    expectation = false;

                }
            };

            BackPanel.MouseEnter += async (s, a) =>   // панель уезжает обратно
            {
                while (!expectation && slidePanel.Location.X > -270)
                {
                    expectation = true;
                    await Task.Delay(1);
                    slidePanel.Location = new Point(slidePanel.Location.X - (slidePanel.Width + slidePanel.Location.X)/8+1, slidePanel.Location.Y);
                    expectation = false; 

                }
            };
        }

        private void btnPrevious_MouseEnter(object sender, EventArgs e)
        {
            btnPrevious.BackColor = Color.FromArgb(244, 63, 94);
        }

        private void btnPrevious_MouseLeave(object sender, EventArgs e)
        {
            btnPrevious.BackColor = Color.FromArgb(30, 41, 59);
        }

        private void btnPause_MouseEnter(object sender, EventArgs e)
        {
            btnPause.BackColor = Color.FromArgb(244, 63, 94);
        }

        private void btnPause_MouseLeave(object sender, EventArgs e)
        {
            btnPause.BackColor = Color.FromArgb(30, 41, 59);
        }

        private void btnPlay_MouseEnter(object sender, EventArgs e)
        {
            btnPlay.BackColor = Color.FromArgb(244, 63, 94);
        }

        private void btnPlay_MouseLeave(object sender, EventArgs e)
        {
            btnPlay.BackColor = Color.FromArgb(30, 41, 59);
        }

        private void btnStop_MouseEnter(object sender, EventArgs e)
        {
            btnStop.BackColor = Color.FromArgb(244, 63, 94);
        }

        private void btnStop_MouseLeave(object sender, EventArgs e)
        {
            btnStop.BackColor = Color.FromArgb(30, 41, 59);
        }

        private void btnNext_MouseEnter(object sender, EventArgs e)
        {
            btnNext.BackColor = Color.FromArgb(244, 63, 94);
        }

        private void btnNext_MouseLeave(object sender, EventArgs e)
        {
            btnNext.BackColor = Color.FromArgb(30, 41, 59);
        }
    }
}
