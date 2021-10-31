using System;

namespace Methods
{
    public class Task
    {
        public static void Main(string[] args)
        {
            PrintArray(Sort(5, 6, 9, 8, 7, 4)); //4 5 6 7 8 9
            PrintArray(Sort(1, 8, 9, 6)); //1 6 8 9
            PrintArray(Sort(9, 5, 4, 2, 0)); //0 2 4 5 9
            PrintArray(Sort("Tree", "Scone")); //Scone Tree
            PrintArray(Sort("Love", "Sonic", "Bottle")); //Bottle Love Sonic
            PrintArray(Sort("Anna", "An", "Sonia")); //An Anna Sonia
            PrintArray(Sort("hello", "world", "School", "cat")); //cat hello School world
            PrintArray(Sort("Kiril", "Alex", "Anton", "David")); //Alex Anton David Kiril
        }

        public static bool IsWordGreater(string a, string b)
        {
            a = a.ToLower();
            b = b.ToLower();
            var minLenght = Math.Min(a.Length, b.Length);
            for (int i = 0; i < minLenght; i++)
            {
                if (a[i] > b[i])
                {
                    return false;
                }

                if (a[i] < b[i])
                {
                    return true;
                }
            }

            return a.Length < b.Length;
        }
        public static int[] Sort(params int[] numbers)
        {
            for (var firstUnsortedIndex = 0; firstUnsortedIndex < numbers.Length; firstUnsortedIndex++)
            {
                var minIndex = FindMinIndex(firstUnsortedIndex, numbers);

                Swap(ref numbers[minIndex], ref numbers[firstUnsortedIndex]);
            }

            return numbers;
        }
        public static string[] Sort(params string[] words)
        {
            for (var firstUnsortedIndex = 0; firstUnsortedIndex < words.Length; firstUnsortedIndex++)
            {
                var minIndex = FindMinIndex(firstUnsortedIndex, words);

                Swap(ref words[minIndex], ref words[firstUnsortedIndex]);
            }

            return words;
        }
        private static int FindMinIndex(int startIndex, int[] numbers)
        {
            var minIndex = startIndex;
            for (var i = startIndex; i < numbers.Length; i++)
            {
                if (numbers[i] < numbers[minIndex])
                {
                    minIndex = i;
                }
            }

            return minIndex;
        }
        private static int FindMinIndex(int startIndex, string[] words)
        {
            var minIndex = startIndex;
            for (var j = startIndex; j < words.Length; j++)
            {
                if (IsWordGreater(words[j], words[minIndex]))
                {
                    minIndex = j;
                }
            }

            return minIndex;
        }
        private static void Swap(ref string firstWord, ref string secondWord)
        {
            var temp = firstWord;
            firstWord = secondWord;
            secondWord = temp;
        }
        private static void Swap(ref int firstNumber, ref int secondNumber)
        {
            var temp = firstNumber;
            firstNumber = secondNumber;
            secondNumber = temp;
        }
        private static void PrintArray(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }

            Console.WriteLine();
        }
        private static void PrintArray(string[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }

            Console.WriteLine();
        }
    }
}