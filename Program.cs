namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            // add screenshots

            /*Task 7
             Створіть додаток, що перевіряє текст на неприпустимі слова. 
            Якщо неприпустиме слово знайдено, воно має бути замінено на набір символів *. 
            За підсумками роботи додатка необхідно показати статистику дій.
             */
            /*
            string text = "To be, or not to be, that is the question, " +
                "And by opposing end them? To die: to sleep; " +
                "Devoutly to be wish'd. To die, to sleep";

            string badWord = "die";
            string stars = new string('*', badWord.Length);
            int count = 0;
            int index = text.IndexOf(badWord);
            while (index != -1)
            {
                count++;
                index = text.IndexOf(badWord, index + badWord.Length);
            }
            string censoredText = text.Replace(badWord, stars);

            Console.WriteLine("Initial text:\n" + text + "\n");
            Console.WriteLine("Censored text:\n" + censoredText + "\n");
            Console.WriteLine("--- STATISTICS ---");
            Console.WriteLine("Search word: " + badWord);
            Console.WriteLine("Count of substitutions: " + count);
            */

            /* Task 6
             Користувач з клавіатури вводить деякий текст. 
            Додаток повинен змінювати регістр першої літери кожного речення на букву у верхньому регістрі.
             */
            /*
            Console.WriteLine("Enter text:");
            string input = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(input)) return;

            char[] separators = { '.', '!', '?' };
            string[] sentences = input.Split(separators, StringSplitOptions.RemoveEmptyEntries);

            string result = "";
            int currentPos = 0;

            foreach (string sentence in sentences)
            {
                string trimmed = sentence.TrimStart();
                int spacesCount = sentence.Length - trimmed.Length;
                string leadingSpaces = sentence.Substring(0, spacesCount);

                if (trimmed.Length > 0)
                {
                    char firstChar = char.ToUpper(trimmed[0]);
                    string restOfSentence = trimmed.Substring(1);

                    result += leadingSpaces + firstChar + restOfSentence;
                }
                else
                {
                    result += leadingSpaces;
                }

                int separatorIndex = input.IndexOfAny(separators, currentPos);
                if (separatorIndex != -1)
                {
                    result += input[separatorIndex];
                    currentPos = separatorIndex + 1;
                }
                else
                {
                    result += ".";
                }
            }

            Console.WriteLine("\nResult:");
            Console.WriteLine(result);
            */
            /*Task 5
            Користувач з клавіатури вводить у рядок арифметичний вираз. 
            Додаток має порахувати його результат. 
            Необхідно підтримувати тільки дві операції: + і -
             */
            /*
            Console.WriteLine("Enter an expression (e.g. 10 + 5 - 3):");
            string input = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(input)) return;
            double result = 0;
            char currentOp = '+';
            string currentNumber = "";

            string expression = input.Replace(" ", "") + " ";

            for (int i = 0; i < expression.Length; i++)
            {
                char c = expression[i];

                if (char.IsDigit(c) || c == '.' || c == ',')
                {
                    currentNumber += c;
                }
                else if (c == '+' || c == '-' || i == expression.Length - 1)
                {
                    if (currentNumber != "")
                    {
                        double number = Convert.ToDouble(currentNumber.Replace(',', '.'));

                        if (currentOp == '+') result += number;
                        else if (currentOp == '-') result -= number;
                    }

                    currentOp = c;
                    currentNumber = "";
                }
            }

            Console.WriteLine($"Result: {result}");
            */

            // Task 3
            /*
                Користувач вводить рядок із клавіатури. 
                Необхідно зашифрувати цей рядок, використовуючи шифр Цезаря. З 
                Вікіпедії: "Шифр Цезаря - це різновид шифру підстановки, 
                в якому кожен символ у відкритому тексті замінюється символом, 
                що знаходиться на деякому постійному числі позицій лівіше або правіше за нього в алфавіті. 
                Наприклад, у шифрі зі зсувом вправо на 3, A була б замінена на D, B стане E, і так далі".
             */
            /*
            Console.Write("Enter text for Encrypting: ");
            string inputText = Console.ReadLine();

            Console.Write("Enter the key (number to shift): ");
            int shift = int.Parse(Console.ReadLine());

            string encryptedText = Encrypt(inputText, shift);
            Console.WriteLine($"\nCiphertext: {encryptedText}");

            string decryptedText = Decrypt(encryptedText, shift);
            Console.WriteLine($"Decrypted text: {decryptedText}");

            Console.ReadLine();

            */
        }
        /*Task 3
        static string Encrypt(string text, int shift)
        {
            char[] buffer = text.ToCharArray();

            for (int i = 0; i < buffer.Length; i++)
            {
                char letter = buffer[i];

                if (char.IsLetter(letter))
                {
                    char offset = char.IsUpper(letter) ? 'A' : 'a';

                    letter = (char)((((letter + shift) - offset) % 26) + offset);
                }
                buffer[i] = letter;
            }

            return new string(buffer);
        }

        static string Decrypt(string text, int shift)
        {
            return Encrypt(text, 26 - shift);
        }
        */
    }
}
