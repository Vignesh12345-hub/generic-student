// See https://aka.ms/new-console-template for more information
using exception_stu;
using System;

class Program
{
    static Repository<int, person> repo = new Repository<int, person>();

     public static void Main()
    {
        int choice;

        do
        {
            Console.WriteLine("\n1 Add Student");
            Console.WriteLine("2 Add Teacher");
            Console.WriteLine("3 Search by Name");
            Console.WriteLine("4 Filter Students");
            Console.WriteLine("5 Filter Teachers");
            Console.WriteLine("6 Exit");

            Console.Write("Enter Choice: ");
            choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    AddStudent();
                    break;

                case 2:
                    AddTeacher();
                    break;

                case 3:
                    SearchByName();
                    break;

                case 4:
                    FilterStudents();
                    break;

                case 5:
                    FilterTeachers();
                    break;
            }

        } while (choice != 6);
    }

     public static void AddStudent()
    {
        try
        {
            Console.Write("Id: ");
            int id = int.Parse(Console.ReadLine());

            Console.Write("Name: ");
            string name = Console.ReadLine();

            Console.Write("DOB: ");
            DateTime dob = DateTime.Parse(Console.ReadLine());

            Console.Write("Email: ");
            string email = Console.ReadLine();

            Console.Write("RollNo: ");
            string roll = Console.ReadLine();

            Console.Write("Department: ");
            string dept = Console.ReadLine();

            Console.Write("Semester: ");
            int sem = int.Parse(Console.ReadLine());

            Student s = new Student(id, name, dob, email, roll, dept, sem);

            repo.Add(id, s);

            Console.WriteLine("Student Added Successfully");
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }

    public static void AddTeacher()
    {
        try
        {
            Console.Write("Id: ");
            int id = int.Parse(Console.ReadLine());

            Console.Write("Name: ");
            string name = Console.ReadLine();

            Console.Write("DOB: ");
            DateTime dob = DateTime.Parse(Console.ReadLine());

            Console.Write("Email: ");
            string email = Console.ReadLine();

            Console.Write("EmpId: ");
            string emp = Console.ReadLine();

            Console.Write("Subject: ");
            string subject = Console.ReadLine();

            Console.Write("Experience: ");
            int exp = int.Parse(Console.ReadLine());

            Teacher t = new Teacher(id, name, dob, email, emp, subject, exp);

            repo.Add(id, t);

            Console.WriteLine("Teacher Added Successfully");
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }

    public static void SearchByName()
    {
        Console.Write("Enter Name: ");
        string name = Console.ReadLine();

        foreach (person p in repo.GetAll())
        {
            if (p.name.Contains(name))
            {
                Console.WriteLine(p.name);
            }
        }
    }

   public static void FilterStudents()
    {
        Console.Write("Department: ");
        string dept = Console.ReadLine();

        Console.Write("Semester: ");
        int sem = int.Parse(Console.ReadLine());

        foreach (person p in repo.GetAll())
        {
            if (p is Student)
            {
                Student s = (Student)p;

                if (s.Department == dept && s.CurrentSemester == sem)
                {
                    Console.WriteLine(s.name + " " + s.Department);
                }
            }
        }
    }

   public  static void FilterTeachers()
    {
        Console.Write("Subject: ");
        string subject = Console.ReadLine();

        Console.Write("Minimum Experience: ");
        int exp = int.Parse(Console.ReadLine());

        foreach (person p in repo.GetAll())
        {
            if (p is Teacher)
            {
                Teacher t = (Teacher)p;

                if (t.Subject == subject && t.YearsExperience >= exp)
                {
                    Console.WriteLine(t.name + " " + t.Subject);
                }
            }
        }
    }
}
