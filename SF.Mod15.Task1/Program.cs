using System;
using System.Collections.Generic;
using System.Linq;

namespace SF.Mod15.Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            var classes = new[]
            {
                new Classroom {Students = {"Evgeniy", "Sergey", "Andrew"},},
                new Classroom {Students = {"Anna", "Viktor", "Vladimir"},},
                new Classroom {Students = {"Bulat", "Alex", "Galina"},}
            };
            var allStudents = GetAllStudents(classes);

            Console.WriteLine(string.Join(" ", allStudents));
        }

        /// <summary>
        /// Собираем всех студентов в одну коллекцию
        /// </summary>
        /// <param name="classes">The classes.</param>
        /// <returns>An array of string.</returns>
        public static string[] GetAllStudents(Classroom[] classes)
        {
            var allStud =
                from classroom in classes
                from stud in classroom.Students
                select stud;

            return allStud.ToArray();
        }
    }
}
