using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string example = "Some words here";
            StringBuilder Para = new StringBuilder("Paragraphs are the building blocks of papers.");
            int pos = Para.ToString().IndexOf("papers.") + 5 + Environment.NewLine.Length;
            Para.Insert(pos, " Many students define paragraphs in terms of length: a paragraph is a group of at least five sentences, a paragraph is half a page long, etc.");
            pos = Para.ToString().IndexOf("etc.")+2+ Environment.NewLine.Length;
            Para.Insert(pos, " In reality, though, the unity and coherence of ideas among sentences is what constitutes a paragraph.");
            pos = Para.ToString().IndexOf("paragraph.") + 8 + Environment.NewLine.Length;
            Para.Insert(pos, " A paragraph is defined as “a group of sentences or a single sentence that forms a unit” (Lunsford and Connors 116).");
            Console.WriteLine("Hello " + "World " + "!");
            Console.WriteLine(Para);
            example = example.ToUpper();
            Console.WriteLine(example);
            Console.ReadLine();
        }
    }
}
