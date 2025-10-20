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
using DevExpress.XtraGrid;
using System.Data.Entity;
using DevExpress.XtraReports.UI;

namespace apc
{
    public partial class frm_all_vac : DevExpress.XtraEditors.XtraForm
    {
        public frm_all_vac(employ employé, Model1Container dbcontex)
        {
            InitializeComponent();
            docvacanceBindingSource.DataSource = employé.doc_vacance.ToList();
            docvacaneplusBindingSource.DataSource = employé.doc_vacane_plus.ToList();
            this.dbcontex = dbcontex;
            employBindingSource.DataSource = employé;
            this.employé = employé;
 

        }

        public Model1Container dbcontex;
        employ employé;
        doc_vacance doc_vac;


        private void SimpleButton2_Click(object sender, EventArgs e)
        {
            this.Close();

        }

      
 

        void refrech()
        {
          
            docvacanceBindingSource.DataSource = employé.doc_vacance.ToList();
        }

        public void simpleButton1_Click(object sender, EventArgs e)
        {
             DialogResult reponse = MessageBox.Show(" هل تريد حذف هذه العطلـــــــة ؟؟ ", " Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
           if (DialogResult.OK==reponse)
           {
            docvacanceBindingSource.EndEdit();
            doc_vacance delt = (doc_vacance)docvacanceBindingSource.Current;

            if (delt.id_vacnace != 0)
            {
                dbcontex.doc_vacanceSet.Remove(delt);

            }
            else
            {
                employé.doc_vacance.Remove(delt);

            }


            dbcontex.SaveChanges();
            refrech();
            MessageBox.Show(" لقد تم حذف العطلة من قاعدة البيانات ", " Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
           }
        }

        private void gridView1_CustomSummaryCalculate(object sender, DevExpress.Data.CustomSummaryEventArgs e)
        {

        }

  

        private void SimpleButton3_Click(object sender, EventArgs e)
        {
            selct_vac = (doc_vacance)docvacanceBindingSource.Current;
            imprission.print_vac print_vac = new imprission.print_vac(selct_vac);
 
            ReportPrintTool printTool = new ReportPrintTool(print_vac);

            printTool.ShowPreviewDialog();
        }

        public doc_vacance selct_vac;
        public void gridView1_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            
        }
    }
}