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
    /// Test of SpecificVolume.
    /// </summary>
// ReSharper disable once PartialTypeWithSinglePart
    public abstract partial class SpecificVolumeTestsBase
    {
        protected abstract double CubicFeetPerPoundInOneCubicMeterPerKilogram { get; }
        protected abstract double CubicMetersPerKilogramInOneCubicMeterPerKilogram { get; }
        protected abstract double MillicubicMetersPerKilogramInOneCubicMeterPerKilogram { get; }

// ReSharper disable VirtualMemberNeverOverriden.Global
        protected virtual double CubicFeetPerPoundTolerance { get { return 1e-5; } }
        protected virtual double CubicMetersPerKilogramTolerance { get { return 1e-5; } }
        protected virtual double MillicubicMetersPerKilogramTolerance { get { return 1e-5; } }
// ReSharper restore VirtualMemberNeverOverriden.Global

        [Fact]
        public void Ctor_WithUndefinedUnit_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => new SpecificVolume((double)0.0, SpecificVolumeUnit.Undefined));
        }

        [Fact]
        public void Ctor_WithInfinityValue_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => new SpecificVolume(double.PositiveInfinity, SpecificVolumeUnit.CubicMeterPerKilogram));
            Assert.Throws<ArgumentException>(() => new SpecificVolume(double.NegativeInfinity, SpecificVolumeUnit.CubicMeterPerKilogram));
        }

        [Fact]
        public void Ctor_WithNaNValue_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => new SpecificVolume(double.NaN, SpecificVolumeUnit.CubicMeterPerKilogram));
        }

        [Fact]
        public void CubicMeterPerKilogramToSpecificVolumeUnits()
        {
            SpecificVolume cubicmeterperkilogram = SpecificVolume.FromCubicMetersPerKilogram(1);
            AssertEx.EqualTolerance(CubicFeetPerPoundInOneCubicMeterPerKilogram, cubicmeterperkilogram.CubicFeetPerPound, CubicFeetPerPoundTolerance);
            AssertEx.EqualTolerance(CubicMetersPerKilogramInOneCubicMeterPerKilogram, cubicmeterperkilogram.CubicMetersPerKilogram, CubicMetersPerKilogramTolerance);
            AssertEx.EqualTolerance(MillicubicMetersPerKilogramInOneCubicMeterPerKilogram, cubicmeterperkilogram.MillicubicMetersPerKilogram, MillicubicMetersPerKilogramTolerance);
        }

        [Fact]
        public void FromValueAndUnit()
        {
            AssertEx.EqualTolerance(1, SpecificVolume.From(1, SpecificVolumeUnit.CubicFootPerPound).CubicFeetPerPound, CubicFeetPerPoundTolerance);
            AssertEx.EqualTolerance(1, SpecificVolume.From(1, SpecificVolumeUnit.CubicMeterPerKilogram).CubicMetersPerKilogram, CubicMetersPerKilogramTolerance);
            AssertEx.EqualTolerance(1, SpecificVolume.From(1, SpecificVolumeUnit.MillicubicMeterPerKilogram).MillicubicMetersPerKilogram, MillicubicMetersPerKilogramTolerance);
        }

        [Fact]
        public void FromCubicMetersPerKilogram_WithInfinityValue_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => SpecificVolume.FromCubicMetersPerKilogram(double.PositiveInfinity));
            Assert.Throws<ArgumentException>(() => SpecificVolume.FromCubicMetersPerKilogram(double.NegativeInfinity));
        }

        [Fact]
        public void FromCubicMetersPerKilogram_WithNanValue_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => SpecificVolume.FromCubicMetersPerKilogram(double.NaN));
        }

        [Fact]
        public void As()
        {
            var cubicmeterperkilogram = SpecificVolume.FromCubicMetersPerKilogram(1);
            AssertEx.EqualTolerance(CubicFeetPerPoundInOneCubicMeterPerKilogram, cubicmeterperkilogram.As(SpecificVolumeUnit.CubicFootPerPound), CubicFeetPerPoundTolerance);
            AssertEx.EqualTolerance(CubicMetersPerKilogramInOneCubicMeterPerKilogram, cubicmeterperkilogram.As(SpecificVolumeUnit.CubicMeterPerKilogram), CubicMetersPerKilogramTolerance);
            AssertEx.EqualTolerance(MillicubicMetersPerKilogramInOneCubicMeterPerKilogram, cubicmeterperkilogram.As(SpecificVolumeUnit.MillicubicMeterPerKilogram), MillicubicMetersPerKilogramTolerance);
        }

        [Fact]
        public void ToUnit()
        {
            var cubicmeterperkilogram = SpecificVolume.FromCubicMetersPerKilogram(1);

            var cubicfootperpoundQuantity = cubicmeterperkilogram.ToUnit(SpecificVolumeUnit.CubicFootPerPound);
            AssertEx.EqualTolerance(CubicFeetPerPoundInOneCubicMeterPerKilogram, (double)cubicfootperpoundQuantity.Value, CubicFeetPerPoundTolerance);
            Assert.Equal(SpecificVolumeUnit.CubicFootPerPound, cubicfootperpoundQuantity.Unit);

            var cubicmeterperkilogramQuantity = cubicmeterperkilogram.ToUnit(SpecificVolumeUnit.CubicMeterPerKilogram);
            AssertEx.EqualTolerance(CubicMetersPerKilogramInOneCubicMeterPerKilogram, (double)cubicmeterperkilogramQuantity.Value, CubicMetersPerKilogramTolerance);
            Assert.Equal(SpecificVolumeUnit.CubicMeterPerKilogram, cubicmeterperkilogramQuantity.Unit);

            var millicubicmeterperkilogramQuantity = cubicmeterperkilogram.ToUnit(SpecificVolumeUnit.MillicubicMeterPerKilogram);
            AssertEx.EqualTolerance(MillicubicMetersPerKilogramInOneCubicMeterPerKilogram, (double)millicubicmeterperkilogramQuantity.Value, MillicubicMetersPerKilogramTolerance);
            Assert.Equal(SpecificVolumeUnit.MillicubicMeterPerKilogram, millicubicmeterperkilogramQuantity.Unit);
        }

        [Fact]
        public void ConversionRoundTrip()
        {
            SpecificVolume cubicmeterperkilogram = SpecificVolume.FromCubicMetersPerKilogram(1);
            AssertEx.EqualTolerance(1, SpecificVolume.FromCubicFeetPerPound(cubicmeterperkilogram.CubicFeetPerPound).CubicMetersPerKilogram, CubicFeetPerPoundTolerance);
            AssertEx.EqualTolerance(1, SpecificVolume.FromCubicMetersPerKilogram(cubicmeterperkilogram.CubicMetersPerKilogram).CubicMetersPerKilogram, CubicMetersPerKilogramTolerance);
            AssertEx.EqualTolerance(1, SpecificVolume.FromMillicubicMetersPerKilogram(cubicmeterperkilogram.MillicubicMetersPerKilogram).CubicMetersPerKilogram, MillicubicMetersPerKilogramTolerance);
        }

        [Fact]
        public void ArithmeticOperators()
        {
            SpecificVolume v = SpecificVolume.FromCubicMetersPerKilogram(1);
            AssertEx.EqualTolerance(-1, -v.CubicMetersPerKilogram, CubicMetersPerKilogramTolerance);
            AssertEx.EqualTolerance(2, (SpecificVolume.FromCubicMetersPerKilogram(3)-v).CubicMetersPerKilogram, CubicMetersPerKilogramTolerance);
            AssertEx.EqualTolerance(2, (v + v).CubicMetersPerKilogram, CubicMetersPerKilogramTolerance);
            AssertEx.EqualTolerance(10, (v*10).CubicMetersPerKilogram, CubicMetersPerKilogramTolerance);
            AssertEx.EqualTolerance(10, (10*v).CubicMetersPerKilogram, CubicMetersPerKilogramTolerance);
            AssertEx.EqualTolerance(2, (SpecificVolume.FromCubicMetersPerKilogram(10)/5).CubicMetersPerKilogram, CubicMetersPerKilogramTolerance);
            AssertEx.EqualTolerance(2, SpecificVolume.FromCubicMetersPerKilogram(10)/SpecificVolume.FromCubicMetersPerKilogram(5), CubicMetersPerKilogramTolerance);
        }

        [Fact]
        public void ComparisonOperators()
        {
            SpecificVolume oneCubicMeterPerKilogram = SpecificVolume.FromCubicMetersPerKilogram(1);
            SpecificVolume twoCubicMetersPerKilogram = SpecificVolume.FromCubicMetersPerKilogram(2);

            Assert.True(oneCubicMeterPerKilogram < twoCubicMetersPerKilogram);
            Assert.True(oneCubicMeterPerKilogram <= twoCubicMetersPerKilogram);
            Assert.True(twoCubicMetersPerKilogram > oneCubicMeterPerKilogram);
            Assert.True(twoCubicMetersPerKilogram >= oneCubicMeterPerKilogram);

            Assert.False(oneCubicMeterPerKilogram > twoCubicMetersPerKilogram);
            Assert.False(oneCubicMeterPerKilogram >= twoCubicMetersPerKilogram);
            Assert.False(twoCubicMetersPerKilogram < oneCubicMeterPerKilogram);
            Assert.False(twoCubicMetersPerKilogram <= oneCubicMeterPerKilogram);
        }

        [Fact]
        public void CompareToIsImplemented()
        {
            SpecificVolume cubicmeterperkilogram = SpecificVolume.FromCubicMetersPerKilogram(1);
            Assert.Equal(0, cubicmeterperkilogram.CompareTo(cubicmeterperkilogram));
            Assert.True(cubicmeterperkilogram.CompareTo(SpecificVolume.Zero) > 0);
            Assert.True(SpecificVolume.Zero.CompareTo(cubicmeterperkilogram) < 0);
        }

        [Fact]
        public void CompareToThrowsOnTypeMismatch()
        {
            SpecificVolume cubicmeterperkilogram = SpecificVolume.FromCubicMetersPerKilogram(1);
            Assert.Throws<ArgumentException>(() => cubicmeterperkilogram.CompareTo(new object()));
        }

        [Fact]
        public void CompareToThrowsOnNull()
        {
            SpecificVolume cubicmeterperkilogram = SpecificVolume.FromCubicMetersPerKilogram(1);
            Assert.Throws<ArgumentNullException>(() => cubicmeterperkilogram.CompareTo(null));
        }

        [Fact]
        public void EqualityOperators()
        {
            var a = SpecificVolume.FromCubicMetersPerKilogram(1);
            var b = SpecificVolume.FromCubicMetersPerKilogram(2);

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
            var a = SpecificVolume.FromCubicMetersPerKilogram(1);
            var b = SpecificVolume.FromCubicMetersPerKilogram(2);

            Assert.True(a.Equals(a));
            Assert.False(a.Equals(b));
            Assert.False(a.Equals(null));
        }

        [Fact]
        public void EqualsRelativeToleranceIsImplemented()
        {
            var v = SpecificVolume.FromCubicMetersPerKilogram(1);
            Assert.True(v.Equals(SpecificVolume.FromCubicMetersPerKilogram(1), CubicMetersPerKilogramTolerance, ComparisonType.Relative));
            Assert.False(v.Equals(SpecificVolume.Zero, CubicMetersPerKilogramTolerance, ComparisonType.Relative));
        }

        [Fact]
        public void EqualsReturnsFalseOnTypeMismatch()
        {
            SpecificVolume cubicmeterperkilogram = SpecificVolume.FromCubicMetersPerKilogram(1);
            Assert.False(cubicmeterperkilogram.Equals(new object()));
        }

        [Fact]
        public void EqualsReturnsFalseOnNull()
        {
            SpecificVolume cubicmeterperkilogram = SpecificVolume.FromCubicMetersPerKilogram(1);
            Assert.False(cubicmeterperkilogram.Equals(null));
        }

        [Fact]
        public void UnitsDoesNotContainUndefined()
        {
            Assert.DoesNotContain(SpecificVolumeUnit.Undefined, SpecificVolume.Units);
        }

        [Fact]
        public void HasAtLeastOneAbbreviationSpecified()
        {
            var units = Enum.GetValues(typeof(SpecificVolumeUnit)).Cast<SpecificVolumeUnit>();
            foreach(var unit in units)
            {
                if(unit == SpecificVolumeUnit.Undefined)
                    continue;

                var defaultAbbreviation = UnitAbbreviationsCache.Default.GetDefaultAbbreviation(unit);
            }
        }

        [Fact]
        public void BaseDimensionsShouldNeverBeNull()
        {
            Assert.False(SpecificVolume.BaseDimensions is null);
        }
    }
}
