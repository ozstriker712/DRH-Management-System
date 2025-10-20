using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using apc.Modele;
using System.Diagnostics;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Columns;

namespace apc.imprission
{
    public partial class who_charge_poste : DevExpress.XtraEditors.XtraForm
    {
        public who_charge_poste()
        {
            InitializeComponent();
           
        }
        doc2_charge_poste chargeposte;
        Model1Container dbcontex;

        private void Form2_Load(object sender, EventArgs e)
        {
            dbcontex = new Model1Container();
            doc2chargeposteBindingSource.DataSource = dbcontex.doc2_charge_poste.ToList();
        }

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
                gridView1.ExportToXls("c:\\liste_poste_charge.xls");
                Process proc = new Process();
                proc.StartInfo.FileName = "c:\\liste_poste_charge.xls";
                proc.StartInfo.UseShellExecute = true;
                proc.Start();

                 
            }
        }

        private void checkEdit1_CheckedChanged(object sender, EventArgs e)
        {
            gridView1.OptionsView.ShowAutoFilterRow = checkEdit1.Checked;
        }

        private void doc2chargeposteBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void gridControl1_Click(object sender, EventArgs e)
        {
           
        }

        private void checkEdit2_CheckedChanged(object sender, EventArgs e)
        {
            ColumnView view = gridView1;

            if (checkEdit2.Checked == true)
            {

                ViewColumnFilterInfo viewFilterInfo = new ViewColumnFilterInfo(view.Columns["apc_annex_catgr.nom_apc_annex"],
                new ColumnFilterInfo("[apc_annex_catgr.nom_apc_annex] = 'ملحقات البلدية' "));

                view.ActiveFilter.Add(viewFilterInfo);

            }
            else
            {
                view.ActiveFilter.Clear();
            }
        }

        public void gridView1_CustomRowFilter(object sender, RowFilterEventArgs e)
        {
           

 
        }

        private void checkEdit3_CheckedChanged(object sender, EventArgs e)
        {
            ColumnView view = gridView1;

            if (checkEdit3.Checked == true)
            {

                ViewColumnFilterInfo viewFilterInfo = new ViewColumnFilterInfo(view.Columns["apc_annex_catgr.nom_apc_annex"],
                new ColumnFilterInfo("[apc_annex_catgr.nom_apc_annex] = 'المصالح الادارية' "));

                view.ActiveFilter.Add(viewFilterInfo);

            }
            else
            {
                view.ActiveFilter.Clear();
            }
        }

        private void checkEdit4_CheckedChanged(object sender, EventArgs e)
        {
             ColumnView view = gridView1;

            if (checkEdit4.Checked == true)
            {

                ViewColumnFilterInfo viewFilterInfo = new ViewColumnFilterInfo(view.Columns["apc_annex_catgr.nom_apc_annex"],
                new ColumnFilterInfo("[apc_annex_catgr.nom_apc_annex] = 'المدارس' "));

                view.ActiveFilter.Add(viewFilterInfo);

            }
            else
            {
                view.ActiveFilter.Clear();
            }
            
        }

        private void checkEdit5_CheckedChanged(object sender, EventArgs e)
        {
            
                 ColumnView view = gridView1;

            if (checkEdit5.Checked == true)
            {

                ViewColumnFilterInfo viewFilterInfo = new ViewColumnFilterInfo(view.Columns["apc_annex_catgr.nom_apc_annex"],
                new ColumnFilterInfo("[apc_annex_catgr.nom_apc_annex] = 'المكاتب' "));

                view.ActiveFilter.Add(viewFilterInfo);

            }
            else
            {
                view.ActiveFilter.Clear();
            }
        }

        private void checkEdit6_CheckedChanged(object sender, EventArgs e)
        {
           ColumnView view = gridView1;

            if (checkEdit6.Checked == true)
            {

                ViewColumnFilterInfo viewFilterInfo = new ViewColumnFilterInfo(view.Columns["apc_annex_catgr.nom_apc_annex"],
                new ColumnFilterInfo("[apc_annex_catgr.nom_apc_annex] = 'المناصب العليا' "));

                view.ActiveFilter.Add(viewFilterInfo);

            }
            else
            {
                view.ActiveFilter.Clear();
            }
        
        }

        private void checkEdit7_CheckedChanged(object sender, EventArgs e)
        {
            ColumnView view = gridView1;

            if (checkEdit7.Checked == true)
            {

                ViewColumnFilterInfo viewFilterInfo = new ViewColumnFilterInfo(view.Columns["date_fin_charge"],
                new ColumnFilterInfo("[date_fin_charge] = null "));

                view.ActiveFilter.Add(viewFilterInfo);

            }
            else
            {
                view.ActiveFilter.Clear();
            }
        }

        private void checkEdit8_CheckedChanged(object sender, EventArgs e)
        {
            ColumnView view = gridView1;

            if (checkEdit8.Checked == true)
            {

                ViewColumnFilterInfo viewFilterInfo = new ViewColumnFilterInfo(view.Columns["apc_annex_catgr.nom_apc_annex"],
                new ColumnFilterInfo("[apc_annex_catgr.nom_apc_annex] = 'الحضائر' "));

                view.ActiveFilter.Add(viewFilterInfo);

            }
            else
            {
                view.ActiveFilter.Clear();
            }
            
            
        }

        private void checkEdit9_CheckedChanged(object sender, EventArgs e)
        {
       
                  ColumnView view = gridView1;

            if (checkEdit9.Checked == true)
            {

                ViewColumnFilterInfo viewFilterInfo = new ViewColumnFilterInfo(view.Columns["apc_annex_catgr.nom_apc_annex"],
                new ColumnFilterInfo("[apc_annex_catgr.nom_apc_annex] = 'المذبح' "));

                view.ActiveFilter.Add(viewFilterInfo);

            }
            else
            {
                view.ActiveFilter.Clear();
            }
            

        }
    }
}