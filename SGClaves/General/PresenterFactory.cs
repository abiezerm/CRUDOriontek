using Autofac;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGClaves.General
{
    class PresenterFactory
    {
        private static IContainer _container;

        public static TPresenter Create<TPresenter, TView>(TView view) where TPresenter : IPresenter<TView>
        {
            var result = _container.Resolve<TPresenter>();
            result.View = view;
            return result;
        }

        public static void SetContainer(IContainer container)
        {
            _container = container;
        }
    }
}
