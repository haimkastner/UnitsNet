﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by \generate-code.bat.
//
//     Changes to this file will be lost when the code is regenerated.
//     The build server regenerates the code before each build and a pre-build
//     step will regenerate the code on each local build.
//
//     See https://github.com/angularsen/UnitsNet/wiki/Adding-a-New-Unit for how to add or edit units.
//
//     Add CustomCode\Quantities\MyQuantity.extra.cs files to add code to generated quantities.
//     Add UnitDefinitions\MyQuantity.json and run generate-code.bat to generate new units or quantities.
//
// </auto-generated>
//------------------------------------------------------------------------------

// Licensed under MIT No Attribution, see LICENSE file at the root.
// Copyright 2013 Andreas Gullberg Larsen (andreas.larsen84@gmail.com). Maintained at https://github.com/angularsen/UnitsNet.

using System;
using System.Linq;
using UnitsNet.Units;
using Xunit;

// Disable build warning CS1718: Comparison made to same variable; did you mean to compare something else?
#pragma warning disable 1718

// ReSharper disable once CheckNamespace
namespace UnitsNet.Tests
{
    /// <summary>
    /// Test of TemperatureDelta.
    /// </summary>
// ReSharper disable once PartialTypeWithSinglePart
    public abstract partial class TemperatureDeltaTestsBase
    {
        protected abstract double DegreesCelsiusInOneKelvin { get; }
        protected abstract double DegreesDelisleInOneKelvin { get; }
        protected abstract double DegreesFahrenheitInOneKelvin { get; }
        protected abstract double DegreesNewtonInOneKelvin { get; }
        protected abstract double DegreesRankineInOneKelvin { get; }
        protected abstract double DegreesReaumurInOneKelvin { get; }
        protected abstract double DegreesRoemerInOneKelvin { get; }
        protected abstract double KelvinsInOneKelvin { get; }

// ReSharper disable VirtualMemberNeverOverriden.Global
        protected virtual double DegreesCelsiusTolerance { get { return 1e-5; } }
        protected virtual double DegreesDelisleTolerance { get { return 1e-5; } }
        protected virtual double DegreesFahrenheitTolerance { get { return 1e-5; } }
        protected virtual double DegreesNewtonTolerance { get { return 1e-5; } }
        protected virtual double DegreesRankineTolerance { get { return 1e-5; } }
        protected virtual double DegreesReaumurTolerance { get { return 1e-5; } }
        protected virtual double DegreesRoemerTolerance { get { return 1e-5; } }
        protected virtual double KelvinsTolerance { get { return 1e-5; } }
// ReSharper restore VirtualMemberNeverOverriden.Global

