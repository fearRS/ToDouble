using System;

namespace FunctionTest
{
    public static class ConvertClass
    {
        public static double GetDouble(string input)
        {
            const char decimal1 = '.';
            int dPos = input.IndexOf(decimal1);
            input = input.Replace(".", "");
            int decimalPlace = input.Length - dPos;
            double replaceDecimal = Convert.ToInt32(input) / (Math.Pow(10, decimalPlace));
            return replaceDecimal;
        }
    }

    public static class InputClass
    {
        public static double GetDoubleFromConsole()
        {
            string input = Console.ReadLine();
            
            Validate(input);

            return ConvertClass.GetDouble(input);
        }

        private static void Validate(string inputCharacters)
        {
            char[] validArray = { '.', '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
            char[] inputArray = inputCharacters.ToCharArray();
            for (int inputIncrement = 0; inputIncrement < inputCharacters.Length - 1; inputIncrement++)
            {
                bool validCharacter = false;
                for (int validIncrement = 0; validIncrement < validArray.Length - 1; validIncrement++)
                {
                    if (inputArray[inputIncrement] == validArray[validIncrement])
                    {
                        validCharacter = true;
                        break;
                    }
                }
                if (!validCharacter)
                {
                    Console.WriteLine("Invalid Character");
                }
            }
        }
    }
    public static class Program
    {
        public static void Main()
        {
            Console.WriteLine(InputClass.GetDoubleFromConsole());
        }
    }
}
