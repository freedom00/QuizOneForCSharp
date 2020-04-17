using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace QuizOne
{
    internal class Program
    {
        private static List<Employee> employeesList = new List<Employee>();

        private delegate void EmployeeDelegate();

        private static void PrintTupleByFormat(Tuple<string, int, string> tuple) => WriteLine("Name: {0}; Age: {1}; Address: {2}", tuple.Item1, tuple.Item2, tuple.Item3);

        private static void PrintTupleByInterpolation(Tuple<string, int, string> tuple) => WriteLine("Name: {0}; Age: {1}; Address: {2}", tuple.Item1, tuple.Item2, tuple.Item3);

        private static void FindLowestSalary()
        {
            Employee result = employeesList[0];
            for (int i = 1; i < employeesList.Count; i++)
            {
                if (result.Salary > employeesList[i].Salary)
                {
                    result = employeesList[i];
                }
            }
            WriteLine($"The lowest salary employee is: {result}");
        }

        private static void FindHighestSalary()
        {
            Employee result = employeesList[0];
            for (int i = 1; i < employeesList.Count; i++)
            {
                if (result.Salary < employeesList[i].Salary)
                {
                    result = employeesList[i];
                }
            }
            WriteLine($"The highest salary employee is: {result}");
        }

        private static bool IsVowel(char c) => "aeiou".Contains(char.ToLower(c));

        private static void HasVowel(String s)
        {
            Predicate<char> predicate = IsVowel;
            foreach (var item in Array.FindAll(s.ToCharArray(), predicate))
            {
                Write($"{item} ");
            }
            WriteLine();
        }

        private static void Main(string[] args)
        {
            //#1
            //b

            //#2
            for (int i = 0; i < 5; i++)
            {
                employeesList.Add(new Employee(i, $"name{i}", 1000 + i));
            }
            foreach (var item in employeesList)
            {
                WriteLine(item.Name);
            }
            EmployeeDelegate employeeDelegate = FindLowestSalary;
            employeeDelegate += FindHighestSalary;
            employeeDelegate();

            //#3
            Tuple<string, int, string> personTuple = Tuple.Create("Zhaosheng", 30, "Montreal");
            PrintTupleByInterpolation(personTuple);
            PrintTupleByFormat(personTuple);

            //#4
            Dictionary<int, string> employeesDictionary = new Dictionary<int, string>();
            for (int i = 0; i < employeesList.Count; i++)
            {
                employeesDictionary.Add(employeesList[i].Id, $"Office Address{i}");
            }
            foreach (var item in employeesDictionary)
            {
                WriteLine(item);
            }

            //#5
            new MyConstraintGenericClass<Employee>();
            //new MyConstraintGenericClass<int>();

            //#6
            int number = 5;
            WriteLine($"The number {number} is dividable by 3: {number.IsDividableByThree()}");

            //#7
            HasVowel("asdfe");

            //#8
            Student student = new Student() { Name = "Zhaosheng", IsGraduated = false };
            student.StudentGraduated += RegisterStudentOperation.Graduated;
            student.IsGraduated = true;

            ReadKey();
        }
    }
}