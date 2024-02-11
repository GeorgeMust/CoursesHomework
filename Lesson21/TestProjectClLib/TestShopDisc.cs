using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary.Classes;
using ClassLibrary.Interfaces;
using Moq;

namespace TestProjectClLib
{
    [TestFixture]
    public class TestDiscounter
    {
        private IShopDiscounter discounter;

        [SetUp]
        public void Setup()
        {
            var logger = new Mock<ILogger>();
            logger.Setup(x => x.Warn(It.IsAny<string>()));
            logger.Setup(x => x.IsAvailable()).Returns(true);
            discounter = new ShopDiscounter(logger.Object);
        }
        [TearDown]
        public void Cleanup()
        {
            discounter = null;
        }
        [TestCase(10)]
        public void ShouldReturnItemWithCorrectPriceWhenCalled(int percent)
        {
            decimal price = 10;
            var itm = new ShopItem("test", price);
            var result = discounter.AddDiscountToItem(itm, percent);

            Assert.That(result.Price, Is.EqualTo(9.0M));
        }
        [TestCase(120)]
        public void ShouldThrowWhenPercentIsInvalid(int percent)
        {
            decimal price = 10;
            var itm = new ShopItem("test", price);

            var ex = Assert.Throws<Exception>(() =>
            {
                discounter.AddDiscountToItem(itm, percent);
            });
            Assert.That(ex?.Message, Is.EqualTo("Wrong discount percent"));
        }        
    }
}
