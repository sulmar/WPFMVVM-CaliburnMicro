using Caliburn.Micro.Hello.IServices;
using Caliburn.Micro.Hello.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caliburn.Micro.Hello.ViewModels
{
    public class CustomersViewModel : ViewModelBase
    {
        public BindableCollection<Customer> Customers { get; private set; }

        private Customer _selectedCustomer;
        public Customer SelectedCustomer
        {
            get { return _selectedCustomer; }
            set
            {
                _selectedCustomer = value;
                NotifyOfPropertyChange(() => SelectedCustomer);
            }
        }

        private readonly ICustomersService customersService;

        //public CustomersViewModel()
        //    : this(new FakeServices.CustomersService())
        //{

        //}

        public CustomersViewModel(ICustomersService customersService)
        {
            this.customersService = customersService;

            Load();
        }

        private void Load()
        {
            Customers = new BindableCollection<Customer>(customersService.Get());
        }

        public bool CanLogin()
        {
            return true;
            // return !String.IsNullOrEmpty(username) && !String.IsNullOrEmpty(password);
        }

        public void Login()
        {
    
        }
    }
}
