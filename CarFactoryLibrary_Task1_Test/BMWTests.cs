using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarFactoryLibrary;

namespace CarFactoryLibrary_Task1_Test
{
    public class BMWTests
    {

        //bool
        [Fact]
        public void IsStopped_velocity0_true()
        {
            BMW bmw = new BMW();
            bmw.velocity = 0;
            bool result = bmw.IsStopped();
            Assert.True(result);
        }

        [Fact]
        public void IsStopped_velocity1_true() {
            BMW bMW = new BMW();
            bMW.velocity = 1;
            bool result = bMW.IsStopped();
            Assert.False(result);
        }

        //numaric
        [Fact]
        public void IncreaseVelocity_1Add10()
        {
            BMW bMW = new BMW();
            bMW.velocity = 1;
            double newVolacity = 10;
            bMW.IncreaseVelocity(newVolacity);
            Assert.Equal(11, bMW.velocity);
            Assert.InRange(bMW.velocity, 10,15);
        }

        //string
        [Fact]
        public void GetType_BMW()
        {
            BMW bMW = new BMW();
            bMW.carTypes=CarTypes.BMW;
            string res=bMW.GetType();
            Assert.Equal(CarTypes.BMW.ToString(), res);
            // Assert.StartsWith("s",res);
            Assert.StartsWith("B",res);
            Assert.EndsWith("W", res);
            Assert.Contains("M", res);
            Assert.DoesNotContain("N", res);

        }

        //refrence
        [Fact]
        public void GetMyCar_SameCar()
        {
            BMW bMW = new BMW();
            Car car = bMW.GetMyCar();
            Assert.Same(bMW, car);
        }
        //type
        [Fact]
        public void NewCar_CarType_Honda()
        {
            Car? car = CarFactory.NewCar(CarTypes.Toyota);
            Assert.NotNull(car);
            Assert.IsType<Toyota>(car);
        }

        [Fact]
        public void NewCar_Exception()
        {
            Assert.Throws<NotImplementedException>(() =>
            {
                Car? result = CarFactory.NewCar(CarTypes.Honda);
            });
        }


    }
}
