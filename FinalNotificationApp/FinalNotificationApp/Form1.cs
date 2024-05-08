using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;

namespace FinalNotificationApp
{
    public partial class Form1 : Form
    {
        TimerManager timerManager;
        int h, m, s;
        int toastCounter = 0;
        string[] randomMessages = { "Ini adalah pesan acak 1", "Ini adalah pesan acak 2", "Ini adalah pesan acak 3", "Ini adalah pesan acak 4" };

        public Form1()
        {
            InitializeComponent();
            timerManager = new TimerManager();
            timerManager.Elapsed += OnTimeEvent;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Jangan berhenti timer saat form ditutup
            e.Cancel = true;
            this.Hide();
        }

        private void ShowToast(string type, string message)
        {
            ToastForms toast = new ToastForms(type, message);
            toast.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timerManager.Start();
        }

        private void OnTimeEvent(object sender, EventArgs e)
        {
            // Logika waktu di sini
            // Pastikan Anda memanggil Invoke jika Anda perlu mengakses UI dari luar thread UI.
            Invoke(new Action(() =>
            {
                s += 1;
                if (s == 60)
                {
                    s = 0;
                    m += 1;
                }
                if (m == 60)
                {
                    m = 0;
                    h += 1;
                }

                toastCounter++;

                if (toastCounter == 10)
                {
                    Random rnd = new Random();
                    int index = rnd.Next(randomMessages.Length);
                    string randomMessage = randomMessages[index];

                    ShowToast("Daily Reminder", randomMessage);
                    toastCounter = 0;
                    SoundPlayer player = new SoundPlayer();
                    player.SoundLocation = @"C:\Users\atbiw\Downloads\mixkit-software-interface-start-2574.wav";
                    player.Stop();
                    player.Play();
                }

                if (s == 60)
                {
                    h = 0;
                    m = 0;
                    s = 0;
                }

                textResult.Text = string.Format("{0}:{1}:{2}", h.ToString().PadLeft(2, '0'), m.ToString().PadLeft(2, '0'), s.ToString().PadLeft(2, '0'));
            }));
        }
    }

    public class TimerManager
    {
        private System.Timers.Timer timer;

        public event EventHandler Elapsed;

        public TimerManager()
        {
            timer = new System.Timers.Timer();
            timer.Interval = 1000; // Satuan waktu dalam milidetik
            timer.Elapsed += Timer_Elapsed;
        }

        private void Timer_Elapsed(object sender, ElapsedEventArgs e)
        {
            Elapsed?.Invoke(sender, e);
        }

        public void Start()
        {
            timer.Start();
        }

        public void Stop()
        {
            timer.Stop();
        }
    }
}
