using Caliburn.Micro.Hello.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caliburn.Micro.Hello.IServices
{
    public interface ICustomersService
    {
        IList<Customer> Get();
    }
}
