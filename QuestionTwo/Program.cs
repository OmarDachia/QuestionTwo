using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuestionTwo
{
    class Program
    {
        static void Main(string[] args)
        {
            //#2 This is a program that get two numbers from the user and perform some Mathematical operations that is Addition, Subtraction, Division, and Multiplication

            Console.WriteLine("WAP to input 2 no’s from the user & do their addition, subtraction, multiplication & division.");
            Console.WriteLine("==============================================================================================");
            Console.WriteLine("User Input the two numbers:->");
            Console.WriteLine("+++++++++++++++++++++++++++++");

            //Declare two Variable to store the two numbers. i will be calling them first_number and second_number. 
            //Optional:-> if you want you can declare four more variable to store the operation metioned in the question i.e Addition, multiplication, subtraction, and division

            double first_number=0, second_number=0, addition=0, subtraction=0, multiplaction=0, division = 0;
            
            //Get the two number form our console 
            first_number = Convert.ToDouble(Console.ReadLine());
            second_number= Convert.ToDouble(Console.ReadLine());


            //Result:->
            Console.WriteLine("Result:->");
            Console.WriteLine("+++++++++");

            //Heer are the operation
            addition = first_number + second_number;
            subtraction = first_number - second_number;
            multiplaction = first_number * second_number;
            division = first_number / second_number;

            Console.WriteLine(string.Format("First Number: {0} \n Second Number: {1} \n Addition: {2} \n Subtraction: {3} \n Multiplication: {4} Division: {5}", first_number, second_number, addition, subtraction, multiplaction, division));
            Console.ReadKey();


        }
    }
}
