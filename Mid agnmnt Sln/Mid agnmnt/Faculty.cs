using System;
using System.Collections.Generic;
using System.Text;

namespace Mid_agnmnt
{
    class Faculty:Section
    {
        private String Fname;
        private String Fid;
        private float Fstime=0;
        public Section[] facultySection;
        private int countS = 0;
        public int FacultyTotalSection { get; set; }
        public Faculty()
        {
        }
        public Faculty(String Fn,String Fi,float Fst)
        {
            getFname(Fn);
            getFid(Fi);
            getFstime(Fst);
            facultySection = new Section[5];
        }
        public void getFname(String nm)
        {
            Fname = nm;
        }
        public String setFname()
        {
            return Fname;
        }
        public void getFid(String id)
        {
            Fid = id;
        }
        public String setFid()
        {
            return Fid;
        }
        public void getFstime(float t)
        {
            Fstime = t;
        }
        public float setFstime()
        {
            return Fstime;
        }
        public void AddFacultySection(Section SNm)
        {
            int t=Convert.ToInt32( SNm.time);
            float temp = Fstime + t;
            if (temp <= 21)
            {
                facultySection[FacultyTotalSection++] = SNm;
                Fstime += t;
            }
            else
                Console.WriteLine("We can't assign ");

        }


        public void ShowFInfo()
        {
            Console.WriteLine("Faculty name: " + setFname());
            Console.WriteLine("Faculty ID: " + setFid());
            Console.WriteLine("Faculty's Section time: " + setFstime());
            for (int i = 0; i < FacultyTotalSection; i++)
            {

                Console.WriteLine("Course Name: ");
            }
        }
        public void ShowSinfo()
        {
            for(int i=0;i<countS;i++)
                if(facultySection[i]!=null)
                {
                    ShowSectionInfo();
                }
                else { break; }
        }

    }
}
