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
    public partial class frm_doc2_charge : DevExpress.XtraEditors.XtraForm
    {
        public frm_doc2_charge(employ employé, Model1Container dbcontex)
        {
            InitializeComponent();
            this.dbcontex = dbcontex;
            this.employé = employé;
            employBindingSource.DataSource = employé;
            charg = new doc2_charge_poste();
            charg.employ_id = employé.id;
            doc2chargeposteBindingSource.DataSource = charg;

            apcannexcatgrBindingSource.DataSource = dbcontex.apc_annex_catgr.ToList();
            apcannexcatgrdetailBindingSource.DataSource = dbcontex.apc_annex_catgr_detail.ToList();
            doc2chargeposteBindingSource.DataSource = employé.doc2_charge_poste.ToList();
            textEdit1.Enabled = false;
        }

        Model1Container dbcontex;
        employ employé;
        doc2_charge_poste charg;

        private void simpleButton4_Click(object sender, EventArgs e) //add charge poste
        {
            try
            {
                doc2chargeposteBindingSource.EndEdit();
                employé.doc2_charge_poste.Add(charg);
                dbcontex.SaveChanges();

                AlertInfo info = new AlertInfo("", "لقد تم اضافة التكليـف ");
                alertControl1.Show(this, info);

                charg = new doc2_charge_poste();

                doc2chargeposteBindingSource.DataSource = employé.doc2_charge_poste.ToList();

            }
            catch
            {
                MessageBox.Show("there is a controle is Null", " Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
        }

        private void simpleButton1_Click(object sender, EventArgs e) // clear
        {
            doc2chargeposteBindingSource.DataSource = charg;
        }

        private void simpleButton3_Click(object sender, EventArgs e) // show all charger postes
        {
           
        }

        private void textEdit5_EditValueChanged(object sender, EventArgs e) // filtre auto
        {
            try
            {
                apcannexcatgrdetailBindingSource.DataSource = dbcontex.apc_annex_catgr_detail.Where(k => k.apc_annex_catgr_id_apc_annex == (int)textEdit5.EditValue).ToList();

            }
            catch  
            {
                doc2chargeposteBindingSource.DataSource = charg;

                
            }
            
        }

      
       
    }
}