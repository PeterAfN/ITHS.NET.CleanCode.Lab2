﻿using static ITHS_CC_Labb2.Order;

namespace ITHS_CC_Labb2
{
    public class OrderService : IOrderService
    {
        private readonly IOrder _iOrder;
        private readonly ILoggingStrategy _iLoggingStrategy;

        public OrderService(IOrder iOrder, ILoggingStrategy iLoggingStrategy)
        {
            _iOrder = iOrder;
            _iLoggingStrategy = iLoggingStrategy;
        }

        public void Start()
        {
            StatusLogger _log = new(_iLoggingStrategy);
            _log.Status("Attempting to process order with ID " + _iOrder.ID);

            if (Process())
            {
                _log.Status("Succesfully processed order with ID " + _iOrder.ID);

                IEmail email = new Email();
                email.SendNotifiction(_iOrder.Email, _iOrder.ID);
            }
            else
                _log.Status("FAILED ORDER: Could not ship order with ID " + _iOrder.ID);
        }

        public bool Process()
        {
            switch (_iOrder.Priority)
            {
                case Status.Normal:
                    // Some logic we don't care about,
                    return true;
                case Status.Quick:
                    // Some logic we don't care about
                    return true;
                case Status.LightningSpeed:
                    // Some logic we don't care about
                    return true;
                default: return false;
            }
        }
    }
}
