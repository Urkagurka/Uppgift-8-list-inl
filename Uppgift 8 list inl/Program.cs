using System;

namespace Uppgift_5_list_inl
{
    class program
    {
        static void Main(string[] args)
        {
            Dictionary<char, char> dic = new Dictionary<char, char>();

            Console.WriteLine("Hur många koder vill du skriva in?");
            int antalkod = int.Parse(Console.ReadLine());
            Console.WriteLine("Skriv in dina koder");

            for (int i = 0; i < antalkod; i++)
            {
                string kod = Console.ReadLine();

                if (kod.Length != 3)
                {
                    return;
                }

                dic.Add(kod[0], kod[2]);

            }

            string avkodad = "";
            Console.WriteLine("skriv in ditt hemliga medelande ");
            string hemligkod = Console.ReadLine();

            foreach (char hemligbokstaav in hemligkod)
            {
                avkodad += avkodabokstav(hemligbokstaav, dic);
            }

            Console.WriteLine("Här är ditt avkodade meddelande");
            Console.WriteLine(avkodad);
        }

        static char avkodabokstav(char hemlig, Dictionary<char, char> dic)
        {
            if (dic.ContainsKey(hemlig))
            {
                char kanskeavkodad = dic[hemlig];
                return avkodabokstav(kanskeavkodad, dic);
            }
            return hemlig;
        }
    }
}