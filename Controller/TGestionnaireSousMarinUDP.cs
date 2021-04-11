using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Sockets;

namespace UnderwaterRover
{
    class TGestionnaireSousMarinUDP : IGestionnaireSousMarin
    {
        private UdpClient _clientUDP;

        public TGestionnaireSousMarinUDP(string pAdressIP)
        {
            _clientUDP = new UdpClient(pAdressIP, 12345);
        }

        public bool EstConnecté()
        {
            return true;
        }

        public void Avancer()
        {
            Byte[] message = { 1 };
            _clientUDP.Send(message, 1);
        }

        public void Descendre()
        {
            Byte[] message = { 32 };
            _clientUDP.Send(message, 1);
        }

        public void Monter()
        {
            Byte[] message = { 16 };
            _clientUDP.Send(message, 1);
        }

        public void Reculer()
        {
            Byte[] message = { 2 };
            _clientUDP.Send(message, 1);
        }

        public void TournerADroite()
        {
            Byte[] message = { 8 }; 
            _clientUDP.Send(message, 1); // 3
        }

        public void TournerAGauche()
        {
            Byte[] message = { 4 };
            _clientUDP.Send(message, 1);
        }
    }
}
