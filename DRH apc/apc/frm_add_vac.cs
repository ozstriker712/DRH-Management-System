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

namespace apc
{
    public partial class frm_add_vac : DevExpress.XtraEditors.XtraForm
    {


        public frm_add_vac(employ employé, Model1Container dbcontex)
        {
            InitializeComponent();
            add_vac = new doc_vacance();
            this.dbcontex = dbcontex;
            this.employé = employé;

            employBindingSource.DataSource = employé;
            
            add_vac.employ_id = employé.id;     // int auto for proprt_id for table parent
            docvacanceBindingSource.DataSource = add_vac;

            textEdit1.Enabled = false;
        }

        employ employé;
        Model1Container dbcontex;
        doc_vacance add_vac;

        private void frm_add_vac_Load(object sender, EventArgs e)
        {
        }

        private void textEdit5_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void SimpleButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }


       

        private void SimpleButton1_Click(object sender, EventArgs e)
        {
            try
            {
                docvacanceBindingSource.EndEdit();
                employé.doc_vacance.Add(add_vac);
                dbcontex.SaveChanges();
                AlertInfo info = new AlertInfo("", "لقد تم اضافة عطلة سنوية الى قاعدة البيانات");
                alertControl1.Show(this, info);
                add_vac = new doc_vacance();
                docvacanceBindingSource.DataSource = add_vac;
              
                      
            }
            catch
            {
                MessageBox.Show("there is a controle is Null", " Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

         

         public void textEdit3_EditValueChanged(object sender, EventArgs e) //nb cons
         {
             int all_day = 40 - employé.doc_vacance.Where(v => v.vacance_year == add_vac.vacance_year).Sum(v => v.nbr_cons);
             docvacanceBindingSource.EndEdit();

             if (add_vac.nbr_cons <= all_day)
             {

                 add_vac.nbr_rest = all_day - add_vac.nbr_cons;
                 all_day = add_vac.nbr_rest;
                 docvacanceBindingSource.ResetBindings(true);
             }
             else
             {
                 MessageBox.Show("   لا يمكنـــك ادخال أكثــــــر من : " +  all_day +  "يــوم", " Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
             }
         }

        private void textEdit7_EditValueChanged(object sender, EventArgs e)
        {
            
           
        }

        private void textEdit7_Enter(object sender, EventArgs e)
        {

          
        }

        private void textEdit7_EditValueChanging(object sender, DevExpress.XtraEditors.Controls.ChangingEventArgs e)
        {
            
        }

        private void textEdit7_DateTimeChanged(object sender, EventArgs e)
        {
            docvacanceBindingSource.EndEdit();
            add_vac.date_vac_in = add_vac.date_vac_out.AddDays(add_vac.nbr_cons).Date;
            docvacanceBindingSource.ResetBindings(true);
                
        }

        private void textEdit2_EditValueChanged(object sender, EventArgs e)
        {
            docvacanceBindingSource.EndEdit();
            add_vac.nbr_rest = 40 - employé.doc_vacance.Where(v => v.vacance_year == add_vac.vacance_year).Sum(v => v.nbr_cons);
            docvacanceBindingSource.ResetBindings(true);
        }

     
    }
}