using System;
namespace Maths
{
    public class MatematicalFunctions
    {
        public static void Main(string[] args)
        {
            const string InitialMessage = "Escogeix una opció";
            const string Options = "1. Mirar si un nombre és senar\n2. Calcular una potència\n3. Valor Random\n4. Comptar vocals o consonants d'un text\n5. Sortir";
            const string ExitMessage = "Gràcies per utilitzar el programa.";
            const string Error = "Error, opció incorrecta";
            const string IntroduceNumber = "Introdueix un nombre";
            const string IntroduceBaseNumber = "Introdueix un nombre base";
            const string IntroducePower = "Introdueix un nombre potència";
            bool exit = false;
            while (exit == false)
            {
                Console.WriteLine("");
                Console.WriteLine(InitialMessage);
                Console.WriteLine(Options);

                switch (Console.ReadLine())
                {
                    case "1":
                        Console.WriteLine(IntroduceNumber);
                        int number = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine(OddNumber(number));
                        break;
                    case "2":
                       
                    case "3":


                    case "4":

                    case "5":
                        Console.WriteLine(ExitMessage);
                        exit = true;
                        break;
                    default:
                        Console.WriteLine(Error);
                        break;
                }
            }
        }
        public static string OddNumber(int number)
        {
            if (number % 2 == 0)
            {
                return "El nombre no és senar";
            }
            else
            {
                return "El nombre és senar";
            }
        }
       
    }
}
