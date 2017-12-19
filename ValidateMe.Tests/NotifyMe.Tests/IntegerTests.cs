using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ValidateMe.Tests
{
    [TestClass]
    public class IntegerTests
    {
        [TestMethod]
        public void Must_ValidateInt64()
        {
            long testedInt = 1;
            var return1 = testedInt.MustBePositive();

            testedInt = -1;
            var return2 = testedInt.MustBeNegative();

            testedInt = 0;
            var return3 = testedInt.MustBeZero();

            testedInt = 100;
            var return4 = testedInt.MustBeEven();

            testedInt = 103;
            var return5 = testedInt.MustBeOdd();

            testedInt = 9;
            var return6 = testedInt.MustBeEqual(9);
            var return7 = testedInt.MustBeGreaterThan(8);
            var return8 = testedInt.MustBeSmallerThan(10);

            Assert.IsTrue(return1);
            Assert.IsTrue(return2);
            Assert.IsTrue(return3);
            Assert.IsTrue(return4);
            Assert.IsTrue(return5);
            Assert.IsTrue(return6);
            Assert.IsTrue(return7);
            Assert.IsTrue(return8);

        }

        [TestMethod]
        public void Must_ValidateInt32()
        {
            int testedInt = 1;
            var return1 = testedInt.MustBePositive();

            testedInt = -1;
            var return2 = testedInt.MustBeNegative();

            testedInt = 0;
            var return3 = testedInt.MustBeZero();

            testedInt = 100;
            var return4 = testedInt.MustBeEven();

            testedInt = 103;
            var return5 = testedInt.MustBeOdd();

            testedInt = 9;
            var return6 = testedInt.MustBeEqual(9);
            var return7 = testedInt.MustBeGreaterThan(8);
            var return8 = testedInt.MustBeSmallerThan(10);

            Assert.IsTrue(return1);
            Assert.IsTrue(return2);
            Assert.IsTrue(return3);
            Assert.IsTrue(return4);
            Assert.IsTrue(return5);
            Assert.IsTrue(return6);
            Assert.IsTrue(return7);
            Assert.IsTrue(return8);
        }

        [TestMethod]
        public void Must_ValidateInt16()
        {
            short testedInt = 1;
            var return1 = testedInt.MustBePositive();

            testedInt = -1;
            var return2 = testedInt.MustBeNegative();

            testedInt = 0;
            var return3 = testedInt.MustBeZero();

            testedInt = 100;
            var return4 = testedInt.MustBeEven();

            testedInt = 103;
            var return5 = testedInt.MustBeOdd();

            testedInt = 9;
            var return6 = testedInt.MustBeEqual(9);
            var return7 = testedInt.MustBeGreaterThan(8);
            var return8 = testedInt.MustBeSmallerThan(10);

            Assert.IsTrue(return1);
            Assert.IsTrue(return2);
            Assert.IsTrue(return3);
            Assert.IsTrue(return4);
            Assert.IsTrue(return5);
            Assert.IsTrue(return6);
            Assert.IsTrue(return7);
            Assert.IsTrue(return8);
        }

        [TestMethod]
        public void Must_ValidateUInt64()
        {
            ulong testedInt = 1;

            testedInt = 0;
            var return1 = testedInt.MustBeZero();

            testedInt = 100;
            var return2 = testedInt.MustBeEven();

            testedInt = 103;
            var return3 = testedInt.MustBeOdd();

            testedInt = 9;
            var return4 = testedInt.MustBeEqual(9);
            var return5 = testedInt.MustBeGreaterThan(8);
            var return6 = testedInt.MustBeSmallerThan(10);

            Assert.IsTrue(return1);
            Assert.IsTrue(return2);
            Assert.IsTrue(return3);
            Assert.IsTrue(return4);
            Assert.IsTrue(return5);
            Assert.IsTrue(return6);
        }

        [TestMethod]
        public void Must_ValidateUInt32()
        {
            uint testedInt = 1;

            testedInt = 0;
            var return1 = testedInt.MustBeZero();

            testedInt = 100;
            var return2 = testedInt.MustBeEven();

            testedInt = 103;
            var return3 = testedInt.MustBeOdd();

            testedInt = 9;
            var return4 = testedInt.MustBeEqual(9);
            var return5 = testedInt.MustBeGreaterThan(8);
            var return6 = testedInt.MustBeSmallerThan(10);

            Assert.IsTrue(return1);
            Assert.IsTrue(return2);
            Assert.IsTrue(return3);
            Assert.IsTrue(return4);
            Assert.IsTrue(return5);
            Assert.IsTrue(return6);
        }

        [TestMethod]
        public void Must_ValidateUInt16()
        {
            ushort testedInt = 1;

            testedInt = 0;
            var return1 = testedInt.MustBeZero();

            testedInt = 100;
            var return2 = testedInt.MustBeEven();

            testedInt = 103;
            var return3 = testedInt.MustBeOdd();

            testedInt = 9;
            var return4 = testedInt.MustBeEqual(9);
            var return5 = testedInt.MustBeGreaterThan(8);
            var return6 = testedInt.MustBeSmallerThan(10);

            Assert.IsTrue(return1);
            Assert.IsTrue(return2);
            Assert.IsTrue(return3);
            Assert.IsTrue(return4);
            Assert.IsTrue(return5);
            Assert.IsTrue(return6);
        }

        [TestMethod]
        public void Must_ValidateNullableInt16()
        { 
            short? testedInt = 1;
            var return1 = testedInt.MustBePositive();

            testedInt = -1;
            var return2 = testedInt.MustBeNegative();

            testedInt = 0;
            var return3 = testedInt.MustBeZero();

            testedInt = 100;
            var return4 = testedInt.MustBeEven();

            testedInt = 103;
            var return5 = testedInt.MustBeOdd();

            testedInt = 9;
            var return6 = testedInt.MustBeEqual(9);
            var return7 = testedInt.MustBeGreaterThan(8);
            var return8 = testedInt.MustBeSmallerThan(10);

            Assert.IsTrue(return1);
            Assert.IsTrue(return2);
            Assert.IsTrue(return3);
            Assert.IsTrue(return4);
            Assert.IsTrue(return5);
            Assert.IsTrue(return6);
            Assert.IsTrue(return7);
            Assert.IsTrue(return8);

        }

        [TestMethod]
        public void Must_ValidateNullableInt64()
        {
            long? testedInt = 1;
            var return1 = testedInt.MustBePositive();

            testedInt = -1;
            var return2 = testedInt.MustBeNegative();

            testedInt = 0;
            var return3 = testedInt.MustBeZero();

            testedInt = 100;
            var return4 = testedInt.MustBeEven();

            testedInt = 103;
            var return5 = testedInt.MustBeOdd();

            testedInt = 9;
            var return6 = testedInt.MustBeEqual(9);
            var return7 = testedInt.MustBeGreaterThan(8);
            var return8 = testedInt.MustBeSmallerThan(10);

            Assert.IsTrue(return1);
            Assert.IsTrue(return2);
            Assert.IsTrue(return3);
            Assert.IsTrue(return4);
            Assert.IsTrue(return5);
            Assert.IsTrue(return6);
            Assert.IsTrue(return7);
            Assert.IsTrue(return8);
        }

        [TestMethod]
        public void Must_ValidateNullableInt32()
        {
            int? testedInt = 1;
            var return1 = testedInt.MustBePositive();

            testedInt = -1;
            var return2 = testedInt.MustBeNegative();

            testedInt = 0;
            var return3 = testedInt.MustBeZero();

            testedInt = 100;
            var return4 = testedInt.MustBeEven();

            testedInt = 103;
            var return5 = testedInt.MustBeOdd();

            testedInt = 9;
            var return6 = testedInt.MustBeEqual(9);
            var return7 = testedInt.MustBeGreaterThan(8);
            var return8 = testedInt.MustBeSmallerThan(10);

            Assert.IsTrue(return1);
            Assert.IsTrue(return2);
            Assert.IsTrue(return3);
            Assert.IsTrue(return4);
            Assert.IsTrue(return5);
            Assert.IsTrue(return6);
            Assert.IsTrue(return7);
            Assert.IsTrue(return8);
        }
    }
}
