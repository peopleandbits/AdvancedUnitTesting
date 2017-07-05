using System.Linq;

namespace AdvancedUnitTesting.Domain
{
    public class Student
    {
        public Student(int age, string name, School[] schoolHistory)
        {
            Age = age;
            Name = name;
            SchoolHistory = schoolHistory;
        }

        public int Age { get; set; }
        public string Name { get; set; }
        public School[] SchoolHistory { get; set; }

        public override string ToString()
        {
            return $"Age: {Age}\nName: {Name}\nEducation: {string.Join(", ", SchoolHistory.Select(c => c.Name))}";
        }

        public static Student Default()
        {
            return new Student(30, "Tommy",
                new[]
                {
                    new School("Freising Grundschule"),
                    new School("Freising Gymnasium"),
                    new School("Melbourne Hacker Academy"),
                    new School("Lissabon University for Star Wars Fans")
                });
        }
    }
}
