using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
    Définit le standard d'une classe permettant l'envoi de commandes vers un sous-marin
*/

namespace UnderwaterRover
{
    interface IGestionnaireSousMarin
    {
        /// <summary>
        /// Ordonne au sous-marin de monter légèrement
        /// </summary>
        public void Monter();

        /// <summary>
        /// Ordonne au sous-marin de descendre légèrement
        /// </summary>
        public void Descendre();

        /// <summary>
        /// Ordonne au sous-marin de tourner légèrement à gauche
        /// </summary>
        public void TournerAGauche();

        /// <summary>
        /// Ordonne au sous-marin de tourner légèrement à droite
        /// </summary>
        public void TournerADroite();

        /// <summary>
        /// Ordonne au sous-marin d'avancer légèrement
        /// </summary>
        public void Avancer();

        /// <summary>
        /// Ordonne au sous-marin de reculer légèrement
        /// </summary>
        public void Reculer();


        /// <summary>
        /// Test si la connexion s'est bien faite avec le rover
        /// </summary>
        /// <returns></returns>
        public Boolean EstConnecté();
    }
}
