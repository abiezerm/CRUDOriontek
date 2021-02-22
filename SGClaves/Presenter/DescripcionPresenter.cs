using SGClaves.General;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGClaves.Presenter
{
    public interface IDescripcionPresenter : IPresenter<IDescripcion>
    {

    }
    public class DescripcionPresenter : PresenterBase, IDescripcionPresenter
    {
        public IDescripcion View
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }

        public event CompletedOperationDelegate CompleteEvent;
    }
}
