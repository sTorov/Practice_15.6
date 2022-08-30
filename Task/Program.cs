using System.Text;

namespace Task
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            var classes = new[]
            {
               new Classroom { Students = {"Evgeniy", "Sergey", "Andrew"}, },
               new Classroom { Students = {"Anna", "Viktor", "Vladimir"}, },
               new Classroom { Students = {"Bulat", "Alex", "Galina"}, }
           };
            
            var allStudents1 = GetAllStudentsSQLSyntax(classes);
            Console.WriteLine(string.Join(" ", allStudents1));

            //или

            var allStudents2 = GetAllStudentsMethodExtension(classes);
            Console.WriteLine(string.Join(" ", allStudents2));
        }

        /// <summary>
        /// Получение списка всех студентов, реализованного при помощи SQL-подобного синтаксиса
        /// </summary>
        /// <param name="classes"></param>
        /// <returns></returns>
        static string[] GetAllStudentsSQLSyntax(Classroom[] classes)
        {
            var allStidents = from classroom in classes
                              from student in classroom.Students
                              select student;

            return allStidents.ToArray();
        }

        /// <summary>
        /// Получение списка всех студентов, реализованного при помощи методов-расширения
        /// </summary>
        /// <param name="classes"></param>
        /// <returns></returns>
        static string[] GetAllStudentsMethodExtension(Classroom[] classes)
        {
            return classes.SelectMany(room => room.Students).ToArray();
        }
    }
}