        [Fact]
        public void Ctor_WithUndefinedUnit_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => new TemperatureDelta((double)0.0, TemperatureDeltaUnit.Undefined));
        }

        [Fact]
        public void Ctor_WithInfinityValue_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => new TemperatureDelta(double.PositiveInfinity, TemperatureDeltaUnit.Kelvin));
            Assert.Throws<ArgumentException>(() => new TemperatureDelta(double.NegativeInfinity, TemperatureDeltaUnit.Kelvin));
        }

        [Fact]
        public void Ctor_WithNaNValue_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => new TemperatureDelta(double.NaN, TemperatureDeltaUnit.Kelvin));
        }

        [Fact]
        public void KelvinToTemperatureDeltaUnits()
        {
            TemperatureDelta kelvin = TemperatureDelta.FromKelvins(1);
            AssertEx.EqualTolerance(DegreesCelsiusInOneKelvin, kelvin.DegreesCelsius, DegreesCelsiusTolerance);
            AssertEx.EqualTolerance(DegreesDelisleInOneKelvin, kelvin.DegreesDelisle, DegreesDelisleTolerance);
            AssertEx.EqualTolerance(DegreesFahrenheitInOneKelvin, kelvin.DegreesFahrenheit, DegreesFahrenheitTolerance);
            AssertEx.EqualTolerance(DegreesNewtonInOneKelvin, kelvin.DegreesNewton, DegreesNewtonTolerance);
            AssertEx.EqualTolerance(DegreesRankineInOneKelvin, kelvin.DegreesRankine, DegreesRankineTolerance);
            AssertEx.EqualTolerance(DegreesReaumurInOneKelvin, kelvin.DegreesReaumur, DegreesReaumurTolerance);
            AssertEx.EqualTolerance(DegreesRoemerInOneKelvin, kelvin.DegreesRoemer, DegreesRoemerTolerance);
            AssertEx.EqualTolerance(KelvinsInOneKelvin, kelvin.Kelvins, KelvinsTolerance);
        }

        [Fact]
        public void FromValueAndUnit()
        {
            AssertEx.EqualTolerance(1, TemperatureDelta.From(1, TemperatureDeltaUnit.DegreeCelsius).DegreesCelsius, DegreesCelsiusTolerance);
            AssertEx.EqualTolerance(1, TemperatureDelta.From(1, TemperatureDeltaUnit.DegreeDelisle).DegreesDelisle, DegreesDelisleTolerance);
            AssertEx.EqualTolerance(1, TemperatureDelta.From(1, TemperatureDeltaUnit.DegreeFahrenheit).DegreesFahrenheit, DegreesFahrenheitTolerance);
            AssertEx.EqualTolerance(1, TemperatureDelta.From(1, TemperatureDeltaUnit.DegreeNewton).DegreesNewton, DegreesNewtonTolerance);
            AssertEx.EqualTolerance(1, TemperatureDelta.From(1, TemperatureDeltaUnit.DegreeRankine).DegreesRankine, DegreesRankineTolerance);
            AssertEx.EqualTolerance(1, TemperatureDelta.From(1, TemperatureDeltaUnit.DegreeReaumur).DegreesReaumur, DegreesReaumurTolerance);
            AssertEx.EqualTolerance(1, TemperatureDelta.From(1, TemperatureDeltaUnit.DegreeRoemer).DegreesRoemer, DegreesRoemerTolerance);
            AssertEx.EqualTolerance(1, TemperatureDelta.From(1, TemperatureDeltaUnit.Kelvin).Kelvins, KelvinsTolerance);
        }

        [Fact]
        public void FromKelvins_WithInfinityValue_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => TemperatureDelta.FromKelvins(double.PositiveInfinity));
            Assert.Throws<ArgumentException>(() => TemperatureDelta.FromKelvins(double.NegativeInfinity));
        }

        [Fact]
        public void FromKelvins_WithNanValue_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => TemperatureDelta.FromKelvins(double.NaN));
        }

        [Fact]
        public void As()
        {
            var kelvin = TemperatureDelta.FromKelvins(1);
            AssertEx.EqualTolerance(DegreesCelsiusInOneKelvin, kelvin.As(TemperatureDeltaUnit.DegreeCelsius), DegreesCelsiusTolerance);
            AssertEx.EqualTolerance(DegreesDelisleInOneKelvin, kelvin.As(TemperatureDeltaUnit.DegreeDelisle), DegreesDelisleTolerance);
            AssertEx.EqualTolerance(DegreesFahrenheitInOneKelvin, kelvin.As(TemperatureDeltaUnit.DegreeFahrenheit), DegreesFahrenheitTolerance);
            AssertEx.EqualTolerance(DegreesNewtonInOneKelvin, kelvin.As(TemperatureDeltaUnit.DegreeNewton), DegreesNewtonTolerance);
            AssertEx.EqualTolerance(DegreesRankineInOneKelvin, kelvin.As(TemperatureDeltaUnit.DegreeRankine), DegreesRankineTolerance);
            AssertEx.EqualTolerance(DegreesReaumurInOneKelvin, kelvin.As(TemperatureDeltaUnit.DegreeReaumur), DegreesReaumurTolerance);
            AssertEx.EqualTolerance(DegreesRoemerInOneKelvin, kelvin.As(TemperatureDeltaUnit.DegreeRoemer), DegreesRoemerTolerance);
            AssertEx.EqualTolerance(KelvinsInOneKelvin, kelvin.As(TemperatureDeltaUnit.Kelvin), KelvinsTolerance);
        }

        [Fact]
        public void ToUnit()
        {
            var kelvin = TemperatureDelta.FromKelvins(1);

            var degreecelsiusQuantity = kelvin.ToUnit(TemperatureDeltaUnit.DegreeCelsius);
            AssertEx.EqualTolerance(DegreesCelsiusInOneKelvin, (double)degreecelsiusQuantity.Value, DegreesCelsiusTolerance);
            Assert.Equal(TemperatureDeltaUnit.DegreeCelsius, degreecelsiusQuantity.Unit);

            var degreedelisleQuantity = kelvin.ToUnit(TemperatureDeltaUnit.DegreeDelisle);
            AssertEx.EqualTolerance(DegreesDelisleInOneKelvin, (double)degreedelisleQuantity.Value, DegreesDelisleTolerance);
            Assert.Equal(TemperatureDeltaUnit.DegreeDelisle, degreedelisleQuantity.Unit);

            var degreefahrenheitQuantity = kelvin.ToUnit(TemperatureDeltaUnit.DegreeFahrenheit);
            AssertEx.EqualTolerance(DegreesFahrenheitInOneKelvin, (double)degreefahrenheitQuantity.Value, DegreesFahrenheitTolerance);
            Assert.Equal(TemperatureDeltaUnit.DegreeFahrenheit, degreefahrenheitQuantity.Unit);

            var degreenewtonQuantity = kelvin.ToUnit(TemperatureDeltaUnit.DegreeNewton);
            AssertEx.EqualTolerance(DegreesNewtonInOneKelvin, (double)degreenewtonQuantity.Value, DegreesNewtonTolerance);
            Assert.Equal(TemperatureDeltaUnit.DegreeNewton, degreenewtonQuantity.Unit);

            var degreerankineQuantity = kelvin.ToUnit(TemperatureDeltaUnit.DegreeRankine);
            AssertEx.EqualTolerance(DegreesRankineInOneKelvin, (double)degreerankineQuantity.Value, DegreesRankineTolerance);
            Assert.Equal(TemperatureDeltaUnit.DegreeRankine, degreerankineQuantity.Unit);

            var degreereaumurQuantity = kelvin.ToUnit(TemperatureDeltaUnit.DegreeReaumur);
            AssertEx.EqualTolerance(DegreesReaumurInOneKelvin, (double)degreereaumurQuantity.Value, DegreesReaumurTolerance);
            Assert.Equal(TemperatureDeltaUnit.DegreeReaumur, degreereaumurQuantity.Unit);

            var degreeroemerQuantity = kelvin.ToUnit(TemperatureDeltaUnit.DegreeRoemer);
            AssertEx.EqualTolerance(DegreesRoemerInOneKelvin, (double)degreeroemerQuantity.Value, DegreesRoemerTolerance);
            Assert.Equal(TemperatureDeltaUnit.DegreeRoemer, degreeroemerQuantity.Unit);

            var kelvinQuantity = kelvin.ToUnit(TemperatureDeltaUnit.Kelvin);
            AssertEx.EqualTolerance(KelvinsInOneKelvin, (double)kelvinQuantity.Value, KelvinsTolerance);
            Assert.Equal(TemperatureDeltaUnit.Kelvin, kelvinQuantity.Unit);
        }

        [Fact]
        public void ConversionRoundTrip()
        {
            TemperatureDelta kelvin = TemperatureDelta.FromKelvins(1);
            AssertEx.EqualTolerance(1, TemperatureDelta.FromDegreesCelsius(kelvin.DegreesCelsius).Kelvins, DegreesCelsiusTolerance);
            AssertEx.EqualTolerance(1, TemperatureDelta.FromDegreesDelisle(kelvin.DegreesDelisle).Kelvins, DegreesDelisleTolerance);
            AssertEx.EqualTolerance(1, TemperatureDelta.FromDegreesFahrenheit(kelvin.DegreesFahrenheit).Kelvins, DegreesFahrenheitTolerance);
            AssertEx.EqualTolerance(1, TemperatureDelta.FromDegreesNewton(kelvin.DegreesNewton).Kelvins, DegreesNewtonTolerance);
            AssertEx.EqualTolerance(1, TemperatureDelta.FromDegreesRankine(kelvin.DegreesRankine).Kelvins, DegreesRankineTolerance);
            AssertEx.EqualTolerance(1, TemperatureDelta.FromDegreesReaumur(kelvin.DegreesReaumur).Kelvins, DegreesReaumurTolerance);
            AssertEx.EqualTolerance(1, TemperatureDelta.FromDegreesRoemer(kelvin.DegreesRoemer).Kelvins, DegreesRoemerTolerance);
            AssertEx.EqualTolerance(1, TemperatureDelta.FromKelvins(kelvin.Kelvins).Kelvins, KelvinsTolerance);
        }

        [Fact]
        public void ArithmeticOperators()
        {
            TemperatureDelta v = TemperatureDelta.FromKelvins(1);
            AssertEx.EqualTolerance(-1, -v.Kelvins, KelvinsTolerance);
            AssertEx.EqualTolerance(2, (TemperatureDelta.FromKelvins(3)-v).Kelvins, KelvinsTolerance);
            AssertEx.EqualTolerance(2, (v + v).Kelvins, KelvinsTolerance);
            AssertEx.EqualTolerance(10, (v*10).Kelvins, KelvinsTolerance);
            AssertEx.EqualTolerance(10, (10*v).Kelvins, KelvinsTolerance);
            AssertEx.EqualTolerance(2, (TemperatureDelta.FromKelvins(10)/5).Kelvins, KelvinsTolerance);
            AssertEx.EqualTolerance(2, TemperatureDelta.FromKelvins(10)/TemperatureDelta.FromKelvins(5), KelvinsTolerance);
        }

        [Fact]
        public void ComparisonOperators()
        {
            TemperatureDelta oneKelvin = TemperatureDelta.FromKelvins(1);
            TemperatureDelta twoKelvins = TemperatureDelta.FromKelvins(2);

            Assert.True(oneKelvin < twoKelvins);
            Assert.True(oneKelvin <= twoKelvins);
            Assert.True(twoKelvins > oneKelvin);
            Assert.True(twoKelvins >= oneKelvin);

            Assert.False(oneKelvin > twoKelvins);
            Assert.False(oneKelvin >= twoKelvins);
            Assert.False(twoKelvins < oneKelvin);
            Assert.False(twoKelvins <= oneKelvin);
        }

        [Fact]
        public void CompareToIsImplemented()
        {
            TemperatureDelta kelvin = TemperatureDelta.FromKelvins(1);
            Assert.Equal(0, kelvin.CompareTo(kelvin));
            Assert.True(kelvin.CompareTo(TemperatureDelta.Zero) > 0);
            Assert.True(TemperatureDelta.Zero.CompareTo(kelvin) < 0);
        }

        [Fact]
        public void CompareToThrowsOnTypeMismatch()
        {
            TemperatureDelta kelvin = TemperatureDelta.FromKelvins(1);
            Assert.Throws<ArgumentException>(() => kelvin.CompareTo(new object()));
        }

        [Fact]
        public void CompareToThrowsOnNull()
        {
            TemperatureDelta kelvin = TemperatureDelta.FromKelvins(1);
            Assert.Throws<ArgumentNullException>(() => kelvin.CompareTo(null));
        }

        [Fact]
        public void EqualityOperators()
        {
            var a = TemperatureDelta.FromKelvins(1);
            var b = TemperatureDelta.FromKelvins(2);

 // ReSharper disable EqualExpressionComparison

            Assert.True(a == a);
            Assert.False(a != a);

            Assert.True(a != b);
            Assert.False(a == b);

            Assert.False(a == null);
            Assert.False(null == a);

// ReSharper restore EqualExpressionComparison
        }

        [Fact]
        public void EqualsIsImplemented()
        {
            var a = TemperatureDelta.FromKelvins(1);
            var b = TemperatureDelta.FromKelvins(2);

            Assert.True(a.Equals(a));
            Assert.False(a.Equals(b));
            Assert.False(a.Equals(null));
        }

        [Fact]
        public void EqualsRelativeToleranceIsImplemented()
        {
            var v = TemperatureDelta.FromKelvins(1);
            Assert.True(v.Equals(TemperatureDelta.FromKelvins(1), KelvinsTolerance, ComparisonType.Relative));
            Assert.False(v.Equals(TemperatureDelta.Zero, KelvinsTolerance, ComparisonType.Relative));
        }

        [Fact]
        public void EqualsReturnsFalseOnTypeMismatch()
        {
            TemperatureDelta kelvin = TemperatureDelta.FromKelvins(1);
            Assert.False(kelvin.Equals(new object()));
        }

        [Fact]
        public void EqualsReturnsFalseOnNull()
        {
            TemperatureDelta kelvin = TemperatureDelta.FromKelvins(1);
            Assert.False(kelvin.Equals(null));
        }

        [Fact]
        public void UnitsDoesNotContainUndefined()
        {
            Assert.DoesNotContain(TemperatureDeltaUnit.Undefined, TemperatureDelta.Units);
        }

        [Fact]
        public void HasAtLeastOneAbbreviationSpecified()
        {
            var units = Enum.GetValues(typeof(TemperatureDeltaUnit)).Cast<TemperatureDeltaUnit>();
            foreach(var unit in units)
            {
                if(unit == TemperatureDeltaUnit.Undefined)
                    continue;

                var defaultAbbreviation = UnitAbbreviationsCache.Default.GetDefaultAbbreviation(unit);
            }
        }

        [Fact]
        public void BaseDimensionsShouldNeverBeNull()
        {
            Assert.False(TemperatureDelta.BaseDimensions is null);
        }
    }
}
