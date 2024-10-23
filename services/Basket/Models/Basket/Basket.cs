namespace Basket.Models.Basket
{
    public class Basket
    {
        public int UserId { get; set; }
        public List<BasketItem> Items { get; set; }
    }
}
