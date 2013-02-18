using System;

class BinarySearch
{
    private const int NOT_FOUND = -1;

    static void Main()
    {
        Console.Write("Enter the size of the array: ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Enter the key you are looking for: ");
        int key = int.Parse(Console.ReadLine());
        Console.WriteLine("Start entering numbers");
        int[] numbers = new int[n];
        for (int i = 0; i < n; i++)
        {
            numbers[i] = int.Parse(Console.ReadLine());
        }

        Array.Sort(numbers);

        int indexOfKey = BinarySearchAlg(numbers, key);

        if (indexOfKey == NOT_FOUND)
        {
            Console.WriteLine("{0} Not Found!", key);
        }
        else
        {
            Console.WriteLine("{0} Found at Index [{1}]", key, indexOfKey);
        }
    }

    static int BinarySearchAlg(int[] nums, int key)
    {
        int min = 0;
        int max = nums.Length - 1;

        if (key > nums[max] || key < nums[min])
        {
            return NOT_FOUND;
        }

        while (max >= min)
        {
            int mid = (min + max) / 2;

            if (nums[mid] < key)
            {
                min = mid + 1;
            }
            else if (nums[mid] > key)
            {
                max = mid - 1;
            }
            else
            {
                return mid;
            }
        }

        return NOT_FOUND;
    }
}

