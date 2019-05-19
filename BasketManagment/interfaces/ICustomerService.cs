﻿using System;
using System.Collections.Generic;

namespace BasketManagment
{
    interface ICustomerService
    {
        bool Register(string email, string name, string address, DateTime birthDate);

        bool Update(string email, string name, string address, DateTime birthDate,bool status,string newEmail);

        bool Delete(string email);

        bool AddBasket(string email, Basket basket);
        bool DeleteBasket(string email, int basketId);

        List<Customer> GetRecentCustomers();
    }
}