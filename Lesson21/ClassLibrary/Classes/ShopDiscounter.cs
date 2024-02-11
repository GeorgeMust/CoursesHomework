using System;
using System.Collections.Generic;
using ClassLibrary.Interfaces;

namespace ClassLibrary.Classes
{
    public class ShopDiscounter : IShopDiscounter
    {
        ILogger logger;

        public ShopDiscounter(ILogger logger)
        {
            this.logger = logger;
        }

        public IItem AddDiscountToItem(IItem item, int discountPercent)
        {
            if (discountPercent < 0 | discountPercent > 100)
            {
                logger.Warn("Request with wrong discounter");
                throw new Exception("Wrong discount percent");
            }

            var price = item.Price;

            decimal priceToGet = (decimal)(100 - discountPercent)/100;

            item.Price = item.Price * priceToGet;

            return item;
        }
    }
}
