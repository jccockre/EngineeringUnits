using EngineeringUnits;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Diagnostics;
using UnitsNet;
using System.Linq;
using Newtonsoft.Json;
using System.Collections.Generic;
using EngineeringUnits.Units;

namespace UnitTests
{
    [TestClass]
    public class ElectricPotentialAcTest
    {



        [TestMethod]
        public void ElectricPotentialAcAutoTest()
        {
            var A1 = new UnitsNet.ElectricPotentialAc(1, UnitsNet.Units.ElectricPotentialAcUnit.MicrovoltAc);
            var A2 = new EngineeringUnits.ElectricPotentialAc(1, ElectricPotentialUnit.Microvolt);

            int WorkingCompares = 0;


            foreach (var EU in Enumeration.ListOf<ElectricPotentialUnit>())
            {


                double Error = 1E-5;
                double RelError = 1E-5;

                var UNList = UnitsNet.ElectricPotentialAc.Units.Where(x => x.ToString() == EU.QuantityName + "Ac");


                if (UNList.Count() == 1)
                {
                    var UN = UNList.Single();

                    //if (UN == UnitsNet.Units.ElectricPotentialAcUnit.SquareMicrometer) Error = 2629720.0009765625;


                    Debug.Print($"");
                    Debug.Print($"UnitsNets:       {UN} {A1.As(UN)}");
                    Debug.Print($"EngineeringUnit: {EU.QuantityName} {A2.As(EU)}");
                    Debug.Print($"ABS:    {A2.As(EU) - A1.As(UN):F6}");
                    Debug.Print($"REF[%]: {HelperClass.Percent(A2.As(EU), A1.As(UN)):P6}");

                    //All units absolute difference
                    Assert.AreEqual(0, A2.As(EU) - A1.As(UN), Error);

                    //All units relative difference
                    Assert.AreEqual(0, HelperClass.Percent(A2.As(EU),
                                                            A1.As(UN)),
                                                            RelError);
                    //All units symbol compare
                    Assert.AreEqual(A2.ToUnit(EU).DisplaySymbol(),
                                    A1.ToUnit(UN).ToString("a")
                                    
                                    .Replace("ac","")
                                    );

                    WorkingCompares++;

                }

            }

            //Number of comparables units
            Assert.AreEqual(5, WorkingCompares);

        }
    }
}