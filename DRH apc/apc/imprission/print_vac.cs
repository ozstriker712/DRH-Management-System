using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using apc.Modele;

namespace apc.imprission
{
    public partial class print_vac : DevExpress.XtraReports.UI.XtraReport
    {
        public print_vac(doc_vacance selct_vac)
        {
            InitializeComponent();
            bindingSource2.DataSource = selct_vac;
        }

    }
}
