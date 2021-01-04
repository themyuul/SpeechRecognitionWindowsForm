using System;
using System.Globalization;
using System.Speech.Recognition;
using System.Windows.Forms;

namespace SpeechRecognitionWindowsForm
{
    public partial class Form1 : Form
    {
        SpeechRecognitionEngine recognizer;
        public Form1()
        {
            InitializeComponent();
        }

        private void BTNListen_Click(object sender, EventArgs e)
        {            
            CultureInfo cultureInfo = new CultureInfo("en-US");
            recognizer = new SpeechRecognitionEngine(cultureInfo);
            recognizer.LoadGrammar(new DictationGrammar());
            recognizer.SpeechRecognized += new EventHandler<SpeechRecognizedEventArgs>(SpeechRecognized);
            recognizer.SetInputToDefaultAudioDevice();
            recognizer.RecognizeAsync(RecognizeMode.Multiple);
        }

        private void SpeechRecognized(object sender, SpeechRecognizedEventArgs e)
        {
            TXTOutput.Text += "\r\n" + e.Result.Text;
        }

        private void BTNStopListening_Click(object sender, EventArgs e)
        {
            recognizer.RecognizeAsyncStop();
        }

        private void BTNClear_Click(object sender, EventArgs e)
        {
            TXTOutput.Text = string.Empty;
        }
    }
}