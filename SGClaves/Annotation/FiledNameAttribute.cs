using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGClaves.Annotation
{
    [AttributeUsage(AttributeTargets.Property | AttributeTargets.Field)]
    public class FieldNameAttribute : Attribute
    {
        private int _visibleIndex = -1;
        private int _groupIndex = -1;

        public string Caption { get; set; }
        public bool EnableCount { get; set; }
        public bool AllowEdit { get; set; }
        public bool Hide { get; set; }
        public bool Printable { get; set; }
        public int GroupIndex
        {
            get
            {
                return _groupIndex;
            }
            set { _groupIndex = value; }
        }
        public int VisibleIndex
        {
            get { return _visibleIndex; }
            set { _visibleIndex = value; }
        }
    }
}
