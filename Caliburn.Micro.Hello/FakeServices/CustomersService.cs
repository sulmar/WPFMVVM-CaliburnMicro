using Caliburn.Micro.Hello.Fakers;
using Caliburn.Micro.Hello.IServices;
using Caliburn.Micro.Hello.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caliburn.Micro.Hello.FakeServices
{
    public class CustomersService : ICustomersService
    {
        CustomerFaker customerFaker = new CustomerFaker();

        IList<Customer> customers;

        public CustomersService()
        {
            customers = customerFaker.Generate(100);
        }

        public IList<Customer> Get() => customers;
    }
}
