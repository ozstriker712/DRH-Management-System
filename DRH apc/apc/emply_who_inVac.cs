using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Diagnostics;
using apc.Modele;
using DevExpress.XtraEditors.Filtering;
using DevExpress.XtraEditors.Repository;
using DevExpress.Data.Filtering.Helpers;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Columns;

namespace apc
{
    public partial class emply_who_inVac : DevExpress.XtraEditors.XtraForm
    {
        public emply_who_inVac()
        {
            InitializeComponent();
            dbcontex = new Model1Container();
            docvacanceBindingSource.DataSource = dbcontex.doc_vacanceSet.ToList();
            filterControl1.SourceControl = gridControl1;
            GridColumn columnCustomer = gridView1.Columns["date_vac_out"]; ;
            columnCustomer.FilterInfo = new ColumnFilterInfo("[date_vac_out] between ('[ بداية مجال التاريخ ]', '[ نهاية مجال التاريخ ]')");
            
        }

        Model1Container dbcontex;
        private void simpleButton2_Click(object sender, EventArgs e)
        {
            if (gridView1 != null)
            {
                gridView1.ExportToXls("c:\\liste_employ_in_vacance.xls");
                Process proc = new Process();
                proc.StartInfo.FileName = "c:\\liste_employ_in_vacance.xls";
                proc.StartInfo.UseShellExecute = true;
                proc.Start();


            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            Cursor currentCursor = Cursor.Current;
            Cursor.Current = Cursors.WaitCursor;
            gridControl1.ShowRibbonPrintPreview();
            Cursor.Current = currentCursor;
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            
	      filterControl1.ApplyFilter();
 

        }
 

         
    }
}