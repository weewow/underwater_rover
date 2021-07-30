#ifndef MOTEUR_H
#define MOTEUR_H

#include <wiringPi.h>

class AbstractMotor
{
    private:
        unsigned int m_PinNumber;
    public:
        AbstractMotor(unsigned int pPinNumber) : m_PinNumber(pPinNumber)
        {
            pinMode(Getm_PinNumber(), PWM_OUTPUT);
            pwmSetMode(PWM_MODE_MS);
        }
        unsigned int Getm_PinNumber() { return m_PinNumber; }
        virtual void armerESC() = 0; // Envoyer le signal de calibrage à l'ESC
        virtual void Actionner(unsigned int pIntensite) =0; // Faire tourner le moteur
};

// Moteur dirigé par un ESC avec le firmware Simonk
// Le signal PWM à 0 permet d'initialiser l'ESC
// La valeur minimale pour faire tourner le moteur est 250
// la valeur max est ...
// Le moteur ne peut tourner que dans un sens
class MoteurSimonkFirmware : AbstractMotor
{
    public:
        MoteurSimonkFirmware(unsigned int pPinNumber);
        virtual ~MoteurSimonkFirmware();
        //
        virtual void armerESC();
        virtual void Actionner(unsigned int pIntensite);
};

#endif // MOTEUR_H
