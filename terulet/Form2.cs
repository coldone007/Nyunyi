using System;
using System.IO;
using System.Windows.Forms;

namespace terulet
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            this.TopMost = true;

            var file = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "pedro_meme.mp4");

            try
            {
                // ResourceName = the resource you want to play
                File.WriteAllBytes(file, Properties.Resources.pedro_meme);
                axWindowsMediaPlayer1.uiMode = "none";
                axWindowsMediaPlayer1.URL = file;
                axWindowsMediaPlayer1.Ctlcontrols.play();

            }
            catch (Exception ex)
            {

                // Manage me
                MessageBox.Show(ex.Message);
            }
        }
        private void axWindowsMediaPlayer1_PlayStateChange(object sender, AxWMPLib._WMPOCXEvents_PlayStateChangeEvent e)
        {
            // 8 = vidoe stopped
            if (e.newState == 8)
            {
                Dispose();
            }
        }
    }
}
