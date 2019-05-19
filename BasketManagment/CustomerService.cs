using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BasketManagment
{
    class CustomerService : ICustomerService
    {
        public bool AddBasket(string email, Basket basket)
        {
            try
            {
                using (var context = new OrderManagmentDbContext())
                {
                    var query = context.Set<Customer>().SingleOrDefault(c => c.Email == email);
                    if (query != null)
                    {
                        query.Baskets.Add(basket.BasketId);
                        context.Add(basket);
                        context.SaveChanges();
                    }
                    return true;
                }
            }
            catch (Exception e)
            {

                return false;
            }
        }

        public bool Delete(string email)
        {
            try
            {
                using (var context = new OrderManagmentDbContext())
                {
                    var query = context.Set<Customer>().SingleOrDefault(c => c.Email == email);
                    if (query != null)
                    {
                        query.IsActive = false;
                        context.SaveChanges();
                    }
                    else
                    {
                        Console.WriteLine("No customer with this email not found");
                    }
                    return true;
                }
            }
            catch (Exception e)
            {

                return false;
            }

        }

        public bool DeleteBasket(string email, int basketId)
        {
            try
            {
                using (var context = new OrderManagmentDbContext())
                {
                    var query = context.Set<Customer>().SingleOrDefault(c => c.Email == email);
                    if (query != null)
                    {
                        var basketRemover = context.Set<Basket>().SingleOrDefault(b => b.BasketId == basketId);
                        query.Baskets.Remove(basketId);
                        context.Remove(basketRemover);
                        context.SaveChanges();
                    }
                    return true;
                }
            }
            catch (Exception e)
            {
                return false;
            }
        }

        public List<Customer> GetRecentCustomers()
        {
 
            using (var context = new OrderManagmentDbContext())
            {
                var customerList = new List<Customer>();
                customerList = context.Set<Customer>()
                    .Where(t=>t.RegisterDay.AddDays(30)>=DateTime.Today)
                    .ToList();
                //this return all the customer that have been registered the last month
                return customerList;
            }

        }

        public bool Register(string email, string name, string address, DateTime birthDate)
        {
            using (var context = new OrderManagmentDbContext())
            {
                context.Add(new Customer(email, name, address, true, birthDate));
                context.SaveChanges();
                return true;
            }
        }

        public bool Update(string email, string name, string address, DateTime birthDate,bool status,string newEmail)
        {
            try
            {
                using (var context = new OrderManagmentDbContext())
                {
                    var query = context.Set<Customer>().SingleOrDefault(c => c.Email == email);
                    if (query != null)
                    {
                        query.Email = newEmail;
                        query.Name = name;
                        query.Address = address;
                        query.Dob = birthDate;
                        query.IsActive = status;
                        context.SaveChanges();
                    }
                    return true;
                }
            }
            catch (Exception e)
            {

                return false;
            }
        }
    }
}
