using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
    Définit l'implémentation d'une classe permettant l'envoi de commandes vers un sous-marin
    Les commandes sont envoyées via une connexion TCP/IP
*/

namespace UnderwaterRover
{
    class TGestionnaireSousMarinTCP : IGestionnaireSousMarin
    {
        private System.Net.Sockets.TcpClient tcpClient;
        public void Avancer()
        {
            byte[] trame = System.Text.Encoding.ASCII.GetBytes("Avancer");
            tcpClient.GetStream().Write(trame, 0, trame.Length);
        }

        public void Descendre()
        {
            byte[] trame = System.Text.Encoding.ASCII.GetBytes("Descendre");
            tcpClient.GetStream().Write(trame, 0, trame.Length);
        }

        public bool EstConnecté()
        {
            throw new NotImplementedException();
        }

        public void Monter()
        {
            byte[] trame = System.Text.Encoding.ASCII.GetBytes("Monter");
            tcpClient.GetStream().Write(trame, 0, trame.Length);
        }

        public void Reculer()
        {
            byte[] trame = System.Text.Encoding.ASCII.GetBytes("Reculer");
            tcpClient.GetStream().Write(trame, 0, trame.Length);
        }

        public bool SeConnecter(string pIPSousMarin, int pPort)
        {
            tcpClient = new System.Net.Sockets.TcpClient(pIPSousMarin, pPort);
            //
            return tcpClient.Connected;
        }

        public void TournerADroite()
        {
            byte[] trame = System.Text.Encoding.ASCII.GetBytes("TournerADroite");
            tcpClient.GetStream().Write(trame, 0, trame.Length);
        }

        public void TournerAGauche()
        {
            byte[] trame = System.Text.Encoding.ASCII.GetBytes("tournerAGauche");
            tcpClient.GetStream().Write(trame, 0, trame.Length);
        }
    }
}
