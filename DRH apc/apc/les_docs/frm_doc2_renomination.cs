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
using DevExpress.XtraBars.Alerter;

namespace apc.les_docs
{
    public partial class frm_doc2_renomination : DevExpress.XtraEditors.XtraForm
    {
        public frm_doc2_renomination(employ employé, Model1Container dbcontex)
        {
            InitializeComponent();
            this.employé = employé;
            this.dbcontex = dbcontex;
            apc_annex = new apc_annex_catgr_detail();
            lieu_nominationn = new lieu_nominaiton();
            lieu_nominationn.employ_id = employé.id; 
            employBindingSource.DataSource = employé;
            apcannexcatgrBindingSource.DataSource = dbcontex.apc_annex_catgr.ToList();
            apcannexcatgrdetailBindingSource.DataSource = dbcontex.apc_annex_catgr_detail.ToList();
            lieunominaitonBindingSource.DataSource = employé.lieu_nominaiton.ToList();

            
        }
        Model1Container dbcontex;
        employ employé;
        apc_annex_catgr_detail apc_annex;
        lieu_nominaiton lieu_nominationn;

        private void gridLookUpEdit1_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                apcannexcatgrdetailBindingSource.DataSource = dbcontex.apc_annex_catgr_detail.Where(k => k.apc_annex_catgr_id_apc_annex == (int)gridLookUpEdit1.EditValue).ToList();

            }
            catch  
            {

                lieunominaitonBindingSource.DataSource = lieu_nominationn;

            }

           
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        { 
            
            employBindingSource.EndEdit();

            employé.apc_annex_catgr_detail_id_annex_detail = (int)searchLookUpEdit1.Properties.View.GetFocusedRowCellValue("id_annex_detail");
            employé.apc_annex_catgr_id_apc_annex = (int)gridLookUpEdit1.Properties.View.GetFocusedRowCellValue("id_apc_annex");

            employé.lieu_nominaiton.Add(lieu_nominationn);
        
            employBindingSource.ResetBindings(true); 
            dbcontex.SaveChanges();

            lieunominaitonBindingSource.DataSource = employé.lieu_nominaiton.ToList();
            AlertInfo info = new AlertInfo("", " لقد تم اعادة تعيين مكان الموظف ");
            alertControl1.Show(this, info);
 
           
          
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            lieunominaitonBindingSource.DataSource = lieu_nominationn;
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            Cursor currentCursor = Cursor.Current;
            Cursor.Current = Cursors.WaitCursor;
            gridControl1.ShowRibbonPrintPreview();
            Cursor.Current = currentCursor;
        }

       
        
    }
}