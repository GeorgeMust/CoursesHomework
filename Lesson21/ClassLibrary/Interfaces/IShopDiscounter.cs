namespace ClassLibrary.Interfaces
{
    public interface IShopDiscounter
    {
        public IItem AddDiscountToItem(IItem item, int discountPercent);
    }
}
