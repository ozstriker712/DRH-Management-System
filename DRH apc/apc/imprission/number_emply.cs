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

namespace apc.imprission
{
    public partial class number_emply : DevExpress.XtraEditors.XtraForm
    {
        public number_emply()
        {
            InitializeComponent();
            get_sum_all_empl();
           
        }
        Model1Container dbcontex;
        employ employé;

        void get_sum_all_empl()
        {
            dbcontex = new Model1Container();
            textEdit1.Text = ((dbcontex.employSet.Count()).ToString()).ToString() ;
            textEdit8.Text = (dbcontex.employSet.Where(p => p.etat_emply == "تقاعد").Count()).ToString();

           
            textEdit2.Text = (dbcontex.employSet.Where(k => k.catgr == "مرسم").Count()).ToString() ;
            textEdit4.Text = (dbcontex.employSet.Where(k => k.catgr == "متعاقد محدد المدة - توقيت كلي").Count()).ToString();
            textEdit3.Text = (dbcontex.employSet.Where(k => k.catgr == "متعاقد محدد المدة - توقيت جزئي").Count()).ToString();
            textEdit12.Text = (dbcontex.employSet.Where(k => k.catgr == "متعاقد غير محدد المدة - توقيت كلي").Count()).ToString();
            textEdit10.Text = (dbcontex.employSet.Where(k => k.catgr == "متعاقد غير محدد المدة - توقيت جزئي").Count()).ToString();

            textEdit5.Text = (dbcontex.employSet.Where(k => k.catgr == "مرسم" && k.etat_emply == "تقاعد").Count()).ToString();
            textEdit7.Text = (dbcontex.employSet.Where(k => k.catgr == "متعاقد محدد المدة - توقيت كلي" && k.etat_emply == "تقاعد").Count()).ToString();
            textEdit6.Text = (dbcontex.employSet.Where(k => k.catgr == "متعاقد محدد المدة - توقيت جزئي" && k.etat_emply == "تقاعد").Count()).ToString();
            textEdit9.Text = (dbcontex.employSet.Where(k => k.catgr == "متعاقد غير محدد المدة - توقيت كلي" && k.etat_emply == "تقاعد").Count()).ToString();
            textEdit11.Text = (dbcontex.employSet.Where(k => k.catgr == "متعاقد غير محدد المدة - توقيت جزئي" && k.etat_emply == "تقاعد").Count()).ToString();
        }

        private void textEdit12_EditValueChanged(object sender, EventArgs e)
        {

        }

     
 
    }
}