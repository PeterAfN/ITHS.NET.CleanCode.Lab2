namespace ITHS_CC_Labb2
{
    public class Order : IOrder
    {
        public Guid ID { get; set; }
        public int TotalPrice { get; set; }
        public Status Priority { get; set; }
        public string Email { get; set; }

        public enum Status
        {
            Normal,
            Quick,
            LightningSpeed
        }
    }

    //public enum OrderStatus
    //{
    //    Normal,
    //    Quick,
    //    LightningSpeed
    //}
}
