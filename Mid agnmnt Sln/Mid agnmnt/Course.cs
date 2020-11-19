using System;

namespace Mid_agnmnt
{
    class Course : Faculty
    {
        private String Cname;
        private int Csnum;
        Section[] sectionName = new Section[50];
        private int countS = 0;

        public Course()
        { } 
        public Course(String cn,int csnum)
        {
            getCname(cn);
            getCsnum(csnum);
        }
        public void getCname(String n)
        {
            Cname = n;
        }
        public String setCname()
        {
            return Cname;
        }
        public void getCsnum(int n)
        {
            Csnum = n;
        }
        public int setCsnum()
        {
            return Csnum;
        }
        public void ShowCInfo()
        {
            Console.WriteLine("Course name: " + Cname);
            Console.WriteLine("Number of Section: " + Csnum);
        }
        public void AddCSection(Section sectionName)

        {

            this.sectionName[countS++] = sectionName;
        }
        public void ShowSectionTeacher()
        {
            for (int i = 0; i < 10; i++)
            {
                if (sectionName[i] != null)
                {
                    sectionName[i].ShowSectionInfo();
                }
                else { break; }
            }
        }

    }
}
