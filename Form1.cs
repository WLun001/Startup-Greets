using System;
using System.Speech.Synthesis;
using System.Windows.Forms;

namespace Startup_Greets
{
    public partial class Form1 : Form
    {
        private SpeechSynthesizer speak;
        private Timer timer;
        public Form1()
        {
            InitializeComponent();
            speak = new SpeechSynthesizer();
            timer = new Timer();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Opacity = 0;
            this.ShowInTaskbar = false;
            string greets = "";
            DateTime date = new DateTime();
            date = DateTime.Now;
            int hour = date.Hour;

            if (hour >= 0 && hour <= 4)
                greets += "Hello";
            else if (hour >= 5 && hour <= 11)
                greets += "Good Morning";
            else if (hour >= 12 && hour <= 16)
                greets += "Good Afternoon";
            else if (hour >= 17 && hour <= 24)
                greets += "Good Evening";

            string time = "It's " + String.Format(date.ToString("h ") + date.ToString("m tt"));
            string fullSpeech = greets + ". " + time;

            speak.Speak(fullSpeech);
            Application.Exit();
        }
    }
}
