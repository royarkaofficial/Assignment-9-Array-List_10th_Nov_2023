using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_List_task_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Task 1: ArrayList Initialization and Population

            // 1.1 Declare an 'ArrayList' named 'studentGrades'.
            ArrayList studentGrades;

            // 1.2 Initialize studentGrades with the following integer values: 85, 92, 78, 95, 88.
            studentGrades = new ArrayList() { 85, 92, 78, 95, 88 };

            // Display the contents of studentGrades for verification
            Console.WriteLine("Student Grades:");
            DisplayArrayList(studentGrades);
        }
        static void DisplayArrayList(ArrayList arrayList)
        {
            foreach (var grade in arrayList)
            {
                Console.Write($"{grade} ");
            }
            Console.WriteLine();
        }
    }
}
