using System;

namespace GuessingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int targetNumber = random.Next(1, 101);
            int maxAttempts = 5; // عدد المحاولات بناءً على الصورة
            bool won = false;

            // رسالة البداية باللون الأصفر
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("I have chosen a number between 1 and 100.");

            // رسالة عدد المحاولات باللون الأحمر
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"You have {maxAttempts} attempts to guess it.\n");

            for (int i = 1; i <= maxAttempts; i++)
            {
                // طباعة رقم المحاولة باللون الأحمر
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write($"Attempt {i}/{maxAttempts} - ");

                // طلب التخمين باللون الأصفر
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("Enter your guess: ");

                // إعادة اللون للأبيض لإدخال المستخدم
                Console.ResetColor();
                if (!int.TryParse(Console.ReadLine(), out int guess)) continue;

                if (guess == targetNumber)
                {
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.WriteLine("🎉 Congratulations! You guessed the correct number!");
                    won = true;
                    break;
                }
                else if (guess > targetNumber)
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("📧 Too high! Try again.\n");
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.WriteLine("📈 Too low! Try again.\n");
                }
            }

            if (!won)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"\nGame Over! The number was {targetNumber}.");
            }

            Console.ResetColor();
        }
    }
}


