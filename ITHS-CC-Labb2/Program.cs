using ITHS_CC_Labb2;
using static ITHS_CC_Labb2.Order;

IOrder slowOrder = new Order
{
    ID = Guid.NewGuid(),
    Email = "slowEmail@example.com",
    Priority = Status.Normal,
    TotalPrice = 100,
};

IOrderService orderService = new OrderService(slowOrder, new ConsoleWriteLoggingStrategy());

orderService.Start();  