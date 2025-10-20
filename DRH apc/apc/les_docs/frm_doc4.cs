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
    public partial class frm_doc4 : DevExpress.XtraEditors.XtraForm
    {
        public frm_doc4(employ employé, Model1Container dbcontex)
        {
            InitializeComponent();
            this.dbcontex = dbcontex;
            this.employé = employé;
            employBindingSource.DataSource = employé;
            ta9yim = new doc_ta9yim();
            ta9yim.employ_id = employé.id;
            docta9yimBindingSource.DataSource = ta9yim;

            textEdit1.Enabled = false;
            docta9yimBindingSource.DataSource = employé.doc_ta9yim.ToList();

        }

        employ employé;
        Model1Container dbcontex;
        doc_ta9yim ta9yim;


        private void simpleButton4_Click(object sender, EventArgs e) // add ta9yim
        {
            try
            {
                docta9yimBindingSource.EndEdit();
                employé.doc_ta9yim.Add(ta9yim);
                dbcontex.SaveChanges();

                AlertInfo info = new AlertInfo("", "لقد تم اضافة تقييــــم ");
                alertControl1.Show(this, info);

                ta9yim = new doc_ta9yim();
                docta9yimBindingSource.DataSource = employé.doc_ta9yim.ToList();

            }
            catch
            {
                MessageBox.Show("there is a controle is Null", " Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e) // cLear
        {
            docta9yimBindingSource.DataSource = ta9yim;
        }

        private void simpleButton3_Click(object sender, EventArgs e) // show all doc Ta9yim
        {
            
        }

      
    }
}