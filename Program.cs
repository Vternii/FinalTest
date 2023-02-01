using System;

namespace FinalTest{

    class Program{
        static string[] ArrayFill()
        {
            string[] result = new string[1];
            int count = 0;
            while(true)
            {
                System.Console.WriteLine("Введите что-нибудь или Q что-бы окончить ввод");
                string arg = Console.ReadLine();
                if (arg == "q"){break;}
                
                else
                {
                    string[] resultLoc = new string[count + 1];
                    for (int i = 0; i < result.Length; i++)
                    {
                        resultLoc[i] = result[i];
                    }
                    resultLoc[count] = arg;

                    result = resultLoc;
                }
                count++;
            }
            return result;
        }
        static string[] filter(string[] array,in int border)
        {
            int count = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i].Length <= border)
                {
                    count++;
                }
            }
            string[] res = new string[count];
            for (int i = 0, c = 0; i < array.Length; i++)
            {
                if (array[i].Length <= border)
                {
                    res[c] = array[i];
                    c++;
                }
            }
            return res;
        }
        static void Main(string[] args)
        {
            string[] FinalResult = filter(ArrayFill(),3);
            System.Console.WriteLine($"[{string.Join(", ",FinalResult)}]");
        }
    }
}