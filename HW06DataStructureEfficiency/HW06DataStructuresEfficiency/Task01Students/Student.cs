namespace Task01Students
{
    using System;

    public class Student : IComparable<Student>
    {
        public Student(string firstName, string lastName)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
        }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public int CompareTo(Student other)
        {
            // in the dictionary the students will be sorted by Last Name
            return String.Compare(this.LastName, other.LastName, StringComparison.Ordinal);
        }
    }
}