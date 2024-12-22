using System;
using System.Linq;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Q1
            // Write a program that allows the user to insert an integer then print all numbers between 1 to that number.

            //Console.Write("Enter an integer: ");
            //int number = int.Parse(Console.ReadLine());

            //for (int i = 1; i <= number; i++)
            //{
            //    Console.WriteLine(i);
            //}

            #endregion

            #region Q2
            // Write a program that allows the user to insert an integer then print a multiplication table up to 12.

            //Console.Write("Enter an integer: ");
            //int number = int.Parse(Console.ReadLine());

            //for (int i = 1; i <= 12; i++)
            //{
            //    Console.WriteLine( number * i);
            //}
            #endregion

            #region Q3
            //Write a program that allows to user to insert number then print all even numbers between 1 to this number

            //Console.Write("Enter a number: ");
            //int number = int.Parse(Console.ReadLine());
            //for (int i = 1; i <= number; i++)
            //{
            //    if (i % 2 == 0) 
            //    {
            //        Console.WriteLine(i);
            //    }
            //}           
            #endregion

            #region Q4
            //Write a program that takes two integers then prints the power.

            //Console.Write("Enter the number: ");
            //int Number = int.Parse(Console.ReadLine());

            //Console.Write("Enter the power: ");
            //int Power = int.Parse(Console.ReadLine());

            //int result = 1;

            //for (int i = 1; i <= Power; i++)
            //{
            //    result *= Number; 
            //}

            //Console.WriteLine(result);
            #endregion

            #region Q5
            //Write a program to allow the user to enter a string and print the REVERSE of it.

            //Console.Write("Enter a string: ");
            //string input = Console.ReadLine();

            //string reversed = "";

            //for (int i = input.Length - 1; i >= 0; i--)
            //{
            //    reversed += input[i];
            //}

            //Console.WriteLine(reversed);
            #endregion

            #region Q6
            //Write a program in C# Sharp to find prime numbers within a range of numbers.

            #endregion

            #region Q7
            //Write a program in C# Sharp to convert a decimal number into binary without using an array.

            //Console.Write("Enter a decimal number: ");
            //int decimalNumber = int.Parse(Console.ReadLine());

            //string binary = "";

            //while (decimalNumber > 0)
            //{
            //    int remainder = decimalNumber % 2;  //note => Get the remainder (0 or 1)
            //    binary = remainder + binary;      //note => Append the remainder to the front of the binary string
            //    decimalNumber /= 2;               //note => Divide the number by 2
            //}

            //Console.WriteLine($"Binary: {binary}");
            #endregion

            #region Q8
            //Write a program that prints an identity matrix using for loop, in other words takes a value n from the user and shows the identity table of size n * n.

            //Console.Write("Enter the size of the identity matrix (n): ");
            //int n = int.Parse(Console.ReadLine());

            //Console.WriteLine($"Matrix of size {n}x{n}: ");

            //for (int i = 0; i < n; i++) 
            //{
            //    for (int j = 0; j < n; j++) 
            //    {
            //        if (i == j) 
            //        {
            //            Console.Write("1 ");
            //        }
            //        else 
            //        {
            //            Console.Write("0 ");
            //        }
            //    }
            //    Console.WriteLine(); 
            //}
            #endregion

            #region Q9
            //Write C# program that Extract a substring from a given string.

            //Console.Write("Enter a string: ");
            //string inputString = Console.ReadLine();

            //Console.Write("Enter the starting index: ");
            //int startIndex = int.Parse(Console.ReadLine());

            //Console.Write("Enter the length of the substring: ");
            //int length = int.Parse(Console.ReadLine());

            //if (//condition) 
            //{
            //    string substring = inputString.Substring(startIndex, length);
            //    Console.WriteLine(substring);
            //}
            //else
            //{
            //    Console.WriteLine("Invalid input");
            //}
            #endregion

            #region Q10
            //Write C# program that take two string variables and print them as one variable 

            //Console.Write("Enter the first string: ");
            //string firstString = Console.ReadLine();

            //Console.Write("Enter the second string: ");
            //string secondString = Console.ReadLine();

            //string ConcatString = firstString + " " + secondString;

            //Console.WriteLine(ConcatString);
            #endregion

            #region Q12
            //Write a program in C# Sharp to find the sum of all elements of the array.

            //Console.Write("Enter the size of the array: ");
            //int size = int.Parse(Console.ReadLine());

            //int[] numbers = new int[size];

            //Console.WriteLine("Enter the elements of the array:");
            //for (int i = 0; i < size; i++)
            //{
            //    Console.Write($"Element {i + 1}: ");
            //    numbers[i] = int.Parse(Console.ReadLine());
            //}

            //int sum = 0;
            //for (int i = 0; i < size; i++)
            //{
            //    sum += numbers[i];
            //}

            //Console.WriteLine(sum);
            #endregion

            #region Q13
            // Write a program in C# Sharp to merge two arrays of the same size sorted in ascending order.

            //Console.Write("Enter the size of the arrays: ");
            //int size = int.Parse(Console.ReadLine());

            //int[] array1 = new int[size];
            //int[] array2 = new int[size];
            //int i;
            //Console.WriteLine("Enter the elements of the first array (sorted in ascending order):");
            //for ( i = 0; i < size; i++) 
            //{
            //    Console.Write($"Element {i + 1}: ");
            //    array1[i] = int.Parse(Console.ReadLine());
            //}

            //Console.WriteLine("Enter the elements of the second array (sorted in ascending order):");
            //for ( i=0; i < size; i++)
            //{
            //    Console.Write($"Element {i + 1}: ");
            //    array2[i] = int.Parse(Console.ReadLine());
            //}

            //int[] mergedArray = array1.Concat(array2).ToArray();



            //Console.WriteLine("Merged Array : ");
            //for (int index = 0; index < mergedArray.Length; index++)
            //{
            //    Console.Write(mergedArray[index] + " ");
            //}
            #endregion

            #region Q14
            //Write a program in C# Sharp to count the frequency of each element of an array.


            #endregion

            #region Q15
            //Write a program in C# Sharp to find maximum and minimum element in an array

            //Console.Write("Enter the size of the array: ");
            //int size = int.Parse(Console.ReadLine());

            //int[] array = new int[size];

            //Console.WriteLine("Enter the elements of the array:");
            //for (int i = 0; i < size; i++)
            //{
            //    Console.Write($"Element {i + 1}: ");
            //    array[i] = int.Parse(Console.ReadLine());
            //}
            //int max = array[0];
            //int min = array[0];

            // for (int i = 1; i < size; i++)
            //{
            //    if (array[i] > max)
            //    {
            //        max = array[i];
            //    }
            //    if (array[i] < min)
            //    {
            //        min = array[i];
            //    }
            //}

            //Console.WriteLine($"Maximum element: {max}");
            //Console.WriteLine($"Minimum element: {min}");
            #endregion

            #region Q16
            //Write a program in C# Sharp to find the second largest element in an array.



            #endregion

            #region Q18
            //Write a program to create two multidimensional arrays of same size. Accept value from user and store them in first array. Now copy all the elements of first array on second array and print second array.

            //Console.Write("Enter the number of rows: ");
            //int rows = int.Parse(Console.ReadLine());

            //Console.Write("Enter the number of columns: ");
            //int cols = int.Parse(Console.ReadLine());

            //int[,] array1 = new int[rows, cols];
            //int[,] array2 = new int[rows, cols];

            //Console.WriteLine("Enter the elements for the first array:");
            //for (int i = 0; i < rows; i++)
            //{
            //    for (int j = 0; j < cols; j++)
            //    {
            //        Console.Write($"Enter element at position ({i + 1},{j + 1}): ");
            //        array1[i, j] = int.Parse(Console.ReadLine());
            //    }
            //}

            //for (int i = 0; i < rows; i++) //make copy
            //{
            //    for (int j = 0; j < cols; j++)
            //    {
            //        array2[i, j] = array1[i, j];
            //    }
            //}

            //Console.WriteLine("The elements of the second array are:");
            //for (int i = 0; i < rows; i++)
            //{
            //    for (int j = 0; j < cols; j++)
            //    {
            //        Console.Write(array2[i, j]);
            //    }
            //    Console.WriteLine();
            //}
            #endregion

            #region Q19
            //Write a Program to Print One Dimensional Array in Reverse Order

            Console.Write("Enter the size of the array: ");
            int size = int.Parse(Console.ReadLine());

            int[] array = new int[size];

            Console.WriteLine("Enter the elements of the array:");
            for (int i = 0; i < size; i++)
            {
                Console.Write($"Element {i + 1}: ");
                array[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Array in reverse order:");
            for (int i = size - 1; i >= 0; i--)
            {
                Console.Write(array[i] + " ");
            }
            #endregion

        }
    }
}
