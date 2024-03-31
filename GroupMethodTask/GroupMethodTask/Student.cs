using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroupMethodTask
{
    internal class Student
    {
        public string FullName;
        private int _groupNo ;
        private double _avgPoint;

        public int GroupNo
        {
            get
            {
                return _groupNo;
            }
            set
            {
                if(value > 0)
                {
                    _groupNo = value;
                }
                else
                {
                    Console.WriteLine("Duzgun deyer daxil edin");
                }
            }
        }
        public double AvgPoint
        {
            get
            {
                return _avgPoint;
            }
            set
            {
                if(value >= 0 && value <= 100)
                {
                    _avgPoint = value;
                }
                else
                {
                    Console.WriteLine("Ortalama 0 ve 100 araliqinda olmalidir");
                }
            }
        }
        public Student(string fullName,int groupNo,double avgPoint)
        {
            FullName = fullName;
            GroupNo = groupNo;
            AvgPoint = avgPoint;
        }
    }
}
