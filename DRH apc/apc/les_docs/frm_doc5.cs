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
    public partial class frm_doc5 : DevExpress.XtraEditors.XtraForm
    {
        public frm_doc5(employ employé, Model1Container dbcontex)
        {
            InitializeComponent();
            this.dbcontex = dbcontex;
            this.employé = employé;
            mo7asaba = new doc_mo7asaba();
            employBindingSource.DataSource = employé;
            mo7asaba.employ_id = employé.id;
            docmo7asabaBindingSource.DataSource = mo7asaba;
            docmo7asabaBindingSource.DataSource = employé.doc_mo7asaba.ToList();
            textEdit1.Enabled = false;
        }

        Model1Container dbcontex;
        employ employé;
        doc_mo7asaba mo7asaba;

        private void simpleButton4_Click(object sender, EventArgs e) // add mo7assba
        {

            try
            {
                docmo7asabaBindingSource.EndEdit();
                employé.doc_mo7asaba.Add(mo7asaba);
                dbcontex.SaveChanges();

                AlertInfo info = new AlertInfo("", "لقد تم اضافة محاسبة ");
                alertControl1.Show(this, info);

                mo7asaba = new doc_mo7asaba();
                docmo7asabaBindingSource.DataSource = employé.doc_mo7asaba.ToList();

            }
            catch
            {
                MessageBox.Show("there is a controle is Null", " Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e) // clear
        {
            docmo7asabaBindingSource.DataSource = mo7asaba;
        }

        private void simpleButton3_Click(object sender, EventArgs e) //show all liste 
        {
          

        }

        private void textEdit3_DateTimeChanged(object sender, EventArgs e)
        {
            docmo7asabaBindingSource.EndEdit();
            mo7asaba.date2_abs = mo7asaba.date1_abs.AddDays(mo7asaba.nbr_day_absence).Date;
           
            docmo7asabaBindingSource.ResetBindings(true);
        }
    }
}