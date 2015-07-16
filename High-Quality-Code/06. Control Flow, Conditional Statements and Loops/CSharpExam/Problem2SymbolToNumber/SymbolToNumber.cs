using System;

class SymbolToNumber
{
    const int LETTER_ADDITION = 1000;
    const int DIGIT_ADDITION = 500;
    const int ODD_MULTIPLIER = 100;
    const float EVEN_DIVIDER = 100f;

    static void Main()
    {
        int secret = int.Parse(Console.ReadLine());
        string textToEncode = string.Empty;

        do
        {
            char inputCharacter = Console.ReadKey().KeyChar;
            if (inputCharacter == '@')
            {
                break;
            }
            textToEncode += inputCharacter;
        } while (true);

        string currentCharacterType = string.Empty;

        for (int i = 0; i < textToEncode.Length; i++)
        {
            char currentCharInText = textToEncode[i];
            if (Char.IsLetter(currentCharInText))
            {
                currentCharacterType = "letter";
            }
            else if (Char.IsNumber(currentCharInText))
            {
                currentCharacterType = "number";
            }
            else
            {
                currentCharacterType = "default";
            }

            int encodedValue = CharConversionToNumber(currentCharInText, currentCharacterType, secret);

            if (i % 2 == 0)
            {
                Console.WriteLine("{0:F2}", encodedValue / EVEN_DIVIDER);                
            }
            else
            {
                Console.WriteLine(encodedValue * ODD_MULTIPLIER);
            }
        }
    }

    static int CharConversionToNumber(char currentChar, string charType, int secret)
    {
        int charCode = (int)currentChar;
        int result = 0;

        switch (charType)
        {
            case "letter":
                {
                    result = (charCode * secret) + LETTER_ADDITION;
                    break;
                }
            case "number":
                {
                    result = charCode + secret + DIGIT_ADDITION; 
                    break;
                }
            default:
                {
                    result = charCode - secret;
                    break;
                }
        }
        return result;
    }
}
