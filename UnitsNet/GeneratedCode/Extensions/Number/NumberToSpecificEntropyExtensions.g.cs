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
//     Add Extensions\MyQuantityExtensions.cs to decorate quantities with new behavior.
//     Add UnitDefinitions\MyQuantity.json and run GeneratUnits.bat to generate new units or quantities.
//
// </auto-generated>
//------------------------------------------------------------------------------

// Copyright (c) 2013 Andreas Gullberg Larsen (andreas.larsen84@gmail.com).
// https://github.com/angularsen/UnitsNet
//
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
//
// The above copyright notice and this permission notice shall be included in
// all copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
// THE SOFTWARE.

using System;

// Windows Runtime Component does not support extension methods and method overloads: https://msdn.microsoft.com/en-us/library/br230301.aspx
#if !WINDOWS_UWP
namespace UnitsNet.Extensions.NumberToSpecificEntropy
{
    public static class NumberToSpecificEntropyExtensions
    {
        #region CaloriePerGramKelvin

        /// <inheritdoc cref="SpecificEntropy.FromCaloriesPerGramKelvin(UnitsNet.QuantityValue)" />
        public static SpecificEntropy CaloriesPerGramKelvin(this int value) => SpecificEntropy.FromCaloriesPerGramKelvin(value);

        /// <inheritdoc cref="SpecificEntropy.FromCaloriesPerGramKelvin(UnitsNet.QuantityValue)" />
        public static SpecificEntropy? CaloriesPerGramKelvin(this int? value) => SpecificEntropy.FromCaloriesPerGramKelvin(value);

        /// <inheritdoc cref="SpecificEntropy.FromCaloriesPerGramKelvin(UnitsNet.QuantityValue)" />
        public static SpecificEntropy CaloriesPerGramKelvin(this long value) => SpecificEntropy.FromCaloriesPerGramKelvin(value);

        /// <inheritdoc cref="SpecificEntropy.FromCaloriesPerGramKelvin(UnitsNet.QuantityValue)" />
        public static SpecificEntropy? CaloriesPerGramKelvin(this long? value) => SpecificEntropy.FromCaloriesPerGramKelvin(value);

        /// <inheritdoc cref="SpecificEntropy.FromCaloriesPerGramKelvin(UnitsNet.QuantityValue)" />
        public static SpecificEntropy CaloriesPerGramKelvin(this double value) => SpecificEntropy.FromCaloriesPerGramKelvin(value);

        /// <inheritdoc cref="SpecificEntropy.FromCaloriesPerGramKelvin(UnitsNet.QuantityValue)" />
        public static SpecificEntropy? CaloriesPerGramKelvin(this double? value) => SpecificEntropy.FromCaloriesPerGramKelvin(value);

        /// <inheritdoc cref="SpecificEntropy.FromCaloriesPerGramKelvin(UnitsNet.QuantityValue)" />
        public static SpecificEntropy CaloriesPerGramKelvin(this float value) => SpecificEntropy.FromCaloriesPerGramKelvin(value);

        /// <inheritdoc cref="SpecificEntropy.FromCaloriesPerGramKelvin(UnitsNet.QuantityValue)" />
        public static SpecificEntropy? CaloriesPerGramKelvin(this float? value) => SpecificEntropy.FromCaloriesPerGramKelvin(value);

        /// <inheritdoc cref="SpecificEntropy.FromCaloriesPerGramKelvin(UnitsNet.QuantityValue)" />
        public static SpecificEntropy CaloriesPerGramKelvin(this decimal value) => SpecificEntropy.FromCaloriesPerGramKelvin(Convert.ToDouble(value));

