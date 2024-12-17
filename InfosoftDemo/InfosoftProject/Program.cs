using System;

namespace InfosoftDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Lessons lessons = new Lessons();
            

            //Lesson 1: Introduction to C#
            Console.WriteLine("Lesson 1: Introduction to C#");
            lessons.Helloworld_l1();
            
            Console.WriteLine();

            //Lesson 2: Data Variables and Data Types
            Console.WriteLine("Lesson 2: Data Variables and Data Types");
            lessons.VariablesandDatatype_l2();

            Console.WriteLine();

            //Lesson 3: Basic Input and Output
            Console.WriteLine("Lesson 3: Basic Input and Output");
            lessons.InputOutput_l3();

            Console.WriteLine();
            
            //Lesson 4: Operators and Expressions
            Console.WriteLine("Lesson 4: Operators and Expressions");
            lessons.OperatorsandExpressions_l4();

            Console.WriteLine();
            
            //Lesson 5: Conditional Statements
            Console.WriteLine("Lesson 5: Conditional Statements");
            lessons.ConditionalStatements_l5();

            Console.WriteLine();

            //Lesson 6: Switch Statements
            Console.WriteLine("Lesson 6: Switch Statements");
            lessons.SwitchStatements_l6();

            Console.WriteLine();

            //Lesson 7: Loops : While loop
            Console.WriteLine("Lesson 7: Loops : While loop");
            lessons.WhileLoop_l7();

            Console.WriteLine();

            //Lesson 7: Loops : For loop
            Console.WriteLine("Lesson 7: Loops : For loop");
            lessons.Forloop_l7();

            Console.WriteLine();

            //Lesson 8: Arrays
            Console.WriteLine("Lesson 8: Arrays");
            lessons.Array_l8();

            Console.WriteLine();

            //Lesson 9: Functions
            Console.WriteLine("Lesson 9: Functions");
            int result = lessons.Functions_l9(new int[]{5,6,4,3,2,6});
            Console.WriteLine("The sum is: "+ result);
        }
    }
}
