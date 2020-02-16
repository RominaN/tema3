using System;
using System.Linq;

namespace Tema3
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Exercitiul 1");
			double[] arr;
			arr = new double[3];
			arr[0] = 10;
			arr[1] = 20;
			arr[2] = 30;
			for (int i = 0; i < arr.Length; i++)
				Console.WriteLine("Element at index " + i + " : " + arr[i]);

			Console.WriteLine();
			Console.WriteLine("Exercitiul 2");
			int[] intArray = new int[] { 1, 11, 13, 40, 36, 54, 17, 81, 93, 18 };

			int min = intArray.Min();
			int max = intArray.Max();
			Console.WriteLine("Min: " + min + " and max: " + max);
			Console.WriteLine();


			Console.WriteLine();
			Console.WriteLine("Exercitiul 3");
			int[] input = { 8, 23, 89, 57, 98, 58, -18 };
			for (int index = 0; index < input.Length; index++)
			{
				if (input[index] < 0)
				{
					Console.WriteLine("Numar negativ este la indexul: " + index);
				}
			}

			Console.WriteLine();
			Console.WriteLine("Exercitiul 4");
            string value = "Cursul numarul 3";
            char[] array = value.ToCharArray();
            for (int i = 0; i < array.Length; i++)
            {
                char letter = array[i];
                Console.Write("Letter: ");
                Console.WriteLine(letter);
            }


            Console.WriteLine();
            Console.WriteLine("Exercitiul 5");
            string sirCaractere = "pozitie para"; 
            string[] words = sirCaractere.Split(' ');
            foreach (string word in words)
            {
                char[] stringToChar = word.ToCharArray();

                for (int i=0; i<stringToChar.Length; i++)
                {
                    if (i%2!=0)
                    {
                        stringToChar[i] = Char.ToUpper(stringToChar[i]);

                    }

                }
                Console.WriteLine(new String(stringToChar));

            }
          
          
            Console.WriteLine();
            Console.WriteLine("Exercitiul 6");

            int[] vector = { 5, 8, 10, 12, 6, 18, 20 };
            Console.WriteLine("Vectorul initial este:");
            for (int i = 0; i < vector.Length; i++)
            {
                Console.Write(vector[i].ToString() + "\t");
            }

            double doubleNumber = 10.2;

            double[] vector2 = new double[vector.Length];
            for (int i = 0; i < vector.Length; i++)
            {
                vector2[i] = vector[i] + doubleNumber;
            }
            Console.WriteLine();
            Console.WriteLine("Vectorul dupa adunare este:");
            for (int i = 0; i < vector2.Length; i++)
            {
                Console.Write(vector2[i].ToString() + "\t");
            }
        }
	}

}
