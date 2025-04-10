namespace FundamentalClassExercises
{
    internal class Program
    {
       

    /*    static void Main(string[] args)
        {
            DemoClass.DisplayHelloWorld();
            
            DemoClass demo = new DemoClass();
            
            Task.Delay(10000).Wait();

            DemoClass anotherDemo = new DemoClass();
            //demo.

            Console.WriteLine("Demo");
            demo.DisplayDate();

            Console.WriteLine("Another Demo");
            anotherDemo.DisplayDate();

            Console.WriteLine("Demo");
            demo.DisplayDate();
            
        }*/

        
        static void Main(string[] args)
        {

          // string myString = new String("Hello");

            ClassExercises myClassExercises = new ClassExercises();

            //  Capturing a string from the keyboard 

            Console.WriteLine("Please enter a sentence.");
            string forwardString = string.Empty;

            forwardString = Console.ReadLine();


            // This is to answer green squiggly line question in class. It's a nullable warning.  
            if (forwardString != null)
            {
                //Calling method StringReverse - Exercise 1

                string reversedString = myClassExercises.StringReverse(forwardString);
                Console.WriteLine($"This is the sentence string backwards: {reversedString}");


                //Calling method IsPalindrome - Exercise 2
                
                bool palindrome = myClassExercises.IsPalindrome(forwardString);
                Console.WriteLine($"{forwardString} -> {palindrome}");
            }
            else
                Console.WriteLine("Problem reading keyboard.");



            //Calling method ContainsOddNumber - Exercise 3

            int[] numbers = { 2, 3, 4, 9, 12 };
            bool hasOddNumbers = myClassExercises.ContainsOddNumber(numbers);

            if (hasOddNumbers)
                Console.WriteLine("The provided numbers array contains atleast 1 odd number");
            else
                Console.WriteLine("The provided numbers array does not contain any odd numbers.");


            Console.WriteLine("This is the sentence without Vowels");

            string sentenceWithoutVowels = myClassExercises.RemoveVowels(forwardString);
            Console.WriteLine(sentenceWithoutVowels);


        }


       
    }
}
