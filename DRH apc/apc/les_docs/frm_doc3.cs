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
    public partial class frm_doc3 : DevExpress.XtraEditors.XtraForm
    {
        public frm_doc3(employ employé,Model1Container dbcontex )
        {
            InitializeComponent();
            this.dbcontex = dbcontex;
            this.employé = employé;
            promotion = new doc_promotion();
            employBindingSource.DataSource = employé;
            promotion.employ_id = employé.id;
            docpromotionBindingSource.DataSource = promotion;
            rotbaBindingSource.DataSource = dbcontex.rotbaSet.ToList();
            textEdit1.Enabled = false;
            docpromotionBindingSource.DataSource = employé.doc_promotion.ToList();
        }

        Model1Container dbcontex;
        employ employé;
        doc_promotion promotion;

        private void simpleButton4_Click(object sender, EventArgs e) // add promotion
        {
            try
            {
                docpromotionBindingSource.EndEdit();
                employé.doc_promotion.Add(promotion);

                employé.rotba_id_rotba = promotion.rotba_id_rotba;
                employBindingSource.ResetBindings(true);

                dbcontex.SaveChanges();


                AlertInfo info = new AlertInfo("", "لقد تم اضافة ترقية في المنصب");
                alertControl1.Show(this, info);
                docpromotionBindingSource.DataSource = employé.doc_promotion.ToList();

            }
            catch
            {
                MessageBox.Show("there is a controle is Null", " Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void simpleButton1_Click(object sender, EventArgs e)// Clear 
        {
            docpromotionBindingSource.DataSource = promotion;
        }

        private void simpleButton3_Click(object sender, EventArgs e) //show all liste Promotion 
        { 
        }

        private void SimpleButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}