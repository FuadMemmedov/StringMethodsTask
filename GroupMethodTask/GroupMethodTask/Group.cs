using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroupMethodTask
{
    internal class Group
    {
        private string _no;
        private int _studentLimit;
        Student[] Students = new Student[] {};

        public int StudentLimit
        {
            get
            {
                return _studentLimit;
            }
            set
            {
                if ( value >= 0 && value <= 20) 
                {
                    _studentLimit = value;
                }
                else
                {
                    Console.WriteLine("Limit kecilmisdir");
                }
            }
        }

        public string No
        {
            get
            {
                return _no;
            }
            set
            {
                if(value.Length == 5)
                {

                    for (int i = 0; i < value.Length - 3; i++)
                    {
                        if (value[i] >= 65 && value[i] < 97)
                        {
                            _no += value[i];


                        }

                    }
                    for (int k = value.Length - 3; k < value.Length; k++)
                    {
                        if (value[k] >= 48 && value[k] <= 57)
                        {
                            _no += value[k];
                        }
                    }
                }
                else
                {
                    Console.WriteLine("No deyeri 5 simvol olmalidir");
                }
                
            }
        }

        public void AddStudent(Student student)
        {
            if(Students.Length < StudentLimit )
            {
                Array.Resize(ref Students, Students.Length + 1);
                Students[Students.Length - 1] = student;
            }
            else
            {
                Console.WriteLine("Limit kecilmisdir");
            }
           
            
        }


        public Group(string no,int studentLimit)
        {
            No = no;
            StudentLimit = studentLimit;
                
        }

        public void ShowAllStudents()
        {
            for (int i = 0;i < Students.Length; i++)
            {
                Console.WriteLine($"\nFullName: {Students[i].FullName}\n GroupNo: {Students[i].GroupNo}\n AvgPoint: {Students[i].AvgPoint}");
            }
            
        }
        public void SearchStudents(string fullName)
        {
            bool check = false;
            for(int i = 0; i < Students.Length; i++)
            {
                if (Students[i].FullName == fullName)
                {
                    check = true;
                    Console.Write($"FullName: {Students[i].FullName}\n GroupNo: {Students[i].GroupNo}\n AvgPoint: {Students[i].AvgPoint}");
                }

                
                
            }
            if (!check)
            {
                Console.WriteLine($"{fullName} adli telebe yoxdur");
            }
        }

    

    }
}
