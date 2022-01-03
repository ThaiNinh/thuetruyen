using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Text.RegularExpressions;
namespace thuetruyen
{
    class function
    {
        public static SqlConnection a;
        public static string astring;

        public static SqlConnection ketnoi()
        {
            SqlConnection a = new SqlConnection();
            astring = "Data Source=.\\SQLEXPRESS01;AttachDbFilename=D:\\nam hai\\cslt2\\vs\\thuetruyen\\thuetruyen\\database\\thuetruyen.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True";

            a.ConnectionString = astring;
            a.Open();
            return a;

        }
        public static void ngatketnoi()
        {
            if (a.State == ConnectionState.Open)
            {
                a.Close();
                a.Dispose();
                a = null;
            }
        }
       public static void fillcombo(string sql, ComboBox cbobox, string ma, string ten)
        {
            SqlDataAdapter a = new SqlDataAdapter();
            a.SelectCommand = new SqlCommand();
            a.SelectCommand.Connection = function.ketnoi();
            a.SelectCommand.CommandText = sql;

            DataTable bang = new DataTable();
            a.Fill(bang);


            cbobox.DataSource = bang;
            cbobox.ValueMember = ma;
            cbobox.DisplayMember = ten;


        }
        public static DataTable getdatatotable(String sql)
        {
            SqlDataAdapter a = new SqlDataAdapter();
            a.SelectCommand = new SqlCommand();
            a.SelectCommand.Connection = function.ketnoi();
            a.SelectCommand.CommandText = sql;

            DataTable bang = new DataTable();
            a.Fill(bang);
            return bang;

        }
        public static bool ktratrungma(string sql)
        {
            SqlDataAdapter a = new SqlDataAdapter();
            a.SelectCommand = new SqlCommand();
            a.SelectCommand.Connection = function.ketnoi();
            a.SelectCommand.CommandText = sql;

            DataTable bang = new DataTable();
            a.Fill(bang);

            if (bang.Rows.Count > 0)
                return true;
            else
                return false;
        }
        public static void Runsql(string sql)
        {
            SqlCommand a = new SqlCommand();
            a.Connection = function.ketnoi();
            a.CommandText = sql;
            try
            {
                a.ExecuteNonQuery();

            }
            catch (System.Exception loi)
            {
                MessageBox.Show(loi.ToString());
            }
            a.Dispose();
            a = null;
        }
        public static string GetFieldValues(string sql)
        {
            string ma = "";
            SqlCommand cmd = new SqlCommand(sql, function.ketnoi());
            SqlDataReader reader;
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                ma = reader.GetValue(0).ToString();
            }
            reader.Close();
            return ma;
        }
    }
}
