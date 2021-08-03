using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using AForge.Video;
using Accord.Video.FFMPEG;
using System.Drawing.Imaging;

namespace UnderwaterRover
{
    public partial class Form1 : Form
    {
        IGestionnaireSousMarin gestionnaireSousMarin;
        MJPEGStream stream;
        VideoFileWriter fileWriter;

        public Form1()
        {
            InitializeComponent();
            gestionnaireSousMarin = new TGestionnaireSousMarinPortSerie();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            TabTcpIp.SelectedIndex = 2;
        }

        private void BtnUp_Click(object sender, EventArgs e)
        {
            gestionnaireSousMarin.Monter();
        }

        private void BtnDown_Click(object sender, EventArgs e)
        {
            gestionnaireSousMarin.Descendre();
        }

        private void BtnForward_Click(object sender, EventArgs e)
        {
            gestionnaireSousMarin.Avancer();
        }

        private void BtnBackward_Click(object sender, EventArgs e)
        {
            gestionnaireSousMarin.Reculer();
        }

        private void BtnLeft_Click(object sender, EventArgs e)
        {
            gestionnaireSousMarin.TournerAGauche();
        }

        private void BtnRight_Click(object sender, EventArgs e)
        {
            gestionnaireSousMarin.TournerADroite();
        }

        private void BtnTester_Click(object sender, EventArgs e)
        {
            // TODO : à implémenter plus tard
        }

        private void ConnecterSousMarin(object sender, EventArgs e)
        {
            //gestionnaireSousMarin.SeConnecter(TbIpSousMarin.Text, int.Parse(tbPortTcpIp.Text));
        }

        private void BtnTester_Click_1(object sender, EventArgs e)
        {
            
        }

        private void BtnConnexion_Click(object sender, EventArgs e)
        {
            // Créer l'objet de gestion du rover
            gestionnaireSousMarin = new TGestionnaireSousMarinPortSerie();

            // Vérifier que la connexion est établie
            if (!gestionnaireSousMarin.EstConnecté())
            {
                MessageBox.Show("Connexion impossible, recommencez");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Créer l'objet de gestion du rover
            gestionnaireSousMarin = new TGestionnaireSousMarinUDP(TbIpSousMarinUDP.Text);

            // Vérifier que la connexion est établie
            if (!gestionnaireSousMarin.EstConnecté())
            {
                MessageBox.Show("Connexion impossible, recommencez");
            }
        }

        private void BtnConnexion_Click_1(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void VideoStream_NewFrame(object sender, AForge.Video.NewFrameEventArgs eventArgs)
        {
            Bitmap FrameData = new Bitmap(eventArgs.Frame);
            Bitmap clone = (Bitmap)FrameData.Clone();

            pictureBox1.Image = FrameData;

            // Ajouter la nouvelle image à la vidéo finale
            if (fileWriter == null)
            {
                fileWriter = new VideoFileWriter();
                fileWriter.Open("myfile.avi", pictureBox1.Image.Width, pictureBox1.Image.Height, 25, VideoCodec.MPEG4, 1000000);
            }
            fileWriter.WriteVideoFrame(clone);
            clone.Dispose();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            // stream = new MJPEGStream("http://10.20.2.158:8080/?action=stream");
            stream = new MJPEGStream("http://"+TbIpSousMarinUDP.Text+":8080/?action=stream");
            stream.NewFrame += new AForge.Video.NewFrameEventHandler(VideoStream_NewFrame);
            stream.Start();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            stream.Stop();
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            fileWriter.Close();
        }
    }
}
