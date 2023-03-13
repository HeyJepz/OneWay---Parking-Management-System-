using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.IO;
using System.Data;
using System.Security.Cryptography.X509Certificates;

namespace OneWay1
{
    internal class dbControls
    {
        
        //Declaration of variables
        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Kc\Desktop\OneWay1-20230120T174530Z-001\OneWay1\OneWay1\dbAccountsDatabase.mdf;Integrated Security=True;Connect Timeout=30");
        SqlCommand comm;
        public SqlDataAdapter dAdapater;
        List<SqlParameter> Params = new List<SqlParameter>();
        public DataTable dTable;
        public int RecordCount;
        public string exception;

        //Accepts the command from other forms
        public void Query(string name)
        {
            RecordCount= 0;
            exception= null;

            try
            {
                conn.Open();
                comm = new SqlCommand(name)
                {
                    Connection = conn
                };
                Params.ForEach(param => comm.Parameters.Add(param));
                Params.Clear();
                dTable = new DataTable();
                dAdapater = new SqlDataAdapter(comm);
                RecordCount = dAdapater.Fill(dTable);
            }
            catch(Exception e) 
            {
                exception = e.Message;
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }

            }
        }
        //Parameter for username and password
        public void Param(string name, object value)
        {
            SqlParameter NewParam = new SqlParameter(name,value);
            Params.Add(NewParam);
        }
        //checks for errors
        public bool Check4Error(bool Error = false)
        {
            if (string.IsNullOrEmpty(exception))            
                return false;
            
            if (Error == true)
            {
                MessageBox.Show(exception, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return true;
        }
    }
}
