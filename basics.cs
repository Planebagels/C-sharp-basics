using System;
using System.Collections.Generic;
using System.Xml;
using System.Threading;
using System.Threading.Tasks;
using System.Text;



namespace ConsoleApp_c_sharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "My console app";

            // to make comments use // and write your comment.
            //for a multi line comment use /* and end it off with */

            /* this 
             * is 
             * a 
             * multi
             * line
             * comment
             */

            

            //hello world
            Console.WriteLine("Hello World!");


            //varibles
            int num = 123;
            float num2 = 123.456f;// if you don't put the f there the compiler will think it is a double
            double num3 = 908888.23470237047;// they are like floats but with more precision
            char a = 'a';
            string b = "this is a string of charachters";
            bool raining = true; 
            enum AnimalState {dead, notdead, other }// Visual studio will shit itself when you are worikng with enums
            // how to use enums

            static AnimalState animalState;
            
            
            
            myFunction();
            //this won't work because it is a non-static function in a static function
            //when I added the 'static' to the function (see below) it works
            SecondFunc(50);//the SecondFunc() method takes in a parameter

            //you can also store this as a variable
            bool myBool = SecondFunc(69420);

            //if... else conditions

            if (raining)
            {
                Console.WriteLine("It is raining");
            }
            else
            {
                Console.WriteLine("It is not raining");
            }

            //if statements

            // this huge block of code I wrote isn't optimal, and isn't the best coding practice, this is only for demonstration purposes.

            if (num < 1)
            {
                Console.WriteLine("the number is less than 1");
            }
            // if the number is less than one than print a statement
            
            if (num3 < 100)
            {
                Console.WriteLine("the third number is greater than one hundred");
            }
            // if num3 is greater than 100 then print out a statement

            if (num3 <= 100)
            {
                Console.WriteLine("the third number is less than or equal to 100");
            }
            // if the num3 var is less than or equal to 100 than print a statement

            if (num3 >= 100)
            {
                Console.WriteLine("The third number is greater than or equal to 100");
            }
            // if the num3 var is greater than or equal to 100 print out a statement

            if (num3 == 1)
            {
                Console.WriteLine("the third number is equal to one");
            }
            // if the num3 var is equal to one than print out a statement

            if (num3 != 1)
            {
                Console.WriteLine("the third number is not equal to one");
            }
            // if the num3 var is not equal to one print out a statement

            if (num3 > 123 && num3 == 809809808098)
            {
                Console.WriteLine("the thrid number is greater than 123, and is equal to 809809808098");
            }
            // if the num3 var is greater than 123 and is equal to 809809808098 then print out a statement

            if (num3 == 7 || num3 == 6)
            {
                Console.WriteLine("the third nu,ber equals 6 or 7");
            }
            // if the num3 var is 7 or 6 print out a statement


            // another way to do conditional statements is by using a switch case
            switch (num3)
            {
                default:
                    break;
                case 1:
                    break;
                case 5:
                    break;

            }
            // a 'break' is used here to tell the compiler that it is the end of the case, leaving it out will give you an error
            // there is also a defualt case if the num3 var doesn't match any other case

            //collections and arrays
            int[] numArray = new int[5];
            //creates an array that takes in ints
            //make sure to init them or else they are null

            //you can also init arryas like this
            int[] secondNumArray = new int[] { 1, 2, 3, 4 };

            //However if you need something with a dynamic size you can use lists

            List<int> myList = new List<int>(69);
            //by defualt this will be null so we have to creat the object

            //you can also init lists a different way
            List<int> mySecondList = new List<int>() { 1, 2, 3, 4, 5, 6 };

            //But you may be asking "what is the difference between a list and an array?"
            //A list can contract and expand
            //but an array is fixed, so it cannot change

            //adding and removing valuse from a list
            myList.Add(5);
            myList.Remove(1);

            // Loops


            //How would I sort through collections though?
            //you'd do this with a foreach loop


            foreach (int wasd in myList)
            {
                Console.WriteLine(wasd);
            }

            //a for loop also works fine
            var numInMyList = myList.Count;
            
            
            for (int i = 0; i < numInMyList; i++)
            {
                Console.WriteLine(i + " " + myList[i]);
            }
            //the var I is equal to 0, and as long as it is less than the number in myList.count, iterate I, and print it out

            double num4 = 123.456;
            while (num4 < 2)
            {
                num4++;
            }
            // if a condition is met iterate the num4 var

            //there is also another loop called the 'do, while' loop
            do
            {
                num4++;
            } while (num4 < 5);
            // iterate the num4 var as long as num4 is less than 5



            Console.WriteLine("press any key to close this window");
            Console.ReadKey();//waits for a key to be pressed then closes window
        
        }
    
    //functions
    
    static void myFunction()
        {
            Console.WriteLine("this function ran succesfully");
        }
    
    // write the return type before function name, if yoiu want to retuyrn nothing use 'void'
    
    static bool SecondFunc(int num)
        {

            Console.WriteLine("this function ran succesfully");
            return 1 < 100;
        }
    
    
    
    
    
    
    }
}
