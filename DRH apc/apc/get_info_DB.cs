using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Data.SqlClient;
using System.Data.Entity;

namespace apc
{
    public partial class get_info_DB : DevExpress.XtraEditors.XtraForm
    {
        public get_info_DB()
        {
            InitializeComponent();

            string connetionString = null;
            SqlConnection cnn;

            connetionString = "data source=192.168.1.254\\SQLSERVER;initial catalog=db1;Integrated Security=True";
            cnn = new SqlConnection(connetionString.ToString());


             SqlCommand spaceused = new SqlCommand("sp_spaceused", cnn);

            spaceused.CommandType = CommandType.StoredProcedure;
      
             cnn.Open();
             SqlDataReader reader = spaceused.ExecuteReader();
             if (reader.HasRows)
             {
                 while (reader.Read())
                 {

                     textEdit1.Text = reader["database_name"].ToString();
                     textEdit2.Text = reader["database_size"].ToString() ;
                     //memoEdit1.Text += "Rows: " + reader["database_status"] + "\r\n";
                     //memoEdit1.Text += "Reserved: " + reader["database_reserved"] + "\r\n";
                     //memoEdit1.Text += "Data: " + reader["database_data"] + "\r\n";
                       
                 }
             }
        }

     
    }
}