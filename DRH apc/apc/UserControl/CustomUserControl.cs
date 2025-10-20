using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using apc.imprission;

namespace apc.UserControl
{
    public partial class CustomUserControl : DevExpress.XtraEditors.XtraUserControl
    {
        public CustomUserControl()
        {
            InitializeComponent();
        }

        public virtual void ExportToExcel()
        { }
        public virtual void refrech()
        { }

        public virtual void detect_date_n()
        { }

    }

}
