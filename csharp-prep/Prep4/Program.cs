using System;
using System.Collections.Generic;
class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>(); //format of a list.

        int userNumbers = -1; //will work for any number just needs a starting one.

        while (userNumbers != 0)
            {
                Console.Write("What numbers should we add to our list? (type 0 to end) ");
                userNumbers = int.Parse(Console.ReadLine());
                if (userNumbers != 0)
                {
                    numbers.Add(userNumbers);
                }
            }
            int sum = 0; //important to establish them early on in the future put at the top. 
            int count = numbers.Count();
            int max = numbers.Max();

            foreach (int number in numbers)
            {
                Console.WriteLine(number);
                sum += number;
                
            }
            Console.WriteLine("The sum is: " + sum);
            float average = (float) sum/count; //made it a float to create decimal answers. 
            Console.WriteLine($"The average is:{average} ");
            Console.WriteLine("The Largest Number: "+ max);


       // List<string> words = new List<string>();
        //words.Add("phone");
        //words.Add("keyboard");
       // words.Add("mouse");

        ///Console.WriteLine(words.Count);

        //foreach (string word in words)
       // {
            //Console.WriteLine(word);
       // }
    }
}