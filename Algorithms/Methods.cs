using System;
namespace Algorithms
{
    public class Methods
    {

        public void BubbleSort(int[] nums)
        {
            //declare variables
            //loop through comparing numbers, however many times n is

            for (int i = 0; i < nums.Length - 1; i++)
            {
                for (int j = 0; j < nums.Length - 1; j++)
                {
                    if (nums[j] > nums[j + 1])
                    {
                        int temp = nums[j];
                        nums[j] = nums[j + 1];
                        nums[j + 1] = temp;
                    }
                }

            }
            //return sorted list
        }
        public int SingleNumber(int[] nums)
        {

            //sort the array
            Array.Sort(nums);
            //loop through the array
            for (int i = 0; i < nums.Length - 1; i++)
            {
                if (nums[i] != nums[i + 1])
                {
                    return nums[i];
                }
                i++;
            }
            return nums[nums.Length - 1];
            //check that 0/1 2/3 pairs are equal

            //if not, return the first index in the pair

            //return integer
        }
        public void SelectedSort(int[] nums)
        {
            int smallest;
            for (int i = 0; i < nums.Length - 1; i++)
            {
                smallest = i;
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (nums[j] < smallest)
                    {
                        smallest = j;
                    }
                }
                int temp = i;
                nums[i] = nums[smallest];
                nums[smallest] = temp;
            }
        }
        public int[] MergeSort(int[] nums)
        {
            //this is recursive, so its going to call itself
            //split into two arrays

            //declare length var and array vars
            int[] left;
            int[] right;
            int n = nums.Length;

            if (n % 2 == 0)
            {
                left = new int[n / 2];
                right = new int[n / 2];
            }
            else
            {
                left = new int[n / 2];
                right = new int[(n / 2) + 1];
            }


            //fill up each array

            for (int i = 0; i < n; i++)
            {
                if (i < n / 2)
                {
                    left[i] = nums[i];
                }
                else
                {
                    right[i - n / 2] = nums[i];
                }
            }

            left = MergeSort(left);
            right = MergeSort(right);

            return Merge(left, right);
        }
        public int[] Merge(int[] left, int[] right)
        {
            int[] result = new int[left.Length + right.Length];
            int k = 0;
            int j = 0;
            int i = 0;
            while (i < left.Length && j < right.Length)
            {
                if (left[i] < right[j])
                {
                    result[k] = left[i];
                    k++;
                    i++;
                }
                else
                {
                    result[k] = right[j];
                    k++;
                    j++;
                }
            }
            while (i < left.Length)
            {
                result[k++] = left[i++];
            }
            while (j < right.Length)
            {
                result[k] = right[i];
                k++;
                i++;
            }
            return result;
        }
        public static bool BinarySearch(int[] nums, int num)
        {
            //find the length of the array
            Array.Sort(nums);
            int n = nums.Length;
            int high = nums.Length;
            int low = 0;
            //split the array in half
            int middle = n / 2;
            if (nums[middle] == num)
            {
                return true;
            }
            //compare the number you're looking for
            while (nums[middle] != num)
            {
                if (middle == low)
                {
                    break;
                }
                if (nums[middle] > num)
                {
                    high = middle;
                    middle = (high + low) / 2;
                }
                else if (nums[middle] < num)
                {
                    low = middle;
                    middle = (high + low) / 2;
                }
                else
                {
                    Console.WriteLine("Number not found");
                    return false;
                }

            }
            if (nums[middle] == num)
            {
                return true;
            }
            else
            {
                return false;
            }
            //adjust for the number you're looking for
            //repeat until complete
        }
    }
}
