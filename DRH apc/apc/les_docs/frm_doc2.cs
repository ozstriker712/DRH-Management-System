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
    public partial class frm_doc2 : DevExpress.XtraEditors.XtraForm
    {
        public frm_doc2(employ employé, Model1Container dbcontex)
        {
            InitializeComponent();
            chng_daraja =new doc2_chngmt_daraja();
            chng_delgtn = new doc2_chngmnt_delgation();
            chng_poste = new doc2_chngmnt_poste();
           
            this.dbcontex = dbcontex;
            this.employé = employé;

            employBindingSource.DataSource = employé;
           
            chng_daraja.employ_id = employé.id;     // int auto for proprt_id for table parent
            chng_delgtn.employ_id = employé.id;
            chng_poste.employ_id = employé.id;


            doc2chngmtdarajaBindingSource.DataSource=chng_daraja;
            doc2chngmntdelgationBindingSource.DataSource = chng_delgtn;
            doc2chngmntposteBindingSource.DataSource = chng_poste;

            rotbaBindingSource.DataSource = dbcontex.rotbaSet.ToList();

            textEdit8.Enabled = false; textEdit3.Enabled = false; textEdit1.Enabled = false;

            doc2chngmtdarajaBindingSource.DataSource = employé.doc2_chngmt_daraja.ToList();
            doc2chngmntposteBindingSource.DataSource = employé.doc2_chngmnt_poste.ToList();
            doc2chngmntdelgationBindingSource.DataSource = employé.doc2_chngmnt_delgation.ToList();

        }

        employ employé;
        Model1Container dbcontex;
        doc2_chngmt_daraja chng_daraja;
        doc2_chngmnt_delgation chng_delgtn;
        doc2_chngmnt_poste chng_poste;

        private void simpleButton1_Click(object sender, EventArgs e) // add  daraja
        {
            try
            {
                doc2chngmtdarajaBindingSource.EndEdit();
                employé.doc2_chngmt_daraja.Add(chng_daraja);
                dbcontex.SaveChanges();

                AlertInfo info = new AlertInfo("", "لقد تم اضافة ترقية في الدرجـــــة");
                alertControl1.Show(this, info);

                chng_daraja = new doc2_chngmt_daraja();
                doc2chngmtdarajaBindingSource.DataSource = employé.doc2_chngmt_daraja.ToList();


                
            }
            catch 
            {
                MessageBox.Show("there is a controle is Null", " Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void simpleButton2_Click(object sender, EventArgs e) // Clear draja 
        {
          
                doc2chngmtdarajaBindingSource.DataSource = chng_daraja;
            
                
        }

        private void simpleButton3_Click(object sender, EventArgs e) // show all liste draja
        { 
        }

        private void gridControl2_Click(object sender, EventArgs e)
        {

        }

        //----------------------------------------------------------------------------------------------------------------

        private void simpleButton4_Click(object sender, EventArgs e) // show all  Liste delegation
        {
           
        }

        private void simpleButton5_Click(object sender, EventArgs e) // clear delegation
        {
            doc2chngmntdelgationBindingSource.DataSource = chng_delgtn;
        }

        private void simpleButton6_Click(object sender, EventArgs e)
        {
            try
            {
                doc2chngmntdelgationBindingSource.EndEdit();
                
                employé.doc2_chngmnt_delgation.Add(chng_delgtn);
                dbcontex.SaveChanges();

                AlertInfo info = new AlertInfo("", "لقد تم اضافة قرار تفويض بامضاء");
                alertControl1.Show(this, info);

                chng_delgtn = new doc2_chngmnt_delgation();

                doc2chngmntdelgationBindingSource.DataSource = employé.doc2_chngmnt_delgation.ToList();
            }
            catch
            {
                MessageBox.Show("there is a controle is Null", " Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        //----------------------------------------------------------------------------------------------------------------

        private void simpleButton9_Click(object sender, EventArgs e) // add poste 
        {
            try
            {
                doc2chngmntposteBindingSource.EndEdit();
                employé.doc2_chngmnt_poste.Add(chng_poste);
                dbcontex.SaveChanges();

                AlertInfo info = new AlertInfo("", "لقد تم اضافة ترقية في المنصب العالــي");
                alertControl1.Show(this, info);

                chng_poste = new doc2_chngmnt_poste();
                doc2chngmntposteBindingSource.DataSource = employé.doc2_chngmnt_poste.ToList();
            }
            catch
            {
                MessageBox.Show("there is a controle is Null", " Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void simpleButton8_Click(object sender, EventArgs e) // clear poste
        {
            doc2chngmntposteBindingSource.DataSource = chng_poste;
        }

        private void simpleButton7_Click(object sender, EventArgs e) // show all postes
        {
           
        }


    }
}