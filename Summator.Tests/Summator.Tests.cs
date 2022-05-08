using NUnit.Framework;

namespace Summator.Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        
        [Test]
        public void Test_Sum_Of_Two_Possitive_Nummbers()
        {
            long actual_result = Summator.Sum(new int[] { 5, 7 });
            int expected_result = 12;

       
            Assert.That(actual_result, Is.EqualTo(expected_result));
        }
        [Test]
        public void Test_Sum_Of_Two_Negative_Nummbers()
        {
            long actual_result = Summator.Sum(new int[] { -7, -10 });
            int expected_result = -17;


            Assert.That(actual_result, Is.EqualTo(expected_result));
        }
        [Test]
        public void Test_Sum_Of_One_Positive_Nummbers()
        {
            long actual_result = Summator.Sum(new int[] { 8 });
            int expected_result = 8;


            Assert.That(actual_result, Is.EqualTo(expected_result));
        }

        [Test]
        public void Test_Sum_Of_One_Empty_Arrey()
        {
            long actual_result = Summator.Sum(new int[] { });
            int expected_result = 0;


            Assert.That(actual_result, Is.EqualTo(expected_result));
        }


        [Test]
        public void Test_Averege_Of_Two_Possitive_Nummbers()
        {
            double actual_result = Summator.Averege(new double[] { 5, 7 });
            double expected_result = 6;

          
            Assert.That(actual_result, Is.EqualTo(expected_result));
        }
        [Test]
        public void Test_Sum_Of_Big_Amounts()
        {
            long actual_result = Summator.Sum(new int[] { 200000000, 500000000 });
            long expected_result = 700000000;


            Assert.That(actual_result, Is.EqualTo(expected_result));
        }
        [Test]
        public void Test_Averege_Of_Tree_Negative_Nummbers()
        {
            double actual_result = Summator.Averege(new double[] { -4, -8, -6 });
            double expected_result = -6;

            Assert.That(actual_result, Is.EqualTo(expected_result));
        }

        [Test]
        public void Test_Averege_Of_Two_Floating_Positive_Nummbers()
        {
            double actual_result = Summator.Averege(new double[] { 4.5, 4.5 });
            double expected_result = 4.5;


            Assert.That(expected_result == actual_result);
        }
        [Test]
        public void Test_Averege_Of_Two_Floating_Negative_Nummbers()
        {
            double actual_result = Summator.Averege(new double[] { -8, -6 });
            double expected_result = -7;


            Assert.That(expected_result == actual_result);
        }
        [Test]
        public void Test_Averege_Of_Zero_And_One_Positive_Nummber()
        {
            double actual_result = Summator.Averege(new double[] { 0, 5 });
            double expected_result = 2.5;


             Assert.That(expected_result == actual_result);
        }
        [Test]
        public void Test_Averege_Of_Zero_And_One_Negative_Nummber()
        {
            double actual_result = Summator.Averege(new double[] { 0, -6 });
            double expected_result = -3;


            Assert.That(expected_result == actual_result);
        }
        [Test]
        public void Test_Averege_Of_Two_Zeros()
        {
            double actual_result = Summator.Averege(new double[] { 0, 0 });
            double expected_result = 0;


            Assert.That(expected_result == actual_result);
        }
    }
}