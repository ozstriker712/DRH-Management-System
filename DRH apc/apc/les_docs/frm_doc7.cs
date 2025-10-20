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
    public partial class frm_doc7 : DevExpress.XtraEditors.XtraForm
    {
        public frm_doc7(employ employé, Model1Container dbcontex)
        {
            InitializeComponent();
            this.dbcontex = dbcontex;
            this.employé = employé;
            displn = new doc_displine();
            employBindingSource.DataSource = employé;
            displn.employ_id = employé.id;
            docdisplineBindingSource.DataSource = displn;
            docdisplineBindingSource.DataSource = employé.doc_displine.ToList();
            textEdit1.Enabled = false;
        }

        Model1Container dbcontex;
        employ employé;
        doc_displine displn;

        private void simpleButton4_Click(object sender, EventArgs e) // add
        {

            try
            {
                docdisplineBindingSource.EndEdit();
                employé.doc_displine.Add(displn);
                dbcontex.SaveChanges();

                AlertInfo info = new AlertInfo("", "لقد تم اضافة محاسبة ");
                alertControl1.Show(this, info);

                displn = new doc_displine();
                docdisplineBindingSource.DataSource = employé.doc_displine.ToList();

            }
            catch
            {
                MessageBox.Show("there is a controle is Null", " Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e) // clear
        {
            docdisplineBindingSource.DataSource = displn;
        }

        private void simpleButton3_Click(object sender, EventArgs e) // show all doc 7
        {
           

        }
    }
}