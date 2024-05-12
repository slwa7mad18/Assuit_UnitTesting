using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarFactoryLibrary;
using Xunit;



namespace CarFactoryLibrary_Task_test
{
    public class BMWTest
    {
        [Fact]
        public void IsStopped_velocity0_true()
        {
            BMW bmw = new BMW();
            bmw.velocity = 0;
            bool result = bmw.IsStopped();
            Assert.True(result);
        }
    }
}
