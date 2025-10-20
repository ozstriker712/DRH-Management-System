using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraSplashScreen;
using System.Linq;
using apc.Modele;

namespace apc
{
    public partial class frm_Login : SplashScreen
    {
        public frm_Login()
        {
            InitializeComponent();
            dbcontex = new Model1Container();
           
            loginBindingSource.DataSource = dbcontex.logins.ToList();


           
        }
        Model1Container dbcontex;
        login loginn;
        #region Overrides

        public override void ProcessCommand(Enum cmd, object arg)
        {
            base.ProcessCommand(cmd, arg);
        }

        #endregion

        public enum SplashScreenCommand
        {
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            Close();
        }

     
         
        public void simpleButton1_Click(object sender, EventArgs e)
        {
            bool found = false;
            foreach (var loginn in dbcontex.logins)
            {
                if (loginn.user_name == comboBox1.Text && loginn.password == textBox1.Text)
                {
                    frm_Main open_frm_main = new frm_Main(loginn.id_user, loginn.user_name);
                    if (loginn.permision_login == 1)
                    {
                        open_frm_main.Show();
                        this.Hide();
                        found = true;
                        break;
                    }
                    else
                    {
                        if (loginn.permision_login == 2)
                        {
                            open_frm_main.barButtonItem3.Enabled = false; open_frm_main.barButtonItem37.Enabled = false; open_frm_main.barButtonItem10.Enabled = false;
                            open_frm_main.Show();
                            this.Hide();
                            found = true;
                            break;
                        }
                        else
                        {
                            if (loginn.permision_login == 3)
                            {
                                open_frm_main.barButtonItem3.Enabled = false; open_frm_main.barButtonItem41.Enabled = false; open_frm_main.barButtonItem10.Enabled = false;
                                open_frm_main.barButtonItem16.Enabled = false; open_frm_main.barButtonItem21.Enabled = false; open_frm_main.barButtonItem22.Enabled = false;
                                open_frm_main.barButtonItem30.Enabled = false; open_frm_main.barButtonItem23.Enabled = false; open_frm_main.barButtonItem24.Enabled = false;
                                open_frm_main.barButtonItem25.Enabled = false; open_frm_main.barButtonItem26.Enabled = false; open_frm_main.barButtonItem27.Enabled = false;
                                open_frm_main.barButtonItem32.Enabled = false; open_frm_main.barButtonItem37.Enabled = false; open_frm_main.barButtonItem7.Enabled = false;
                                open_frm_main.barButtonItem33.Enabled = false; open_frm_main.barButtonItem8.Enabled = false; open_frm_main.barButtonItem9.Enabled = false;
                                open_frm_main.barButtonItem55.Enabled = false; open_frm_main.barButtonItem9.Enabled = false; open_frm_main.barButtonItem34.Enabled = false;
                                open_frm_main.barButtonItem35.Enabled = false; open_frm_main.barButtonItem31.Enabled = false; open_frm_main.barButtonItem38.Enabled = false;
                                open_frm_main.barButtonItem42.Enabled = false;
                                open_frm_main.Show();
                                this.Hide();
                                found = true;
                                break;
                            }
                            else
                            {
                                if (loginn.permision_login == 4)
                                {
                                    open_frm_main.barButtonItem3.Enabled = false; open_frm_main.barButtonItem12.Enabled = false; open_frm_main.barButtonItem13.Enabled = false;
                                    open_frm_main.barButtonItem37.Enabled = false; open_frm_main.barButtonItem10.Enabled = false; open_frm_main.barButtonItem42.Enabled = false;

                                    open_frm_main.ribbonPage6.Visible = false;
                                    open_frm_main.ribbonPage2.Visible = false;
                                    open_frm_main.ribbonPage3.Visible = false;
                                    open_frm_main.ribbonPage7.Visible = false;
                                    open_frm_main.ribbonPage4.Visible = false;
                                    open_frm_main.Show();
                                    this.Hide();
                                    found = true;
                                    break;
                                }
                               


                            }
                        }

                    }
                     
                }

                
            }

            if (found==false)
            {
                MessageBox.Show("كلمة المــــــــرور خاطئــــة أو لا تتطابق مع اسم المستخدم", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox1.Clear();
            }
           
       }

        private void frm_Login_Load(object sender, EventArgs e)
        {

        }

     
        
    }
}