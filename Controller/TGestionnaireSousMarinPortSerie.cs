using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using
    System.IO.Ports;

namespace UnderwaterRover
{
    class TGestionnaireSousMarinPortSerie : IGestionnaireSousMarin
    {
        private SerialPort portSerie;

        public TGestionnaireSousMarinPortSerie()
        {
            portSerie = new SerialPort("COM3");
            portSerie.BaudRate = 9600;
            portSerie.Parity = System.IO.Ports.Parity.None;
            portSerie.StopBits = System.IO.Ports.StopBits.One;
            portSerie.DataBits = 8;
            portSerie.RtsEnable = true;
            portSerie.DtrEnable = true;
            portSerie.ReadTimeout = 800;
            portSerie.WriteTimeout = 800;
            portSerie.ReceivedBytesThreshold = 1;
        }
        public void Avancer()
        {
            portSerie.WriteLine("16");
        }

        public void Descendre()
        {
            portSerie.WriteLine("2");
        }

        public void Monter()
        {
            portSerie.WriteLine("1");
        }

        public void Reculer()
        {
            portSerie.WriteLine("32");
        }

        public bool SeConnecter(string pIPSousMarin, int pPort)
        {
            throw new NotImplementedException();
        }

        public void TournerADroite()
        {
            portSerie.WriteLine("8");
        }

        public void TournerAGauche()
        {
            portSerie.WriteLine("4");
        }

        public Boolean EstConnecté()
        {
            return portSerie.IsOpen;
        }
    }
}
