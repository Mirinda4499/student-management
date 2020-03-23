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
        private static SqlConnection connection = new SqlConnection(ConnectionString.DB_CONNECTION_STRING);
        private SqlCommand cmd = new SqlCommand();

        public int InsertStudents(String name, int masv, int year, String makhoa)
        {
                                      
             connection.Open();
             cmd = connection.CreateCommand();
             cmd.CommandText = "INSERT SVIEN VALUES('" + name + "','" + masv + "','" + year + "','" + makhoa + "');";
             int resultInsert = cmd.ExecuteNonQuery();
                cmd.Clone();
            
             if (resultInsert > 0)
                return 1;
             else return 0;
        }


        public int UpDateStudents(String name, int masv, int year, String makhoa)
        {
            connection.Open();
            cmd = connection.CreateCommand();
            cmd.CommandText = "UPDATE SVIEN SET TEN = '" + name + "',MASV = '" + masv + "',NAM = '" + year + "',MAKH = '" + makhoa + "'";
            int resultUpdate = cmd.ExecuteNonQuery();
            cmd.Clone();
            if (resultUpdate > 0)
                return 1;
            else return 0;

        }


        public int DeleteStudents(int masv)
        {
            connection.Open();
            cmd = connection.CreateCommand();
            cmd.CommandText = "DELETE FROM SVIEN WHERE MASV = '" + masv + "'";
            int resultDelete = cmd.ExecuteNonQuery();
            cmd.Clone();
            if (resultDelete > 0)
                return 1;
            else return 0;

        }


    }
}


