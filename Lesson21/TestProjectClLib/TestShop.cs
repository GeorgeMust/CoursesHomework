using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary;
using ClassLibrary.Classes;
using ClassLibrary.Exceptions;
using ClassLibrary.Interfaces;
using Microsoft.VisualStudio.TestPlatform.CommunicationUtilities;
using Moq;

namespace TestProjectClLib
{
    [TestFixture]
    internal class TestShop
    {
        private IShopDiscounter discounter;
        private IDb db;
        private Shop shop;
        string itemName = "test";
        ShopItem itm;
       [SetUp]
        public void Setup()
        {
            itm = new ShopItem("test", 10);
            var logger = new Mock<ILogger>();
            logger.Setup(x => x.Warn($"Item with name {itemName} is missed"));
            discounter = new ShopDiscounter(logger.Object);
             var dbMock = new Mock<IDb>();
            dbMock.Setup(x => x.GetItem(itemName)).Returns(itm);
            db = dbMock.Object;
            dbMock.Setup(x => x.AddLogRecord(It.IsAny<string>()));
            shop = new Shop(discounter, logger.Object, itm, db);

        }
        [Test]
        public void ShouldTestWhenItemNotNull()
        {

            var retShopItem= shop.BuyItem(itemName);

            Assert.That(retShopItem, Is.EqualTo(itm));

        }
        [Test]
        public void ShouldTestWhenItemNull()
        {
            string itemName1 = "test1";            

            var ex = Assert.Throws<ShopItemMissedException>(() =>
            {
                var retShopItem = shop.BuyItem(itemName1);
            });
            Assert.That(ex?.Message, Is.EqualTo($"Exception of type 'ClassLibrary.Exceptions.ShopItemMissedException' was thrown."));

        }

    }
}
