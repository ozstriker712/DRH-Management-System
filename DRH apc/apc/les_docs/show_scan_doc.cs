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

namespace apc.les_docs
{
    public partial class show_scan_doc : DevExpress.XtraEditors.XtraForm
    {
        public show_scan_doc(doc_morasalt_idariya select_pic, Model1Container dbcontex)
        {
            InitializeComponent();
            this.dbcontex = dbcontex;
            this.select_pic = select_pic;
            //select_pic = new doc_morasalt_idariya();
         
            docmorasaltidariyaBindingSource.DataSource = select_pic;
        }

        Model1Container dbcontex;
        doc_morasalt_idariya select_pic;    
   
     
    }
}