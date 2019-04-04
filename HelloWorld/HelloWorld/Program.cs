using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class Program
    {
        //int someNumber;

        static void Main(string[] args)
        {
            //int number1 = 0;
            //char holdsALetter = 'a';
            //double amount;
            //amount = 2.5;

            //int number = 5;
            //int sum;
            //sum = number + 5;

            //bool test = true;

            //ask user a question
            //Console.WriteLine("What is your favourite number?");
            //int number;
            //number = Convert.ToInt32(Console.ReadLine());

            //variables
            /*string userFirstName;
            string age;
            //ask user a question
            Console.WriteLine("What is your first name?");
            userFirstName = Console.ReadLine();
            Console.WriteLine("What old are you?");
            age = Console.ReadLine();
            //string response = "Your name is: " + userFirstName + " and you are: " + age + " years old.";
            string response = $"Your name is: {userFirstName} and you are {age} years old";
            Console.WriteLine(response);*/

            /*string itemName = "Widget";
            double pricePerOunce = 17.36;
            string outputString;
            //outputString = String.Format("The current price is {0:C}", pricePerOunce);
            outputString = String.Format("{0,10} {1, 10}", itemName, pricePerOunce);
            Console.WriteLine(String.Format("{0,10} {1, 10}", "Item Name", "Price"));
            Console.WriteLine(outputString);*/

            string file = "C:\\my docs\\homedir\\files"; //use@"C//
            Console.WriteLine(file);
        }
    }
}
