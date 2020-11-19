using System;

namespace Mid_agnmnt
{
    class Program
    {
        static void Main(string[] args)
        {
            Department D=new Department("Cse",4);
            Course C = new Course("c#",10);
            Course j = new Course("j", 5);
            Section S = new Section("A", 40, "3pm");
            Section e = new Section("b", 40, "1pm");
            Faculty F = new Faculty("Karim", "1111111", 11.5f);
            D.AddCourse(C);
            D.AddCourse(j);
            C.AddFacultySection(S);
            j.AddFacultySection(e);
            F.AddFacultySection(S);
            F.AddFacultySection(e);
            S.AddTeacher(F);
            e.AddTeacher(F);
            j.ShowSectionTeacher();
            F.ShowSectionInfo();
            Console.ReadLine();
        }
    }
}
