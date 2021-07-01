﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace EngineeringUnits
{


    public class DynamicViscosityUnit : Enumeration
    {

        public static readonly DynamicViscosityUnit SI =                             new DynamicViscosityUnit(PressureUnit.Pascal, DurationUnit.Second);
        public static readonly DynamicViscosityUnit PascalSecond =                   new DynamicViscosityUnit(PressureUnit.Pascal, DurationUnit.Second);
        public static readonly DynamicViscosityUnit MicropascalSecond =              new DynamicViscosityUnit(PreFix.micro, PascalSecond);
        public static readonly DynamicViscosityUnit MillipascalSecond =              new DynamicViscosityUnit(PreFix.milli, PascalSecond);
        public static readonly DynamicViscosityUnit PoundPerFootSecond =             new DynamicViscosityUnit(MassUnit.Pound, LengthUnit.Foot, DurationUnit.Second);
        public static readonly DynamicViscosityUnit Poise =                          new DynamicViscosityUnit(MassUnit.Gram, LengthUnit.Centimeter, DurationUnit.Second, "P");
        public static readonly DynamicViscosityUnit Centipoise =                     new DynamicViscosityUnit(PreFix.centi, Poise);
        public static readonly DynamicViscosityUnit NewtonSecondPerMeterSquared =    new DynamicViscosityUnit(ForceUnit.Newton, DurationUnit.Second, AreaUnit.SI);
        public static readonly DynamicViscosityUnit PoundForceSecondPerSquareFoot =  new DynamicViscosityUnit(ForceUnit.PoundForce, DurationUnit.Second, AreaUnit.SquareFoot);
        public static readonly DynamicViscosityUnit PoundForceSecondPerSquareInch =  new DynamicViscosityUnit(ForceUnit.PoundForce, DurationUnit.Second, AreaUnit.SquareInch);
        public static readonly DynamicViscosityUnit Reyn =                           new DynamicViscosityUnit(ForceUnit.PoundForce, DurationUnit.Second, AreaUnit.SquareInch, "reyn");



        public DynamicViscosityUnit(PressureUnit Pressure, DurationUnit duration, string NewSymbol = "Empty", decimal correction = 1)
        {

            //Name = "DynamicViscosity";
            Unit = Pressure.Unit * duration.Unit;

            SetCombined(correction);
            SetNewSymbol(NewSymbol);
            SetNewSymbol(NewSymbol, $"{Pressure}·{duration}");



        }

        public DynamicViscosityUnit(ForceUnit force, DurationUnit duration, AreaUnit area, string NewSymbol = "Empty", decimal correction = 1)
        {
            Unit = (force.Unit * duration.Unit) / area.Unit;
            SetCombined(correction);
            SetNewSymbol(NewSymbol, $"{force}·{duration}/{area}");
        }

        public DynamicViscosityUnit(MassUnit mass, LengthUnit length, DurationUnit duration, string NewSymbol = "Empty", decimal correction = 1)
        {
            Unit = mass.Unit /(  duration.Unit * length.Unit);
            SetCombined(correction);
            SetNewSymbol(NewSymbol, $"{mass}/{length}·{duration}");
        }


        public DynamicViscosityUnit(PreFix SI, DynamicViscosityUnit unit)
        {
            Unit = unit.Unit.Copy();
            SetCombined(SI);
            SetNewSymbol(SI);
        }

       


    }




}