using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagement
{
    class Major
    {
        private String makhoa;
        private String tenKhoa;
        private int year;

        public Major(string makhoa, string tenKhoa, int year)
        {
            this.makhoa = makhoa;
            this.tenKhoa = tenKhoa;
            this.year = year;
        }

        public Major()
        {
        }
        public string MaKhoa { get => MaKhoa; set => MaKhoa = value; }
        public String TenKhoa { get => TenKhoa; set => TenKhoa = value; }
        public int Year { get => year; set => year = value; }
    }
 
}

