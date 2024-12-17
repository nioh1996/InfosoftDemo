using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfosoftDemo

{
    class Lessons
    {

        //Lesson 1: Introduction to C#
public void Helloworld_l1()
{
    Console.WriteLine("Hello World!");
}

//Lesson 2: Data Variables and Data Types
public void VariablesandDatatype_l2()
{
    String fname, lname, gender, hobby;
    int age;
    float gpa;

    fname = "Migs";
    lname = "Jimenez";
    gender = "Male";
    hobby = "study programming languages";
    age = 21;
    gpa = 4.0f;

    Console.WriteLine("Name : " + (fname + lname));
    Console.WriteLine("Gender : " + gender);
    Console.WriteLine("Age : " + age);
    Console.WriteLine("Gpa : " + gpa);
    Console.WriteLine("My hobby is to " + hobby);
}

//Lesson 3: Basic Input and Output
public void InputOutput_l3()
{

    Console.WriteLine("Enter your name: ");
    string Name = Console.ReadLine();
    Console.WriteLine("Enter your Address: ");
    string Address = Console.ReadLine();
    Console.WriteLine("Enter your Company: ");
    string Company = Console.ReadLine();

    Console.WriteLine();

    Console.WriteLine("Hi My Name is " + Name);
    Console.WriteLine("I am from " + Address);
    Console.WriteLine("I am currently working at " + Company);

}

//Lesson 4: Operators and Expressions
public void OperatorsandExpressions_l4()
{
    float average, grade1, grade2, grade3, grade4;

    Console.WriteLine("Enter your Proficiency in C#: ");
    grade1 = Convert.ToSingle(Console.ReadLine());

    Console.WriteLine("Enter your Proficiency in Python: ");
    grade2 = Convert.ToSingle(Console.ReadLine());

    Console.WriteLine("Enter your Proficiency in Java: ");
    grade3 = Convert.ToSingle(Console.ReadLine());

    Console.WriteLine("Enter your Proficiency in C++: ");
    grade4 = Convert.ToSingle(Console.ReadLine());

    average = (grade1 + grade2 + grade3 + grade4) / 4;
    Console.WriteLine("Your Average is : " + average);
}

//Lesson 5: Conditional Statements
public void ConditionalStatements_l5()
{
    float average, grade1, grade2, grade3, grade4;

    Console.WriteLine("Enter your Proficiency in C#: ");
    grade1 = Convert.ToSingle(Console.ReadLine());

    Console.WriteLine("Enter your Proficiency in Python: ");
    grade2 = Convert.ToSingle(Console.ReadLine());

    Console.WriteLine("Enter your Proficiency in Java: ");
    grade3 = Convert.ToSingle(Console.ReadLine());

    Console.WriteLine("Enter your Proficiency in C++: ");
    grade4 = Convert.ToSingle(Console.ReadLine());

    average = (grade1 + grade2 + grade3 + grade4) / 4;
    Console.WriteLine("Your Average is : " + average);

    Console.WriteLine();

    if (average > 100)
    {
        Console.WriteLine("Invalid Grade");
    }
    else if (average >= 98)
    {
        Console.WriteLine("Master Coder");
    }
    else if (average >= 95)
    {
        Console.WriteLine("Master Coder");
    }
    else if (average >= 90)
    {
        Console.WriteLine("Master Coder");
    }
    else if (average >= 75)
    {
        Console.WriteLine("Beginner");
    }
    else
    {
        Console.WriteLine("Failed");
    }
}

        //Lesson 6: Switch Statements
        public void SwitchStatements_l6()
        {
            int month, date, year;
            String monthword;

            Console.WriteLine("Enter your birthmonth (number): ");
            month = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter your birthdate (number): ");
            date = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter your birthyear: ");
            year = Convert.ToInt32(Console.ReadLine());

            switch (month)
            {

                case 1:
                    monthword = "January";
                    break;
                case 2:
                    monthword = "February";
                    break;
                case 3:
                    monthword = "March";
                    break;
                case 4:
                    monthword = "April";
                    break;
                case 5:
                    monthword = "May";
                    break;
                case 6:
                    monthword = "June";
                    break;
                case 7:
                    monthword = "July";
                    break;
                case 8:
                    monthword = "August";
                    break;
                case 9:
                    monthword = "September";
                    break;
                case 10:
                    monthword = "October";
                    break;
                case 11:
                    monthword = "November";
                    break;
                case 12:
                    monthword = "December";
                    break;
                default:
                    monthword = "Invalid Month";
                    break;
            }

            if (month <= 12 && date <= 31)
            {
                Console.WriteLine(monthword + " " + date + ", " + year);
            }
            else
            {
                Console.WriteLine("Invalid Input");
            }
        }

        //Lesson 7: Loops : While loop
        public void WhileLoop_l7()
        {
            int health = 5;
            string CorrectAnswer = "Infosoft";
            string answer;

            while (health > 0)
            {
                Console.WriteLine("What company am I working with right now? : ");
                answer = Console.ReadLine();
                if (answer == CorrectAnswer)
                {
                    Console.WriteLine("Your answer is Correct!");
                    break;
                }
                else
                {
                    Console.WriteLine("Your answer is Wrong! you have " + (health - 1) + " Chances!.");
                    health--;
                }

                if (health == 0)
                {
                    Console.WriteLine("You Lost!");
                }
            }

        }

        //Lesson 7: Loops : For loop (username same as password)
        public void Forloop_l7()
        {
            String username, password;
            bool isFound = false;

            string[] uName = {
                "KurtDavid",
                "KarlPaclar",
                "MigsJimenez"
            };
            string[] pWord = {
                "KurtDavid",
                "KarlPaclar",
                "MigsJimenez"
            };

            Console.WriteLine("Enter Username: ");
            username = Console.ReadLine();
            Console.WriteLine("Enter Password: ");
            password = Console.ReadLine();


            for (int i = 0; i < uName.Length; i++)
            {
                if (uName[i].Equals(username) && pWord[i].Equals(password))
                {
                    Console.WriteLine("Welcome " + username[i]);
                    isFound = true;
                    break;
                }
              
            }

            if (!isFound)
            {
                Console.WriteLine("Account Not Found!");
            }

        }

        //Lesson 8: Arrays
        public void Array_l8()
        {
            int input;
            string[] Email = {"kurtdade24@gmail.com",
                "migueljimenez@gmail.com",
                "karlpaclar@gmail.com"
            };
            string[] Username = {"Kurt",
                "Miguel",
                "Karl" 
            };
            string[] Password = {
                "kurt","miguel","karlpaclar"
            };

            Console.WriteLine("Enter Index: ");
            input = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Index: "+ input);
            Console.WriteLine("Email: " + Email[input]);
            Console.WriteLine("Username: " + Username[input]);
            Console.WriteLine("Password: " + Password[input]);
        }

        //Lesson 9: Functions

        public int Functions_l9(int[] numbers)
        {
            int sum = 0;
            for (int i = 0; i < numbers.Length; i++) {

                sum += numbers[i];  
            }

            return sum;

        }

    }
}
