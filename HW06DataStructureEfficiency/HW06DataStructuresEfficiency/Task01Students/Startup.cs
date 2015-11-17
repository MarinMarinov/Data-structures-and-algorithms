namespace Task01Students
{
    using System;
    using System.IO;
    using System.Linq;
    using Wintellect.PowerCollections;

    public class Startup
    {
        public static void Main()
        {
            var reader = new StreamReader("../../Students.txt");

            var dictionary = new OrderedMultiDictionary<string, Student>(true);

            string line = reader.ReadLine();

            while (line != null)
            {
                string[] splitedLine = line.Split(new char[]{'|'}, StringSplitOptions.RemoveEmptyEntries).Select(word => word.Trim()).ToArray();

                Student student = new Student(splitedLine[0], splitedLine[1]);
                if(!dictionary.ContainsKey(splitedLine[2]))
                {
                    dictionary.Add(splitedLine[2], student);
                }
                else
                {
                    dictionary[splitedLine[2]].Add(student);
                }

                line = reader.ReadLine();
            }

            foreach (var pair in dictionary)
            {
                Console.Write(pair.Key + " : ");

                var orderedList = pair.Value.OrderBy(v => v.LastName).ThenBy(v => v.FirstName).ToList();
                
                Console.WriteLine(string.Join(", ", orderedList.Select(s => s.FirstName + " " + s.LastName)));
            }
        }
    }
}