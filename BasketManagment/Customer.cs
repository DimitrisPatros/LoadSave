using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BasketManagment
{
    public class Customer
    {
        [Key]
        [MaxLength(150)]
        public string Email { get; set; }// unque & require
        public string Name { get; set; } //require
        public string Address { get; set; }
        public bool IsActive { get; set; }
        public DateTime Dob { get; set; }
        public DateTime RegisterDay { get; set; }
        //public List<int> Baskets { get; set; }
        public CustomerBaskets Baskets { get; set; }

        public Customer(string email, string name, string address, bool isActive, DateTime dob) //: this(email, name)
        {
            Email = email;
            Name = name;
            Address = address;
            Dob = dob;
            // Baskets = new CustomerBaskets();
            // Baskets = new List<int>();
            //when we register a new customer we set that this customer is active and that he registger today
            RegisterDay = DateTime.Today;
            IsActive = true;
        }

        public Customer(string name, string email)
        {
            Name = name;
            Email = email;
            IsActive = true;
        }
        public override string ToString()
        {
            return $"{Name}:{Address}:{Email}:{IsActive},{Dob}";
        }
    }
}
