using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using apc.Modele;
using System.Diagnostics;
using DevExpress.XtraGrid.Views.Grid;
namespace apc.UserControl
{
    public partial class frm_show_search : CustomUserControl
    {
        public frm_show_search()
        {
            InitializeComponent();
            refrech();
            
        }

        Model1Container dbcontex;
        employ employé;

        public override void refrech()
        {
            dbcontex = new Model1Container();
            employBindingSource.DataSource = dbcontex.employSet.ToList();

        }

        public override void ExportToExcel()
        {
            if (gridView1 != null)
            {
                gridView1.ExportToXls("c:\\liste.xls");
                Process proc = new Process();
                proc.StartInfo.FileName = "c:\\liste.xls";
                proc.StartInfo.UseShellExecute = true;
                proc.Start();   
 
            }
        }
 
        private void checkEdit1_CheckedChanged(object sender, EventArgs e)
        {
            gridView1.OptionsView.ShowAutoFilterRow=checkEdit1.Checked;
    
        }

        private void gridView1_RowStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowStyleEventArgs e)
        {

            GridView View = sender as GridView;
            if (e.RowHandle >= 0)
            {
                string etat_emply = View.GetRowCellDisplayText(e.RowHandle, View.Columns["etat_emply"]);
                string date_out_work =View.GetRowCellDisplayText(e.RowHandle, View.Columns["date_out_work"]);
                if (etat_emply == "تقاعد" && date_out_work != null)
                {
                    e.Appearance.BackColor = Color.Salmon;
                    e.Appearance.BackColor2 = Color.SeaShell;
                    
                    
                }

              
            }
        }

        private void frm_show_search_Load(object sender, EventArgs e)
        {
            refrech();
        }

       
        
    }
}
