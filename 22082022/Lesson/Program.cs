using System;

namespace Lesson
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str = "   Hello, World, salam, dunya";

            int charIndex = str.LastIndexOf('j');
            bool result = str.Contains("Hello");
            result = str.StartsWith("He");
            result = str.EndsWith("aa");

            str = str.Trim();
            string newStr = str.Substring(str.IndexOf(','));
            str = str.Replace("Hello", "Salam");
            str = str.ToLower();

            string sentence = ",,Hello, World, salam, dunya";
            var arr = sentence.Split(",");
            Console.WriteLine(arr.Length);


            string newSentence = String.Join("", arr);

            string username = "   ";

            Console.WriteLine(String.IsNullOrWhiteSpace(username));
            

            Console.WriteLine(newSentence);

            Char letter = 'a';

            Console.WriteLine(Char.IsWhiteSpace(letter));
            Console.WriteLine(Char.IsUpper(letter));
            Console.WriteLine(Char.IsLower(letter));
            Console.WriteLine(Char.IsDigit(letter));
            Console.WriteLine(Char.IsLetter(letter));
            Console.WriteLine(Char.IsLetterOrDigit(letter));

            letter = Char.ToUpper(letter);




            Console.WriteLine("============Words============");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
            Console.WriteLine("========================");


            int[] numbers = { 45, 10, -4, 56,-4,45,33,-4,34 };
            int[] newNumbers = new int[numbers.Length];


            numbers.CopyTo(newNumbers, 0);
            Array.Clear(newNumbers, 0, 2);
            Array.Sort(newNumbers);
            Array.Reverse(newNumbers);
            Array.Resize(ref newNumbers, 4);



            Console.WriteLine("============numbers==============");
            for (int i = 0; i < newNumbers.Length; i++)
            {
                Console.WriteLine(newNumbers[i]);
            }
            Console.WriteLine("==========================");


            //int index = Array.IndexOf(numbers, -4);
            int index = Array.LastIndexOf(numbers, -5);

            Console.WriteLine(index);



        }
    }
}
