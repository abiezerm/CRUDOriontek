using DevExpress.XtraBars.Alerter;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Drawing;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SGClaves
{
    public partial class FormBase : XtraForm
    {
        private readonly AlertControl _alertControl;
        private Label _timer;
        public FormBase()
        {
            var focus = new AlertButton(Properties.Resources.opendoc_16x16) { Hint = "Mostrar modulo", Name = "btnFocusModulo", Style = AlertButtonStyle.Button };
            _alertControl = new AlertControl();
            {
                _alertControl.ShowCloseButton = true;
                _alertControl.FormMaxCount = 10;
                _alertControl.FormLocation = AlertFormLocation.BottomRight;
                _alertControl.FormShowingEffect = AlertFormShowingEffect.MoveHorizontal;
                _alertControl.Buttons.Add(focus);
                _alertControl.AutoHeight = true;
                _alertControl.FormLoad += AlertControlOnFormLoad;
                _alertControl.ButtonClick += AlertControlOnButtonClick;
                _alertControl.BeforeFormShow += AlertControlOnBeforeFormShow;
            }
            //InitializeComponent();
        }
        private void AlertControlOnFormLoad(object sender, AlertFormLoadEventArgs alertFormLoadEventArgs)
        {
            alertFormLoadEventArgs.AlertForm.Pin = true;
        }

        private void AlertControlOnBeforeFormShow(object sender, AlertFormEventArgs alertFormEventArgs)
        {
            _timer.Parent = alertFormEventArgs.AlertForm;
            _timer.Location = new Point(32, 57);
        }

        private void AlertControlOnButtonClick(object sender, AlertButtonClickEventArgs e)
        {
            if (e.ButtonName == "btnFocusModulo")
            {
                Focus();

                if (MdiParent.WindowState == FormWindowState.Minimized)
                {
                    MdiParent.WindowState = FormWindowState.Maximized;
                }
                if (!MdiParent.Focused)
                {
                    MdiParent.Focus();
                }
            }

        }

        public DialogResult MessageBox(string title, string message, MessageBoxButtons messageBoxButton = MessageBoxButtons.OK, MessageBoxIcon messageBoxIcon = MessageBoxIcon.None)
        {
            return XtraMessageBox.Show(LookAndFeel, message, title, messageBoxButton, messageBoxIcon);
        }

        public virtual void ExportToXls(string fileName)
        {
            MessageBox("No disponible", "Esta funcionalidad no esta disponible ");
        }
        public virtual void ExportToXlsx(string fileName)
        {
            MessageBox("No disponible", "Esta funcionalidad no esta disponible ");

        }
        public virtual void ExportToPdf(string fileName)
        {
            MessageBox("No disponible", "Esta funcionalidad no esta disponible ");
        }
        public virtual void ExportToPng(string fileName)
        {
            MessageBox("No disponible", "Esta funcionalidad no esta disponible ");
        }
        public void Export(int filterIndex = 0)
        {
            var dialog = new SaveFileDialog();
            dialog.Filter = @"Excel (.xls) |*.xls|Excel 2007 (.xlsx)|*.xlsx | Pdf (.pdf)|*.pdf| Imagen (.png)|*.png";
            var result = dialog.ShowDialog();
            if (filterIndex > 0)
            {
                dialog.FilterIndex = filterIndex;
            }
            if (result == DialogResult.OK)
            {
                switch (dialog.FilterIndex)
                {
                    case 1:
                        ExportToXls(dialog.FileName);
                        break;
                    case 2:
                        ExportToXlsx(dialog.FileName);
                        break;
                    case 3:
                        ExportToPdf(dialog.FileName);
                        break;
                    case 4:
                        ExportToPdf(dialog.FileName);
                        break;
                }
            }
        }
        public void AlertMessage(string message)
        {
            _alertControl.Show(this, Text, message);
        }
        public void AlertMessage(string message, TimeSpan timeSpan)
        {
            _timer = new Label
            {
                BackColor = Color.Transparent,
                Text =
                        string.Format("{0:00}:{1:00}:{2:00}.{3} tiempo", timeSpan.Hours, timeSpan.Minutes, timeSpan.Seconds, timeSpan.Milliseconds),
                AutoSize = true,
            };

            _alertControl.Show(this, Text, message);
        }
        //protected void ShowError(Exception exception)
        //{
        //    new FrmWindowError("", exception).ShowDialog();
        //}

        public Task<T> StartAsyncProcess<T>(Func<T> action)
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
        protected async Task StartAsyncProcess(Action action, CancellationToken token)
        {
            await Task.Factory.StartNew(action, token);
        }

        public delegate void ThrowEventDelegate<in T>(T item, EventArgs e);
        public delegate void ThrowEventDelegate<in TX, in TY>(TX itemx, TY itemy, EventArgs e);

        //protected LoadingPanel GetWaitPanel()
        //{
        //    var pnl = new LoadingPanel { Name = "pnlWaitProgress", Anchor = AnchorStyles.None };
        //    pnl.Location = new Point((ClientSize.Width / 2) - (pnl.Size.Width / 2), (ClientSize.Height / 2) - (pnl.Size.Height / 2));
        //    return pnl;
        //}

        //protected void ShowWaitPanel()
        //{
        //    var pnl = GetWaitPanel();
        //    EnableControls(false);
        //    Controls.Add(pnl);
        //    pnl.BringToFront();
        //    Cursor = Cursors.WaitCursor;
        //}
        protected void HideWaitPanel()
        {
            Controls.RemoveByKey("pnlWaitProgress");
            Cursor = Cursors.Default;
            EnableControls(true);
        }

        protected void EnableControls(bool value)
        {
            for (var index = 0; index < Controls.Count; index++)
            {
                Controls[index].Enabled = value;

            }
        }
        /// <summary>
        /// Call a method of control the ThreadSafe way.
        /// </summary>
        /// <param name="control"> object of control.</param>
        /// <param name="methodName">Name of method</param>
        /// <param name="methodParam">Value of parameter of method.</param>
        public delegate void CallMethodThreadSafeDelegate(Control control, string methodName, object methodParam);
        public void CallMethodThreadSafe(Control control, string methodName, object methodParam)
        {
            if (control.InvokeRequired)
            {
                var delega = new CallMethodThreadSafeDelegate(CallMethodThreadSafe);
                control.Invoke(delega, new[] { control, methodName, methodParam });
            }
            else
            {
                control.GetType().InvokeMember(methodName, BindingFlags.InvokeMethod, null, control, methodParam == null ? null : new[] { methodParam });
            }
        }

        public delegate void CallMethodThreadSafeDelegates(Control control, string methodName, params object[] methodParam);
        public void CallMethodThreadSafe(Control control, string methodName, params object[] methodParam)
        {
            if (control.InvokeRequired)
            {
                var delega = new CallMethodThreadSafeDelegates(CallMethodThreadSafe);
                control.Invoke(delega, control, methodName, methodParam);
            }
            else
            {
                control.GetType().InvokeMember(methodName, BindingFlags.InvokeMethod, null, control, methodParam ?? null);
            }
        }
        /// <summary>
        /// Call a method of control the ThreadSafe way.
        /// </summary>
        /// <param name="control"> object of control.</param>
        /// <param name="propertyName">Name of method</param>
        /// <param name="propertyValue">Value of parameter of method.</param>
        public delegate void SetPropertyThreadSafeDelegate(Control control, string propertyName, object propertyValue);
        public void SetPropertyThreadSafe(Control control, string propertyName, object propertyValue)
        {
            if (control.InvokeRequired)
            {
                var delega = new SetPropertyThreadSafeDelegate(SetPropertyThreadSafe);
                control.Invoke(delega, new[] { control, propertyName, propertyValue });
            }
            else
            {
                control.GetType().InvokeMember(propertyName, BindingFlags.SetProperty, null, control, new[] { propertyValue });
            }
        }

        public void CloseForm()
        {
            this.Close();
        }


    }
}
