using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace AcceserTextFiler
{
    public static class TextHelper
    {
        public static List<string> WriteInfosToFile(this List<string> output, List<Person> p ,string path)
        {
            output = new List<string>();
            foreach (var pi in p)
            {
                output.Add($"{pi.First} {pi.Last }: {pi.URL}");
            }
            File.WriteAllLines(path, output);
            return output;
        }

        public static void CreatePeople( this List<string> output, List<Person> people, string path)
        {
            output= File.ReadAllLines(path).ToList();
            foreach (var line in output)
            {
                string[] entries = line.Split(',');
                Person p = new Person();

                if (entries.Length > 0)
                {
                    p.First = entries[0];
                    p.Last = entries[1];
                    p.URL = entries[2];
                }
                else
                {
                    p = null;
                }

                people.Add(p);
            }
            ListPerson(people);
        }

        private static void ListPerson( List<Person> people)
        {
            foreach (var p in people)
            {
                Console.WriteLine($"{p.First} {p.Last}: {p.URL}");
            }
        }

        public static void Add( this List<string> lines, string text)
        {
            if (lines == null)
                throw new ArgumentNullException();
            lines.Add(text);
        }

        public static void Remove(this List<string> lines, string text)
        {
            lines.Remove(text);
        }

        public static void Foreach(this List<string> lines)
        {
            foreach (var line in lines)
            {
                if (line == null)
                    throw new ArgumentNullException();
                Console.WriteLine(line);
            }
        }

        public static List<string> ReadLines(string filePath)
        {
            var lines = File.ReadAllLines(filePath).ToList();
            if (lines != null)
                return lines;
            return new List<string>();
        }
    }
}