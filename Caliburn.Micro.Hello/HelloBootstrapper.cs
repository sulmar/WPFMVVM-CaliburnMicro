using Caliburn.Micro.Hello.FakeServices;
using Caliburn.Micro.Hello.IServices;
using Caliburn.Micro.Hello.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Caliburn.Micro.Hello
{
    public class HelloBootstrapper : BootstrapperBase
    {
        private SimpleContainer _container = new SimpleContainer();

        public HelloBootstrapper()
        {
            Initialize();
        }

        protected override void Configure()
        {
            _container.Singleton<ShellViewModel>();
            _container.Singleton<ICustomersService, CustomersService>();
        }

        protected override void OnStartup(object sender, StartupEventArgs e)
        {
            // DisplayRootViewFor<ShellViewModel>();

            DisplayRootViewFor<CustomersViewModel>();
        }

        protected override object GetInstance(Type service, string key)
        {
            return _container.GetInstance(service, key);
        }

        protected override IEnumerable<object> GetAllInstances(Type service)
        {
            return _container.GetAllInstances(service);
        }

        protected override void BuildUp(object instance)
        {
            _container.BuildUp(instance);
        }
    }

    public class CustomBootstrapper : BootstrapperBase
    {
        private SimpleContainer _container = new SimpleContainer();

        public CustomBootstrapper()
        {
            _container.Singleton<ICustomersService, CustomersService>();
        }

        protected override void Configure()
        {
           
        }

        protected override object GetInstance(Type service, string key)
        {
            return _container.GetInstance(service, key);
        }

        protected override IEnumerable<object> GetAllInstances(Type service)
        {
            return _container.GetAllInstances(service);
        }

        protected override void BuildUp(object instance)
        {
            _container.BuildUp(instance);
        }

        protected override void OnStartup(object sender, StartupEventArgs e)
        {
            DisplayRootViewFor<CustomersViewModel>();
        }
    }
}
