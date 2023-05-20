﻿using Core.Entities.OrderAggregate;
using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Interfaces.Specification
{
    public interface IPaymentService
    {
        Task<CustomerBasket> CreateOrUpdatePaymentIntent(string basketId);
        Task<Order> UpdateOrderPaymentSucceeded(string paymentIntentId);
        Task<Order> UpdateOrderPaymentFailed(string paymentIntentId);
    }
}
