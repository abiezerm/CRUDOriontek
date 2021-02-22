using System;


namespace SGClaves.General
{
    public interface IAlertMessageView : IFormView
    {
        void AlertMessage(string message, TimeSpan timeSpan);
        void AlertMessage(string message);
    }

    public interface IFormView : IView
    {
        void CloseForm();
    }

    public interface IView
    {

    }
}
