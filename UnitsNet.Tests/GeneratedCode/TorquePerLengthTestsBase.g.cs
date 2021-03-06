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
    /// Test of TorquePerLength.
    /// </summary>
// ReSharper disable once PartialTypeWithSinglePart
    public abstract partial class TorquePerLengthTestsBase
    {
        protected abstract double KilogramForceCentimetersPerMeterInOneNewtonMeterPerMeter { get; }
        protected abstract double KilogramForceMetersPerMeterInOneNewtonMeterPerMeter { get; }
        protected abstract double KilogramForceMillimetersPerMeterInOneNewtonMeterPerMeter { get; }
        protected abstract double KilonewtonCentimetersPerMeterInOneNewtonMeterPerMeter { get; }
        protected abstract double KilonewtonMetersPerMeterInOneNewtonMeterPerMeter { get; }
        protected abstract double KilonewtonMillimetersPerMeterInOneNewtonMeterPerMeter { get; }
        protected abstract double KilopoundForceFeetPerFootInOneNewtonMeterPerMeter { get; }
        protected abstract double KilopoundForceInchesPerFootInOneNewtonMeterPerMeter { get; }
        protected abstract double MeganewtonCentimetersPerMeterInOneNewtonMeterPerMeter { get; }
        protected abstract double MeganewtonMetersPerMeterInOneNewtonMeterPerMeter { get; }
        protected abstract double MeganewtonMillimetersPerMeterInOneNewtonMeterPerMeter { get; }
        protected abstract double MegapoundForceFeetPerFootInOneNewtonMeterPerMeter { get; }
        protected abstract double MegapoundForceInchesPerFootInOneNewtonMeterPerMeter { get; }
        protected abstract double NewtonCentimetersPerMeterInOneNewtonMeterPerMeter { get; }
        protected abstract double NewtonMetersPerMeterInOneNewtonMeterPerMeter { get; }
        protected abstract double NewtonMillimetersPerMeterInOneNewtonMeterPerMeter { get; }
        protected abstract double PoundForceFeetPerFootInOneNewtonMeterPerMeter { get; }
        protected abstract double PoundForceInchesPerFootInOneNewtonMeterPerMeter { get; }
        protected abstract double TonneForceCentimetersPerMeterInOneNewtonMeterPerMeter { get; }
        protected abstract double TonneForceMetersPerMeterInOneNewtonMeterPerMeter { get; }
        protected abstract double TonneForceMillimetersPerMeterInOneNewtonMeterPerMeter { get; }

// ReSharper disable VirtualMemberNeverOverriden.Global
        protected virtual double KilogramForceCentimetersPerMeterTolerance { get { return 1e-5; } }
        protected virtual double KilogramForceMetersPerMeterTolerance { get { return 1e-5; } }
        protected virtual double KilogramForceMillimetersPerMeterTolerance { get { return 1e-5; } }
        protected virtual double KilonewtonCentimetersPerMeterTolerance { get { return 1e-5; } }
        protected virtual double KilonewtonMetersPerMeterTolerance { get { return 1e-5; } }
        protected virtual double KilonewtonMillimetersPerMeterTolerance { get { return 1e-5; } }
        protected virtual double KilopoundForceFeetPerFootTolerance { get { return 1e-5; } }
        protected virtual double KilopoundForceInchesPerFootTolerance { get { return 1e-5; } }
        protected virtual double MeganewtonCentimetersPerMeterTolerance { get { return 1e-5; } }
        protected virtual double MeganewtonMetersPerMeterTolerance { get { return 1e-5; } }
        protected virtual double MeganewtonMillimetersPerMeterTolerance { get { return 1e-5; } }
        protected virtual double MegapoundForceFeetPerFootTolerance { get { return 1e-5; } }
        protected virtual double MegapoundForceInchesPerFootTolerance { get { return 1e-5; } }
        protected virtual double NewtonCentimetersPerMeterTolerance { get { return 1e-5; } }
        protected virtual double NewtonMetersPerMeterTolerance { get { return 1e-5; } }
        protected virtual double NewtonMillimetersPerMeterTolerance { get { return 1e-5; } }
        protected virtual double PoundForceFeetPerFootTolerance { get { return 1e-5; } }
        protected virtual double PoundForceInchesPerFootTolerance { get { return 1e-5; } }
        protected virtual double TonneForceCentimetersPerMeterTolerance { get { return 1e-5; } }
        protected virtual double TonneForceMetersPerMeterTolerance { get { return 1e-5; } }
        protected virtual double TonneForceMillimetersPerMeterTolerance { get { return 1e-5; } }
// ReSharper restore VirtualMemberNeverOverriden.Global

        [Fact]
        public void Ctor_WithUndefinedUnit_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => new TorquePerLength((double)0.0, TorquePerLengthUnit.Undefined));
        }

        [Fact]
        public void Ctor_WithInfinityValue_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => new TorquePerLength(double.PositiveInfinity, TorquePerLengthUnit.NewtonMeterPerMeter));
            Assert.Throws<ArgumentException>(() => new TorquePerLength(double.NegativeInfinity, TorquePerLengthUnit.NewtonMeterPerMeter));
        }

        [Fact]
        public void Ctor_WithNaNValue_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => new TorquePerLength(double.NaN, TorquePerLengthUnit.NewtonMeterPerMeter));
        }

        [Fact]
        public void NewtonMeterPerMeterToTorquePerLengthUnits()
        {
            TorquePerLength newtonmeterpermeter = TorquePerLength.FromNewtonMetersPerMeter(1);
            AssertEx.EqualTolerance(KilogramForceCentimetersPerMeterInOneNewtonMeterPerMeter, newtonmeterpermeter.KilogramForceCentimetersPerMeter, KilogramForceCentimetersPerMeterTolerance);
            AssertEx.EqualTolerance(KilogramForceMetersPerMeterInOneNewtonMeterPerMeter, newtonmeterpermeter.KilogramForceMetersPerMeter, KilogramForceMetersPerMeterTolerance);
            AssertEx.EqualTolerance(KilogramForceMillimetersPerMeterInOneNewtonMeterPerMeter, newtonmeterpermeter.KilogramForceMillimetersPerMeter, KilogramForceMillimetersPerMeterTolerance);
            AssertEx.EqualTolerance(KilonewtonCentimetersPerMeterInOneNewtonMeterPerMeter, newtonmeterpermeter.KilonewtonCentimetersPerMeter, KilonewtonCentimetersPerMeterTolerance);
            AssertEx.EqualTolerance(KilonewtonMetersPerMeterInOneNewtonMeterPerMeter, newtonmeterpermeter.KilonewtonMetersPerMeter, KilonewtonMetersPerMeterTolerance);
            AssertEx.EqualTolerance(KilonewtonMillimetersPerMeterInOneNewtonMeterPerMeter, newtonmeterpermeter.KilonewtonMillimetersPerMeter, KilonewtonMillimetersPerMeterTolerance);
            AssertEx.EqualTolerance(KilopoundForceFeetPerFootInOneNewtonMeterPerMeter, newtonmeterpermeter.KilopoundForceFeetPerFoot, KilopoundForceFeetPerFootTolerance);
            AssertEx.EqualTolerance(KilopoundForceInchesPerFootInOneNewtonMeterPerMeter, newtonmeterpermeter.KilopoundForceInchesPerFoot, KilopoundForceInchesPerFootTolerance);
            AssertEx.EqualTolerance(MeganewtonCentimetersPerMeterInOneNewtonMeterPerMeter, newtonmeterpermeter.MeganewtonCentimetersPerMeter, MeganewtonCentimetersPerMeterTolerance);
            AssertEx.EqualTolerance(MeganewtonMetersPerMeterInOneNewtonMeterPerMeter, newtonmeterpermeter.MeganewtonMetersPerMeter, MeganewtonMetersPerMeterTolerance);
            AssertEx.EqualTolerance(MeganewtonMillimetersPerMeterInOneNewtonMeterPerMeter, newtonmeterpermeter.MeganewtonMillimetersPerMeter, MeganewtonMillimetersPerMeterTolerance);
            AssertEx.EqualTolerance(MegapoundForceFeetPerFootInOneNewtonMeterPerMeter, newtonmeterpermeter.MegapoundForceFeetPerFoot, MegapoundForceFeetPerFootTolerance);
            AssertEx.EqualTolerance(MegapoundForceInchesPerFootInOneNewtonMeterPerMeter, newtonmeterpermeter.MegapoundForceInchesPerFoot, MegapoundForceInchesPerFootTolerance);
            AssertEx.EqualTolerance(NewtonCentimetersPerMeterInOneNewtonMeterPerMeter, newtonmeterpermeter.NewtonCentimetersPerMeter, NewtonCentimetersPerMeterTolerance);
            AssertEx.EqualTolerance(NewtonMetersPerMeterInOneNewtonMeterPerMeter, newtonmeterpermeter.NewtonMetersPerMeter, NewtonMetersPerMeterTolerance);
            AssertEx.EqualTolerance(NewtonMillimetersPerMeterInOneNewtonMeterPerMeter, newtonmeterpermeter.NewtonMillimetersPerMeter, NewtonMillimetersPerMeterTolerance);
            AssertEx.EqualTolerance(PoundForceFeetPerFootInOneNewtonMeterPerMeter, newtonmeterpermeter.PoundForceFeetPerFoot, PoundForceFeetPerFootTolerance);
            AssertEx.EqualTolerance(PoundForceInchesPerFootInOneNewtonMeterPerMeter, newtonmeterpermeter.PoundForceInchesPerFoot, PoundForceInchesPerFootTolerance);
            AssertEx.EqualTolerance(TonneForceCentimetersPerMeterInOneNewtonMeterPerMeter, newtonmeterpermeter.TonneForceCentimetersPerMeter, TonneForceCentimetersPerMeterTolerance);
            AssertEx.EqualTolerance(TonneForceMetersPerMeterInOneNewtonMeterPerMeter, newtonmeterpermeter.TonneForceMetersPerMeter, TonneForceMetersPerMeterTolerance);
            AssertEx.EqualTolerance(TonneForceMillimetersPerMeterInOneNewtonMeterPerMeter, newtonmeterpermeter.TonneForceMillimetersPerMeter, TonneForceMillimetersPerMeterTolerance);
        }

        [Fact]
        public void FromValueAndUnit()
        {
            AssertEx.EqualTolerance(1, TorquePerLength.From(1, TorquePerLengthUnit.KilogramForceCentimeterPerMeter).KilogramForceCentimetersPerMeter, KilogramForceCentimetersPerMeterTolerance);
            AssertEx.EqualTolerance(1, TorquePerLength.From(1, TorquePerLengthUnit.KilogramForceMeterPerMeter).KilogramForceMetersPerMeter, KilogramForceMetersPerMeterTolerance);
            AssertEx.EqualTolerance(1, TorquePerLength.From(1, TorquePerLengthUnit.KilogramForceMillimeterPerMeter).KilogramForceMillimetersPerMeter, KilogramForceMillimetersPerMeterTolerance);
            AssertEx.EqualTolerance(1, TorquePerLength.From(1, TorquePerLengthUnit.KilonewtonCentimeterPerMeter).KilonewtonCentimetersPerMeter, KilonewtonCentimetersPerMeterTolerance);
            AssertEx.EqualTolerance(1, TorquePerLength.From(1, TorquePerLengthUnit.KilonewtonMeterPerMeter).KilonewtonMetersPerMeter, KilonewtonMetersPerMeterTolerance);
            AssertEx.EqualTolerance(1, TorquePerLength.From(1, TorquePerLengthUnit.KilonewtonMillimeterPerMeter).KilonewtonMillimetersPerMeter, KilonewtonMillimetersPerMeterTolerance);
            AssertEx.EqualTolerance(1, TorquePerLength.From(1, TorquePerLengthUnit.KilopoundForceFootPerFoot).KilopoundForceFeetPerFoot, KilopoundForceFeetPerFootTolerance);
            AssertEx.EqualTolerance(1, TorquePerLength.From(1, TorquePerLengthUnit.KilopoundForceInchPerFoot).KilopoundForceInchesPerFoot, KilopoundForceInchesPerFootTolerance);
            AssertEx.EqualTolerance(1, TorquePerLength.From(1, TorquePerLengthUnit.MeganewtonCentimeterPerMeter).MeganewtonCentimetersPerMeter, MeganewtonCentimetersPerMeterTolerance);
            AssertEx.EqualTolerance(1, TorquePerLength.From(1, TorquePerLengthUnit.MeganewtonMeterPerMeter).MeganewtonMetersPerMeter, MeganewtonMetersPerMeterTolerance);
            AssertEx.EqualTolerance(1, TorquePerLength.From(1, TorquePerLengthUnit.MeganewtonMillimeterPerMeter).MeganewtonMillimetersPerMeter, MeganewtonMillimetersPerMeterTolerance);
            AssertEx.EqualTolerance(1, TorquePerLength.From(1, TorquePerLengthUnit.MegapoundForceFootPerFoot).MegapoundForceFeetPerFoot, MegapoundForceFeetPerFootTolerance);
            AssertEx.EqualTolerance(1, TorquePerLength.From(1, TorquePerLengthUnit.MegapoundForceInchPerFoot).MegapoundForceInchesPerFoot, MegapoundForceInchesPerFootTolerance);
            AssertEx.EqualTolerance(1, TorquePerLength.From(1, TorquePerLengthUnit.NewtonCentimeterPerMeter).NewtonCentimetersPerMeter, NewtonCentimetersPerMeterTolerance);
            AssertEx.EqualTolerance(1, TorquePerLength.From(1, TorquePerLengthUnit.NewtonMeterPerMeter).NewtonMetersPerMeter, NewtonMetersPerMeterTolerance);
            AssertEx.EqualTolerance(1, TorquePerLength.From(1, TorquePerLengthUnit.NewtonMillimeterPerMeter).NewtonMillimetersPerMeter, NewtonMillimetersPerMeterTolerance);
            AssertEx.EqualTolerance(1, TorquePerLength.From(1, TorquePerLengthUnit.PoundForceFootPerFoot).PoundForceFeetPerFoot, PoundForceFeetPerFootTolerance);
            AssertEx.EqualTolerance(1, TorquePerLength.From(1, TorquePerLengthUnit.PoundForceInchPerFoot).PoundForceInchesPerFoot, PoundForceInchesPerFootTolerance);
            AssertEx.EqualTolerance(1, TorquePerLength.From(1, TorquePerLengthUnit.TonneForceCentimeterPerMeter).TonneForceCentimetersPerMeter, TonneForceCentimetersPerMeterTolerance);
            AssertEx.EqualTolerance(1, TorquePerLength.From(1, TorquePerLengthUnit.TonneForceMeterPerMeter).TonneForceMetersPerMeter, TonneForceMetersPerMeterTolerance);
            AssertEx.EqualTolerance(1, TorquePerLength.From(1, TorquePerLengthUnit.TonneForceMillimeterPerMeter).TonneForceMillimetersPerMeter, TonneForceMillimetersPerMeterTolerance);
        }

        [Fact]
        public void FromNewtonMetersPerMeter_WithInfinityValue_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => TorquePerLength.FromNewtonMetersPerMeter(double.PositiveInfinity));
            Assert.Throws<ArgumentException>(() => TorquePerLength.FromNewtonMetersPerMeter(double.NegativeInfinity));
        }

        [Fact]
        public void FromNewtonMetersPerMeter_WithNanValue_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => TorquePerLength.FromNewtonMetersPerMeter(double.NaN));
        }

        [Fact]
        public void As()
        {
            var newtonmeterpermeter = TorquePerLength.FromNewtonMetersPerMeter(1);
            AssertEx.EqualTolerance(KilogramForceCentimetersPerMeterInOneNewtonMeterPerMeter, newtonmeterpermeter.As(TorquePerLengthUnit.KilogramForceCentimeterPerMeter), KilogramForceCentimetersPerMeterTolerance);
            AssertEx.EqualTolerance(KilogramForceMetersPerMeterInOneNewtonMeterPerMeter, newtonmeterpermeter.As(TorquePerLengthUnit.KilogramForceMeterPerMeter), KilogramForceMetersPerMeterTolerance);
            AssertEx.EqualTolerance(KilogramForceMillimetersPerMeterInOneNewtonMeterPerMeter, newtonmeterpermeter.As(TorquePerLengthUnit.KilogramForceMillimeterPerMeter), KilogramForceMillimetersPerMeterTolerance);
            AssertEx.EqualTolerance(KilonewtonCentimetersPerMeterInOneNewtonMeterPerMeter, newtonmeterpermeter.As(TorquePerLengthUnit.KilonewtonCentimeterPerMeter), KilonewtonCentimetersPerMeterTolerance);
            AssertEx.EqualTolerance(KilonewtonMetersPerMeterInOneNewtonMeterPerMeter, newtonmeterpermeter.As(TorquePerLengthUnit.KilonewtonMeterPerMeter), KilonewtonMetersPerMeterTolerance);
            AssertEx.EqualTolerance(KilonewtonMillimetersPerMeterInOneNewtonMeterPerMeter, newtonmeterpermeter.As(TorquePerLengthUnit.KilonewtonMillimeterPerMeter), KilonewtonMillimetersPerMeterTolerance);
            AssertEx.EqualTolerance(KilopoundForceFeetPerFootInOneNewtonMeterPerMeter, newtonmeterpermeter.As(TorquePerLengthUnit.KilopoundForceFootPerFoot), KilopoundForceFeetPerFootTolerance);
            AssertEx.EqualTolerance(KilopoundForceInchesPerFootInOneNewtonMeterPerMeter, newtonmeterpermeter.As(TorquePerLengthUnit.KilopoundForceInchPerFoot), KilopoundForceInchesPerFootTolerance);
            AssertEx.EqualTolerance(MeganewtonCentimetersPerMeterInOneNewtonMeterPerMeter, newtonmeterpermeter.As(TorquePerLengthUnit.MeganewtonCentimeterPerMeter), MeganewtonCentimetersPerMeterTolerance);
            AssertEx.EqualTolerance(MeganewtonMetersPerMeterInOneNewtonMeterPerMeter, newtonmeterpermeter.As(TorquePerLengthUnit.MeganewtonMeterPerMeter), MeganewtonMetersPerMeterTolerance);
            AssertEx.EqualTolerance(MeganewtonMillimetersPerMeterInOneNewtonMeterPerMeter, newtonmeterpermeter.As(TorquePerLengthUnit.MeganewtonMillimeterPerMeter), MeganewtonMillimetersPerMeterTolerance);
            AssertEx.EqualTolerance(MegapoundForceFeetPerFootInOneNewtonMeterPerMeter, newtonmeterpermeter.As(TorquePerLengthUnit.MegapoundForceFootPerFoot), MegapoundForceFeetPerFootTolerance);
            AssertEx.EqualTolerance(MegapoundForceInchesPerFootInOneNewtonMeterPerMeter, newtonmeterpermeter.As(TorquePerLengthUnit.MegapoundForceInchPerFoot), MegapoundForceInchesPerFootTolerance);
            AssertEx.EqualTolerance(NewtonCentimetersPerMeterInOneNewtonMeterPerMeter, newtonmeterpermeter.As(TorquePerLengthUnit.NewtonCentimeterPerMeter), NewtonCentimetersPerMeterTolerance);
            AssertEx.EqualTolerance(NewtonMetersPerMeterInOneNewtonMeterPerMeter, newtonmeterpermeter.As(TorquePerLengthUnit.NewtonMeterPerMeter), NewtonMetersPerMeterTolerance);
            AssertEx.EqualTolerance(NewtonMillimetersPerMeterInOneNewtonMeterPerMeter, newtonmeterpermeter.As(TorquePerLengthUnit.NewtonMillimeterPerMeter), NewtonMillimetersPerMeterTolerance);
            AssertEx.EqualTolerance(PoundForceFeetPerFootInOneNewtonMeterPerMeter, newtonmeterpermeter.As(TorquePerLengthUnit.PoundForceFootPerFoot), PoundForceFeetPerFootTolerance);
            AssertEx.EqualTolerance(PoundForceInchesPerFootInOneNewtonMeterPerMeter, newtonmeterpermeter.As(TorquePerLengthUnit.PoundForceInchPerFoot), PoundForceInchesPerFootTolerance);
            AssertEx.EqualTolerance(TonneForceCentimetersPerMeterInOneNewtonMeterPerMeter, newtonmeterpermeter.As(TorquePerLengthUnit.TonneForceCentimeterPerMeter), TonneForceCentimetersPerMeterTolerance);
            AssertEx.EqualTolerance(TonneForceMetersPerMeterInOneNewtonMeterPerMeter, newtonmeterpermeter.As(TorquePerLengthUnit.TonneForceMeterPerMeter), TonneForceMetersPerMeterTolerance);
            AssertEx.EqualTolerance(TonneForceMillimetersPerMeterInOneNewtonMeterPerMeter, newtonmeterpermeter.As(TorquePerLengthUnit.TonneForceMillimeterPerMeter), TonneForceMillimetersPerMeterTolerance);
        }

        [Fact]
        public void ToUnit()
        {
            var newtonmeterpermeter = TorquePerLength.FromNewtonMetersPerMeter(1);

            var kilogramforcecentimeterpermeterQuantity = newtonmeterpermeter.ToUnit(TorquePerLengthUnit.KilogramForceCentimeterPerMeter);
            AssertEx.EqualTolerance(KilogramForceCentimetersPerMeterInOneNewtonMeterPerMeter, (double)kilogramforcecentimeterpermeterQuantity.Value, KilogramForceCentimetersPerMeterTolerance);
            Assert.Equal(TorquePerLengthUnit.KilogramForceCentimeterPerMeter, kilogramforcecentimeterpermeterQuantity.Unit);

            var kilogramforcemeterpermeterQuantity = newtonmeterpermeter.ToUnit(TorquePerLengthUnit.KilogramForceMeterPerMeter);
            AssertEx.EqualTolerance(KilogramForceMetersPerMeterInOneNewtonMeterPerMeter, (double)kilogramforcemeterpermeterQuantity.Value, KilogramForceMetersPerMeterTolerance);
            Assert.Equal(TorquePerLengthUnit.KilogramForceMeterPerMeter, kilogramforcemeterpermeterQuantity.Unit);

            var kilogramforcemillimeterpermeterQuantity = newtonmeterpermeter.ToUnit(TorquePerLengthUnit.KilogramForceMillimeterPerMeter);
            AssertEx.EqualTolerance(KilogramForceMillimetersPerMeterInOneNewtonMeterPerMeter, (double)kilogramforcemillimeterpermeterQuantity.Value, KilogramForceMillimetersPerMeterTolerance);
            Assert.Equal(TorquePerLengthUnit.KilogramForceMillimeterPerMeter, kilogramforcemillimeterpermeterQuantity.Unit);

            var kilonewtoncentimeterpermeterQuantity = newtonmeterpermeter.ToUnit(TorquePerLengthUnit.KilonewtonCentimeterPerMeter);
            AssertEx.EqualTolerance(KilonewtonCentimetersPerMeterInOneNewtonMeterPerMeter, (double)kilonewtoncentimeterpermeterQuantity.Value, KilonewtonCentimetersPerMeterTolerance);
            Assert.Equal(TorquePerLengthUnit.KilonewtonCentimeterPerMeter, kilonewtoncentimeterpermeterQuantity.Unit);

            var kilonewtonmeterpermeterQuantity = newtonmeterpermeter.ToUnit(TorquePerLengthUnit.KilonewtonMeterPerMeter);
            AssertEx.EqualTolerance(KilonewtonMetersPerMeterInOneNewtonMeterPerMeter, (double)kilonewtonmeterpermeterQuantity.Value, KilonewtonMetersPerMeterTolerance);
            Assert.Equal(TorquePerLengthUnit.KilonewtonMeterPerMeter, kilonewtonmeterpermeterQuantity.Unit);

            var kilonewtonmillimeterpermeterQuantity = newtonmeterpermeter.ToUnit(TorquePerLengthUnit.KilonewtonMillimeterPerMeter);
            AssertEx.EqualTolerance(KilonewtonMillimetersPerMeterInOneNewtonMeterPerMeter, (double)kilonewtonmillimeterpermeterQuantity.Value, KilonewtonMillimetersPerMeterTolerance);
            Assert.Equal(TorquePerLengthUnit.KilonewtonMillimeterPerMeter, kilonewtonmillimeterpermeterQuantity.Unit);

            var kilopoundforcefootperfootQuantity = newtonmeterpermeter.ToUnit(TorquePerLengthUnit.KilopoundForceFootPerFoot);
            AssertEx.EqualTolerance(KilopoundForceFeetPerFootInOneNewtonMeterPerMeter, (double)kilopoundforcefootperfootQuantity.Value, KilopoundForceFeetPerFootTolerance);
            Assert.Equal(TorquePerLengthUnit.KilopoundForceFootPerFoot, kilopoundforcefootperfootQuantity.Unit);

            var kilopoundforceinchperfootQuantity = newtonmeterpermeter.ToUnit(TorquePerLengthUnit.KilopoundForceInchPerFoot);
            AssertEx.EqualTolerance(KilopoundForceInchesPerFootInOneNewtonMeterPerMeter, (double)kilopoundforceinchperfootQuantity.Value, KilopoundForceInchesPerFootTolerance);
            Assert.Equal(TorquePerLengthUnit.KilopoundForceInchPerFoot, kilopoundforceinchperfootQuantity.Unit);

            var meganewtoncentimeterpermeterQuantity = newtonmeterpermeter.ToUnit(TorquePerLengthUnit.MeganewtonCentimeterPerMeter);
            AssertEx.EqualTolerance(MeganewtonCentimetersPerMeterInOneNewtonMeterPerMeter, (double)meganewtoncentimeterpermeterQuantity.Value, MeganewtonCentimetersPerMeterTolerance);
            Assert.Equal(TorquePerLengthUnit.MeganewtonCentimeterPerMeter, meganewtoncentimeterpermeterQuantity.Unit);

            var meganewtonmeterpermeterQuantity = newtonmeterpermeter.ToUnit(TorquePerLengthUnit.MeganewtonMeterPerMeter);
            AssertEx.EqualTolerance(MeganewtonMetersPerMeterInOneNewtonMeterPerMeter, (double)meganewtonmeterpermeterQuantity.Value, MeganewtonMetersPerMeterTolerance);
            Assert.Equal(TorquePerLengthUnit.MeganewtonMeterPerMeter, meganewtonmeterpermeterQuantity.Unit);

            var meganewtonmillimeterpermeterQuantity = newtonmeterpermeter.ToUnit(TorquePerLengthUnit.MeganewtonMillimeterPerMeter);
            AssertEx.EqualTolerance(MeganewtonMillimetersPerMeterInOneNewtonMeterPerMeter, (double)meganewtonmillimeterpermeterQuantity.Value, MeganewtonMillimetersPerMeterTolerance);
            Assert.Equal(TorquePerLengthUnit.MeganewtonMillimeterPerMeter, meganewtonmillimeterpermeterQuantity.Unit);

            var megapoundforcefootperfootQuantity = newtonmeterpermeter.ToUnit(TorquePerLengthUnit.MegapoundForceFootPerFoot);
            AssertEx.EqualTolerance(MegapoundForceFeetPerFootInOneNewtonMeterPerMeter, (double)megapoundforcefootperfootQuantity.Value, MegapoundForceFeetPerFootTolerance);
            Assert.Equal(TorquePerLengthUnit.MegapoundForceFootPerFoot, megapoundforcefootperfootQuantity.Unit);

            var megapoundforceinchperfootQuantity = newtonmeterpermeter.ToUnit(TorquePerLengthUnit.MegapoundForceInchPerFoot);
            AssertEx.EqualTolerance(MegapoundForceInchesPerFootInOneNewtonMeterPerMeter, (double)megapoundforceinchperfootQuantity.Value, MegapoundForceInchesPerFootTolerance);
            Assert.Equal(TorquePerLengthUnit.MegapoundForceInchPerFoot, megapoundforceinchperfootQuantity.Unit);

            var newtoncentimeterpermeterQuantity = newtonmeterpermeter.ToUnit(TorquePerLengthUnit.NewtonCentimeterPerMeter);
            AssertEx.EqualTolerance(NewtonCentimetersPerMeterInOneNewtonMeterPerMeter, (double)newtoncentimeterpermeterQuantity.Value, NewtonCentimetersPerMeterTolerance);
            Assert.Equal(TorquePerLengthUnit.NewtonCentimeterPerMeter, newtoncentimeterpermeterQuantity.Unit);

            var newtonmeterpermeterQuantity = newtonmeterpermeter.ToUnit(TorquePerLengthUnit.NewtonMeterPerMeter);
            AssertEx.EqualTolerance(NewtonMetersPerMeterInOneNewtonMeterPerMeter, (double)newtonmeterpermeterQuantity.Value, NewtonMetersPerMeterTolerance);
            Assert.Equal(TorquePerLengthUnit.NewtonMeterPerMeter, newtonmeterpermeterQuantity.Unit);

            var newtonmillimeterpermeterQuantity = newtonmeterpermeter.ToUnit(TorquePerLengthUnit.NewtonMillimeterPerMeter);
            AssertEx.EqualTolerance(NewtonMillimetersPerMeterInOneNewtonMeterPerMeter, (double)newtonmillimeterpermeterQuantity.Value, NewtonMillimetersPerMeterTolerance);
            Assert.Equal(TorquePerLengthUnit.NewtonMillimeterPerMeter, newtonmillimeterpermeterQuantity.Unit);

            var poundforcefootperfootQuantity = newtonmeterpermeter.ToUnit(TorquePerLengthUnit.PoundForceFootPerFoot);
            AssertEx.EqualTolerance(PoundForceFeetPerFootInOneNewtonMeterPerMeter, (double)poundforcefootperfootQuantity.Value, PoundForceFeetPerFootTolerance);
            Assert.Equal(TorquePerLengthUnit.PoundForceFootPerFoot, poundforcefootperfootQuantity.Unit);

            var poundforceinchperfootQuantity = newtonmeterpermeter.ToUnit(TorquePerLengthUnit.PoundForceInchPerFoot);
            AssertEx.EqualTolerance(PoundForceInchesPerFootInOneNewtonMeterPerMeter, (double)poundforceinchperfootQuantity.Value, PoundForceInchesPerFootTolerance);
            Assert.Equal(TorquePerLengthUnit.PoundForceInchPerFoot, poundforceinchperfootQuantity.Unit);

            var tonneforcecentimeterpermeterQuantity = newtonmeterpermeter.ToUnit(TorquePerLengthUnit.TonneForceCentimeterPerMeter);
            AssertEx.EqualTolerance(TonneForceCentimetersPerMeterInOneNewtonMeterPerMeter, (double)tonneforcecentimeterpermeterQuantity.Value, TonneForceCentimetersPerMeterTolerance);
            Assert.Equal(TorquePerLengthUnit.TonneForceCentimeterPerMeter, tonneforcecentimeterpermeterQuantity.Unit);

            var tonneforcemeterpermeterQuantity = newtonmeterpermeter.ToUnit(TorquePerLengthUnit.TonneForceMeterPerMeter);
            AssertEx.EqualTolerance(TonneForceMetersPerMeterInOneNewtonMeterPerMeter, (double)tonneforcemeterpermeterQuantity.Value, TonneForceMetersPerMeterTolerance);
            Assert.Equal(TorquePerLengthUnit.TonneForceMeterPerMeter, tonneforcemeterpermeterQuantity.Unit);

            var tonneforcemillimeterpermeterQuantity = newtonmeterpermeter.ToUnit(TorquePerLengthUnit.TonneForceMillimeterPerMeter);
            AssertEx.EqualTolerance(TonneForceMillimetersPerMeterInOneNewtonMeterPerMeter, (double)tonneforcemillimeterpermeterQuantity.Value, TonneForceMillimetersPerMeterTolerance);
            Assert.Equal(TorquePerLengthUnit.TonneForceMillimeterPerMeter, tonneforcemillimeterpermeterQuantity.Unit);
        }

        [Fact]
        public void ConversionRoundTrip()
        {
            TorquePerLength newtonmeterpermeter = TorquePerLength.FromNewtonMetersPerMeter(1);
            AssertEx.EqualTolerance(1, TorquePerLength.FromKilogramForceCentimetersPerMeter(newtonmeterpermeter.KilogramForceCentimetersPerMeter).NewtonMetersPerMeter, KilogramForceCentimetersPerMeterTolerance);
            AssertEx.EqualTolerance(1, TorquePerLength.FromKilogramForceMetersPerMeter(newtonmeterpermeter.KilogramForceMetersPerMeter).NewtonMetersPerMeter, KilogramForceMetersPerMeterTolerance);
            AssertEx.EqualTolerance(1, TorquePerLength.FromKilogramForceMillimetersPerMeter(newtonmeterpermeter.KilogramForceMillimetersPerMeter).NewtonMetersPerMeter, KilogramForceMillimetersPerMeterTolerance);
            AssertEx.EqualTolerance(1, TorquePerLength.FromKilonewtonCentimetersPerMeter(newtonmeterpermeter.KilonewtonCentimetersPerMeter).NewtonMetersPerMeter, KilonewtonCentimetersPerMeterTolerance);
            AssertEx.EqualTolerance(1, TorquePerLength.FromKilonewtonMetersPerMeter(newtonmeterpermeter.KilonewtonMetersPerMeter).NewtonMetersPerMeter, KilonewtonMetersPerMeterTolerance);
            AssertEx.EqualTolerance(1, TorquePerLength.FromKilonewtonMillimetersPerMeter(newtonmeterpermeter.KilonewtonMillimetersPerMeter).NewtonMetersPerMeter, KilonewtonMillimetersPerMeterTolerance);
            AssertEx.EqualTolerance(1, TorquePerLength.FromKilopoundForceFeetPerFoot(newtonmeterpermeter.KilopoundForceFeetPerFoot).NewtonMetersPerMeter, KilopoundForceFeetPerFootTolerance);
            AssertEx.EqualTolerance(1, TorquePerLength.FromKilopoundForceInchesPerFoot(newtonmeterpermeter.KilopoundForceInchesPerFoot).NewtonMetersPerMeter, KilopoundForceInchesPerFootTolerance);
            AssertEx.EqualTolerance(1, TorquePerLength.FromMeganewtonCentimetersPerMeter(newtonmeterpermeter.MeganewtonCentimetersPerMeter).NewtonMetersPerMeter, MeganewtonCentimetersPerMeterTolerance);
            AssertEx.EqualTolerance(1, TorquePerLength.FromMeganewtonMetersPerMeter(newtonmeterpermeter.MeganewtonMetersPerMeter).NewtonMetersPerMeter, MeganewtonMetersPerMeterTolerance);
            AssertEx.EqualTolerance(1, TorquePerLength.FromMeganewtonMillimetersPerMeter(newtonmeterpermeter.MeganewtonMillimetersPerMeter).NewtonMetersPerMeter, MeganewtonMillimetersPerMeterTolerance);
            AssertEx.EqualTolerance(1, TorquePerLength.FromMegapoundForceFeetPerFoot(newtonmeterpermeter.MegapoundForceFeetPerFoot).NewtonMetersPerMeter, MegapoundForceFeetPerFootTolerance);
            AssertEx.EqualTolerance(1, TorquePerLength.FromMegapoundForceInchesPerFoot(newtonmeterpermeter.MegapoundForceInchesPerFoot).NewtonMetersPerMeter, MegapoundForceInchesPerFootTolerance);
            AssertEx.EqualTolerance(1, TorquePerLength.FromNewtonCentimetersPerMeter(newtonmeterpermeter.NewtonCentimetersPerMeter).NewtonMetersPerMeter, NewtonCentimetersPerMeterTolerance);
            AssertEx.EqualTolerance(1, TorquePerLength.FromNewtonMetersPerMeter(newtonmeterpermeter.NewtonMetersPerMeter).NewtonMetersPerMeter, NewtonMetersPerMeterTolerance);
            AssertEx.EqualTolerance(1, TorquePerLength.FromNewtonMillimetersPerMeter(newtonmeterpermeter.NewtonMillimetersPerMeter).NewtonMetersPerMeter, NewtonMillimetersPerMeterTolerance);
            AssertEx.EqualTolerance(1, TorquePerLength.FromPoundForceFeetPerFoot(newtonmeterpermeter.PoundForceFeetPerFoot).NewtonMetersPerMeter, PoundForceFeetPerFootTolerance);
            AssertEx.EqualTolerance(1, TorquePerLength.FromPoundForceInchesPerFoot(newtonmeterpermeter.PoundForceInchesPerFoot).NewtonMetersPerMeter, PoundForceInchesPerFootTolerance);
            AssertEx.EqualTolerance(1, TorquePerLength.FromTonneForceCentimetersPerMeter(newtonmeterpermeter.TonneForceCentimetersPerMeter).NewtonMetersPerMeter, TonneForceCentimetersPerMeterTolerance);
            AssertEx.EqualTolerance(1, TorquePerLength.FromTonneForceMetersPerMeter(newtonmeterpermeter.TonneForceMetersPerMeter).NewtonMetersPerMeter, TonneForceMetersPerMeterTolerance);
            AssertEx.EqualTolerance(1, TorquePerLength.FromTonneForceMillimetersPerMeter(newtonmeterpermeter.TonneForceMillimetersPerMeter).NewtonMetersPerMeter, TonneForceMillimetersPerMeterTolerance);
        }

        [Fact]
        public void ArithmeticOperators()
        {
            TorquePerLength v = TorquePerLength.FromNewtonMetersPerMeter(1);
            AssertEx.EqualTolerance(-1, -v.NewtonMetersPerMeter, NewtonMetersPerMeterTolerance);
            AssertEx.EqualTolerance(2, (TorquePerLength.FromNewtonMetersPerMeter(3)-v).NewtonMetersPerMeter, NewtonMetersPerMeterTolerance);
            AssertEx.EqualTolerance(2, (v + v).NewtonMetersPerMeter, NewtonMetersPerMeterTolerance);
            AssertEx.EqualTolerance(10, (v*10).NewtonMetersPerMeter, NewtonMetersPerMeterTolerance);
            AssertEx.EqualTolerance(10, (10*v).NewtonMetersPerMeter, NewtonMetersPerMeterTolerance);
            AssertEx.EqualTolerance(2, (TorquePerLength.FromNewtonMetersPerMeter(10)/5).NewtonMetersPerMeter, NewtonMetersPerMeterTolerance);
            AssertEx.EqualTolerance(2, TorquePerLength.FromNewtonMetersPerMeter(10)/TorquePerLength.FromNewtonMetersPerMeter(5), NewtonMetersPerMeterTolerance);
        }

        [Fact]
        public void ComparisonOperators()
        {
            TorquePerLength oneNewtonMeterPerMeter = TorquePerLength.FromNewtonMetersPerMeter(1);
            TorquePerLength twoNewtonMetersPerMeter = TorquePerLength.FromNewtonMetersPerMeter(2);

            Assert.True(oneNewtonMeterPerMeter < twoNewtonMetersPerMeter);
            Assert.True(oneNewtonMeterPerMeter <= twoNewtonMetersPerMeter);
            Assert.True(twoNewtonMetersPerMeter > oneNewtonMeterPerMeter);
            Assert.True(twoNewtonMetersPerMeter >= oneNewtonMeterPerMeter);

            Assert.False(oneNewtonMeterPerMeter > twoNewtonMetersPerMeter);
            Assert.False(oneNewtonMeterPerMeter >= twoNewtonMetersPerMeter);
            Assert.False(twoNewtonMetersPerMeter < oneNewtonMeterPerMeter);
            Assert.False(twoNewtonMetersPerMeter <= oneNewtonMeterPerMeter);
        }

        [Fact]
        public void CompareToIsImplemented()
        {
            TorquePerLength newtonmeterpermeter = TorquePerLength.FromNewtonMetersPerMeter(1);
            Assert.Equal(0, newtonmeterpermeter.CompareTo(newtonmeterpermeter));
            Assert.True(newtonmeterpermeter.CompareTo(TorquePerLength.Zero) > 0);
            Assert.True(TorquePerLength.Zero.CompareTo(newtonmeterpermeter) < 0);
        }

        [Fact]
        public void CompareToThrowsOnTypeMismatch()
        {
            TorquePerLength newtonmeterpermeter = TorquePerLength.FromNewtonMetersPerMeter(1);
            Assert.Throws<ArgumentException>(() => newtonmeterpermeter.CompareTo(new object()));
        }

        [Fact]
        public void CompareToThrowsOnNull()
        {
            TorquePerLength newtonmeterpermeter = TorquePerLength.FromNewtonMetersPerMeter(1);
            Assert.Throws<ArgumentNullException>(() => newtonmeterpermeter.CompareTo(null));
        }

        [Fact]
        public void EqualityOperators()
        {
            var a = TorquePerLength.FromNewtonMetersPerMeter(1);
            var b = TorquePerLength.FromNewtonMetersPerMeter(2);

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
            var a = TorquePerLength.FromNewtonMetersPerMeter(1);
            var b = TorquePerLength.FromNewtonMetersPerMeter(2);

            Assert.True(a.Equals(a));
            Assert.False(a.Equals(b));
            Assert.False(a.Equals(null));
        }

        [Fact]
        public void EqualsRelativeToleranceIsImplemented()
        {
            var v = TorquePerLength.FromNewtonMetersPerMeter(1);
            Assert.True(v.Equals(TorquePerLength.FromNewtonMetersPerMeter(1), NewtonMetersPerMeterTolerance, ComparisonType.Relative));
            Assert.False(v.Equals(TorquePerLength.Zero, NewtonMetersPerMeterTolerance, ComparisonType.Relative));
        }

        [Fact]
        public void EqualsReturnsFalseOnTypeMismatch()
        {
            TorquePerLength newtonmeterpermeter = TorquePerLength.FromNewtonMetersPerMeter(1);
            Assert.False(newtonmeterpermeter.Equals(new object()));
        }

        [Fact]
        public void EqualsReturnsFalseOnNull()
        {
            TorquePerLength newtonmeterpermeter = TorquePerLength.FromNewtonMetersPerMeter(1);
            Assert.False(newtonmeterpermeter.Equals(null));
        }

        [Fact]
        public void UnitsDoesNotContainUndefined()
        {
            Assert.DoesNotContain(TorquePerLengthUnit.Undefined, TorquePerLength.Units);
        }

        [Fact]
        public void HasAtLeastOneAbbreviationSpecified()
        {
            var units = Enum.GetValues(typeof(TorquePerLengthUnit)).Cast<TorquePerLengthUnit>();
            foreach(var unit in units)
            {
                if(unit == TorquePerLengthUnit.Undefined)
                    continue;

                var defaultAbbreviation = UnitAbbreviationsCache.Default.GetDefaultAbbreviation(unit);
            }
        }

        [Fact]
        public void BaseDimensionsShouldNeverBeNull()
        {
            Assert.False(TorquePerLength.BaseDimensions is null);
        }
    }
}
