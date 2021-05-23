using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab04_1712534
{

    class NhanVienService
    {
        DataConnection dc;
        SqlDataAdapter da;
        AES_256 AES_256;
        public NhanVienService()
        {
            dc = new DataConnection();
        }
        public string login()
        {
            try
            {
                SqlConnection con = dc.getConnect();
                SqlCommand cmd = new SqlCommand();
                con.Open();
                con.Close();
                return "a";
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
                throw e;
            }
        }

        public DataTable getAll()
        {
            try
            {
                string query = "";
                SqlConnection con = dc.getConnect();
                da = new SqlDataAdapter(query, con);
                con.Open();
                DataTable dt = new DataTable();
                da.Fill(dt);
                con.Close();
                return dt;
            }
            catch (Exception e) {
                Console.WriteLine(e.ToString());
                throw e; 
            }
        }

        public bool insert()
        {
            try
            {
                Console.WriteLine(AES_256.Encrypt("abc", "zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz", "zzzxxxzzzzzxxxzz"));
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
                return false;
            }
        }
    }
}
