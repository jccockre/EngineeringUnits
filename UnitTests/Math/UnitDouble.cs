using EngineeringUnits;
using EngineeringUnits.Units;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;


namespace UnitTests
{
    [TestClass]
    public class UnitDouble
    {

        [TestMethod]
        public void Ratio()
        {
            MassFlow M1 = new MassFlow(1, MassFlowUnit.KilogramPerSecond);
            MassFlow M2 = new MassFlow(4, MassFlowUnit.KilogramPerSecond);
            Temperature T2 = new Temperature(10, TemperatureUnit.DegreeCelsius);
            Temperature T1 = new Temperature(5, TemperatureUnit.DegreeCelsius);

            double Ratio1 = M1 / M2;
            double Ratio2 = M2 / M1;

            double Ratio3 = T2 / T2;
            double Ratio4 = T1 / T2;

            Assert.AreEqual(1/4d, Ratio1);
            Assert.AreEqual(4/1d, Ratio2);
            Assert.AreEqual(1d, Ratio3);
            Assert.AreEqual(T2.SI / T2.SI, Ratio3);

        }



    }
}
