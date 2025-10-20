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
using System.Data.Entity.Validation;
using apc;
using DevExpress.XtraSplashScreen;
using DevExpress.XtraBars.Alerter;
using System.Globalization;


namespace apc
{
    public partial class frm_add_emply : DevExpress.XtraEditors.XtraForm
    {
        int id_public;


        public frm_add_emply(employ employé, Model1Container dbcontex,int id_user)
        {
            InitializeComponent();
            LoadDataSource(employé);
            textEdit1.Enabled = false;
            textEdit24.Enabled = false;
            textEdit8.Enabled = false;

            id_public = id_user;
            this.employé = employé;
            this.dbcontex = dbcontex;
            refrech();

        }

        public void LoadDataSource(employ employé)
        {
            employBindingSource.DataSource = employé;
           
        }


        Model1Container dbcontex;
        employ employé;
        
        
        void refrech()
        {
            brancheBindingSource.DataSource = dbcontex.brancheSet.ToList();
            rotbaBindingSource.DataSource = dbcontex.rotbaSet.ToList();
            rotbaBindingSource1.DataSource = dbcontex.rotbaSet.ToList();
            apcannexcatgrBindingSource.DataSource = dbcontex.apc_annex_catgr.ToList();
            apcannexcatgrdetailBindingSource.DataSource = dbcontex.apc_annex_catgr_detail.ToList();
            
        }

     
     
       
        public void SimpleButton2_Click(object sender, EventArgs e)
        {
           
            try
            {
                employBindingSource.EndEdit();
                bool IsNew=false;

                if (employé.id == 0)
                {
                    IsNew = true;
                    dbcontex.employSet.Add(employé);
                }

                this.employé.login_id_user = id_public;    //add id user who add this employ
                dbcontex.SaveChanges();

                if (IsNew)
                {
                    employé = new employ(); 
                    employBindingSource.DataSource = employé;
                }

                AlertInfo info;
                if (IsNew)
                {
                    info = new AlertInfo("", "لقد تم اضافة موظف بنجاح الى قاعدة البيانات");
                   
                     
                }
                else
                    info = new AlertInfo("", "لقد تم تعديل معلومات موظف بنجاح ");

                alertControl1.Show(this, info);

                
            }

            catch 
            {
                MessageBox.Show("يوجـــــــــد حقل فارغ. يرجى التـأكد", " Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

 
        public void frm_add_emply_FormClosed(object sender, FormClosedEventArgs e) // refrech() after close form Add employ
        {
             
        }

    
        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            
            if (checkBox26.Checked == true)
            {
                textEdit24.Enabled = true;
            }
            else
            {
                textEdit24.Enabled = false;
               
            }
        }

    

        private void checkBox1_CheckedChanged_1(object sender, EventArgs e)
        {
            if (checkBox8.Checked == true)
            {
                textEdit8.Enabled = true;
                textEdit7.Enabled = false;
            }
            else
            {
                textEdit8.Enabled = false;
                textEdit7.Enabled = true;
                
            }
        }

     
 

        private void textEdit22_EditValueChanged(object sender, EventArgs e)
        {
            rotbaBindingSource.DataSource = dbcontex.rotbaSet.Where(r => r.branche_id_branche == (int)textEdit22.EditValue).ToList();

        }

      

        private void gridLookUpEdit1_EditValueChanged_1(object sender, EventArgs e)
        {
            apcannexcatgrdetailBindingSource.DataSource = dbcontex.apc_annex_catgr_detail.Where(k => k.apc_annex_catgr_id_apc_annex == (int)gridLookUpEdit1.EditValue).ToList();
            
        }

     

       
        private void textEdit23_EditValueChanged(object sender, EventArgs e)
        {
            employBindingSource.EndEdit();
            if (textEdit23.Properties.View.GetFocusedRowCellValue("sinf")!=null)
            {
                textEdit26.Text = textEdit23.Properties.View.GetFocusedRowCellValue("sinf").ToString();
                textEdit27.Text = textEdit23.Properties.View.GetFocusedRowCellValue("istidl").ToString();
                textEdit25.Text = textEdit23.Properties.View.GetFocusedRowCellValue("silk").ToString(); 
            }
             
        }

        private void textEdit4_Enter(object sender, EventArgs e)
        {
            Application.CurrentInputLanguage = InputLanguage.FromCulture(new CultureInfo("fr-FR"));
        }

        private void textEdit5_Leave(object sender, EventArgs e)
        {
            Application.CurrentInputLanguage = InputLanguage.FromCulture(new CultureInfo("ar-DZ"));
        }

        private void textEdit2_Enter(object sender, EventArgs e)
        {
            Application.CurrentInputLanguage = InputLanguage.FromCulture(new CultureInfo("ar-DZ"));
        }

        private void textEdit9_Enter(object sender, EventArgs e)
        {
            Application.CurrentInputLanguage = InputLanguage.FromCulture(new CultureInfo("ar-DZ"));
        }

       
      
      
    }
}