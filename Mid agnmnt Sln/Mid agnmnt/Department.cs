using System;
using System.Collections.Generic;
using System.Text;

namespace Mid_agnmnt
{
    class Department : Course
    {
        private String Dname;
        private int Dsnum;
        Course[] courseName = new Course[5];
        private int countC = 0;
        public Department()
        { }
        public Department(String Dn,int Ds)
        {
            getDname(Dn);
            getDsnum(Ds);
        }
        public void getDname(String n)
        {
            Dname = n;
        }
        public String setDname()
        {
            return Dname;
        }
        public void getDsnum(int n)
        {
            Dsnum = n;
        }
        public int setDsnum()
        {
            return Dsnum;
        }
        public void ShowDInfo()
        {
            Console.WriteLine("Department name: " + setDname());
            Console.WriteLine("Number of Department: " + setDsnum());   
        }
        public void AddCourse(Course cn)
        {
            this.courseName[countC++] =cn;
        }

    }
}
