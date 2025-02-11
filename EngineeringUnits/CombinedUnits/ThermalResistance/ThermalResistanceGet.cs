﻿using EngineeringUnits.Units;
using System.Collections.Generic;
using System.Text;

namespace EngineeringUnits
{
    public partial class ThermalResistance
    {

        /// <summary>
        ///     Get ThermalResistance in HourSquareFeetDegreesFahrenheitPerBtu.
        /// </summary>
        public double HourSquareFeetDegreesFahrenheitPerBtu => As(ThermalResistanceUnit.HourSquareFeetDegreeFahrenheitPerBtu);

        /// <summary>
        ///     Get ThermalResistance in SquareCentimeterHourDegreesCelsiusPerKilocalorie.
        /// </summary>
        public double SquareCentimeterHourDegreesCelsiusPerKilocalorie => As(ThermalResistanceUnit.SquareCentimeterHourDegreeCelsiusPerKilocalorie);

        /// <summary>
        ///     Get ThermalResistance in SquareCentimeterKelvinsPerWatt.
        /// </summary>
        public double SquareCentimeterKelvinsPerWatt => As(ThermalResistanceUnit.SquareCentimeterKelvinPerWatt);

        /// <summary>
        ///     Get ThermalResistance in SquareMeterDegreesCelsiusPerWatt.
        /// </summary>
        public double SquareMeterDegreesCelsiusPerWatt => As(ThermalResistanceUnit.SquareMeterDegreeCelsiusPerWatt);

        /// <summary>
        ///     Get ThermalResistance in SquareMeterKelvinsPerKilowatt.
        /// </summary>
        public double SquareMeterKelvinsPerKilowatt => As(ThermalResistanceUnit.SquareMeterKelvinPerKilowatt);

        /// <summary>
        ///     Get ThermalResistance in SI unit (SquareMeterKelvinsPerKilowatt).
        /// </summary>
        public double SI => As(ThermalResistanceUnit.SI);
    }
}
