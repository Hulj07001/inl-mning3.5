using System;
namespace inlämning3_5
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Skriv in två tal.");
                Console.Write("Tal 1: ");
                double tal1 = double.Parse(Console.ReadLine());
                Console.Write("Tal 2: ");
                double tal2 = double.Parse(Console.ReadLine());
                Console.WriteLine("Välj ett räknesätt.");
                Console.WriteLine("1. Addition.\n2. Subtraktion.\n3. Multiplikation.\n4. Division");
                string val = Console.ReadLine();

                switch (val)
                {
                    case "1":
                        Console.WriteLine("Additionen av talen blir: " + (tal1 + tal2) + ".");
                        break;
                    case "2":
                        Console.WriteLine("Subtraktionen av talen blir: " + (tal1 - tal2) + ".");
                        break;
                    case "3":
                        Console.WriteLine("Multiplikationen av talen blir: " + (tal1 * tal2) + ".");
                        break;
                    case "4":
                        Console.WriteLine("Divisionen av talen blir: " + (tal1 / tal2) + ".");
                        break;
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Fel inträffade! Använd ednast siffror och kommatecken.");
            }
        }   
    }
}