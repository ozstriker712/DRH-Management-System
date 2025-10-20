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
    public partial class frm_vac_plus : DevExpress.XtraEditors.XtraForm
    {
        public frm_vac_plus(employ employé, Model1Container dbcontex)
        {
            InitializeComponent();
            add_vac_plus = new doc_vacane_plus();
            this.dbcontex = dbcontex;

            employBindingSource.DataSource = employé;
            this.employé = employé;
            add_vac_plus.employ_id = employé.id;     // int auto for proprt_id for table parent
            
            docvacaneplusBindingSource.DataSource = add_vac_plus;

            textEdit1.Enabled = false;

        }

        employ employé;
        Model1Container dbcontex;
        doc_vacane_plus add_vac_plus;


        private void SimpleButton1_Click(object sender, EventArgs e)
        {
            try
            {
                docvacaneplusBindingSource.EndEdit();
                
                employé.doc_vacane_plus.Add(add_vac_plus);
                dbcontex.SaveChanges();
                AlertInfo info = new AlertInfo("", "لقد تم اضافة عطلة سنوية الى قاعدة البيانات");
                alertControl1.Show(this, info);
                add_vac_plus = new doc_vacane_plus();


            }
            catch
            {
                MessageBox.Show("there is a controle is Null", " Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void SimpleButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textEdit7_DateTimeChanged(object sender, EventArgs e)
        {
            docvacaneplusBindingSource.EndEdit();
            add_vac_plus.date_in_vacplus = add_vac_plus.date_out_vacpus.AddDays(add_vac_plus.nbr_day_vac).Date;

            docvacaneplusBindingSource.ResetBindings(true);
        }
    }
}