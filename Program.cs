namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            // Task 3
            /*
                Користувач вводить рядок із клавіатури. 
                Необхідно зашифрувати цей рядок, використовуючи шифр Цезаря. З 
                Вікіпедії: "Шифр Цезаря - це різновид шифру підстановки, 
                в якому кожен символ у відкритому тексті замінюється символом, 
                що знаходиться на деякому постійному числі позицій лівіше або правіше за нього в алфавіті. 
                Наприклад, у шифрі зі зсувом вправо на 3, A була б замінена на D, B стане E, і так далі".
             */

            Console.Write("Enter text for Encrypting: ");
            string inputText = Console.ReadLine();

            Console.Write("Enter the key (number to shift): ");
            int shift = int.Parse(Console.ReadLine());

            string encryptedText = Encrypt(inputText, shift);
            Console.WriteLine($"\nCiphertext: {encryptedText}");

            string decryptedText = Decrypt(encryptedText, shift);
            Console.WriteLine($"Decrypted text: {decryptedText}");

            Console.ReadLine();
        }

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
    }
}
