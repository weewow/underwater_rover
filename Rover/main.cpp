#include <iostream>
#include <stdio.h>
#include <sys/types.h>
#include <sys/socket.h>
#include <netinet/in.h>
#include <netdb.h>
#include <cstdlib>
#include <cstring>
#include <unistd.h>
#include <boost/asio.hpp>
#include <boost/array.hpp>
#include <boost/bind.hpp>
#include <wiringPi.h>
#include "Moteur.h"


const int INSTRUCTION_AVANCER = 1;
const int INSTRUCTION_RECULER = 2;
const int INSTRUCTION_TOURNER_GAUCHE = 4;
const int INSTRUCTION_TOURNER_DROITE = 8;
const int INSTRUCTION_MONTER = 16;
const int INSTRUCTION_DESCENDRE = 32;


using namespace boost::asio;

int main()
{
    // Lancement de la librairie wiringPi
    wiringPiSetupGpio();
    // Initialisation des moteurs
    MoteurSimonkFirmware propulseurGauche(18); // gpio18 soit la pin n°12
    MoteurSimonkFirmware propulseurDroite(4); // gpio4 soit la pin n°7
    MoteurSimonkFirmware regleurAssiette(5); // gpio5 soit la pin n°29
    // Réceptions de données
    std::cout << "V3 début de recherche d'instructions" << std::endl << std::flush;
    int instruction;
    // A chaque tour il faut dire à tous les moteurs quoi faire
    // On calcul donc l'intensité avec laquelle ils doivent tourner en fonction de l'instruction reçue
    while(1)
    {

    /*int j;
    propulseurGauche.Actionner(0);
            delay(10000);
    propulseurGauche.Actionner(250);
            delay(1000);
        for(j=677; j<800; j++)
        {
            propulseurGauche.Actionner(j);
            delay(500);
        }*/

        int intensitePropulseurGauche(0);
        int intensitePropulseurDroite(0);
        int intensiteRegleurAssiette(0);
        //
        boost::asio::io_service io_service;
        ip::udp::endpoint endpoint(ip::udp::v4(), 12345);
        ip::udp::socket socketUDP(io_service, endpoint);
        boost::array<char, 1024> bufferReception;
        std::cout << "attente..." << std::endl << std::flush;
        int ret = socketUDP.receive(boost::asio::buffer(bufferReception));
        // // On a quelque chose à faire
        if (ret > 0)
        {
            std::string donnees(bufferReception.data(), ret);
            instruction = static_cast<int>(donnees[0]);
            //
            std::cout << ret << " caractères;  reçu : **" << instruction << "**" << std::endl << std::flush;
            // Déterminer l'instruction à envoyer à chaque moteur
            if (instruction && INSTRUCTION_AVANCER)
            {
                intensitePropulseurGauche+=250;
                intensitePropulseurDroite+=250;
                intensiteRegleurAssiette+=0;
            }
            if (instruction && INSTRUCTION_RECULER)
            {
                intensitePropulseurGauche+=0;
                intensitePropulseurDroite+=0;
                intensiteRegleurAssiette+=0;
            }
            if (instruction && INSTRUCTION_TOURNER_GAUCHE)
            {
                intensitePropulseurGauche-=250;
                intensitePropulseurDroite+=250;
                intensiteRegleurAssiette+=0;
            }
            if (instruction && INSTRUCTION_TOURNER_DROITE)
            {
                intensitePropulseurGauche+=250;
                intensitePropulseurDroite-=250;
                intensiteRegleurAssiette+=0;
            }
            if (instruction && INSTRUCTION_MONTER)
            {
                intensitePropulseurGauche+=0;
                intensitePropulseurDroite+=0;
                intensiteRegleurAssiette+=250;
            }
            if (instruction && INSTRUCTION_DESCENDRE)
            {
                intensitePropulseurGauche+=0;
                intensitePropulseurDroite+=0;
                intensiteRegleurAssiette+=0;
            }
            // Nettoyage des valeurs de commande
            intensitePropulseurGauche = intensitePropulseurGauche < 0 ? 0 : intensitePropulseurGauche;
            intensitePropulseurGauche = intensitePropulseurGauche > 500 ? 500 : intensitePropulseurGauche;
            intensitePropulseurDroite = intensitePropulseurDroite < 0 ? 0 : intensitePropulseurDroite;
            intensitePropulseurDroite = intensitePropulseurDroite > 500 ? 500 : intensitePropulseurDroite;
            intensiteRegleurAssiette = intensiteRegleurAssiette < 0 ? 0 : intensiteRegleurAssiette;
            intensiteRegleurAssiette = intensiteRegleurAssiette > 500 ? 500 : intensiteRegleurAssiette;
            // Activer les moteurs
            propulseurGauche.Actionner(intensitePropulseurGauche);
            propulseurDroite.Actionner(intensitePropulseurDroite);
            regleurAssiette.Actionner(intensiteRegleurAssiette);
            // Préparer l'itération suivante
            intensitePropulseurGauche = 0;
            intensitePropulseurDroite = 0;
            intensiteRegleurAssiette = 0;
        }else // Rien à faire, on met donc les moteurs à l'arrêt
        {
            propulseurGauche.Actionner(0);
            propulseurDroite.Actionner(0);
            regleurAssiette.Actionner(0);
        }
    }
    //
    return 0;
}
