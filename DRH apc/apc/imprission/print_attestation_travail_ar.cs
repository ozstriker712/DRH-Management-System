using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using apc.Modele;

namespace apc.imprission
{
    public partial class print_attestation_travail_ar : DevExpress.XtraReports.UI.XtraReport
    {
        public print_attestation_travail_ar( )
        {
            InitializeComponent();
            
        }
        
        private void print_attestation_travail_ar_AfterPrint(object sender, EventArgs e)
        {
            //report = new print_attestation_travail_ar();
            //string path = "C:\\MyReport.repx";
            //report.SaveLayout(path);
        }

        private void xrLabel14_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            DateTime a = Convert.ToDateTime(xrLabel14.Text);
            DateTime h = a.AddDays(1);
            xrLabel14.Text = h.ToString("yyyy-MM-dd");
              
        }

    
        
    }
}
