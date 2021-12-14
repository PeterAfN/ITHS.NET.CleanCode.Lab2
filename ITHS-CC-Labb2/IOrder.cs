using static ITHS_CC_Labb2.Order;

namespace ITHS_CC_Labb2
{
    public interface IOrder
    {
        public Guid ID { get; set; }
        public int TotalPrice { get; set; }
        public Status Priority { get; set; }
        public string Email { get; set; }
    }
}
