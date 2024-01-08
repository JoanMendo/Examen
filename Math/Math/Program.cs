using System;
namespace Maths
{
    public class MatematicalFunctions
    {
        public static void Main(string[] args)
        {
            const string InitialMessage = "Escogeix una opció";
            const string Options = "1. Mirar si un nombre és senar\n2. Calcular una potència\n3. Valor Random\n4. Comptar vocals i consonants d'un text\n5. Sortir";
            const string ExitMessage = "Gràcies per utilitzar el programa.";
            const string Error = "Error, opció incorrecta";
            const string IntroduceNumber = "Introdueix un nombre";
            const string IntroduceBase = "Introdueix un nombre base";
            const string IntroduceExponent = "Introdueix un nombre exponent";
            const string Min = "Introdueix el nombre mínim";
            const string Max = "Introdueix el nombre màxim";
            const string IntroduceText = "Introdueix un text";
            const string ErrorNumber = "El nombre no pot ser negatiu";
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
                        if (number < 0)
                        {
                            Console.WriteLine(ErrorNumber);
                        }
                        else
                        { 
                            Console.WriteLine(OddNumber(number)); 
                        }
                        
                        break;
                    case "2":
                        Console.WriteLine(IntroduceBase);
                        int baseNumber = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine(IntroduceExponent);
                        int power = Convert.ToInt32(Console.ReadLine());
                        if (baseNumber < 0 || power < 0)
                        {
                            Console.WriteLine(ErrorNumber);
                        }
                        else
                        {
                            Console.WriteLine(Power(baseNumber, power));
                        }
                        break;
                    case "3":
                        Console.WriteLine(Min);
                        int minNumber = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine(Max);
                        int maxNumber = Convert.ToInt32(Console.ReadLine());
                        if (minNumber < 0 || maxNumber < 0)
                        {
                            Console.WriteLine(ErrorNumber);
                        }
                        else
                        {
                            Console.WriteLine(RandomNumber(minNumber, maxNumber));
                        }
                        break;

                    case "4":
                        Console.WriteLine(IntroduceText);
                        string text = Console.ReadLine();
                        
                        if (text.Length == 0)
                        {
                            Console.WriteLine(Error);
                        }
                        else
                        {
                            Console.WriteLine(CountVowelsOrConsonants(text));
                        }
                        break;
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
        public static int Power(int number, int power)
        {
            int result = 1;
            for (int i = 0; i < power; i++)
            {
                result = result * number;
            }
            return result;
        }
        public static int RandomNumber(int min, int max)
        {
            Random random = new Random();
            return random.Next(min, max);
        }
        public static string CountVowelsOrConsonants(string text)
        {
            int vowels = 0;
            int consonants = 0;
            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] == 'a' || text[i] == 'e' || text[i] == 'i' || text[i] == 'o' || text[i] == 'u')
                {
                    vowels++;
                }
                else
                {
                    consonants++;
                }
            }
            return $"Vocals: {vowels}\nConsonants: {consonants}";
        }

        
    }
}