        /// <inheritdoc cref="SpecificEntropy.FromCaloriesPerGramKelvin(UnitsNet.QuantityValue)" />
        public static SpecificEntropy? CaloriesPerGramKelvin(this decimal? value) => SpecificEntropy.FromCaloriesPerGramKelvin(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

        #region JoulePerKilogramDegreeCelsius

        /// <inheritdoc cref="SpecificEntropy.FromJoulesPerKilogramDegreeCelsius(UnitsNet.QuantityValue)" />
        public static SpecificEntropy JoulesPerKilogramDegreeCelsius(this int value) => SpecificEntropy.FromJoulesPerKilogramDegreeCelsius(value);

        /// <inheritdoc cref="SpecificEntropy.FromJoulesPerKilogramDegreeCelsius(UnitsNet.QuantityValue)" />
        public static SpecificEntropy? JoulesPerKilogramDegreeCelsius(this int? value) => SpecificEntropy.FromJoulesPerKilogramDegreeCelsius(value);

        /// <inheritdoc cref="SpecificEntropy.FromJoulesPerKilogramDegreeCelsius(UnitsNet.QuantityValue)" />
        public static SpecificEntropy JoulesPerKilogramDegreeCelsius(this long value) => SpecificEntropy.FromJoulesPerKilogramDegreeCelsius(value);

        /// <inheritdoc cref="SpecificEntropy.FromJoulesPerKilogramDegreeCelsius(UnitsNet.QuantityValue)" />
        public static SpecificEntropy? JoulesPerKilogramDegreeCelsius(this long? value) => SpecificEntropy.FromJoulesPerKilogramDegreeCelsius(value);

        /// <inheritdoc cref="SpecificEntropy.FromJoulesPerKilogramDegreeCelsius(UnitsNet.QuantityValue)" />
        public static SpecificEntropy JoulesPerKilogramDegreeCelsius(this double value) => SpecificEntropy.FromJoulesPerKilogramDegreeCelsius(value);

        /// <inheritdoc cref="SpecificEntropy.FromJoulesPerKilogramDegreeCelsius(UnitsNet.QuantityValue)" />
        public static SpecificEntropy? JoulesPerKilogramDegreeCelsius(this double? value) => SpecificEntropy.FromJoulesPerKilogramDegreeCelsius(value);

        /// <inheritdoc cref="SpecificEntropy.FromJoulesPerKilogramDegreeCelsius(UnitsNet.QuantityValue)" />
        public static SpecificEntropy JoulesPerKilogramDegreeCelsius(this float value) => SpecificEntropy.FromJoulesPerKilogramDegreeCelsius(value);

        /// <inheritdoc cref="SpecificEntropy.FromJoulesPerKilogramDegreeCelsius(UnitsNet.QuantityValue)" />
        public static SpecificEntropy? JoulesPerKilogramDegreeCelsius(this float? value) => SpecificEntropy.FromJoulesPerKilogramDegreeCelsius(value);

        /// <inheritdoc cref="SpecificEntropy.FromJoulesPerKilogramDegreeCelsius(UnitsNet.QuantityValue)" />
        public static SpecificEntropy JoulesPerKilogramDegreeCelsius(this decimal value) => SpecificEntropy.FromJoulesPerKilogramDegreeCelsius(Convert.ToDouble(value));

        /// <inheritdoc cref="SpecificEntropy.FromJoulesPerKilogramDegreeCelsius(UnitsNet.QuantityValue)" />
        public static SpecificEntropy? JoulesPerKilogramDegreeCelsius(this decimal? value) => SpecificEntropy.FromJoulesPerKilogramDegreeCelsius(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

        #region JoulePerKilogramKelvin

        /// <inheritdoc cref="SpecificEntropy.FromJoulesPerKilogramKelvin(UnitsNet.QuantityValue)" />
        public static SpecificEntropy JoulesPerKilogramKelvin(this int value) => SpecificEntropy.FromJoulesPerKilogramKelvin(value);

        /// <inheritdoc cref="SpecificEntropy.FromJoulesPerKilogramKelvin(UnitsNet.QuantityValue)" />
        public static SpecificEntropy? JoulesPerKilogramKelvin(this int? value) => SpecificEntropy.FromJoulesPerKilogramKelvin(value);

        /// <inheritdoc cref="SpecificEntropy.FromJoulesPerKilogramKelvin(UnitsNet.QuantityValue)" />
        public static SpecificEntropy JoulesPerKilogramKelvin(this long value) => SpecificEntropy.FromJoulesPerKilogramKelvin(value);

        /// <inheritdoc cref="SpecificEntropy.FromJoulesPerKilogramKelvin(UnitsNet.QuantityValue)" />
        public static SpecificEntropy? JoulesPerKilogramKelvin(this long? value) => SpecificEntropy.FromJoulesPerKilogramKelvin(value);

        /// <inheritdoc cref="SpecificEntropy.FromJoulesPerKilogramKelvin(UnitsNet.QuantityValue)" />
        public static SpecificEntropy JoulesPerKilogramKelvin(this double value) => SpecificEntropy.FromJoulesPerKilogramKelvin(value);

        /// <inheritdoc cref="SpecificEntropy.FromJoulesPerKilogramKelvin(UnitsNet.QuantityValue)" />
        public static SpecificEntropy? JoulesPerKilogramKelvin(this double? value) => SpecificEntropy.FromJoulesPerKilogramKelvin(value);

        /// <inheritdoc cref="SpecificEntropy.FromJoulesPerKilogramKelvin(UnitsNet.QuantityValue)" />
        public static SpecificEntropy JoulesPerKilogramKelvin(this float value) => SpecificEntropy.FromJoulesPerKilogramKelvin(value);

        /// <inheritdoc cref="SpecificEntropy.FromJoulesPerKilogramKelvin(UnitsNet.QuantityValue)" />
        public static SpecificEntropy? JoulesPerKilogramKelvin(this float? value) => SpecificEntropy.FromJoulesPerKilogramKelvin(value);

        /// <inheritdoc cref="SpecificEntropy.FromJoulesPerKilogramKelvin(UnitsNet.QuantityValue)" />
        public static SpecificEntropy JoulesPerKilogramKelvin(this decimal value) => SpecificEntropy.FromJoulesPerKilogramKelvin(Convert.ToDouble(value));

        /// <inheritdoc cref="SpecificEntropy.FromJoulesPerKilogramKelvin(UnitsNet.QuantityValue)" />
        public static SpecificEntropy? JoulesPerKilogramKelvin(this decimal? value) => SpecificEntropy.FromJoulesPerKilogramKelvin(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

        #region KilocaloriePerGramKelvin

        /// <inheritdoc cref="SpecificEntropy.FromKilocaloriesPerGramKelvin(UnitsNet.QuantityValue)" />
        public static SpecificEntropy KilocaloriesPerGramKelvin(this int value) => SpecificEntropy.FromKilocaloriesPerGramKelvin(value);

        /// <inheritdoc cref="SpecificEntropy.FromKilocaloriesPerGramKelvin(UnitsNet.QuantityValue)" />
        public static SpecificEntropy? KilocaloriesPerGramKelvin(this int? value) => SpecificEntropy.FromKilocaloriesPerGramKelvin(value);

        /// <inheritdoc cref="SpecificEntropy.FromKilocaloriesPerGramKelvin(UnitsNet.QuantityValue)" />
        public static SpecificEntropy KilocaloriesPerGramKelvin(this long value) => SpecificEntropy.FromKilocaloriesPerGramKelvin(value);

        /// <inheritdoc cref="SpecificEntropy.FromKilocaloriesPerGramKelvin(UnitsNet.QuantityValue)" />
        public static SpecificEntropy? KilocaloriesPerGramKelvin(this long? value) => SpecificEntropy.FromKilocaloriesPerGramKelvin(value);

        /// <inheritdoc cref="SpecificEntropy.FromKilocaloriesPerGramKelvin(UnitsNet.QuantityValue)" />
        public static SpecificEntropy KilocaloriesPerGramKelvin(this double value) => SpecificEntropy.FromKilocaloriesPerGramKelvin(value);

        /// <inheritdoc cref="SpecificEntropy.FromKilocaloriesPerGramKelvin(UnitsNet.QuantityValue)" />
        public static SpecificEntropy? KilocaloriesPerGramKelvin(this double? value) => SpecificEntropy.FromKilocaloriesPerGramKelvin(value);

        /// <inheritdoc cref="SpecificEntropy.FromKilocaloriesPerGramKelvin(UnitsNet.QuantityValue)" />
        public static SpecificEntropy KilocaloriesPerGramKelvin(this float value) => SpecificEntropy.FromKilocaloriesPerGramKelvin(value);

        /// <inheritdoc cref="SpecificEntropy.FromKilocaloriesPerGramKelvin(UnitsNet.QuantityValue)" />
        public static SpecificEntropy? KilocaloriesPerGramKelvin(this float? value) => SpecificEntropy.FromKilocaloriesPerGramKelvin(value);

        /// <inheritdoc cref="SpecificEntropy.FromKilocaloriesPerGramKelvin(UnitsNet.QuantityValue)" />
        public static SpecificEntropy KilocaloriesPerGramKelvin(this decimal value) => SpecificEntropy.FromKilocaloriesPerGramKelvin(Convert.ToDouble(value));

        /// <inheritdoc cref="SpecificEntropy.FromKilocaloriesPerGramKelvin(UnitsNet.QuantityValue)" />
        public static SpecificEntropy? KilocaloriesPerGramKelvin(this decimal? value) => SpecificEntropy.FromKilocaloriesPerGramKelvin(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

        #region KilojoulePerKilogramDegreeCelsius

        /// <inheritdoc cref="SpecificEntropy.FromKilojoulesPerKilogramDegreeCelsius(UnitsNet.QuantityValue)" />
        public static SpecificEntropy KilojoulesPerKilogramDegreeCelsius(this int value) => SpecificEntropy.FromKilojoulesPerKilogramDegreeCelsius(value);

        /// <inheritdoc cref="SpecificEntropy.FromKilojoulesPerKilogramDegreeCelsius(UnitsNet.QuantityValue)" />
        public static SpecificEntropy? KilojoulesPerKilogramDegreeCelsius(this int? value) => SpecificEntropy.FromKilojoulesPerKilogramDegreeCelsius(value);

        /// <inheritdoc cref="SpecificEntropy.FromKilojoulesPerKilogramDegreeCelsius(UnitsNet.QuantityValue)" />
        public static SpecificEntropy KilojoulesPerKilogramDegreeCelsius(this long value) => SpecificEntropy.FromKilojoulesPerKilogramDegreeCelsius(value);

        /// <inheritdoc cref="SpecificEntropy.FromKilojoulesPerKilogramDegreeCelsius(UnitsNet.QuantityValue)" />
        public static SpecificEntropy? KilojoulesPerKilogramDegreeCelsius(this long? value) => SpecificEntropy.FromKilojoulesPerKilogramDegreeCelsius(value);

        /// <inheritdoc cref="SpecificEntropy.FromKilojoulesPerKilogramDegreeCelsius(UnitsNet.QuantityValue)" />
        public static SpecificEntropy KilojoulesPerKilogramDegreeCelsius(this double value) => SpecificEntropy.FromKilojoulesPerKilogramDegreeCelsius(value);

        /// <inheritdoc cref="SpecificEntropy.FromKilojoulesPerKilogramDegreeCelsius(UnitsNet.QuantityValue)" />
        public static SpecificEntropy? KilojoulesPerKilogramDegreeCelsius(this double? value) => SpecificEntropy.FromKilojoulesPerKilogramDegreeCelsius(value);

        /// <inheritdoc cref="SpecificEntropy.FromKilojoulesPerKilogramDegreeCelsius(UnitsNet.QuantityValue)" />
        public static SpecificEntropy KilojoulesPerKilogramDegreeCelsius(this float value) => SpecificEntropy.FromKilojoulesPerKilogramDegreeCelsius(value);

        /// <inheritdoc cref="SpecificEntropy.FromKilojoulesPerKilogramDegreeCelsius(UnitsNet.QuantityValue)" />
        public static SpecificEntropy? KilojoulesPerKilogramDegreeCelsius(this float? value) => SpecificEntropy.FromKilojoulesPerKilogramDegreeCelsius(value);

        /// <inheritdoc cref="SpecificEntropy.FromKilojoulesPerKilogramDegreeCelsius(UnitsNet.QuantityValue)" />
        public static SpecificEntropy KilojoulesPerKilogramDegreeCelsius(this decimal value) => SpecificEntropy.FromKilojoulesPerKilogramDegreeCelsius(Convert.ToDouble(value));

        /// <inheritdoc cref="SpecificEntropy.FromKilojoulesPerKilogramDegreeCelsius(UnitsNet.QuantityValue)" />
        public static SpecificEntropy? KilojoulesPerKilogramDegreeCelsius(this decimal? value) => SpecificEntropy.FromKilojoulesPerKilogramDegreeCelsius(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

        #region KilojoulePerKilogramKelvin

        /// <inheritdoc cref="SpecificEntropy.FromKilojoulesPerKilogramKelvin(UnitsNet.QuantityValue)" />
        public static SpecificEntropy KilojoulesPerKilogramKelvin(this int value) => SpecificEntropy.FromKilojoulesPerKilogramKelvin(value);

        /// <inheritdoc cref="SpecificEntropy.FromKilojoulesPerKilogramKelvin(UnitsNet.QuantityValue)" />
        public static SpecificEntropy? KilojoulesPerKilogramKelvin(this int? value) => SpecificEntropy.FromKilojoulesPerKilogramKelvin(value);

        /// <inheritdoc cref="SpecificEntropy.FromKilojoulesPerKilogramKelvin(UnitsNet.QuantityValue)" />
        public static SpecificEntropy KilojoulesPerKilogramKelvin(this long value) => SpecificEntropy.FromKilojoulesPerKilogramKelvin(value);

        /// <inheritdoc cref="SpecificEntropy.FromKilojoulesPerKilogramKelvin(UnitsNet.QuantityValue)" />
        public static SpecificEntropy? KilojoulesPerKilogramKelvin(this long? value) => SpecificEntropy.FromKilojoulesPerKilogramKelvin(value);

        /// <inheritdoc cref="SpecificEntropy.FromKilojoulesPerKilogramKelvin(UnitsNet.QuantityValue)" />
        public static SpecificEntropy KilojoulesPerKilogramKelvin(this double value) => SpecificEntropy.FromKilojoulesPerKilogramKelvin(value);

        /// <inheritdoc cref="SpecificEntropy.FromKilojoulesPerKilogramKelvin(UnitsNet.QuantityValue)" />
        public static SpecificEntropy? KilojoulesPerKilogramKelvin(this double? value) => SpecificEntropy.FromKilojoulesPerKilogramKelvin(value);

        /// <inheritdoc cref="SpecificEntropy.FromKilojoulesPerKilogramKelvin(UnitsNet.QuantityValue)" />
        public static SpecificEntropy KilojoulesPerKilogramKelvin(this float value) => SpecificEntropy.FromKilojoulesPerKilogramKelvin(value);

        /// <inheritdoc cref="SpecificEntropy.FromKilojoulesPerKilogramKelvin(UnitsNet.QuantityValue)" />
        public static SpecificEntropy? KilojoulesPerKilogramKelvin(this float? value) => SpecificEntropy.FromKilojoulesPerKilogramKelvin(value);

        /// <inheritdoc cref="SpecificEntropy.FromKilojoulesPerKilogramKelvin(UnitsNet.QuantityValue)" />
        public static SpecificEntropy KilojoulesPerKilogramKelvin(this decimal value) => SpecificEntropy.FromKilojoulesPerKilogramKelvin(Convert.ToDouble(value));

        /// <inheritdoc cref="SpecificEntropy.FromKilojoulesPerKilogramKelvin(UnitsNet.QuantityValue)" />
        public static SpecificEntropy? KilojoulesPerKilogramKelvin(this decimal? value) => SpecificEntropy.FromKilojoulesPerKilogramKelvin(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

        #region MegajoulePerKilogramDegreeCelsius

        /// <inheritdoc cref="SpecificEntropy.FromMegajoulesPerKilogramDegreeCelsius(UnitsNet.QuantityValue)" />
        public static SpecificEntropy MegajoulesPerKilogramDegreeCelsius(this int value) => SpecificEntropy.FromMegajoulesPerKilogramDegreeCelsius(value);

        /// <inheritdoc cref="SpecificEntropy.FromMegajoulesPerKilogramDegreeCelsius(UnitsNet.QuantityValue)" />
        public static SpecificEntropy? MegajoulesPerKilogramDegreeCelsius(this int? value) => SpecificEntropy.FromMegajoulesPerKilogramDegreeCelsius(value);

        /// <inheritdoc cref="SpecificEntropy.FromMegajoulesPerKilogramDegreeCelsius(UnitsNet.QuantityValue)" />
        public static SpecificEntropy MegajoulesPerKilogramDegreeCelsius(this long value) => SpecificEntropy.FromMegajoulesPerKilogramDegreeCelsius(value);

        /// <inheritdoc cref="SpecificEntropy.FromMegajoulesPerKilogramDegreeCelsius(UnitsNet.QuantityValue)" />
        public static SpecificEntropy? MegajoulesPerKilogramDegreeCelsius(this long? value) => SpecificEntropy.FromMegajoulesPerKilogramDegreeCelsius(value);

        /// <inheritdoc cref="SpecificEntropy.FromMegajoulesPerKilogramDegreeCelsius(UnitsNet.QuantityValue)" />
        public static SpecificEntropy MegajoulesPerKilogramDegreeCelsius(this double value) => SpecificEntropy.FromMegajoulesPerKilogramDegreeCelsius(value);

        /// <inheritdoc cref="SpecificEntropy.FromMegajoulesPerKilogramDegreeCelsius(UnitsNet.QuantityValue)" />
        public static SpecificEntropy? MegajoulesPerKilogramDegreeCelsius(this double? value) => SpecificEntropy.FromMegajoulesPerKilogramDegreeCelsius(value);

        /// <inheritdoc cref="SpecificEntropy.FromMegajoulesPerKilogramDegreeCelsius(UnitsNet.QuantityValue)" />
        public static SpecificEntropy MegajoulesPerKilogramDegreeCelsius(this float value) => SpecificEntropy.FromMegajoulesPerKilogramDegreeCelsius(value);

        /// <inheritdoc cref="SpecificEntropy.FromMegajoulesPerKilogramDegreeCelsius(UnitsNet.QuantityValue)" />
        public static SpecificEntropy? MegajoulesPerKilogramDegreeCelsius(this float? value) => SpecificEntropy.FromMegajoulesPerKilogramDegreeCelsius(value);

        /// <inheritdoc cref="SpecificEntropy.FromMegajoulesPerKilogramDegreeCelsius(UnitsNet.QuantityValue)" />
        public static SpecificEntropy MegajoulesPerKilogramDegreeCelsius(this decimal value) => SpecificEntropy.FromMegajoulesPerKilogramDegreeCelsius(Convert.ToDouble(value));

        /// <inheritdoc cref="SpecificEntropy.FromMegajoulesPerKilogramDegreeCelsius(UnitsNet.QuantityValue)" />
        public static SpecificEntropy? MegajoulesPerKilogramDegreeCelsius(this decimal? value) => SpecificEntropy.FromMegajoulesPerKilogramDegreeCelsius(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

        #region MegajoulePerKilogramKelvin

        /// <inheritdoc cref="SpecificEntropy.FromMegajoulesPerKilogramKelvin(UnitsNet.QuantityValue)" />
        public static SpecificEntropy MegajoulesPerKilogramKelvin(this int value) => SpecificEntropy.FromMegajoulesPerKilogramKelvin(value);

        /// <inheritdoc cref="SpecificEntropy.FromMegajoulesPerKilogramKelvin(UnitsNet.QuantityValue)" />
        public static SpecificEntropy? MegajoulesPerKilogramKelvin(this int? value) => SpecificEntropy.FromMegajoulesPerKilogramKelvin(value);

        /// <inheritdoc cref="SpecificEntropy.FromMegajoulesPerKilogramKelvin(UnitsNet.QuantityValue)" />
        public static SpecificEntropy MegajoulesPerKilogramKelvin(this long value) => SpecificEntropy.FromMegajoulesPerKilogramKelvin(value);

        /// <inheritdoc cref="SpecificEntropy.FromMegajoulesPerKilogramKelvin(UnitsNet.QuantityValue)" />
        public static SpecificEntropy? MegajoulesPerKilogramKelvin(this long? value) => SpecificEntropy.FromMegajoulesPerKilogramKelvin(value);

        /// <inheritdoc cref="SpecificEntropy.FromMegajoulesPerKilogramKelvin(UnitsNet.QuantityValue)" />
        public static SpecificEntropy MegajoulesPerKilogramKelvin(this double value) => SpecificEntropy.FromMegajoulesPerKilogramKelvin(value);

        /// <inheritdoc cref="SpecificEntropy.FromMegajoulesPerKilogramKelvin(UnitsNet.QuantityValue)" />
        public static SpecificEntropy? MegajoulesPerKilogramKelvin(this double? value) => SpecificEntropy.FromMegajoulesPerKilogramKelvin(value);

        /// <inheritdoc cref="SpecificEntropy.FromMegajoulesPerKilogramKelvin(UnitsNet.QuantityValue)" />
        public static SpecificEntropy MegajoulesPerKilogramKelvin(this float value) => SpecificEntropy.FromMegajoulesPerKilogramKelvin(value);

        /// <inheritdoc cref="SpecificEntropy.FromMegajoulesPerKilogramKelvin(UnitsNet.QuantityValue)" />
        public static SpecificEntropy? MegajoulesPerKilogramKelvin(this float? value) => SpecificEntropy.FromMegajoulesPerKilogramKelvin(value);

        /// <inheritdoc cref="SpecificEntropy.FromMegajoulesPerKilogramKelvin(UnitsNet.QuantityValue)" />
        public static SpecificEntropy MegajoulesPerKilogramKelvin(this decimal value) => SpecificEntropy.FromMegajoulesPerKilogramKelvin(Convert.ToDouble(value));

        /// <inheritdoc cref="SpecificEntropy.FromMegajoulesPerKilogramKelvin(UnitsNet.QuantityValue)" />
        public static SpecificEntropy? MegajoulesPerKilogramKelvin(this decimal? value) => SpecificEntropy.FromMegajoulesPerKilogramKelvin(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

    }
}
#endif
