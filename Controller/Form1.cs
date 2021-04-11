using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UnderwaterRover
{
    public partial class Form1 : Form
    {
        IGestionnaireSousMarin gestionnaireSousMarin;
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
    }
}
