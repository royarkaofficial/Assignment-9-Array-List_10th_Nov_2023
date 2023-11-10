using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_List_task_5
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

            // Task 3: Grade Addition

            // 3.1 Add a new grade of 90 to the end of 'studentGrades'.
            studentGrades.Add(90);

            // 3.2 Display the updated contents of 'studentGrades'.
            Console.WriteLine("\nStudent Grades after Addition:");
            DisplayArrayList(studentGrades);

            // Task 4: Grade Removal

            // 4.1 Remove the grade of 78 from 'studentGrades'.
            studentGrades.Remove(78);

            // 4.2 Display the contents of studentGrades after the removal.
            Console.WriteLine("\nStudent Grades after Removal:");
            DisplayArrayList(studentGrades);

            // Task 5: Search and Update

            // 5.1 Search for the index of the grade 95 in 'studentGrades'.
            int indexOf95 = studentGrades.IndexOf(95);

            // 5.2 Update the grade at the found index to 96.
            if (indexOf95 != -1)
            {
                studentGrades[indexOf95] = 96;
                Console.WriteLine($"\nGrade at index {indexOf95} updated to 96.");
            }
            else
            {
                Console.WriteLine("\nGrade 95 not found in 'studentGrades'.");
            }

            // Display the final contents of 'studentGrades'.
            Console.WriteLine("\nFinal Student Grades:");
            DisplayArrayList(studentGrades);
        }
        // Helper method to display the contents of an ArrayList
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
