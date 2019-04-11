using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C0725030_Assignment_4
{
    class Program
    {
        ArrayList Beowulf;

        static void Main(string[] args)
        {
            Program p = new Program();
            p.Beowulf = new ArrayList();
            p.Run();

        }

        public void Run()
        {
            this.ReadTextFiles();
        }

        public void ReadTextFiles()
        {            
            //Read file using StreamReader. Reads file line by line
            using (StreamReader file = new StreamReader("U:/Users/725030/Beowulf.txt"))
            {
                int words = 1;
                int counter = 0;
                string ln;

                while ((ln = file.ReadLine()) != null)
                {
                    Console.WriteLine(ln);
                    Beowulf.Add(ln);
                    counter++;
                }

                //while (counter <= ln.Length - 1)
                //{
                //    if (ln[counter] == ' ' || ln[counter] == '\n' || ln[counter] == '\t')
                //    {
                //        words++;
                //    }
                //    counter++;
                //}
                file.Close();
                Console.WriteLine($"File has {counter} lines.");
                Console.WriteLine("Number of words in the string: {0}", words);                
            }

        }


        public int FindNumberOfBlankSpaces(string line)
        {
            int countletters = 0;
            int countSpaces = 0;

            foreach (char c in line)
            {
                if (char.IsLetter(c))
                {
                    countletters++;
                }

                if (char.IsWhiteSpace(c))
                {
                    countSpaces++;
                }
            }
            return countSpaces;
        }
    }
}
