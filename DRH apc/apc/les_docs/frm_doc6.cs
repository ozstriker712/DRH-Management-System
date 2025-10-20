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
    public partial class frm_doc6 : DevExpress.XtraEditors.XtraForm
    {
        public frm_doc6(employ employé, Model1Container dbcontex)
        {
            InitializeComponent();
            this.dbcontex = dbcontex;
            this.employé = employé;
            movmnt =new doc_7araka();
            employBindingSource.DataSource = employé;
            movmnt.employ_id = employé.id;
            doc7arakaBindingSource.DataSource = movmnt;
            doc7arakaBindingSource.DataSource = employé.doc_7araka.ToList();
            textEdit1.Enabled = false;

        }
        Model1Container dbcontex;
        employ employé;
        doc_7araka movmnt;
        private void simpleButton4_Click(object sender, EventArgs e) //add
        {

            try
            {
                doc7arakaBindingSource.EndEdit();
                employé.doc_7araka.Add(movmnt);
                dbcontex.SaveChanges();

                AlertInfo info = new AlertInfo("", "لقد تم اضافة حركة ادارية ");
                alertControl1.Show(this, info);

                movmnt = new doc_7araka();
                doc7arakaBindingSource.DataSource = employé.doc_7araka.ToList();

            }
            catch
            {
                MessageBox.Show("there is a controle is Null", " Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e) //clear
        {
            doc7arakaBindingSource.DataSource = movmnt;
        }

        private void simpleButton3_Click(object sender, EventArgs e) //show all
        {
          

        }

    
    
    }
}