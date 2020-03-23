using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagement
{
    class SinhVienDAO
    {
        private DataSet dataSet = new DataSet();
        private static SqlConnection cn = new SqlConnection("Data Source=SE130059;Initial Catalog=QLSVien;Integrated Security=True");
        private SqlCommand cmd = new SqlCommand();
        public int InsertStudents(String name, int masv, int year, String makhoa)
        {
            cn.Open();
            cmd = cn.CreateCommand();
            cmd.CommandText = "INSERT INTO SVIEN VALUES('" + name + "','" + masv + "','" + year + "','"+makhoa+"')";
            int rs = cmd.ExecuteNonQuery();
            cmd.Clone();
            if (rs > 0)
                return 1;
            else return 0;

        }
        public int UpDateStudents(String name, int masv, int year, String makhoa)
        {
            cn.Open();
            cmd = cn.CreateCommand();
            cmd.CommandText = "UPDATE SVIEN SET NAME = '" + name + "',MASV = '" + masv + "',NAM = '" + year + "',MAKHOA = '" + makhoa + "'";
            int rs = cmd.ExecuteNonQuery();
            cmd.Clone();
            if (rs > 0)
                return 1;
            else return 0;

        }
        public int DeleteStudents(int masv)
        {
            cn.Open();
            cmd = cn.CreateCommand();
            cmd.CommandText = "DELETE FROM SVIEN WHERE MASV = '"+ masv +"'";
            int rs = cmd.ExecuteNonQuery();
            cmd.Clone();
            if (rs > 0)
                return 1;
            else return 0;

        }
    }

}
