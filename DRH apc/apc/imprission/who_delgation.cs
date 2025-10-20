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
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Columns;

namespace apc.imprission
{
    public partial class who_delgation : DevExpress.XtraEditors.XtraForm
    {
        public who_delgation()
        {
            InitializeComponent();
        }

        Model1Container dbcontex;

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            Cursor currentCursor = Cursor.Current;
            Cursor.Current = Cursors.WaitCursor;
            gridControl1.ShowRibbonPrintPreview();
            Cursor.Current = currentCursor;
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            if (gridView1 != null)
            {
                gridView1.ExportToXls("c:\\liste_delgation.xls");
                Process proc = new Process();
                proc.StartInfo.FileName = "c:\\liste_delgation.xls";
                proc.StartInfo.UseShellExecute = true;
                proc.Start();

            }
        }

        private void checkEdit1_CheckedChanged(object sender, EventArgs e)
        {
            gridView1.OptionsView.ShowAutoFilterRow = checkEdit1.Checked;
        }

        private void who_delgation_Load(object sender, EventArgs e)
        {
            dbcontex = new Model1Container();
            doc2chngmntdelgationBindingSource.DataSource = dbcontex.doc2_chngmnt_delgationSet.ToList();
        }

        private void checkEdit2_CheckedChanged(object sender, EventArgs e)
        {

            ColumnView view = gridView1;

            if (checkEdit2.Checked == true)
            {

                ViewColumnFilterInfo viewFilterInfo = new ViewColumnFilterInfo(view.Columns["date_fin_delegation"],
                new ColumnFilterInfo("[date_fin_delegation] = null "));

                view.ActiveFilter.Add(viewFilterInfo);

            }
            else
            {
                view.ActiveFilter.Clear();
            }
        }
    }
}