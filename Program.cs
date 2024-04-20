using static System.Console;

internal class Program
{
    private static void Main(string[] args)
    {

        bool should_repeat = false;

        do
        {

            Write("Enter a Roman Numeral: ");
            string user_input;

            try
            {
                user_input = ReadLine();
                int result = ConvertFromRomanNumerals(user_input);
                WriteLine("Arabic Numeral: " + result);
            }
            catch (Exception ex)
            {
                WriteLine(ex.Message);
            }

            Write("Try another? (y/n): ");
            string answer = ReadLine();

            if (answer.ToLower() == "y")
            {
                should_repeat = true;
            }
            else
            {
                should_repeat = false;
            }

        } while (should_repeat);

    }

    private static int ConvertFromRomanNumerals(string input)
    {
        int result = 0;

        for (int index = 0; index < input.Length; index++)
        {

            if (input[index] == 'M')
            {
                result += 1000;
            }

            if (input[index] == 'D')
            {
                result += 500;
            }

            if (input[index] == 'C')
            {
                result += 100;
            }

            if (input[index] == 'L')
            {
                result += 50;
            }

            if (input[index] == 'X')
            {
                result += 10;
            }

            if (input[index] == 'V')
            {
                result += 5;
            }

            if (input[index] == 'I')
            {
                // Check for the last index to avoid out of bounds errors
                if (index + 1 == input.Length)
                {
                    result += 1;
                    break;
                }

                // NOTE: If this isn't the end of the roman numeral this will break
                else
                {
                    if (input[index + 1] == 'X')
                    {
                        result += 9;
                        break;
                    }

                    else if (input[index + 1] == 'V')
                    {
                        result += 4;
                        break;
                    }

                    else
                    {
                        result += 1;
                    }
                }
            }

        }

        return result;
    }
}