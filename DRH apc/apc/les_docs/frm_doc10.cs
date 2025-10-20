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
    public partial class frm_doc10 : DevExpress.XtraEditors.XtraForm
    {
        public frm_doc10(employ employé, Model1Container dbcontex)
        {
            InitializeComponent();
            this.dbcontex = dbcontex;
            this.employé = employé;
            employBindingSource.DataSource = employé;
            morasalt = new doc_morasalt_idariya();
            morasalt.employ_id = employé.id;
          docmorasaltidariyaBindingSource.DataSource = morasalt;
          docmorasaltidariyaBindingSource.DataSource = employé.doc_morasalt_idariya.ToList();
          
            
            textEdit1.Enabled = false;
        }

        Model1Container dbcontex;
        employ employé;
        doc_morasalt_idariya morasalt ;
        doc_morasalt_idariya select_pic;

        private void simpleButton4_Click(object sender, EventArgs e) //add
        {
            try
            {
                docmorasaltidariyaBindingSource.EndEdit();
                employé.doc_morasalt_idariya.Add(morasalt);
                dbcontex.SaveChanges();

                AlertInfo info = new AlertInfo("", "لقد تم اضافة مراسلة ادارية");
                alertControl1.Show(this, info);

                morasalt = new doc_morasalt_idariya();
                docmorasaltidariyaBindingSource.DataSource = employé.doc_morasalt_idariya.ToList();
            }
            catch
            {
                MessageBox.Show("there is a controle is Null", " Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e) //clear
        {
            docmorasaltidariyaBindingSource.DataSource = morasalt;

        }

        private void simpleButton3_Click(object sender, EventArgs e) // show all
        {
           
        }


    
        public void simpleButton2_Click(object sender, EventArgs e)
        {
            select_pic = (doc_morasalt_idariya)docmorasaltidariyaBindingSource.Current;
            show_scan_doc frm_scan = new show_scan_doc(select_pic, dbcontex);

            frm_scan.Show();
        
        }

        
        public void gridView1_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
             
            
            

        }

       
    }
}