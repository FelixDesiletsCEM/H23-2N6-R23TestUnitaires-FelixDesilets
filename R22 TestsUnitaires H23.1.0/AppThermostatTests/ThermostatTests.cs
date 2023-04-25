using Thermostat;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Thermostat.Tests
{
    [TestClass()]
    public class ThermostatTests
    {

        #region TESTS PROPRIÉTÉ Temperature
		/// <summary>
        /// Tester l'accesseur GET avec la température initiale
        /// </summary>
        [TestMethod()]
        public void TemperatureGetCasTempInitRetourTempInitTest()
        {
            // Arranger (Arrange)
            Thermostat objThermostat = new Thermostat(Thermostat.TEMPERATURE_INITIALE);
            // Agir (Act)
            int valeurRetournee = objThermostat.Temperature;
            // Auditer (Assert)
            int ValeurAttendue = Thermostat.TEMPERATURE_INITIALE;
            Assert.AreEqual(ValeurAttendue, valeurRetournee);
        }
        /// <summary>
        /// Tester l'accesseur GET avec la température minimale
        /// </summary>
        [TestMethod()]
        public void TemperatureGetCasAuLimiteMinRetourLimiteMinTest()
        {
            // Arranger (Arrange)
            Thermostat objThermostat = new Thermostat(Thermostat.MIN_TEMPERATURE);
            // Agir (Act)
            int valeurRetournee = objThermostat.Temperature;

            // Auditer (Assert)
            int ValeurAttendue = Thermostat.MIN_TEMPERATURE;

            Assert.AreEqual(ValeurAttendue, valeurRetournee);


        }
        /// <summary>
        /// Tester l'accesseur GET avec la température maximale
        /// </summary>

        [TestMethod()]
        public void TemperatureGetCasAuLimiteMaxRetourLimiteMaxTest()
        {
            // Arranger (Arrange)
            Thermostat objThermostat = new Thermostat(Thermostat.MAX_TEMPERATURE);
            // Agir (Act)
            int valeurRetournee = objThermostat.Temperature;


            // Auditer
            int ValeurAttendue = Thermostat.MAX_TEMPERATURE;

            Assert.AreEqual(ValeurAttendue, valeurRetournee);


        }
        /// <summary>
        /// TODO 01 : Tester l'accesseur SET avec une température valide (15)
        /// </summary>

        public void TemperatureSetCasTempInitRetourTempInitTest()
        {
            // À Compléter
            // ....
            Thermostat objThermostat = new Thermostat();
            objThermostat.Temperature = 15;
            Assert.AreEqual(15, objThermostat.Temperature);


        }
        /// <summary>
        /// TODO 02 : Tester  l'accesseur SET avec la température minimale
        /// </summary>
      
        public void TemperatureSetCasAuLimiteMinRetourLimiteMinTest()
        {
            // À Compléter
            // ....
            Thermostat objThermostat = new Thermostat();
            objThermostat.Temperature = Thermostat.MIN_TEMPERATURE;
            Assert.AreEqual(Thermostat.MIN_TEMPERATURE, objThermostat.Temperature);

        }
        /// <summary>
        /// TODO 03 : Tester  l'accesseur SET avec la température maximale
        /// </summary>
 
        public void TemperatureSetCasAuLimiteMaxRetourLimiteMaxTest()
        {
            // À Compléter
            // ....
            Thermostat objThermostat = new Thermostat();
            objThermostat.Temperature = Thermostat.MAX_TEMPERATURE;
            Assert.AreEqual(Thermostat.MAX_TEMPERATURE, objThermostat.Temperature);

        }
        /// <summary>
        /// TODO 04 : Tester  l'accesseur SET  avec une température en dessous de la température minimale
        /// Dans ce cas, le comportement normal de  l'accesseur SET  est de lever une exception de type ArgumentOutOfRangeException
        /// La vérification de ce comportement sera assurée par l'annotation [ExpectedException(typeof(ArgumentOutOfRangeException))]
        /// </summary>
        [TestMethod()]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TemperatureSetCasHorsLimiteMinMoinsUnRetourExceptionTest()
        {

            // À Compléter
            // ....
            Thermostat objThermostat = new Thermostat();
            objThermostat.Temperature = Thermostat.MIN_TEMPERATURE - 1;

            // Auditer (Assert)
            // ArgumentOutOfRangeException attendue intercepté au niveau de l'annotation  [ExpectedException(typeof(ArgumentOutOfRangeException))]

        }
        /// <summary>
        /// TODO 05 : Tester  l'accesseur SET avec une température au dessus de la température maximale
        /// Dans ce cas, le comprtement normal de l'accesseur SET  est de lever une exception de type ArgumentOutOfRangeException
        /// </summary>

        [TestMethod()]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TemperatureSetCasHorsLimiteMaxPlusUnRetourExceptionTest()
        {
            // À Compléter
            // ....
            Thermostat objThermostat = new Thermostat();
            objThermostat.Temperature = Thermostat.MAX_TEMPERATURE + 1;
        }
        #endregion
        #region TESTS CONSTRUCTEUR AVEC PARAMÈTRE
        /// <summary>
        /// TODO 06 : Tester le constructeur à un seul paramètre avec une valeur valide
        /// </summary>
    
        public void ConstrAvecParamCasTempInitRetourTempInitTest()
        {
            // À Compléter
            // ....


        }
        /// <summary>
        /// TODO 07 : Tester le constructeur à un seul paramètre avec la température minimale
        /// </summary>
      
        public void ConstrAvecParamCasAuLimiteMinRetourLimiteMinTest()
        {
            // À Compléter
            // ....

        }
        /// <summary>
        /// TODO 08 : Tester le constructeur à un seul paramètre avec la température maximale
        /// </summary>
   
        public void ConstrAvecParamCasAuLimiteMaxRetourLimiteMaxTest()
        {

            // À Compléter
            // ....

        }
        /// <summary>
        /// TODO 09 : Tester le constructeur à un seul paramètre avec une température en dessous de la température minimale
        /// Dans ce cas, le comportement normal ici est de lever une exception de type ArgumentOutOfRangeException
         /// </summary>
        public void ConstrAvecParamCasHorsLimiteMinMoinsUnRetourExceptionTest()
        {
            
        }
        /// <summary>
        /// TODO 10 : Tester le constructeur à un seul paramètre avec une température au dessus de la température maximale
        /// Dans ce cas, le comportement normal ici est de lever une exception de type ArgumentOutOfRangeException
        /// </summary>
        public void ConstrAvecParamCasHorsLimiteMaxPlusUnRetourExceptionTest()
        {

            // À Compléter
            // ....
        }
        #endregion


        #region TESTS MÉTHODE AugmenterTemperature
        // TODO 11 : Identifier 3 cas de tests pour la méthode AugmenterTemperature et définir les méthodes de tests nécessaires
        // À Compléter
        // .... 

        #endregion
        #region TESTS MÉTHODE DiminuerTemperature
        // TODO 12 : Identifier 3 cas de tests pour la méthode DiminuerTemperature et définir les méthodes de tests nécessaires
        // À Compléter
        // .... 


        #endregion

        
    }
}