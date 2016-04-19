using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        // public double add(double FirstValue, double SecondValue)
        [TestMethod]
        public void add_test1()
        {
            matematicka.Class1 NewObject = new matematicka.Class1();
            double result = NewObject.add(0, 0);
            Assert.AreEqual(0, result);
        }
        [TestMethod]
        public void add_test2()
        {
            matematicka.Class1 NewObject = new matematicka.Class1();
            double result = NewObject.add(-1, -8);
            Assert.AreEqual(-9, result);
        }
        [TestMethod]
        public void add_test3()
        {
            matematicka.Class1 NewObject = new matematicka.Class1();
            double result = NewObject.add(-1, 8);
            Assert.AreEqual(7, result);
        }
        [TestMethod]
        public void add_test4()
        {
            matematicka.Class1 NewObject = new matematicka.Class1();
            double result = NewObject.add(9, 10);
            Assert.AreEqual(19, result);
        }
        [TestMethod]
        public void add_test5()
        {
            matematicka.Class1 NewObject = new matematicka.Class1();
            double result = NewObject.add(1, -3);
            Assert.AreEqual(-2, result);
        }
        // public double sub(double FirstValue, double SecondValue)
        [TestMethod]
        public void sub_test1()
        {
            matematicka.Class1 NewObject = new matematicka.Class1();
            double result = NewObject.sub(0, 0);
            Assert.AreEqual(0, result);
        }
        [TestMethod]
        public void sub_test2()
        {
            matematicka.Class1 NewObject = new matematicka.Class1();
            double result = NewObject.sub(-1, -3);
            Assert.AreEqual(2, result);
        }
        [TestMethod]
        public void sub_test3()
        {
            matematicka.Class1 NewObject = new matematicka.Class1();
            double result = NewObject.sub(9, -2);
            Assert.AreEqual(11, result);
        }
        [TestMethod]
        public void sub_test4()
        {
            matematicka.Class1 NewObject = new matematicka.Class1();
            double result = NewObject.sub(-1, 2);
            Assert.AreEqual(-3, result);
        }
        [TestMethod]
        public void sub_test5()
        {
            matematicka.Class1 NewObject = new matematicka.Class1();
            double result = NewObject.sub(100, 99);
            Assert.AreEqual(1, result);
        }
        // public double del(double FirstValue, double SecondValue)
        [TestMethod]
        public void del_test2()
        {
            matematicka.Class1 NewObject = new matematicka.Class1();
            double result = NewObject.del(10, 2);
            Assert.AreEqual(5, result);
        }
        [TestMethod]
        public void del_test3()
        {
            matematicka.Class1 NewObject = new matematicka.Class1();
            double result = NewObject.del(16, -4);
            Assert.AreEqual(-4, result);
        }
        [TestMethod]
        public void del_test4()
        {
            matematicka.Class1 NewObject = new matematicka.Class1();
            double result = NewObject.del(-16, 4);
            Assert.AreEqual(-4, result);
        }
        [TestMethod]
        public void del_test5()
        {
            matematicka.Class1 NewObject = new matematicka.Class1();
            double result = NewObject.del(-16, -4);
            Assert.AreEqual(4, result);
        }
        [TestMethod]
        public void del_test6()
        {
            matematicka.Class1 NewObject = new matematicka.Class1();
            double result = NewObject.del(25, 4);
            Assert.AreEqual(6.25, result);
        }
        [TestMethod]
        public void del_test7()
        {
            matematicka.Class1 NewObject = new matematicka.Class1();
            double result = NewObject.del(0.1, 2);
            Assert.AreEqual(0.05, result);
        }
        [TestMethod]
        public void del_test8()
        {
            matematicka.Class1 NewObject = new matematicka.Class1();
            double result = NewObject.del(-18, 4);
            Assert.AreEqual(-4.5, result);
        }
        [TestMethod]
        public void del_test9()
        {
            matematicka.Class1 NewObject = new matematicka.Class1();
            double result = NewObject.del(1, 0);
            Assert.AreEqual(double.PositiveInfinity, result);
        }
        [TestMethod]
        public void del_test10()
        {
            matematicka.Class1 NewObject = new matematicka.Class1();
            double result = NewObject.del(-1, 0);
            Assert.AreEqual(double.NegativeInfinity, result);
        }
        [TestMethod]
        public void del_test11()
        {
            matematicka.Class1 NewObject = new matematicka.Class1();
            double result = NewObject.del(0, 0);
            Assert.AreEqual(double.NaN, result);
        }
        //  public double nas(double FirstValue, double SecondValue)
        [TestMethod]
        public void nas_test1()
        {
            matematicka.Class1 NewObject = new matematicka.Class1();
            double result = NewObject.nas(2, 4);
            Assert.AreEqual(8, result);
        }
        [TestMethod]
        public void nas_test2()
        {
            matematicka.Class1 NewObject = new matematicka.Class1();
            double result = NewObject.nas(0, 0);
            Assert.AreEqual(0, result);
        }
        [TestMethod]
        public void nas_test3()
        {
            matematicka.Class1 NewObject = new matematicka.Class1();
            double result = NewObject.nas(-7, 3);
            Assert.AreEqual(-21, result);
        }
        [TestMethod]
        public void nas_test4()
        {
            matematicka.Class1 NewObject = new matematicka.Class1();
            double result = NewObject.nas(18, -2);
            Assert.AreEqual(-36, result);
        }
        [TestMethod]
        public void nas_test5()
        {
            matematicka.Class1 NewObject = new matematicka.Class1();
            double result = NewObject.nas(-10, -4);
            Assert.AreEqual(40, result);
        }
        [TestMethod]
        public void nas_test6()
        {
            matematicka.Class1 NewObject = new matematicka.Class1();
            double result = NewObject.nas(-18, 0.5);
            Assert.AreEqual(-9, result);
        }
        [TestMethod]
        public void nas_test7()
        {
            matematicka.Class1 NewObject = new matematicka.Class1();
            double result = NewObject.nas(0.5, -0.25);
            Assert.AreEqual(-0.125, result);
        }
        [TestMethod]
        public void nas_test8()
        {
            matematicka.Class1 NewObject = new matematicka.Class1();
            double result = NewObject.del(0, 4);
            Assert.AreEqual(0, result);
        }
        // public double factorial(double FirstValue)
        [TestMethod]
        public void factorial_test1()
        {
            matematicka.Class1 NewObject = new matematicka.Class1();
            double result = NewObject.factorial(4);
            Assert.AreEqual(24, result);
        }
        [TestMethod]
        public void factorial_test2()
        {
            matematicka.Class1 NewObject = new matematicka.Class1();
            double result = NewObject.factorial(1);
            Assert.AreEqual(1, result);
        }
        [TestMethod]
        public void factorial_test3()
        {
            matematicka.Class1 NewObject = new matematicka.Class1();
            double result = NewObject.factorial(0);
            Assert.AreEqual(1, result);
        }
        [TestMethod]
        public void factorial_test4()
        {
            matematicka.Class1 NewObject = new matematicka.Class1();
            double result = NewObject.factorial(12);
            Assert.AreEqual(479001600, result);
        }
        [TestMethod]
        public void factorial_test5()
        {
            matematicka.Class1 NewObject = new matematicka.Class1();
            double result = NewObject.factorial(-8);
            Assert.AreEqual(double.NaN, result);
        }
        //  public double PowerA(double a, double b)
        [TestMethod]
        public void PowerA_test1()
        {
            matematicka.Class1 NewObject = new matematicka.Class1();
            double result = NewObject.PowerA(2,0);
            Assert.AreEqual(1, result);
        }
        [TestMethod]
        public void PowerA_test2()
        {
            matematicka.Class1 NewObject = new matematicka.Class1();
            double result = NewObject.PowerA(0, 2);
            Assert.AreEqual(0, result);
        }
        [TestMethod]
        public void PowerA_test4()
        {
            matematicka.Class1 NewObject = new matematicka.Class1();
            double result = NewObject.PowerA(4, 1);
            Assert.AreEqual(4, result);
        }
        [TestMethod]
        public void PowerA_test5()
        {
            matematicka.Class1 NewObject = new matematicka.Class1();
            double result = NewObject.PowerA(1, 7);
            Assert.AreEqual(1, result);
        }
        [TestMethod]
        public void PowerA_test6()
        {
            matematicka.Class1 NewObject = new matematicka.Class1();
            double result = NewObject.PowerA(4, 5);
            Assert.AreEqual(1024, result);
        }
        [TestMethod]
        public void PowerA_test7()
        {
            matematicka.Class1 NewObject = new matematicka.Class1();
            double result = NewObject.PowerA(-4, 2);
            Assert.AreEqual(16, result);
        }
        [TestMethod]
        public void PowerA_test8()
        {
            matematicka.Class1 NewObject = new matematicka.Class1();
            double result = NewObject.PowerA(-4, 3);
            Assert.AreEqual(-64, result);
        }
        public void PowerA_test9()
        {
            matematicka.Class1 NewObject = new matematicka.Class1();
            double result = NewObject.PowerA(0, 0);
            Assert.AreEqual(1, result);
        }
        // public double modulo(double FirstValue, double SecondValue)
        [TestMethod]
        public void modulo_test1()
        {
            matematicka.Class1 NewObject = new matematicka.Class1();
            double result = NewObject.modulo(4, 3);
            Assert.AreEqual(1, result);
        }
        [TestMethod]
        public void modulo_test2()
        {
            matematicka.Class1 NewObject = new matematicka.Class1();
            double result = NewObject.modulo(4, 4);
            Assert.AreEqual(0, result);
        }
        [TestMethod]
        public void modulo_test3()
        {
            matematicka.Class1 NewObject = new matematicka.Class1();
            double result = NewObject.modulo(24, 3);
            Assert.AreEqual(0, result);
        }
        [TestMethod]
        public void modulo_test4()
        {
            matematicka.Class1 NewObject = new matematicka.Class1();
            double result = NewObject.modulo(-41, 1);
            Assert.AreEqual(0, result);
        }
        [TestMethod]
        public void modulo_test5()
        {
            matematicka.Class1 NewObject = new matematicka.Class1();
            double result = NewObject.modulo(-48, -47);
            Assert.AreEqual(-1, result);
        }
        //  public double odmocneni(double FirstValue, double SecondValue)
        [TestMethod]
        public void odmocneni_test1()
        {
            matematicka.Class1 NewObject = new matematicka.Class1();
            double result = NewObject.odmocneni(1, 2);
            Assert.AreEqual(2, result);
        }
        [TestMethod]
        public void odmocneni_test2()
        {
            matematicka.Class1 NewObject = new matematicka.Class1();
            double result = NewObject.odmocneni(2, 4);
            Assert.AreEqual(2, result);
        }
        [TestMethod]
        public void odmocneni_test3()
        {
            matematicka.Class1 NewObject = new matematicka.Class1();
            double result = NewObject.odmocneni(2, 1);
            Assert.AreEqual(1, result);
        }
        [TestMethod]
        public void odmocneni_test4()
        {
            matematicka.Class1 NewObject = new matematicka.Class1();
            double result = NewObject.odmocneni(2, 9);
            Assert.AreEqual(3, result);
        }
        [TestMethod]
        public void odmocneni_test5()
        {
            matematicka.Class1 NewObject = new matematicka.Class1();
            double result = NewObject.odmocneni(3, 8);
            Assert.AreEqual(2, result);
        }
        [TestMethod]
        public void odmocneni_test6()
        {
            matematicka.Class1 NewObject = new matematicka.Class1();
            double result = NewObject.odmocneni(2, 36);
            Assert.AreEqual(6, result);
        }
        [TestMethod]
        public void odmocneni_test7()
        {
            matematicka.Class1 NewObject = new matematicka.Class1();
            double result = NewObject.odmocneni(20, 1);
            Assert.AreEqual(1, result);
        }
    }

}