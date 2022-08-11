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
const int MAX_ECART_ACCELERATION_MOTEUR = 6;
const int BORNE_MIN_ACCELERATION_MOTEUR = 89;
const int NEUTRE_ACCELERATION_MOTEUR = 111;
const int BORNE_MAX_ACCELERATION_MOTEUR = 128;


using namespace boost::asio;

int main()
{
    std::cout << "dunderwater rover V2" << std::endl << std::flush;
    // Lancement de la librairie wiringPi
    wiringPiSetupGpio();
    // Initialisation des moteurs
    MoteurBidirectionnelZMA propulseurGauche(18); // gpio18 soit la pin n°12





    // TODO : La gestion d'un seul moteur fonctionne mais pas de plusieurs moteurs simultanés


    //MoteurBidirectionnelZMA propulseurDroite(4); // gpio4 soit la pin n°7
    //MoteurBidirectionnelZMA regleurAssiette(5); // gpio5 soit la pin n°29

    /*while(1)
    {
        for (int i=89; i<200; i+=1){
            propulseurGauche.Actionner(i);
            sleep(1);
        }
    }*/


    // Réceptions de données
    std::cout << "début de recherche d'instructions" << std::endl << std::flush;
    int instruction;
    // A chaque tour il faut dire à tous les moteurs quoi faire
    // On calcul donc l'intensité avec laquelle ils doivent tourner en fonction de l'instruction reçue
    while(1)
    {
        int intensitePropulseurGauche(NEUTRE_ACCELERATION_MOTEUR);
        int intensitePropulseurDroite(NEUTRE_ACCELERATION_MOTEUR);
        int intensiteRegleurAssiette(NEUTRE_ACCELERATION_MOTEUR);
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
            if (instruction & INSTRUCTION_AVANCER)
            {
                intensitePropulseurGauche+=MAX_ECART_ACCELERATION_MOTEUR;
                intensitePropulseurDroite+=MAX_ECART_ACCELERATION_MOTEUR;
                intensiteRegleurAssiette+=0;
            }
            if (instruction & INSTRUCTION_RECULER)
            {
                intensitePropulseurGauche+=0;
                intensitePropulseurDroite+=0;
                intensiteRegleurAssiette+=0;
            }
            if (instruction & INSTRUCTION_TOURNER_GAUCHE)
            {
                intensitePropulseurGauche-=MAX_ECART_ACCELERATION_MOTEUR;
                intensitePropulseurDroite+=MAX_ECART_ACCELERATION_MOTEUR;
                intensiteRegleurAssiette+=0;
            }
            if (instruction & INSTRUCTION_TOURNER_DROITE)
            {
                intensitePropulseurGauche+=MAX_ECART_ACCELERATION_MOTEUR;
                intensitePropulseurDroite-=MAX_ECART_ACCELERATION_MOTEUR;
                intensiteRegleurAssiette+=0;
            }
            if (instruction & INSTRUCTION_MONTER)
            {
                intensitePropulseurGauche+=0;
                intensitePropulseurDroite+=0;
                intensiteRegleurAssiette+=MAX_ECART_ACCELERATION_MOTEUR;
            }
            if (instruction & INSTRUCTION_DESCENDRE)
            {
                intensitePropulseurGauche+=0;
                intensitePropulseurDroite+=0;
                intensiteRegleurAssiette+=0;
            }
            // Nettoyage des valeurs de commande
            intensitePropulseurGauche = intensitePropulseurGauche < BORNE_MIN_ACCELERATION_MOTEUR ? BORNE_MIN_ACCELERATION_MOTEUR : intensitePropulseurGauche;
            intensitePropulseurGauche = intensitePropulseurGauche > BORNE_MAX_ACCELERATION_MOTEUR ? BORNE_MAX_ACCELERATION_MOTEUR : intensitePropulseurGauche;
            intensitePropulseurDroite = intensitePropulseurDroite < BORNE_MIN_ACCELERATION_MOTEUR ? BORNE_MIN_ACCELERATION_MOTEUR : intensitePropulseurDroite;
            intensitePropulseurDroite = intensitePropulseurDroite > BORNE_MAX_ACCELERATION_MOTEUR ? BORNE_MAX_ACCELERATION_MOTEUR : intensitePropulseurDroite;
            intensiteRegleurAssiette = intensiteRegleurAssiette < BORNE_MIN_ACCELERATION_MOTEUR ? BORNE_MIN_ACCELERATION_MOTEUR : intensiteRegleurAssiette;
            intensiteRegleurAssiette = intensiteRegleurAssiette > BORNE_MAX_ACCELERATION_MOTEUR ? BORNE_MAX_ACCELERATION_MOTEUR : intensiteRegleurAssiette;
            // Activer les moteurs
            propulseurGauche.Actionner(intensitePropulseurGauche);
            sleep(1);
            /*propulseurDroite.Actionner(intensitePropulseurDroite);
            sleep(1);
            regleurAssiette.Actionner(intensiteRegleurAssiette);
            sleep(1);*/
            // Préparer l'itération suivante
            intensitePropulseurGauche = NEUTRE_ACCELERATION_MOTEUR;
            intensitePropulseurDroite = NEUTRE_ACCELERATION_MOTEUR;
            intensiteRegleurAssiette = NEUTRE_ACCELERATION_MOTEUR;
        }else // Rien à faire, on met donc les moteurs à l'arrêt
        {
            propulseurGauche.Actionner(NEUTRE_ACCELERATION_MOTEUR);
            //propulseurDroite.Actionner(NEUTRE_ACCELERATION_MOTEUR);
            //regleurAssiette.Actionner(NEUTRE_ACCELERATION_MOTEUR);
        }
    }
    //
    return 0;
}
