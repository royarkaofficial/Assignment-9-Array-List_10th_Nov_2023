using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_List_task_2
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

            // Task 2: Display and Sum

            // 2.1 Display the contents of studentGrades using a loop. Print each grade on a new line.
            Console.WriteLine("Student Grades:");
            DisplayArrayList(studentGrades);

            // 2.2 Calculate and display the sum of all the grades in 'studentGrades'.
            int sum = CalculateSum(studentGrades);
            Console.WriteLine($"Sum of Grades: {sum}");
        }
        static void DisplayArrayList(ArrayList arrayList)
        {
            foreach (var grade in arrayList)
            {
                Console.WriteLine(grade);
            }
        }

        // Helper method to calculate the sum of grades in an ArrayList
        static int CalculateSum(ArrayList arrayList)
        {
            int sum = 0;
            foreach (var grade in arrayList)
            {
                sum += (int)grade; // Assuming grades are integers
            }
            return sum;
        }
    }
}
