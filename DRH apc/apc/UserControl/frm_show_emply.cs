using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using apc.Modele;
using apc;

namespace apc.UserControl
{
    public partial class frm_show_emply : DevExpress.XtraEditors.XtraUserControl
    {
        public frm_show_emply(employ employé)
        {
            InitializeComponent();
            LoadDataSource(employé);
            
        }

        employ emply;

        public void LoadDataSource(employ employé)
        {
            employBindingSource.DataSource = employé;
        }

        private void textEdit10_Enter(object sender, EventArgs e)
        { 
        }

        private void textEdit10_EditValueChanged(object sender, EventArgs e)
        {
        }

        private void textEdit13_EditValueChanged(object sender, EventArgs e)
        {
            //if (textEdit13.Text == null)
            //{
            //    emply = new employ();
            //    textEdit10.Text = emply.date_n_prisime.ToString();
            //}
        }

        private void textEdit10_EditValueChanged_1(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

       
     

      
    }
}
