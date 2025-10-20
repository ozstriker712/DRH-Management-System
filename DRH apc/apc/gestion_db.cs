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
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid;

namespace apc
{
    public partial class gestion_db : DevExpress.XtraEditors.XtraForm
    {
        public gestion_db()
        {
            InitializeComponent(); 
            dbcontex = new Model1Container();
            loginn = new login();
            employBindingSource.DataSource = dbcontex.employSet.ToList();
            compteur_empl();
        }
        Model1Container dbcontex;
        employ employé;
        login loginn;
        
        private void checkEdit1_CheckedChanged(object sender, EventArgs e)
        {
            gridView1.OptionsView.ShowAutoFilterRow = checkEdit1.Checked;
        }

        void compteur_empl() // nbr of emply 
        {
            int count = dbcontex.employSet.Count();
            textEdit1.Text = count.ToString();
         

        }

        private void gridView1_CustomSummaryCalculate(object sender, DevExpress.Data.CustomSummaryEventArgs e)
        {
            int summaryID = Convert.ToInt32((e.Item as GridSummaryItem).Tag);

            if (e.SummaryProcess == DevExpress.Data.CustomSummaryProcess.Finalize)
            {
                switch (summaryID)
                {
                    case 1: 
                        break;
                    case 2: ; 
                        break;

                      //e.TotalValue = (  * 100) / (dbcontex.employSet.Count())
                        //e.TotalValue = dbcontex.employSet.Count(m=>m.login_id_user==loginn.id_user)
                }
            } 
        }
    }
}