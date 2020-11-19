using System;
using System.Collections.Generic;
using System.Text;

namespace Mid_agnmnt
{
    class Section 
    {
        private String name;
        private int Student_number;
        public String time;
        public Course course;
        Faculty FacultyName;
        float ft = 1.5f;


        public Section()
        {

        }
        public Section(String sn,int Snum,String st)
        {
            getSname(sn);
            getSnumber(Snum);
            getStime(st);
        }
        public void getSname(String n)
        {
            name = n;
        }
        public String setSname()
        {
            return name;
        }
        public void getSnumber(int n)
        {
            Student_number = n;
        }
        public int setSnumber()
        {
            return Student_number;
        }
        public void getStime(String t)
        {
            time = t;
        }
        public String setStime()
        {
            return time;
        }
        public void AddTeacher(Faculty FN)
        {
            if (ft < 21)
            {
                FacultyName = FN;
                ft=ft+1.5f;
            }
            else
            {
                Console.WriteLine("course can't add");
            }

        }
        public void ShowSectionInfo()
        {
            Console.WriteLine("Section name: "+ setSname());
            Console.WriteLine("Number of student: "+setSnumber());
            Console.WriteLine("Section time: "+setStime());
        }
    }
}
