using ClassLibrary.Exceptions;
using ClassLibrary.Interfaces;

namespace ClassLibrary
{
    public class Shop
    {
        private IShopDiscounter discounter;

        private ILogger logger;

        private IDb dataBase;

        public Shop(IShopDiscounter discounter, ILogger logger, IItem item, IDb dataBase)
        {
            this.discounter = discounter;
            this.logger = logger;
            this.dataBase = dataBase;
        }

        public IItem BuyItem(string itemName)
        {
            var item = dataBase.GetItem(itemName);

            if (item == null)
            {
                string errorMessage = $"Item with name {itemName} is missed";
                logger.Warn(errorMessage);
                throw new ShopItemMissedException();
            }

            return item;
        }

        public IItem BuyItemWithDiscount(string itemName, int discountPercent)
        {
            IItem item = this.BuyItem(itemName);

            return discounter.AddDiscountToItem(item, discountPercent);
        }
    }
}
