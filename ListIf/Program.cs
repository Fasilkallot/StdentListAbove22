using System;
using System.Collections.Generic;
class basicProgram
{
    static void Main(string[] ag)
    {

        List<student> studentlist = new List<student>();

        studentlist.Add(new student
        {
            name = "fasil",
            age = 23,
            department = "CSE"
        });
        studentlist.Add(new student
        {
            name = "Ramees",
            age = 23,
            department = "CSE"
        });
        studentlist.Add(new student
        {
            name = "Subin",
            age = 22,
            department = "CSE"
        });
        studentlist.Add(new student
        {
            name = "Ridwan",
            age = 24,
            department = "MECH"
        });

        studentlist.Insert(2, new student
        {
            name = "Faraz",
            age = 22,
            department = "MECH"
        });
        foreach (student student in studentlist)
        {
            if (student.age > 22)
            {
                Console.WriteLine("Name: " + student.name);
                Console.WriteLine("Age: " + student.age);
                Console.WriteLine("Department: " + student.department);
                Console.WriteLine();
            }

        }
    }


}
class student
{
    public string name { get; set; }
    public int age { get; set; }
    public string department { get; set; }
}






