using System;

namespace ConsoleApp12
{
    internal class Program
    {
        static void Main(string[] args)
        {
          

            string word = "Salam123";
            Console.WriteLine(Check1(ref word));

            string sentence = "Salam,     dunya";
            Keep1Empty(ref sentence);
            Console.WriteLine(sentence);

            string words = "Salam qrup";

            
            //Console.WriteLine(FirstWord(ref words));

            Console.WriteLine(Check2Words(ref words));

            int[] numbers = { 1, 2, 3, 4, 5, 6 };
            int n = 7;
            AddNum(ref numbers, n);
            foreach (int i in numbers)
            {
                Console.WriteLine(i);
            }

        }

        static bool Check1(ref string word)
        {
            bool check = false;
            int countdigit = 0;
            int countupper = 0;
            int countlower = 0;
            for (int i = 0; i < word.Length; i++)
            {
                if (Char.IsDigit(word[i]))
                {

                    countdigit++;

                }
                else if (Char.IsUpper(word[i]))
                {
                    countupper++;
                }
                else if (Char.IsLower(word[i]))
                {
                    countlower++;
                }

            }
            if (countdigit != 0 && countupper != 0 && countlower != 0)
            {
                check = true;
            }


            return check;
        }

        static void Keep1Empty(ref string sentence)
        {
            
            string newsentence = "";
            for (int i = 0; i < sentence.Length; i++)
            {
                if (sentence[i] != ' ')
                {
                    newsentence+=sentence[i];
                }
               
            }
            var make =newsentence.Split(",");
            sentence = String.Join(", " , make);

        }

        // Verilmiş string deyerinin icərisindəki ilk sözü tapıq qaytaran metod

        static string FirstWord (ref string words)
        {
            string firsword = "";
            string[] wordsarr = words.Split(' ');
            firsword = wordsarr[0];
           

            return firsword;
        }

        // Verilmiş string dəyərin içərisində 2 söz olmasını və hər bir sözün böyük hərflə başlamasını yoxlayan metod

        static bool Check2Words(ref string words)
        {
            bool check = false;
            string [] wordsarr = words.Split(' ');

            for (int i = 0; i < wordsarr.Length; i++)
            {
                if (wordsarr.Length == 2 && Char.IsUpper(wordsarr[i][0]))
                {
                    check=true;
                }
                else
                {
                    check = false;
                }
            }
            return check;
        }

        //Parameter olaraq integer array variable-ı (reference) və bir integer value qəbul edən və həmin integer value-nu integer array-ə yəni
        //element kimi əlavə edən metod.

        static void AddNum (ref int[] numbers, int n)
        {
            Array.Resize(ref numbers, numbers.Length + 1);
            numbers[numbers.Length - 1] = n;
        }




    }
}
