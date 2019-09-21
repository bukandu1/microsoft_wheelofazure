using System;
using System.Collections.Generic;
using Wheel_of_Azure;
using Xunit;

namespace UnitTests_Wheel
{
    public class XUnitWheelTest
    {
        [Fact]
        public void TestWheelDollarValues()
        {
            Wheel wheel = new Wheel();
            List<int> dollarValues = new List<int>() { 2500,
                600,
                700,
                600,
                650,
                500,
                700,
                0,
                0,
                0,
                0,
                0,
                600,
                550,
                500,
                600,
                650,
                700,
                800,
                500,
                800,
                500,
                650,
                500 };
            int PrizeAmount = wheel.WheelSpin();
            Assert.Contains(PrizeAmount, dollarValues);
        }
      
        public void TestWheel()
        {
            Wheel wheel = new Wheel();
            HashSet<int> ValuesInWheel = new HashSet<int>();
            foreach (int i in wheel.WheelOfAzure)
            {
                ValuesInWheel.Add(i);
            }

            for (int i = 0; i < 50; i++)
            {
                bool res = ValuesInWheel.Contains(wheel.WheelSpin());
                Assert.True(res);
            }
        }


    }
}
