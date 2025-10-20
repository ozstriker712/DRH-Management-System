using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraBars.Helpers;
using apc.Modele;
using System.Data.SqlClient;
using apc.UserControl;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using DevExpress.XtraGrid.Views.Grid;
using System.Diagnostics;
using DevExpress.XtraReports.UI;
using DevExpress.XtraEditors;
using DevExpress.XtraPrinting.Native;
using System.Net;
using DevExpress.XtraRichEdit;
using apc.imprission;
using apc.Properties;
using DevExpress.LookAndFeel;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using DevExpress.XtraBars.Alerter;


namespace apc
{
    public partial class frm_Main :DevExpress.XtraBars.Ribbon.RibbonForm
    {
        int id_user_public;
         
        public frm_Main(int id_username,string username)
        {
            InitializeComponent();
            refrech();
            textEdit1.Enabled = false;
            textBox3.Text = username;
           
            id_user_public = id_username;

            DevExpress.XtraBars.Helpers.SkinHelper.InitSkinGallery(ribbonGalleryBarItem1, true, true);
            
        }

        Model1Container dbcontex;
        employ selectedEmploy;
        frm_show_emply frm_show_emply;
       
        frm_show_search frm_show_search;

        employ emmmm;

        void refrech()
        {
            dbcontex = new Model1Container();
            employBindingSource.DataSource = dbcontex.employSet.ToList();
          
        }


        public void frm_Main_Load(object sender, EventArgs e)
        {
            //SkinHelper.InitSkinGallery(ribbonGalleryBarItem1, true); // skins

            if (File.Exists(FileName))
                DevExpress.LookAndFeel.UserLookAndFeel.Default.SetSkinStyle(LoadSettings(FileName).SkinName);

            
            
            selectedEmploy = (employ)employBindingSource.Current;
            frm_show_emply = new UserControl.frm_show_emply(selectedEmploy);

            try
            {
                groupControl1.Controls.Add(frm_show_emply);
               
            }
            catch
            {
                groupControl1.Controls.Add(frm_show_search);

                UserControl.frm_show_search frm = new UserControl.frm_show_search();

               
               
            }
            

            compteur_empl();


            string hostName = Dns.GetHostName();
            string myIP = Dns.GetHostByName(hostName).AddressList[0].ToString();
            textBox1.Text = myIP;
            string namepc = System.Environment.MachineName;
            textBox2.Text = namepc;
            
     
            
            
            
        }

        void compteur_empl() // nbr of emply 
        {
            var count = dbcontex.employSet.Count();
            textEdit1.Text = count.ToString();
            refrech();
            
        }

        public void barButtonItem12_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            frm_add_emply open_add_emply = new frm_add_emply(new employ(), dbcontex, id_user_public);
            open_add_emply.simpleButton5.Enabled = false;
            open_add_emply.Show();
            
        }

        
        public void barButtonItem13_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            
            
            try 
            {
                if (selectedEmploy != null)
                {
                    frm_add_emply open_add_emply = new frm_add_emply(selectedEmploy, dbcontex, id_user_public);
                    open_add_emply.SimpleButton2.Enabled = false;
                    
                    open_add_emply.Show();
                }
            }
            catch 
            {
                
                MessageBox.Show(" قم بتحديد المــــوظف أولا للتعديل على المعلومات الخاصة به  ", " Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            
        }

        private void barButtonItem4_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frm_add_vac open_add_vac = new frm_add_vac(selectedEmploy, dbcontex);
            open_add_vac.Show();
        }

