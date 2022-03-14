using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcApp01.Models
{
    public class CustomerBO
    {
        public List<CustomerModel> Customers { get; set; }

        public CustomerBO()
        {
            Customers = new List<CustomerModel>
            {
                new CustomerModel{ Id = 101, CName = "Anil", City = "Delhi", Mobile = "7321737838"},
                new CustomerModel{ Id = 102, CName = "Harshit", City = "Lucknow", Mobile = "7388226762"}
            };
        }
    }
}
