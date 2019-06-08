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
    /// Test of ElectricCurrentDensity.
    /// </summary>
// ReSharper disable once PartialTypeWithSinglePart
    public abstract partial class ElectricCurrentDensityTestsBase
    {
        protected abstract double AmperesPerSquareFootInOneAmperePerSquareMeter { get; }
        protected abstract double AmperesPerSquareInchInOneAmperePerSquareMeter { get; }
        protected abstract double AmperesPerSquareMeterInOneAmperePerSquareMeter { get; }

// ReSharper disable VirtualMemberNeverOverriden.Global
        protected virtual double AmperesPerSquareFootTolerance { get { return 1e-5; } }
        protected virtual double AmperesPerSquareInchTolerance { get { return 1e-5; } }
        protected virtual double AmperesPerSquareMeterTolerance { get { return 1e-5; } }
// ReSharper restore VirtualMemberNeverOverriden.Global

        [Fact]
        public void Ctor_WithUndefinedUnit_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => new ElectricCurrentDensity((double)0.0, ElectricCurrentDensityUnit.Undefined));
        }

        [Fact]
        public void Ctor_WithInfinityValue_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => new ElectricCurrentDensity(double.PositiveInfinity, ElectricCurrentDensityUnit.AmperePerSquareMeter));
            Assert.Throws<ArgumentException>(() => new ElectricCurrentDensity(double.NegativeInfinity, ElectricCurrentDensityUnit.AmperePerSquareMeter));
        }

        [Fact]
        public void Ctor_WithNaNValue_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => new ElectricCurrentDensity(double.NaN, ElectricCurrentDensityUnit.AmperePerSquareMeter));
        }

        [Fact]
        public void AmperePerSquareMeterToElectricCurrentDensityUnits()
        {
            ElectricCurrentDensity amperepersquaremeter = ElectricCurrentDensity.FromAmperesPerSquareMeter(1);
            AssertEx.EqualTolerance(AmperesPerSquareFootInOneAmperePerSquareMeter, amperepersquaremeter.AmperesPerSquareFoot, AmperesPerSquareFootTolerance);
            AssertEx.EqualTolerance(AmperesPerSquareInchInOneAmperePerSquareMeter, amperepersquaremeter.AmperesPerSquareInch, AmperesPerSquareInchTolerance);
            AssertEx.EqualTolerance(AmperesPerSquareMeterInOneAmperePerSquareMeter, amperepersquaremeter.AmperesPerSquareMeter, AmperesPerSquareMeterTolerance);
        }

        [Fact]
        public void FromValueAndUnit()
        {
            AssertEx.EqualTolerance(1, ElectricCurrentDensity.From(1, ElectricCurrentDensityUnit.AmperePerSquareFoot).AmperesPerSquareFoot, AmperesPerSquareFootTolerance);
            AssertEx.EqualTolerance(1, ElectricCurrentDensity.From(1, ElectricCurrentDensityUnit.AmperePerSquareInch).AmperesPerSquareInch, AmperesPerSquareInchTolerance);
            AssertEx.EqualTolerance(1, ElectricCurrentDensity.From(1, ElectricCurrentDensityUnit.AmperePerSquareMeter).AmperesPerSquareMeter, AmperesPerSquareMeterTolerance);
        }

        [Fact]
        public void FromAmperesPerSquareMeter_WithInfinityValue_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => ElectricCurrentDensity.FromAmperesPerSquareMeter(double.PositiveInfinity));
            Assert.Throws<ArgumentException>(() => ElectricCurrentDensity.FromAmperesPerSquareMeter(double.NegativeInfinity));
        }

        [Fact]
        public void FromAmperesPerSquareMeter_WithNanValue_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => ElectricCurrentDensity.FromAmperesPerSquareMeter(double.NaN));
        }

        [Fact]
        public void As()
        {
            var amperepersquaremeter = ElectricCurrentDensity.FromAmperesPerSquareMeter(1);
            AssertEx.EqualTolerance(AmperesPerSquareFootInOneAmperePerSquareMeter, amperepersquaremeter.As(ElectricCurrentDensityUnit.AmperePerSquareFoot), AmperesPerSquareFootTolerance);
            AssertEx.EqualTolerance(AmperesPerSquareInchInOneAmperePerSquareMeter, amperepersquaremeter.As(ElectricCurrentDensityUnit.AmperePerSquareInch), AmperesPerSquareInchTolerance);
            AssertEx.EqualTolerance(AmperesPerSquareMeterInOneAmperePerSquareMeter, amperepersquaremeter.As(ElectricCurrentDensityUnit.AmperePerSquareMeter), AmperesPerSquareMeterTolerance);
        }

        [Fact]
        public void ToUnit()
        {
            var amperepersquaremeter = ElectricCurrentDensity.FromAmperesPerSquareMeter(1);

            var amperepersquarefootQuantity = amperepersquaremeter.ToUnit(ElectricCurrentDensityUnit.AmperePerSquareFoot);
            AssertEx.EqualTolerance(AmperesPerSquareFootInOneAmperePerSquareMeter, (double)amperepersquarefootQuantity.Value, AmperesPerSquareFootTolerance);
            Assert.Equal(ElectricCurrentDensityUnit.AmperePerSquareFoot, amperepersquarefootQuantity.Unit);

            var amperepersquareinchQuantity = amperepersquaremeter.ToUnit(ElectricCurrentDensityUnit.AmperePerSquareInch);
            AssertEx.EqualTolerance(AmperesPerSquareInchInOneAmperePerSquareMeter, (double)amperepersquareinchQuantity.Value, AmperesPerSquareInchTolerance);
            Assert.Equal(ElectricCurrentDensityUnit.AmperePerSquareInch, amperepersquareinchQuantity.Unit);

            var amperepersquaremeterQuantity = amperepersquaremeter.ToUnit(ElectricCurrentDensityUnit.AmperePerSquareMeter);
            AssertEx.EqualTolerance(AmperesPerSquareMeterInOneAmperePerSquareMeter, (double)amperepersquaremeterQuantity.Value, AmperesPerSquareMeterTolerance);
            Assert.Equal(ElectricCurrentDensityUnit.AmperePerSquareMeter, amperepersquaremeterQuantity.Unit);
        }

        [Fact]
        public void ConversionRoundTrip()
        {
            ElectricCurrentDensity amperepersquaremeter = ElectricCurrentDensity.FromAmperesPerSquareMeter(1);
            AssertEx.EqualTolerance(1, ElectricCurrentDensity.FromAmperesPerSquareFoot(amperepersquaremeter.AmperesPerSquareFoot).AmperesPerSquareMeter, AmperesPerSquareFootTolerance);
            AssertEx.EqualTolerance(1, ElectricCurrentDensity.FromAmperesPerSquareInch(amperepersquaremeter.AmperesPerSquareInch).AmperesPerSquareMeter, AmperesPerSquareInchTolerance);
            AssertEx.EqualTolerance(1, ElectricCurrentDensity.FromAmperesPerSquareMeter(amperepersquaremeter.AmperesPerSquareMeter).AmperesPerSquareMeter, AmperesPerSquareMeterTolerance);
        }

        [Fact]
        public void ArithmeticOperators()
        {
            ElectricCurrentDensity v = ElectricCurrentDensity.FromAmperesPerSquareMeter(1);
            AssertEx.EqualTolerance(-1, -v.AmperesPerSquareMeter, AmperesPerSquareMeterTolerance);
            AssertEx.EqualTolerance(2, (ElectricCurrentDensity.FromAmperesPerSquareMeter(3)-v).AmperesPerSquareMeter, AmperesPerSquareMeterTolerance);
            AssertEx.EqualTolerance(2, (v + v).AmperesPerSquareMeter, AmperesPerSquareMeterTolerance);
            AssertEx.EqualTolerance(10, (v*10).AmperesPerSquareMeter, AmperesPerSquareMeterTolerance);
            AssertEx.EqualTolerance(10, (10*v).AmperesPerSquareMeter, AmperesPerSquareMeterTolerance);
            AssertEx.EqualTolerance(2, (ElectricCurrentDensity.FromAmperesPerSquareMeter(10)/5).AmperesPerSquareMeter, AmperesPerSquareMeterTolerance);
            AssertEx.EqualTolerance(2, ElectricCurrentDensity.FromAmperesPerSquareMeter(10)/ElectricCurrentDensity.FromAmperesPerSquareMeter(5), AmperesPerSquareMeterTolerance);
        }

        [Fact]
        public void ComparisonOperators()
        {
            ElectricCurrentDensity oneAmperePerSquareMeter = ElectricCurrentDensity.FromAmperesPerSquareMeter(1);
            ElectricCurrentDensity twoAmperesPerSquareMeter = ElectricCurrentDensity.FromAmperesPerSquareMeter(2);

            Assert.True(oneAmperePerSquareMeter < twoAmperesPerSquareMeter);
            Assert.True(oneAmperePerSquareMeter <= twoAmperesPerSquareMeter);
            Assert.True(twoAmperesPerSquareMeter > oneAmperePerSquareMeter);
            Assert.True(twoAmperesPerSquareMeter >= oneAmperePerSquareMeter);

            Assert.False(oneAmperePerSquareMeter > twoAmperesPerSquareMeter);
            Assert.False(oneAmperePerSquareMeter >= twoAmperesPerSquareMeter);
            Assert.False(twoAmperesPerSquareMeter < oneAmperePerSquareMeter);
            Assert.False(twoAmperesPerSquareMeter <= oneAmperePerSquareMeter);
        }

        [Fact]
        public void CompareToIsImplemented()
        {
            ElectricCurrentDensity amperepersquaremeter = ElectricCurrentDensity.FromAmperesPerSquareMeter(1);
            Assert.Equal(0, amperepersquaremeter.CompareTo(amperepersquaremeter));
            Assert.True(amperepersquaremeter.CompareTo(ElectricCurrentDensity.Zero) > 0);
            Assert.True(ElectricCurrentDensity.Zero.CompareTo(amperepersquaremeter) < 0);
        }

        [Fact]
        public void CompareToThrowsOnTypeMismatch()
        {
            ElectricCurrentDensity amperepersquaremeter = ElectricCurrentDensity.FromAmperesPerSquareMeter(1);
            Assert.Throws<ArgumentException>(() => amperepersquaremeter.CompareTo(new object()));
        }

        [Fact]
        public void CompareToThrowsOnNull()
        {
            ElectricCurrentDensity amperepersquaremeter = ElectricCurrentDensity.FromAmperesPerSquareMeter(1);
            Assert.Throws<ArgumentNullException>(() => amperepersquaremeter.CompareTo(null));
        }

        [Fact]
        public void EqualityOperators()
        {
            var a = ElectricCurrentDensity.FromAmperesPerSquareMeter(1);
            var b = ElectricCurrentDensity.FromAmperesPerSquareMeter(2);

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
            var a = ElectricCurrentDensity.FromAmperesPerSquareMeter(1);
            var b = ElectricCurrentDensity.FromAmperesPerSquareMeter(2);

            Assert.True(a.Equals(a));
            Assert.False(a.Equals(b));
            Assert.False(a.Equals(null));
        }

        [Fact]
        public void EqualsRelativeToleranceIsImplemented()
        {
            var v = ElectricCurrentDensity.FromAmperesPerSquareMeter(1);
            Assert.True(v.Equals(ElectricCurrentDensity.FromAmperesPerSquareMeter(1), AmperesPerSquareMeterTolerance, ComparisonType.Relative));
            Assert.False(v.Equals(ElectricCurrentDensity.Zero, AmperesPerSquareMeterTolerance, ComparisonType.Relative));
        }

        [Fact]
        public void EqualsReturnsFalseOnTypeMismatch()
        {
            ElectricCurrentDensity amperepersquaremeter = ElectricCurrentDensity.FromAmperesPerSquareMeter(1);
            Assert.False(amperepersquaremeter.Equals(new object()));
        }

        [Fact]
        public void EqualsReturnsFalseOnNull()
        {
            ElectricCurrentDensity amperepersquaremeter = ElectricCurrentDensity.FromAmperesPerSquareMeter(1);
            Assert.False(amperepersquaremeter.Equals(null));
        }

        [Fact]
        public void UnitsDoesNotContainUndefined()
        {
            Assert.DoesNotContain(ElectricCurrentDensityUnit.Undefined, ElectricCurrentDensity.Units);
        }

        [Fact]
        public void HasAtLeastOneAbbreviationSpecified()
        {
            var units = Enum.GetValues(typeof(ElectricCurrentDensityUnit)).Cast<ElectricCurrentDensityUnit>();
            foreach(var unit in units)
            {
                if(unit == ElectricCurrentDensityUnit.Undefined)
                    continue;

                var defaultAbbreviation = UnitAbbreviationsCache.Default.GetDefaultAbbreviation(unit);
            }
        }

        [Fact]
        public void BaseDimensionsShouldNeverBeNull()
        {
            Assert.False(ElectricCurrentDensity.BaseDimensions is null);
        }
    }
}