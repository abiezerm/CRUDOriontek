using SGClaves.General;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGClaves.Presenter
{
    public interface IOficinaPresenter :IPresenter<IOficina>
    {

    }
    public class OficinaPresenter : PresenterBase, IOficinaPresenter
    {
        public IOficina View
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
