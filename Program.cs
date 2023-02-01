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
        static void Main(string[] args)
        {
            
        }
    }
}