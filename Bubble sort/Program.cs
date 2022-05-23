using System;
public class BubbleSrt
{
    static int[] arr = new int[10] { 5, 4, 6, 8, 9, 10, 1, 2, 3, 7 };//Array created with 10 unsorted numbers
    static int temp1 = 0;
    static int temp2 = 0;
    static int position = 0;
    static int arrLength = arr.Length;
    static int iterations = 0;
    public static void Main(string[] args)
    {
        try
        {
            if (iterations > arrLength)
            {
                while (position < arrLength) {
                    if (arr[position] > arr[position + 1])
                    {
                        temp1 = arr[position];
                        temp2 = arr[position + 1];
                        arr[position] = temp2;
                        arr[position + 1] = temp1;
                    }
                    position++;
                }
                iterations++;
            }
            else if (iterations != arrLength){
                position = 0;
            }
        }
        catch (System.IndexOutOfRangeException ex)
        {
            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }
        }

    }
}