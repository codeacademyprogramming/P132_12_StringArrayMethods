using System;
using System.Text;

namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Car car1 = new Car()
            {
                Brand = "BMW",
                Model = "X5",
                Millage = 5000,
                FuelCapacity = 50,
                CurrentFuel = 2
            } ;
            car1.AddFuel(5);
            Console.WriteLine(car1.CurrentFuel);

            string name = "    hello , Wo  r  ld!    ";

            DeleteSpace(ref name);
            Console.WriteLine(name);



            string sentence = "Salam,   millet,    necesiniz, ne var ne yox?";
            int count = FindWordsCount(sentence);
            Console.WriteLine(count);

            Console.WriteLine(HasDigit("sala1m"));

            name = "aBBas";
            Capitalize(ref name);
            Console.WriteLine(name);


            var wantedWord = FindFirstWord("   Hello fdfd fdf");
            Console.WriteLine(wantedWord);

        }

        static void DeleteSpace(ref string str)
        {
            //string newStr = "";
            StringBuilder stringBuilder = new StringBuilder();

            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] != ' ')
                    stringBuilder.Append(str[i]);
                    //newStr += str[i];
            }

            str = stringBuilder.ToString();
        }

        static int FindWordsCount(string str)
        {
            var arr = str.Split(' ');

            int count = 0;
            for (int i = 0;i < arr.Length; i++)
            {
                if (arr[i]!="")
                     count++;
            }
            return count;
        }

        static bool HasDigit(string str)
        {
            for (int i = 0; i < str.Length; i++)
            {
                if (Char.IsDigit(str[i])==true)
                    return true;
            }

            return false;
        }
        static void  Capitalize(ref string str)
        {
            str = str.ToLower();
            str = Char.ToUpper(str[0]) + str.Substring(1);
        }

        static string FindFirstWord(string str)
        {

            var word = str.TrimStart();

            int firstSpaceIndex = word.IndexOf(' ');

            if (firstSpaceIndex != -1)
                word = word.Substring(0, firstSpaceIndex);

            return word;
        }

    }
}
