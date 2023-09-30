using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student
{
    struct Student
    {
        public string FULL_NAME { get; set; }
        public string GroupNumber { get; set; }
        public int[] grade { get; set; }

        public double AVGgrade
        {
            get { return grade.Average(); }
        }
    }

    class StudentsInfo
    {
        static void Main(string[] args)
        {
            Student[] students = new Student[10];

            // Заполнение массива студентами
            students[0] = new Student { FULL_NAME = "Иванов И.И.", GroupNumber = "Группа 1", grade = new int[] { 5, 4, 5, 4, 5 } };
            students[1] = new Student { FULL_NAME = "Петров П.П.", GroupNumber = "Группа 1", grade = new int[] { 4, 4, 4, 4, 4 } };
            students[2] = new Student { FULL_NAME = "Сидоров С.С.", GroupNumber = "Группа 2", grade = new int[] { 5, 5, 5, 5, 5 } };
            students[3] = new Student { FULL_NAME = "Козлов К.К.", GroupNumber = "Группа 2", grade = new int[] { 3, 4, 3, 4, 3 } };
            students[4] = new Student { FULL_NAME = "Андреев А.А.", GroupNumber = "Группа 3", grade = new int[] { 5, 4, 5, 4, 5 } };
            students[5] = new Student { FULL_NAME = "Михайлов М.М.", GroupNumber = "Группа 3", grade = new int[] { 4, 5, 4, 5, 4 } };
            students[6] = new Student { FULL_NAME = "Николаев Н.Н.", GroupNumber = "Группа 4", grade = new int[] { 3, 3, 3, 3, 3 } };
            students[7] = new Student { FULL_NAME = "Григорьев Г.Г.", GroupNumber = "Группа 4", grade = new int[] { 4, 4, 4, 4, 4 } };
            students[8] = new Student { FULL_NAME = "Дмитриев Д.Д.", GroupNumber = "Группа 5", grade = new int[] { 5, 5, 5, 5, 5 } };
            students[9] = new Student { FULL_NAME = "Алексеев А.А.", GroupNumber = "Группа 5", grade = new int[] { 4, 4, 4, 4, 4 } };

            // Сортировка студентов по среднему баллу
            students = students.OrderBy(student => student.AVGgrade).ToArray();

            // Вывод фамилий и номеров групп студентов с оценками 4 или 5
            Console.WriteLine("Студенты с оценками 4 или 5:");
            foreach (var student in students)
            {
                if (student.grade.All(grade => grade >= 4))
                {
                    Console.WriteLine($"ФИО: {student.FULL_NAME}, Группа: {student.GroupNumber}");
                }
            }

            Console.ReadLine();
        }
    }
}
