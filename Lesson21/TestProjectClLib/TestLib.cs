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
    internal class ShopLoggerTest
    {
        [Test]
        public void ShouldCurrehtWarnWhenEqualMess()
        {
            string mes = "Wrn mess";
            var dbMock = new Mock<IDb>();
            dbMock.Setup(x => x.AddLogRecord(It.IsAny<string>()));
            ShopLogger logger = new ShopLogger(dbMock.Object);

            logger.Warn(mes);

            dbMock.Verify(x => x.AddLogRecord($"WARN: {mes}"));
        }
        [Test]
        public void ShouldCurrehtInfoWhenEqualMess()
        {
            string mes = "Inf mess";
            var dbMock = new Mock<IDb>();
            dbMock.Setup(x => x.AddLogRecord(It.IsAny<string>()));
            ShopLogger logger = new ShopLogger(dbMock.Object);

            logger.Info(mes);

            dbMock.Verify(x => x.AddLogRecord($"INFO: {mes}"));
        }

        [TestCase(true)]
        [TestCase(false)]
        public void ShouldAvailWhenItem(bool item)
        {
            var dbMock = new Mock<IDb>();
            dbMock.Setup(x => x.IsAvailable()).Returns(item);
            ShopLogger logger = new ShopLogger(dbMock.Object);

            var rezult = logger.IsAvailable();

            Assert.IsTrue(rezult == item);
        }
    }
}
