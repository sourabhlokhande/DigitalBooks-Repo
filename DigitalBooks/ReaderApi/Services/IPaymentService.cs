﻿using ModelService.Model;

namespace ReaderApi.Services
{
    public interface IPaymentService
    {
        string BuyBook(Payment payment);
    }
}