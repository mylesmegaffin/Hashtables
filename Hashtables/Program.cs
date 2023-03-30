using System;
using System.Collections;

namespace Hashtables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Hashtable hashtable = new Hashtable();

            Student[] students = new Student[5];
            students[0] = new Student(1, "Myles", 99);
            students[1] = new Student(1, "Mark", 77);
            students[2] = new Student(6, "Todd", 56);
            students[3] = new Student(1, "John", 87);
            students[4] = new Student(3, "Mike", 93);

            foreach(Student student in students)
            {
                bool added = false;
                do
                {
                    // if a student doesnt have an id as a student in the hashtable add them, if they do display a error
                    if (!hashtable.ContainsKey(student.Id))
                    {
                        hashtable.Add(student.Id, student);
                        Console.WriteLine("Student with ID:{0} was added!", student.Id);
                        added = true;
                    }
                    else
                    {
                        Console.WriteLine("Sorry, A student: {1}, has the same ID as an already existing ID: {0}", student.Id, student.Name);
                        student.Id++;
                    }

                } while (!added);
            }

            foreach (Student value in hashtable.Values)
            {
                Console.WriteLine("Student ID: {0}, Name: {1}, GPA: {2}", value.Id, value.Name, value.GPA);
            }
            Console.Read();
        }

        public static void Lesson()
        {
            // Creating Hash Table
            Hashtable studentsTable = new Hashtable();


            Student stud1 = new Student(1, "Myles", 99);
            Student stud2 = new Student(2, "Mark", 77);
            Student stud3 = new Student(3, "Todd", 56);
            Student stud4 = new Student(4, "John", 87);

            // Storing Data in a Hash Table
            studentsTable.Add(stud1.Id, stud1);
            studentsTable.Add(stud2.Id, stud2);
            studentsTable.Add(stud3.Id, stud3);
            studentsTable.Add(stud4.Id, stud4);

            // Retrieve data from a HashTable
            // Retrieve individual item with a known ID
            Student storedStudent1 = (Student)studentsTable[stud1.Id];

            Console.WriteLine("Student ID: {0}, Name: {1}, GPA: {2}", storedStudent1.Id, storedStudent1.Name, storedStudent1.GPA);
            Console.Read();

            // Retrieve all values from a Hash table
            foreach (DictionaryEntry entry in studentsTable)
            {
                Student temp = (Student)entry.Value;

                Console.WriteLine("Student ID: {0}, Name: {1}, GPA: {2}", temp.Id, temp.Name, temp.GPA);
            }

            // These two are the same but your not casting it to a student object
            foreach (Student value in studentsTable.Values)
            {
                Console.WriteLine("Student ID: {0}, Name: {1}, GPA: {2}", value.Id, value.Name, value.GPA);
            }
            Console.Read();
        }
    }

    class Student
    {
        // Properties
        public int Id { get; set; }
        public string Name { get; set; }
        public float GPA { get; set; }

        // Constructor
        public Student(int id, string name, float GPA)
        {
            this.Id = id;
            this.Name = name;
            this.GPA = GPA;
        }
    }
}
