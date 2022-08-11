#include "Moteur.h"
#include <wiringPi.h>
#include <iostream>
#include <stdio.h>
#include <unistd.h>

MoteurSimonkFirmware::MoteurSimonkFirmware(unsigned int pPinNumber) :
    AbstractMotor(pPinNumber)
{
    armerESC();
}

/*
    A la destruction de l'objet, arrêter le moteur
*/
MoteurSimonkFirmware::~MoteurSimonkFirmware()
{
    Actionner(0);
}

void MoteurSimonkFirmware::armerESC()
{
    for (int i=0; i<400; i++)
        Actionner(i);
}

/*
    Utiliser les valeursz comprises entre 250 et 500 ou bien la valeur 0 (pour arrêter le moteur)
*/
void MoteurSimonkFirmware::Actionner(unsigned int pIntensite)
{
    std::cout << "MoteurSimonkFirmware : " << Getm_PinNumber() << "    intensité : " << pIntensite << std::endl << std::flush;
    pwmWrite(Getm_PinNumber(), pIntensite);
}

/*
    Envoyer 2 pour armer
    111 = moteur arrêté
    123 max dans un sens
    89 min dans l'autre'
*/
MoteurBidirectionnelZMA::MoteurBidirectionnelZMA(unsigned int pPinNumber) :
    AbstractMotor(pPinNumber)
{
    armerESC();
}

/*
    A la destruction de l'objet, arrêter le moteur
*/
MoteurBidirectionnelZMA::~MoteurBidirectionnelZMA()
{
    Actionner(111);
}

void MoteurBidirectionnelZMA::armerESC()
{

    //180 pdt 2S -> 767 pdt 1S
    //on peut faire tourner le moteur avec la valeur 767 et au dessus
    //Actionner(767); // utiliser 767 pendant 2 secondes fonctionne

    // Utiliser 180 fonctionne
    /*Actionner(180);
    sleep(2);
    Actionner(59);
    sleep(0.5);
    Actionner(89);
    sleep(0.5);*/

    Actionner(180);
    sleep(2);
    Actionner(59);
    sleep(0.5);
    Actionner(89);
    sleep(0.1);
}

/*
    Utiliser les valeurs comprises entre 104 et 118 ou bien la valeur 111 (pour arrêter le moteur)
*/
void MoteurBidirectionnelZMA::Actionner(unsigned int pIntensite)
{
    std::cout << "MoteurBidirectionnelZMA : " << Getm_PinNumber() << "    intensité : " << pIntensite << std::endl << std::flush;
    pwmWrite(Getm_PinNumber(), pIntensite);
}

