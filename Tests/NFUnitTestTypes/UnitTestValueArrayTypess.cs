//
// Copyright (c) .NET Foundation and Contributors
// Portions Copyright (c) Microsoft Corporation.  All rights reserved.
// See LICENSE file in the project root for full license information.
//

using nanoFramework.TestFramework;
using System;
using System.Diagnostics;

namespace NFUnitTestTypes
{
    [TestClass]
    public class ValueArrayTypes
    {
        [TestMethod]
        public void ValueArray01_Test()
        {
            Debug.WriteLine(" Section 4.1");
            Debug.WriteLine(" byte is an alias for System.Byte");
            ValueArrayTestClass01.testMethod();
        }

        [TestMethod]
        public void ValueArray02_Test()
        {
            Debug.WriteLine(" Section 4.1");
            Debug.WriteLine(" char is an alias for System.Char");
            ValueArrayTestClass02.testMethod();
        }

        [TestMethod]
        public void ValueArray03_Test()
        {
            Debug.WriteLine(" Section 4.1");
            Debug.WriteLine(" short is an alias for System.Int16");
            ValueArrayTestClass03.testMethod();
        }

        [TestMethod]
        public void ValueArray04_Test()
        {
            Debug.WriteLine(" Section 4.1");
            Debug.WriteLine(" int is an alias for System.Int32");
            ValueArrayTestClass04.testMethod();
        }

        [TestMethod]
        public void ValueArray05_Test()
        {
            Debug.WriteLine(" Section 4.1");
            Debug.WriteLine(" long is an alias for System.Int64");
            ValueArrayTestClass05.testMethod();
        }

        [TestMethod]
        public void ValueArray06_Test()
        {
            Debug.WriteLine(" Section 4.1");
            Debug.WriteLine(" float is an alias for System.Single");
            ValueArrayTestClass06.testMethod();
        }

        [TestMethod]
        public void ValueArray07_Test()
        {
            Debug.WriteLine(" Section 4.1");
            Debug.WriteLine(" double is an alias for System.Double");
            ValueArrayTestClass07.testMethod();
        }
        [TestMethod]
        public void ValueArray09_Test()
        {
            Debug.WriteLine(" Section 4.1");
            Debug.WriteLine(" bool is an alias for System.Boolean");
            ValueArrayTestClass09.testMethod();
        }

        [TestMethod]
        public void ValueArray12_Test()
        {
            Debug.WriteLine(" Section 4.1");
            Debug.WriteLine(" Because a simple type aliases a struct type, every simple type has members.");
            Debug.WriteLine("This test is expected to fail");
            ValueArrayTestClass12.testMethod();
        }

        [TestMethod]
        public void ValueArray13_Test()
        {
            Debug.WriteLine(" Section 4.1");
            Debug.WriteLine(" sbyte is an alias for System.SByte");
            ValueArrayTestClass13.testMethod();
        }

        [TestMethod]
        public void ValueArray14_Test()
        {
            Debug.WriteLine(" Section 4.1");
            Debug.WriteLine(" ushort is an alias for System.UInt16");
            ValueArrayTestClass14.testMethod();
        }
        [TestMethod]
        public void ValueArray15_Test()
        {
            Debug.WriteLine(" Section 4.1");
            Debug.WriteLine(" uint is an alias for System.UInt32");
            ValueArrayTestClass15.testMethod();
        }


        //Compiled Test Cases 
        public class ValueArrayTestClass01
        {
            public static void testMethod()
            {
                byte[] b = { 0 };
                Assert.IsType(b.GetType(), Type.GetType("System.Byte[]"));
            }
        }
        public class ValueArrayTestClass02
        {
            public static void testMethod()
            {
                char[] c = { 'a' };
                Assert.IsType(c.GetType(), Type.GetType("System.Char[]"));
            }
        }
        public class ValueArrayTestClass03
        {
            public static void testMethod()
            {
                short[] s = { 0 };
                Assert.IsType(s.GetType(), Type.GetType("System.Int16[]"));
            }
        }
        public class ValueArrayTestClass04
        {
            public static void testMethod()
            {
                int[] i = { 0 };
                Assert.IsType(i.GetType(), Type.GetType("System.Int32[]"));
            }
        }
        public class ValueArrayTestClass05
        {
            public static void testMethod()
            {
                long[] l = { 0L };
                Assert.IsType(l.GetType(), Type.GetType("System.Int64[]"));
            }
        }
        public class ValueArrayTestClass06
        {
            public static void testMethod()
            {
                float[] f = { 0.0f };
                Assert.IsType(f.GetType(), Type.GetType("System.Single[]"));
            }
        }
        public class ValueArrayTestClass07
        {
            public static void testMethod()
            {
                double[] d = { 0.0d };
                Assert.IsType(d.GetType(), Type.GetType("System.Double[]"));
            }
        }
        public class ValueArrayTestClass09
        {
            public static void testMethod()
            {
                bool[] b = { true };
                Assert.IsType(b.GetType(), Type.GetType("System.Boolean[]"));
            }
        }

        public class ValueArrayTestClass12
        {
            public static void testMethod()
            {
                string[] b = { "string" };
                Assert.IsType(b.GetType(), Type.GetType("System.String[]"));
            }
        }
        public class ValueArrayTestClass13
        {
            public static void testMethod()
            {
                sbyte[] b = { 0 };
                Assert.IsType(b.GetType(), Type.GetType("System.SByte[]"));
            }
        }
        public class ValueArrayTestClass14
        {
            public static void testMethod()
            {
                ushort[] s = { 0 };
                Assert.IsType(s.GetType(), Type.GetType("System.UInt16[]"));
            }
        }
        public class ValueArrayTestClass15
        {
            public static void testMethod()
            {
                uint[] i = { 0 };
                Assert.IsType(i.GetType(), Type.GetType("System.UInt32[]"));
            }
        }
    }
}
