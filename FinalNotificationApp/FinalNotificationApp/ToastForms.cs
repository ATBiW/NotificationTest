using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalNotificationApp
{
    public partial class ToastForms : Form
    {
        int toastX, toastY;
        public ToastForms(string type, string message)
        {
            InitializeComponent();
            lblType.Text = type;
            lblMessage.Text = message;

            switch (type)
            {
                case "Jangan Lupa Makan :)":
                    toastBorder.BackColor = Color.FromArgb(252, 65, 0);
                    picIcon.Image = Properties.Resources.information_button;
                    break;
                case "ERROR":
                    toastBorder.BackColor = Color.FromArgb(255, 197, 90);
                    picIcon.Image = Properties.Resources.information_button;
                    break;
                case "Daily Reminder":
                    toastBorder.BackColor = Color.FromArgb(0, 33, 94);
                    picIcon.Image = Properties.Resources.information_button;
                    break;
            }
        }

        private void toastTimer_Tick(object sender, EventArgs e)
        {
            toastY -= 1;
            this.Location = new Point(toastX, toastY);
            if (toastY <= 760)
            {
                toastTimer.Stop();
                toastHide.Start();
            }
        }
        int y = 100;
        private void toastHide_Tick(object sender, EventArgs e)
        {
            y--;
            if (y <= 0)
            {
                toastY += 1;
                this.Location = new Point(toastX, toastY += 10);
                if (toastY > 800)
                {
                    toastHide.Stop();
                    y = 100;
                    this.Close();
                }
            }
        }
        private void Position()
        {
            int ScreenWidth = Screen.PrimaryScreen.WorkingArea.Width;
            int ScreenHeight = Screen.PrimaryScreen.WorkingArea.Height;

            toastX = ScreenWidth - this.Width - 5;
            toastY = ScreenHeight - this.Height - 5;

            this.Location = new Point(toastX, toastY);

        }

        private void ToastForms_Load(object sender, EventArgs e)
        {
            Position();
        }
    }
}
