using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Security.Cryptography.X509Certificates;
using Microsoft.VisualBasic;
using System.Globalization;

namespace QLHD_QC_VB.Class
{
    internal class Functions
    {
        public static SqlConnection conn;
        public static string stringconn;
        public static void Connect()
        {
            stringconn = "Data Source=ANDY\\SQLEXPRESS;Initial Catalog=BTLC#;Integrated Security=True;Encrypt=False";
            conn = new SqlConnection();
            conn.ConnectionString = stringconn;
            conn.Open();
        }
        public static DataTable GetDataToTable(string sql)
        {
            SqlDataAdapter mydata = new SqlDataAdapter();
            mydata.SelectCommand = new SqlCommand(sql,Functions.conn);
            DataTable table = new DataTable();
            mydata.Fill(table);
            return table;
        }
        public static bool Checkkey(string sql)
        {
            SqlDataAdapter mydata = new SqlDataAdapter();
            mydata.SelectCommand = new SqlCommand(sql, Functions.conn);
            DataTable table = new DataTable();
            mydata.Fill(table);
            if(table.Rows.Count > 0)
                return true;
            else return false;
        }
        public static void Runsql(string sql)
        {
            SqlCommand cmd;
            cmd = new SqlCommand(sql,Functions.conn);
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            cmd.Dispose();
            cmd = null;
        }
        public static void Runsqldel (string sql)
        {
            SqlCommand cmd;
            cmd = new SqlCommand(sql, Functions.conn);
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {
                MessageBox.Show("Dữ liệu đang được sử dụng!","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
            cmd.Dispose();
            cmd = null;
        }
        public static void Fillcombo (string sql,ComboBox cbo, string ma, string ten)
        {
            SqlDataAdapter mydata = new SqlDataAdapter(sql,Functions.conn);
            DataTable table = new DataTable();
            mydata.Fill(table);
            cbo.DataSource = table;
            cbo.ValueMember = ma;
            cbo.DisplayMember = ten;
        }
        public static string GetFieldValues (string sql)
        {
            string ma ="";
            SqlCommand cmd = new SqlCommand(sql,Functions.conn);
            SqlDataReader reader;
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                ma = reader.GetValue(0).ToString();
            }
            reader.Close();
            return ma;

        }
        public static bool Isdate (string date)
        {
            string[] parts = date.Split('/');
            if ((Convert.ToInt32(parts[0]) >=1) && (Convert.ToInt32(parts[0]) <=31) && 
                (Convert.ToInt32(parts[1]) >=1) && (Convert.ToInt32(parts[1]) <=12) && (Convert.ToInt32(parts[2]) >= 1900))
            {
                return true;
            }
            else return false;
        }
        public static string ConvertDate (string date)
        {
            string[] parts = date.Split("/");
            string dt = String.Format("{0}/{1}/{2}", parts[1], parts[0], parts[2]);
            return dt;
        }
        public static int DateDiff (string date1, string date2)
        {
            DateTime dt1 = DateTime.ParseExact(date1, "dd/MM/yyyy", null);
            DateTime dt2 = DateTime.ParseExact(date2, "dd/MM/yyyy", null);
            TimeSpan diff = dt2 - dt1;
            int result = diff.Days;
            return result;
        }
        public static string CreateKey(string tiento)
        {
            string key = tiento;
            string[] partsdate;
            partsdate = DateTime.Now.ToShortDateString().Split('/');
            string d = String.Format("{0}{1}{2}", partsdate[0], partsdate[1], partsdate[2]);
            key = key + d;
            string[] partsTime;
            partsTime = DateTime.Now.ToLongTimeString().Split(":");
            if (partsTime[2].Substring(3, 2) == "PM")
            {
                partsTime[0] = ConvertTimeTo24(partsTime[0]);
            }
            if (partsTime[2].Substring(3, 2) == "AM")
            {
                if (partsTime[0].Length == 1)
                {
                    partsTime[0] = "0" + partsTime[0];
                }
            }
            partsTime[2] = partsTime[2].Remove(2, 3);
            string t;
            t = String.Format("{0}{1}{2}", partsTime[0], partsTime[1], partsTime[2]);
            key = key + "_" +t;
            return key;
        }
        public static string ConvertTimeTo24(string hour)
        {
            string h = "";
            switch (hour)
            {
                case "1":
                    h = "13";
                    break;
                case "2":
                    h = "14";
                    break;
                case "3":
                    h = "15";
                    break;
                case "4":
                    h = "16";
                    break;
                case "5":
                    h = "17";
                    break;
                case "6":
                    h = "18";
                    break;
                case "7":
                    h = "19";
                    break;
                case "8":
                    h = "20";
                    break;
                case "9":
                    h = "21";
                    break;
                case "10":
                    h = "22";
                    break;
                case "11":
                    h = "23";
                    break;
                case "12":
                    h = "24";
                    break;
            }
            return h;
        }
        public static string ConvertNumberToString (string number)
        {
            int mLen, mDigit;
            string mTemp = "";
            string[] mNumText;
            number = number.Replace(",", "");
            mNumText = "không;một;hai;ba;bốn;năm;sáu;bảy;tám;chín".Split(";");
            mLen = number.Length - 1;
            for(int i = 0; i <= mLen; i++)
            {
                mDigit = Convert.ToInt32(number.Substring(i,1));
                mTemp = mTemp + " " + mNumText[mDigit];
                if(mLen == 1)
                {
                    break;
                }
                switch ((mLen - i) % 9)
                {
                    case 0:
                        mTemp = mTemp + " tỷ";
                        if (number.Substring(i + 1, 3) == "000")
                        {
                            i = i + 3;
                        }
                        if (number.Substring(i + 1, 3) == "000")
                        {
                            i = i + 3;
                        }
                        if (number.Substring(i + 1, 3) == "000")
                        {
                            i = i + 3;
                        }
                        break;
                    case 6:
                        mTemp = mTemp + " triệu";
                        if (number.Substring(i + 1, 3) == "000")
                        {
                            i = i + 3;
                        }
                        if (number.Substring(i + 1, 3) == "000")
                        {
                            i = i + 3;
                        }
                        break;
                    case 3:
                        mTemp = mTemp + " nghìn";
                        if (number.Substring(i + 1, 3) == "000")
                        {
                            i = i + 3;
                        }
                        break;
                    default:
                        switch ((mLen - i) % 3)
                        {
                            case 2:
                                mTemp = mTemp + " trăm";
                                break;
                            case 1:
                                mTemp = mTemp + " mươi";
                                break;
                        }
                        break;
                }
            }
            mTemp = mTemp.Replace("không mươi không ", "");
            mTemp = mTemp.Replace("không mươi không", "");
            mTemp = mTemp.Replace("không mươi ", "linh ");
            mTemp = mTemp.Replace("mươi không", "mươi");
            mTemp = mTemp.Replace("một mươi", "mười");
            mTemp = mTemp.Replace("không mươi không ", "");
            mTemp = mTemp.Replace("mươi bốn", "mươi tư");
            mTemp = mTemp.Replace("linh bốn", "linh tư");
            mTemp = mTemp.Replace("mươi năm", "mươi lăm");
            mTemp = mTemp.Replace("mươi một", "mươi mốt");
            mTemp = mTemp.Replace("mười năm", "mười lăm");
            mTemp = mTemp.Trim();
            mTemp = mTemp.Substring(0, 1).ToUpper() + mTemp.Substring(1) + " đồng";
            return mTemp;
        }
    }
}
