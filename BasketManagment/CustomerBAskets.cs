using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace BasketManagment
{
    public  class CustomerBaskets
    {
        [Key]
        public int CustomerBasketstId { get; set; }

        public List<Basket> BasketsId { get; set; }

        public CustomerBaskets()
        {
            BasketsId = new List<Basket>();
        }
    }
}
