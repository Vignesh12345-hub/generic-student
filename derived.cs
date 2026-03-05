using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exception_stu
{
    class Student : person
    {
        public string RollNo;
        public string Department;
        public int CurrentSemester;

        public Student(int id, string name, DateTime dob, string email, string roll, string dept, int sem)
            : base(id, name, dob, email)
        {
            RollNo = roll;
            Department = dept;
            CurrentSemester = sem;
        }
    }

    class Teacher : person
    {
        public string EmpId;
        public string Subject;
        public int YearsExperience;

        public Teacher(int id, string name, DateTime dob, string email, string emp, string subject, int exp)
            : base(id, name, dob, email)
        {
            EmpId = emp;
            Subject = subject;
            YearsExperience = exp;
        }
    }
}
     
