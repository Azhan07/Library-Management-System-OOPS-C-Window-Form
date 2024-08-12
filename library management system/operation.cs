using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
namespace library_management_system
{
    class operation
    {
       public SqlConnection conn;
       public SqlCommand cmd;
       public DataTable dt;
        
        
        public string a;
        public void connectdb()
        {
            a = @"Data Source=DESKTOP-KFOP342\SQLEXPRESS;Initial Catalog=Library Management System;Integrated Security=True";
            conn = new SqlConnection(a);
            conn.Open();
            
        }

        public void insertdata(string insertquery)
        {
          
            cmd = new SqlCommand(insertquery, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
        }
        public void viewdata(string viewquery)
        {
            cmd = new SqlCommand(viewquery,conn);
            var reader = cmd.ExecuteReader();

            dt = new DataTable();
            dt.Load(reader);
            
        }
        public void updatedata(string updatequery)
        {
            
            cmd = new SqlCommand(updatequery, conn);
            var reader = cmd.ExecuteReader();

            dt = new DataTable();
            dt.Load(reader);
        }
        public void deletedata(string deletequery)
        {
            cmd = new SqlCommand(deletequery, conn);
            var reader = cmd.ExecuteReader();

            dt = new DataTable();
            dt.Load(reader);
        }
    }
}
