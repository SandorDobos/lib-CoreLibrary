﻿//
// Copyright (c) 2020 The nanoFramework project contributors
// Portions Copyright (c) Microsoft Corporation.  All rights reserved.
// See LICENSE file in the project root for full license information.
//

using System.Runtime.CompilerServices;

namespace System.Diagnostics
{
    /// <summary>
    /// Provides a set of methods and properties that help debug your code.
    /// </summary>
    public static class Debug
    {

        /// <summary>
        /// Causes a break in execution if the specified assertion (condition) evaluates to false.
        /// </summary>
        /// <param name="condition">The condition to be evaluated. If the value is false, program execution stops.</param>
        [Conditional("DEBUG")]
        static public void Assert(bool condition)
        {
            if (!condition)
            {
                Debugger.Break();
            }
        }

        /// <summary>
        /// Causes a break in execution if the specified assertion (condition) evaluates to false.
        /// </summary>
        /// <param name="condition">The condition to be evaluated. If the value is false, program execution stops.</param>
        /// <param name="message">The text to be output if the assertion is false.</param>
        [Conditional("DEBUG")]
        static public void Assert(bool condition, string message)
        {
            if (!condition)
            {
                Debugger.Break();
            }
        }

        /// <summary>
        /// Causes a break in execution if the specified assertion (condition) evaluates to false.
        /// </summary>
        /// <param name="condition">The condition to be evaluated. If the value is false, program execution stops.</param>
        /// <param name="message">The text to be output if the assertion is false.</param>
        /// <param name="detailedMessage">The detailed message to be displayed if the assertion is false.</param>
        [Conditional("DEBUG")]
        static public void Assert(bool condition, string message, string detailedMessage)
        {
            if (!condition)
            {
                Debugger.Break();
            }
        }

        /// <summary>
        /// Writes a message to the trace listeners in the Listeners collection.
        /// </summary>
        /// <param name="message">A message to write.</param>
        /// <remarks>
        /// In nanoFramework implementation the message is output to Visual Studio debugger window.
        /// </remarks>
        [Conditional("DEBUG")]
#pragma warning disable S4200 // Native methods should be wrapped
        public static void Write(string message) => WriteLineNative(message, false);
#pragma warning restore S4200 // Native methods should be wrapped

        /// <summary>
        /// Writes a message followed by a line terminator to the trace listeners in the Listeners collection.
        /// </summary>
        /// <param name="message">A message to write.</param>
        /// <remarks>
        /// In nanoFramework implementation the message is output to Visual Studio debugger window.
        /// </remarks>
        [Conditional("DEBUG")]
#pragma warning disable S4200 // Native methods should be wrapped
        public static void WriteLine(string message) => WriteLineNative(message, true);
#pragma warning restore S4200 // Native methods should be wrapped


        [MethodImpl(MethodImplOptions.InternalCall)]
        extern static private void WriteLineNative(string text, bool addLineFeed);
    }
}