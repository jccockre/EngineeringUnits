﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;

namespace EngineeringUnits
{

    public class LuminousIntensityUnit : Enumeration
    {

        public static readonly LuminousIntensityUnit SI = new LuminousIntensityUnit(PreFix.SI, BaseUnits.luminousIntensity);



        public LuminousIntensityUnit(string symbol, decimal a1, decimal a2) : base(symbol, a1, a2)
        {
            Unit = new UnitSystem();
            Unit.LuminousIntensity = (LuminousIntensityUnit)Clone();

            //Beta
            //Unit.UnitListBeta.Add(this);
        }


        public LuminousIntensityUnit(PreFix SI, BaseUnits baseunit) : base(SI, baseunit)
        {
            Unit = new UnitSystem();
            Unit.LuminousIntensity = (LuminousIntensityUnit)Clone();

            //Beta
            //Unit.UnitListBeta.Add(this);
        }     
       
    }


}