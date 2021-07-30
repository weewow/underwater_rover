#include "Moteur.h"
#include <wiringPi.h>
#include <iostream>
#include <stdio.h>

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
    Actionner(0);
}

/*
    Utiliser les valeursz comprises entre 250 et 500 ou bien la valeur 0 (pour arrêter le moteur)
*/
void MoteurSimonkFirmware::Actionner(unsigned int pIntensite)
{
    std::cout << "moteur : " << Getm_PinNumber() << "    intensité : " << pIntensite << std::endl << std::flush;
    pwmWrite(Getm_PinNumber(), pIntensite);
}

