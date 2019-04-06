using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C0732135_Assignment4
{

    class Program
    {
        ArrayList Beowulf;

        static void Main(string[] args)
        {
            Program p = new Program();
            p.Beowulf = new ArrayList();
            p.ReadTextFiles();
            p.ReadTextFile();
            p.Wordfind();
            p.Wf();
            p.Average();

            Console.ReadLine();
        }
        public void Run()
        {
            this.ReadTextFiles();
        }
        //SECTION A

        public void ReadTextFiles()
        {
            // Read file using StreamReader. Read file line by line
            using (StreamReader file = new StreamReader("assignment.txt"))
            {

                int counter = 0;
                string ln;
                

                while ((ln = file.ReadLine()) != null)
                {
                    Console.WriteLine(ln);
                    Beowulf.Add(ln);
                    counter++;
                }
                file.Close();
                counter = File.ReadLines("assignment.txt").Count();
                Console.WriteLine("The file has " + counter + " has lines in total");
            }
        }
        //SECTION B
        public void ReadTextFile()
        {

            var reader = new StreamReader("assignment.txt");
            string script = reader.ReadToEnd();

            var text = script.Trim();
            int Count = 0, index = 0;

            while (index < text.Length)
            {

                while (index < text.Length && !char.IsWhiteSpace(text[index]))
                    index++;

                Count++;

                while (index < text.Length && char.IsWhiteSpace(text[index]))
                    index++;
            }

            Console.WriteLine("Total Number of Words are " + Count);

        }
        //SECTION C
        public void Wordfind()

        {
            int a = 0;
            foreach (var c in File.ReadAllLines("assignment.txt"))
            {
                if (c.Contains("sea") && c.Contains("fare"))
                {
                    a++;
                }

            }
            Console.WriteLine("Total number of lines which contains word sea and Fare:" + a);
        }
        //SECTION D
        public void Wf()
        {
            int a = 0, b = 0, c = 0;

            foreach (var line in File.ReadAllLines("assignment.txt"))
            {
                if (line.Contains("fare"))
                {
                    a++;
                }

            }
            foreach (var line in File.ReadAllLines("assignment.txt"))
            {
                if (line.Contains("war") && line.Contains("fare"))
                {
                    b++;
                }

            }
            c = a - b;
            Console.WriteLine("Total lines that have fare but not the war are: " + c);
        }
        //SECTION E
        public void Average()
        {

            StreamReader reader = new StreamReader("assignment.txt");
            string read = reader.ReadToEnd();
            int number = 0;
            foreach (char letter in read)
            { number++; }
            Console.WriteLine("Total number of letters after every word:  " + number);

        }


        public int FindNumberOfBlankSpaces(string line)
        {
            https://stackoverflow.com/questions/17812566/count-words-and-spaces-in-string-c-sharp
            int countletters = 0;
            int countSpaces = 0;

            foreach (char c in line)
            {
                if (char.IsLetter(c)) { countletters++; }

                if (char.IsWhiteSpace(c)) { countletters++; }
            }
            return countSpaces;

        }

    }
}