        private void barButtonItem6_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frm_all_vac open_frm_all_vac = new frm_all_vac(selectedEmploy,dbcontex);
            open_frm_all_vac.Show();
        }

        private void barButtonItem10_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            gestion_db frm = new gestion_db();
            frm.Show();
           
        }

    
       private void barButtonItem14_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ShowUserControl(new UserControl.frm_show_search());

           
        }

   
        

       private void barButtonItem18_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
       {
        
       }

       void ShowUserControl(DevExpress.XtraEditors.XtraUserControl usercontrol)
       {
           bool loaded = false ;
          
           foreach (Control control in groupControl1.Controls)
           {
               if (usercontrol.GetType() != control.GetType())
                   control.Visible = false;
               else
               {
                   control.Visible = true;
                   loaded = true;
                   
               }
           }
           if (!loaded)
               groupControl1.Controls.Add(usercontrol);
       }

       object GetCurrentUserControl()
       {
           foreach (Control control in groupControl1.Controls)
           {
               if (control.Visible)
                   return control;
           }
           return null;
       }


       public int DeleteEmployee(int id)
       {
           int result;
           try
           {
               var employee = dbcontex.employSet.Find(id);
               dbcontex.employSet.Remove(employee);
               dbcontex.SaveChanges();
               result = 1;
           }
           catch  
           {
               result = 0;
           }
           return result;
       }

       private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
       {

           DialogResult reponse = MessageBox.Show(" هل تريد حذف الموظف من قاعدة البيانات ؟؟ ", " Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
           if (DialogResult.OK==reponse)
           {
               employBindingSource.EndEdit();
               employ delt_empl = (employ)employBindingSource.Current;
               dbcontex.employSet.Remove(delt_empl);
               dbcontex.SaveChanges();
               refrech();
               MessageBox.Show(" لقد تم حذف موظف من قاعدة البيانات ", " Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
           }
         

           
       }

       public void detect_date_n()
       {
            //
            
           
 
       }

       
       public void gridView1_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
       {
           
           selectedEmploy = (employ)employBindingSource.Current;
           frm_show_emply.LoadDataSource(selectedEmploy);
           if (selectedEmploy.date_n == null)
           {
               frm_show_emply.textEdit13.Text = "خلال : " + selectedEmploy.date_n_prisime.ToString();
           }
          

          
       }

      

       private void simpleButton1_Click(object sender, EventArgs e)
       {
           string connetionString = null; 
           SqlConnection cnn;

           connetionString = "data source=192.168.1.254\\SQLSERVER;initial catalog=db1;Integrated Security=True";
               cnn = new SqlConnection(connetionString.ToString());
           try 
           {
               cnn.Open();

               MessageBox.Show("... نجاح الاتصـــــــــــال بالخادم الرئيســــــــــي  "); 
               cnn.Close(); 
           } 
           catch 
           {
               MessageBox.Show("  !...  فشل الاتصـــــــــــال بالخادم الرئيســــــــــي");
           }

          
       }

       private void dataNavigator1_Click(object sender, EventArgs e)
       {

       }


       private void frm_Main_FormClosed(object sender, FormClosedEventArgs e)
       {
           Application.Exit();
       }

       private void barButtonItem19_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
       {
           frm_about frm = new frm_about();
           frm.Show();
       }

       private void barButtonItem15_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
       {
           
           //ShowUserControl(new UserControl.frm_dash());
           
           UserControl.frm_dash frm = new frm_dash();
           frm.Show();
          
       }

       private void gridControl1_Click(object sender, EventArgs e)
       {

       }

       private void م_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
       {
           ShowUserControl(new UserControl.frm_show_emply(selectedEmploy));
       }

       private void ribbonControl1_Click(object sender, EventArgs e)
       {
           frm_show_search frm = new frm_show_search();
            frm.refrech();
       }

       private void barButtonItem5_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
       {
           frm_vac_plus frm = new frm_vac_plus(selectedEmploy, dbcontex);
           frm.Show();
       }

       public void barButtonItem16_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e) // open doc2 chngmnt
       {
           les_docs.frm_doc2 open_doc2_daraja = new les_docs.frm_doc2(selectedEmploy, dbcontex);
           open_doc2_daraja.xtraTabControl2.TabPages[2].PageEnabled = false;
           open_doc2_daraja.xtraTabControl2.TabPages[1].PageEnabled = false;

           open_doc2_daraja.Show();
       }

       private void barButtonItem21_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
       {

           les_docs.frm_doc2 open_doc2_poste = new les_docs.frm_doc2(selectedEmploy, dbcontex);
           open_doc2_poste.xtraTabControl2.TabPages[0].PageEnabled = false;
           open_doc2_poste.xtraTabControl2.TabPages[2].PageEnabled = false;

           open_doc2_poste.Show();
       }

       private void barButtonItem22_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
       {
           les_docs.frm_doc2 open_doc2_delgation = new les_docs.frm_doc2(selectedEmploy, dbcontex);
           open_doc2_delgation.xtraTabControl2.TabPages[0].PageEnabled = false;
           open_doc2_delgation.xtraTabControl2.TabPages[1].PageEnabled = false;

           open_doc2_delgation.Show();
       }

       private void barButtonItem23_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e) // open Doc3 promtion
       {
           les_docs.frm_doc3 frm = new les_docs.frm_doc3(selectedEmploy,dbcontex);
           frm.Show();
       }

       private void barButtonItem24_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e) //open doc4 ta9yim
       {
           les_docs.frm_doc4 frm = new les_docs.frm_doc4(selectedEmploy, dbcontex);
           frm.Show();
       }

       private void barButtonItem25_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)// open doc5 mo7asaba
       {
           les_docs.frm_doc5 frm = new les_docs.frm_doc5(selectedEmploy, dbcontex);
           frm.Show();
       }

       private void barButtonItem27_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e) // open doc7 displine
       {
           les_docs.frm_doc7 frm = new les_docs.frm_doc7(selectedEmploy, dbcontex);
           frm.Show();
       }

       private void barButtonItem26_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e) // open doc6
       {
           les_docs.frm_doc6 frm = new les_docs.frm_doc6(selectedEmploy, dbcontex);
           frm.Show();
       }

      
       private void barButtonItem30_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
       {
           les_docs.frm_doc2_charge frm = new les_docs.frm_doc2_charge(selectedEmploy, dbcontex);
           frm.Show();
       }

       private void barButtonItem31_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
       {
           try
           {
               (GetCurrentUserControl() as CustomUserControl).ExportToExcel();
           }
           catch
           {
               MessageBox.Show(" حدد الجـــــــــــــــدول أولا المراد تصديره ", " Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);

           }

       }

     
       private void barButtonItem9_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
       {
          
           imprission.print_badge repot1 = new imprission.print_badge();
           

           List<int> EmployéIds = new List<int>(); ;
          foreach(int selectedRow in gridView1.GetSelectedRows().ToList())
          {
              EmployéIds.Add((int)gridView1.GetRowCellValue(selectedRow, colid));
          }

          repot1.DataSource = (from employé in dbcontex.employSet where EmployéIds.Contains(employé.id) select employé).ToList();

          ReportPrintTool printTool = new ReportPrintTool(repot1);
          
          printTool.ShowPreviewDialog();
          

          // printTool.ShowPreview();
      
       }

       private void barButtonItem8_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
       {
           frm_all_vac frm = new frm_all_vac(selectedEmploy, dbcontex);
           frm.Show();
       }


       private void barButtonItem32_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e) // open frm doc 10
       {
           les_docs.frm_doc10 frm = new les_docs.frm_doc10(selectedEmploy, dbcontex);
           frm.Show();
       }

    


       private void barButtonItem7_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
       {
           imprission.print_attestation_travail_ar print_attest = new imprission.print_attestation_travail_ar( );
           imprission.attestation_tr_2 print_2 = new attestation_tr_2();

           List<int> EmployéIds = new List<int>(); ;
           foreach (int selectedRow in gridView1.GetSelectedRows().ToList())
           {
               EmployéIds.Add((int)gridView1.GetRowCellValue(selectedRow, colid));
           }

           print_attest.DataSource = (from employé in dbcontex.employSet where EmployéIds.Contains(employé.id) select employé).ToList();
           print_2.DataSource = (from employé in dbcontex.employSet where EmployéIds.Contains(employé.id) select employé).ToList();
           if ( selectedEmploy.doc_promotion.Count()==0)
           {
               ReportPrintTool printTool = new ReportPrintTool(print_2);
               printTool.ShowPreviewDialog();

           }
           else
           {
               ReportPrintTool printTool = new ReportPrintTool(print_attest);
               printTool.ShowPreviewDialog();
           }
           
       }

       private void barButtonItem33_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
       {
           imprission.print_attestation_travail_fr print_attest = new imprission.print_attestation_travail_fr();
           List<int> EmployéIds = new List<int>(); ;
           foreach (int selectedRow in gridView1.GetSelectedRows().ToList())
           {
               EmployéIds.Add((int)gridView1.GetRowCellValue(selectedRow, colid));
           }

           print_attest.DataSource = (from employé in dbcontex.employSet where EmployéIds.Contains(employé.id) select employé).ToList();

           ReportPrintTool printTool = new ReportPrintTool(print_attest);

           printTool.ShowPreviewDialog();
       }

       private void barButtonItem34_ItemClick_1(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
       {
           imprission.who_charge_poste frm = new imprission.who_charge_poste();
           frm.Show();
       }

       private void barButtonItem35_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
       {
           imprission.who_delgation frm = new imprission.who_delgation();
           frm.Show();
       }

       private void barButtonItem11_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
       {
           refrech();
           compteur_empl();
           try
           {
               (GetCurrentUserControl() as CustomUserControl).refrech();
           }
           catch
           { }
          
       }
 

       private void barButtonItem29_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
       {
           imprission.number_emply frm = new imprission.number_emply();
           frm.Show();
       }

       private void barCheckItem1_CheckedChanged(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
       {
      
          
       }

      

       private void barButtonItem37_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
       {
           change_login frm = new change_login();
            frm.Show();
       }

       private void ـ_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
       {
          

           imprission.personal_card repot2 = new imprission.personal_card();


           List<int> EmployéIds = new List<int>(); ;
           foreach (int selectedRow in gridView1.GetSelectedRows().ToList())
           {
               EmployéIds.Add((int)gridView1.GetRowCellValue(selectedRow, colid));
           }

           repot2.DataSource = (from employé in dbcontex.employSet where EmployéIds.Contains(employé.id) select employé).ToList();

           ReportPrintTool printTool = new ReportPrintTool(repot2);

           printTool.ShowPreviewDialog();
          
       }

       private void barButtonItem38_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
       {
           
           imprission.personal_card repot2 = new imprission.personal_card();
           

           List<int> EmployéIds = new List<int>(); ;
           foreach (int selectedRow in gridView1.GetSelectedRows().ToList())
           {
               EmployéIds.Add((int)gridView1.GetRowCellValue(selectedRow, colid));
           }

           repot2.DataSource = (from employé in dbcontex.employSet where EmployéIds.Contains(employé.id) select employé).ToList();

           repot2.ExportToRtf("c:\\Personal_card.rtf");
           Process proc = new Process();
           proc.StartInfo.FileName = "c:\\Personal_card.rtf";
           proc.StartInfo.UseShellExecute = true;
           proc.Start();   
            
          
       }

       private void barButtonItem39_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
       {
           get_info_DB frm = new get_info_DB();
           frm.Show();
       }

       private void barButtonItem40_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
       {
           UserSettings us = new UserSettings();
           us.SkinName = DevExpress.LookAndFeel.UserLookAndFeel.Default.ActiveSkinName;
           SaveSettings(us); 

           AlertInfo info;
           info = new AlertInfo("", "لقد تم تعديل و حفظ الشكل "); 
           alertControl1.Show(this, info);

          
       }
       string FileName = "UserSettings.txt";
       private void SaveSettings(UserSettings us)
       {
           BinaryFormatter binFormat = new BinaryFormatter();
           using (Stream fStream = new FileStream(FileName, FileMode.Create, FileAccess.Write, FileShare.None))
           {
               binFormat.Serialize(fStream, us);
               fStream.Close();
           }
       }

       private UserSettings LoadSettings(string fileName)
       {
           UserSettings us = null;
           BinaryFormatter binFormat = new BinaryFormatter();
           Stream fStream = new FileStream(fileName, FileMode.Open);
           try { us = binFormat.Deserialize(fStream) as UserSettings; }
           finally { fStream.Close(); }
           return us;
       }

    

       private void barButtonItem41_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
       {
           les_docs.frm_doc2_renomination frm = new les_docs.frm_doc2_renomination(selectedEmploy, dbcontex);
           frm.Show();
       }

       private void ribbonGalleryBarItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
       {
           UserSettings us = new UserSettings();
           us.SkinName = DevExpress.LookAndFeel.UserLookAndFeel.Default.ActiveSkinName;
           SaveSettings(us);    
       }

       private void barButtonItem42_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
       {
           emply_who_inVac frm = new emply_who_inVac();
           frm.Show();
       }

       private void barButtonItem36_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
       {
           imprission.total_nomination repot2 = new imprission.total_nomination();


           List<int> EmployéIds = new List<int>(); ;
           foreach (int selectedRow in gridView1.GetSelectedRows().ToList())
           {
               EmployéIds.Add((int)gridView1.GetRowCellValue(selectedRow, colid));
           }

           repot2.DataSource = (from employé in dbcontex.employSet where EmployéIds.Contains(employé.id) select employé).ToList();

           ReportPrintTool printTool = new ReportPrintTool(repot2);

           printTool.ShowPreviewDialog();
       }

      
    }


    [Serializable]
    public class UserSettings
    {
        public string SkinName;
    }
}
