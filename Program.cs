using System;
using System.Threading;
using System.IO;



namespace NitroGen
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Number of codes");
            string x = Console.ReadLine();
            int y = int.Parse(x);



            string path = "out.txt";
            using (FileStream fs = new FileStream(path, FileMode.OpenOrCreate))
            {
                using (TextWriter tw = new StreamWriter(fs))
                {

                    for (int b = 0; b < y; b++)
                    {


                        var chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz1234567890-_";
                        var stringChars = new char[11];
                        var random = new Random();

                        for (int i = 0; i < stringChars.Length; i++)
                        {
                            stringChars[i] = chars[random.Next(chars.Length)];
                        }
                        var finalString = new String(stringChars);
                        tw.WriteLine("htts://discord.gift/" + finalString);


                    }
                    tw.WriteLine("Made by DreadTadpole516");
                    tw.Close();

                }


            }
        }
    }
}
