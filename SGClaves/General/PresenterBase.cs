
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SGClaves.General
{
    public interface IPresenter<TView>
    {
        TView View { get; set; }
        CancellationTokenSource CancellationTokenSource { get; set; }
        CancellationToken CancellationToken { get; set; }
        event PresenterBase.CompletedOperationDelegate CompleteEvent;
    }

   
    public abstract class PresenterBase
    {
        private CancellationTokenSource _cancellationToken;
        public CancellationToken CancellationToken { get; set; }
        protected PresenterBase()
        {

        }
        public CancellationTokenSource CancellationTokenSource
        {
            get
            {
                return _cancellationToken ?? new CancellationTokenSource();
            }
            set
            {
                _cancellationToken = value;
            }
        }
        protected Task<T> StartAsyncProcess<T>(Func<T> action)
        {
            var currentCulture = Thread.CurrentThread.CurrentCulture;
            var currentUICulture = Thread.CurrentThread.CurrentUICulture;

            return Task<T>.Factory.StartNew(() =>
            {
                Thread.CurrentThread.CurrentCulture = currentCulture;
                Thread.CurrentThread.CurrentUICulture = currentUICulture;
                return action();
            });
        }

        protected Task<T> CreateTask<T>(Func<T> action)
        {
            var currentCulture = Thread.CurrentThread.CurrentCulture;
            var currentUICulture = Thread.CurrentThread.CurrentUICulture;
            var task = new Task<T>(() =>
            {
                Thread.CurrentThread.CurrentCulture = currentCulture;
                Thread.CurrentThread.CurrentUICulture = currentUICulture;
                return action();
            });
            return task;
        }

        protected Task StartAsyncProcess(Action action)
        {
            var currentCulture = Thread.CurrentThread.CurrentCulture;
            var currentUICulture = Thread.CurrentThread.CurrentUICulture;
            var task = Task.Factory.StartNew(() =>
            {
                Thread.CurrentThread.CurrentCulture = currentCulture;
                Thread.CurrentThread.CurrentUICulture = currentUICulture;
                action();
            });
            return task;
        }
        public virtual void OperationCanceled()
        {
            throw new NotImplementedException();
        }
        public delegate void CompletedOperationDelegate(ObjectCallBack sender);

        public event EventHandler<EventArgs> ForceClose;

        public void CloseModule()
        {
            ForceClose(null, null);
        }
    }
}
