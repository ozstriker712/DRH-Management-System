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
    public partial class change_login : DevExpress.XtraEditors.XtraForm
    {
        public change_login()
        {
            InitializeComponent();
            loginn = new login();
            dbcontex = new Model1Container();
            loginBindingSource.DataSource = dbcontex.logins.ToList();
             

        }
        Model1Container dbcontex;
        login loginn;

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            

            loginBindingSource.EndEdit();
            dbcontex.logins.Add((login)loginBindingSource.Current);
            dbcontex.SaveChanges();
            
            loginBindingSource.DataSource = dbcontex.logins.ToList();

            AlertInfo info = new AlertInfo("", "لقد تم العملية بنجاح ");
            alertControl1.Show(this, info);
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            DialogResult reponse = MessageBox.Show(" هل تريد حذف المستخدم من قاعدة البيانات ؟؟ ", " Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (DialogResult.OK == reponse)
            {
                loginBindingSource.EndEdit();
                login delt_user = (login)loginBindingSource.Current;
                dbcontex.logins.Remove(delt_user);
                dbcontex.SaveChanges();
                loginBindingSource.DataSource = dbcontex.logins.ToList();
                MessageBox.Show(" لقد تم حذف المستخدم من قاعدة البيانات ", " Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            loginBindingSource.DataSource = loginn;
        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {
            dbcontex.SaveChanges();

            AlertInfo info = new AlertInfo("", "لقد تم التعديـــــل بنجاح ");
            alertControl1.Show(this, info);
        }

       
      

    }
}