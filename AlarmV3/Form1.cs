using System.Media;
using System.IO;
using NAudio.Wave;

namespace AlarmV3
{
    public partial class Form1 : Form
    {
        private string alarmSesiDosyaYolu;
        private bool alarmCalisiyor = false;
        private bool alarmZamaninda = false;
        private IWavePlayer wavePlayer;
        private AudioFileReader audioFileReader;
        private WaveStream mp3Stream;
        private TimeSpan kalanSure;
        private int ertelemeSure;
    
        

        public Form1()
        {
            InitializeComponent();
            wavePlayer = new WaveOutEvent();
            trackBarSes.Value = (int)(wavePlayer.Volume * trackBarSes.Maximum);

            kalanSureTimer.Interval = 1000;

            kalanSureTimer.Start();
        }
        private void Form1_Load(object sender, System.EventArgs e)
        {

        }

        private void alarmTimer_Tick(object sender, EventArgs e)
        {

            alarmTimer.Stop();


            if (File.Exists(alarmSesiDosyaYolu))
            {
                if (wavePlayer.PlaybackState == PlaybackState.Playing)
                {
                    wavePlayer.Stop();
                    wavePlayer.Dispose();
                    wavePlayer = new WaveOut();
                }

                try
                {
                    Mp3FileReader mp3Stream = new Mp3FileReader(alarmSesiDosyaYolu);
                    wavePlayer.Init(mp3Stream);
                    wavePlayer.Play();
                    alarmZamaninda = true;
                    btnDurdur.Enabled = true;
                    btnErtele.Enabled = true;
                    alarmButonTimer.Interval = 60000;
                    alarmButonTimer.Start();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Alarm sesini �alarken bir hata olu�tu: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Alarm sesi dosyas� bulunamad�.");
            }
        }

        private void alarmButonTimer_Tick(object sender, EventArgs e)
        {

            if (!alarmZamaninda)
            {

                btnDurdur.Enabled = false;
                btnErtele.Enabled = false;
            }
            else
            {

                btnDurdur.Enabled = true;
                btnErtele.Enabled = true;
            }
        }

        private void btnSesSec_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            openFileDialog.Filter = "MP3 Dosyalar�|*.mp3";
            openFileDialog.Title = "Alarm Sesini Se�";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                alarmSesiDosyaYolu = openFileDialog.FileName;
                MessageBox.Show("Alarm sesi ba�ar�yla se�ildi.");
            }
        }

        private void btnAlarmKur_Click(object sender, EventArgs e)
        {
            try
            {
                if (!alarmCalisiyor && !string.IsNullOrEmpty(alarmSesiDosyaYolu))
                {
                    TimeSpan alarmZamani = dateTimePicker1.Value.TimeOfDay;
                    TimeSpan simdikiZaman = DateTime.Now.TimeOfDay;

                    int kalanSure = (int)(alarmZamani.TotalMilliseconds - simdikiZaman.TotalMilliseconds);
                    alarmTimer.Interval = kalanSure;
                    alarmTimer.Start();

                    MessageBox.Show("Alarm ba�ar�yla kuruldu.");

                    alarmCalisiyor = true;



                }
                else
                {
                    MessageBox.Show("L�tfen �nce alarm sesini se�in veya zaten bir alarm kurulmu� olabilir.");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Alarm kuraca��n�z tarihi ge�mi� tarih se�medi�inizden emin olun");
            }


        }

        private void btnDurdur_Click(object sender, EventArgs e)
        {
            alarmTimer.Stop();
            alarmButonTimer.Stop();
            wavePlayer.Stop();
            audioFileReader?.Dispose();
            MessageBox.Show("Alarm durduruldu.");
            alarmCalisiyor = false;
            alarmZamaninda = false;
        }

        private void btnErtele_Click(object sender, EventArgs e)
        {
            if (alarmCalisiyor)
            {

                TimeSpan ertelemeSuresi = TimeSpan.FromMinutes(Convert.ToInt32(textBox1.Text));
                alarmTimer.Interval = (int)ertelemeSuresi.TotalMilliseconds;
                alarmTimer.Start();
                ertelemeSure = (int)ertelemeSuresi.TotalMinutes;
                
                kalanSure = kalanSure.Add(new TimeSpan(0, ertelemeSure, 0));

                
                label1.Text = $"Kalan S�re: {kalanSure.ToString(@"hh\:mm\:ss")}";

                wavePlayer.Stop();
                alarmButonTimer.Stop();
                btnDurdur.Enabled = true;
                btnErtele.Enabled = false;
                kalanSureTimer.Stop();
                MessageBox.Show("Alarm " + textBox1.Text.ToString() + " dakika ertelendi.");

            }
            else
            {
                MessageBox.Show("�u anda herhangi bir alarm �al��m�yor.");
            }
        }

        private void trackBarSes_Scroll(object sender, EventArgs e)
        {

            float sesSeviyesi = (float)trackBarSes.Value / trackBarSes.Maximum;
            wavePlayer.Volume = sesSeviyesi;
        }

        private void kalanSureTimer_Tick(object sender, EventArgs e)
        {
            
            kalanSure = dateTimePicker1.Value - DateTime.Now;

           
            if (kalanSure.TotalSeconds <= 0)
            {
                label1.Text = "---";
                return;
            }

            label1.Text = $"Kalan S�re: {kalanSure.ToString(@"hh\:mm\:ss")}";
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
          
        }
    }
}
