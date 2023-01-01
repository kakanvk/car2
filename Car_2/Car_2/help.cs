using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Car_2
{
    internal class help
    {
        public SqlConnection ketnoi;
        public SqlCommand lenh;
        public SqlDataAdapter bodocdulieu;
        public SqlDataReader reader;
        public DataSet ds;
        public help()
        {
            ketnoi = new SqlConnection();


            string str = "Data Source=.;Integrated Security = True; Initial Catalog = xeOTo";
            ketnoi.ConnectionString = str;

            /*
             string sqlsang = "";

            ketnoi.ConnectionString = sqlsang;
             */

        }
        public void KetNoi()
        {
            ketnoi = new SqlConnection();
            if (ketnoi.State == ConnectionState.Closed)
                ketnoi.Open();
        }
        public void NgatKetNoi()
        {
            ketnoi.Close();
        }
        public DataTable load_du_lieu(string sql)
        {
            ketnoi.Open();
            bodocdulieu = new SqlDataAdapter(sql, ketnoi);
            DataTable dt = new DataTable();
            bodocdulieu.Fill(dt);
            ketnoi.Close();
            return dt;
        }
        public void thaotaclenh(string sql)
        {
            ketnoi.Open();
            lenh = new SqlCommand(sql, ketnoi);
            lenh.ExecuteNonQuery();
            ketnoi.Close();
        }
        public string GetValues(string sql)
        {

            string ma = "";
            ketnoi.Open();
            lenh = new SqlCommand(sql, ketnoi);
            reader = lenh.ExecuteReader();
            while (reader.Read())
            {
                ma = reader.GetValue(0).ToString();
            }
            reader.Close();
            ketnoi.Close();
            return ma;
        }
        public void FILLComboBox(string sql, ComboBox NameCB, string ma, string ten)
        {
            NameCB.DataSource = load_du_lieu(sql);
            NameCB.DisplayMember = ten;
            NameCB.ValueMember = ma;
        }

        public DataTable Execute(string sql)//Select
        {
            ketnoi.Open();
            bodocdulieu = new SqlDataAdapter(sql, ketnoi);
            ds = new DataSet();
            bodocdulieu.Fill(ds);
            ketnoi.Close();
            return ds.Tables[0];
        }



        public bool CheckKey(string sql)
        {
            SqlDataAdapter hungadap = new SqlDataAdapter(sql, ketnoi);
            DataTable hung = new DataTable();
            hungadap.Fill(hung);

            if (hung.Rows.Count > 0)

                return true;

            else


                return false;

        }
    }