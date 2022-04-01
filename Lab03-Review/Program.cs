using System;
using System.IO;

namespace Lab03_Review
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Challenge1();
            Challenge2();
            Challenge3();
            Console.WriteLine(Challenge4(new int[] { 1, 2, 2, 4, 2, 4, 1, 4, 4, 2, 4 }));
            Console.WriteLine(Challenge5(new int[] { 5, 25, 99, 123, 78, 96, 555, 108, 4 }));
            Challenge6();
            Challenge7();
            Challenge8();
            Challenge9();
        }

        public static void Challenge1()
        {
            Console.WriteLine("Enter 3 Numbers seperated by a space");
            String userInput = Console.ReadLine();
            int result = Challenge1Method(userInput);
            Console.WriteLine("The product of these 3 numbers is:" + result);

        }
        public static int Challenge1Method(String userInput)
        {
            String[] nums = userInput.Split(' ');
            if (nums.Length < 3) return 0;
            int result = 1;
            for (int i = 0; i <= 2; i++)
            {
                try
                {
                    result *= Convert.ToInt32(nums[i]);
                }
                catch (Exception)
                {
                    result *= 1;
                }
            }
            return result;
        }

        public static void Challenge2()
        {
            Console.WriteLine("Please enter a number between 2-10:");
            String userInput = Console.ReadLine();
            int userInputInt;

            try
            {
                userInputInt = Convert.ToInt32(userInput);
            }
            catch (Exception)
            {
                Console.WriteLine("Thats not a number, Enter a number between 2-10:");
                userInput = Console.ReadLine();
                userInputInt = Convert.ToInt32(userInput);
            }

            int[] arr = new int[userInputInt];

            for (int i = 0; i < userInputInt; i++)
            {
                Console.WriteLine($"{i + 1} of {userInputInt} - Enter a number:");
                try
                {
                    arr[i] = Convert.ToInt32(Console.ReadLine());
                }
                catch (Exception)
                {
                    Console.WriteLine("You should Enter a Number");
                }
            }

            Console.WriteLine("Avarage: " + Challenge2Method(arr, userInputInt));
        }

        public static int Challenge2Method(int[] arr, int input)
        {
            int avarage = 0;
            int result = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                result += arr[i];
            }

            avarage = result / input;
            return avarage;
        }

        public static void Challenge3()
        {
            for (int i = 1; i < 6; i++)
            {
                for (int j = 1; j < 6 - i; j++)
                {
                    Console.Write(" ");
                }
                for (int k = 1; k <= i; k++)
                {
                    Console.Write("*");
                }
                for (int k = 2; k <= i; k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            for (int i = 4; i > 0; i--)
            {
                for (int j = 5 - i; j > 0; j--)
                {
                    Console.Write(" ");
                }
                for (int k = i; k > 0; k--)
                {
                    Console.Write("*");
                }
                for (int k = i - 1; k > 0; k--)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }

        public static int Challenge4(int[] arr)
        {
            int rebeate;
            int counter;
            int mostRebeated = arr[0];
            int mostCounter = 0;
            for (int i = 0; i < arr.Length - 1; i++)
            {
                rebeate = arr[i];
                counter = 0;
                for (int j = 0; j < arr.Length; j++)
                {
                    if (rebeate == arr[j])
                    {
                        counter++;
                    }
                }
                if (counter > mostCounter)
                {
                    mostRebeated = rebeate;
                    mostCounter = counter;
                }
            }
            return mostRebeated;
        }

        public static int Challenge5(int[] arr)
        {
            int max = arr[1];
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > max)
                {
                    max = arr[i];
                }
            }
            return max;
        }

        public static void Challenge6()
        {
            Console.WriteLine("Enter a text to save it into words.txt");

            string word = Console.ReadLine();

            File.WriteAllText("words.txt", word);
        }

        public static void Challenge7()
        {
            String[] content = File.ReadAllLines("words.txt");
            for (int i = 0; i < content.Length; i++)
            {
                Console.WriteLine(content[i]);
            }
        }

        public static void Challenge8()
        {
            Console.WriteLine("Enter a word to be deleted from 'words.txt'");
            String input = Console.ReadLine();
            String[] Content = File.ReadAllLines("words.txt");
            String[] words = Content[0].Split(" ");
            String newContent = "";

            for (int i = 0; i < words.Length; i++)
            {
                if (words[i] != input)
                    newContent += words[i] + " ";
            }

            File.WriteAllText("words.txt", newContent);
            Console.WriteLine("The new content is:");
            String[] newfileContent = File.ReadAllLines("words.txt");
            for (int i = 0; i < newfileContent.Length; i++)
                Console.WriteLine(newfileContent[i]);
        }

        public static void Challenge9()
        {

        }
    }
}
