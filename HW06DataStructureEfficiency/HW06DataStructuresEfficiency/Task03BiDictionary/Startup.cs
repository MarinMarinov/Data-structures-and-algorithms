namespace Task03BiDictionary
{
    using System;

    public class Startup
    {
        public static void Main()
        {
            var biDictionary = new BiDictionary<bool, int, string>();

            biDictionary.Add(true, 18, "Ivan Petrov");
            biDictionary.Add(false, 18, "Gergana Mihova");
            biDictionary.Add(true, 30, "Petkan Iliev");
            biDictionary.Add(false, 25, "Ani Petrova");
            biDictionary.Add(true, 45, "Georgi Ivanov");
            biDictionary.Add(true, 45, "Pesho Goshov");
            biDictionary.Add(true, 45, "Miho Mihov");
            biDictionary.Add(false, 28, "Petranka Petrova");
            biDictionary.Add(false, 28, "Ivanka Ivanova");
            biDictionary.Add(false, 28, "Pepa Petrova");

            // all men
            Console.WriteLine(biDictionary.FindByFirstKey(true));

            // all 45 years old
            Console.WriteLine(biDictionary.FindBySecondKey(45));

            // all women 28 years old
            Console.WriteLine(biDictionary.FindByBothKeys(false, 28));

            // all 50 years old men
            Console.WriteLine(biDictionary.FindByBothKeys(true, 50)); // empty collection !!!
        }
    }
}