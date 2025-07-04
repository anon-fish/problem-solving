// Problem:
// Given an array of integers, return all triplets [a, b, c] such that a + b + c = 0.
// The solution must not contain duplicate triplets (e.g., [1, 2, 3] and [2, 3, 1] are considered duplicates).
// If no such triplets are found, return an empty array.
//
// Each triplet can be arranged in any order, and the output can be returned in any order.
//
// Example:
// Input: nums = [0, -1, 2, -3, 1]
// Output: [[-3, 1, 2], [-1, 0, 1]]
//
//solution:
// in case array contains zero, it can be part of a triplet, and the two other numbers are similar but one positive and one negative
// in case array doesn't contain zero or to find triplets that doesn't contain zero
    // find possible pair of numbers add them together and multiply by -1
    // check if the result exists in the array, if yes then the pair and the result form a triplet
namespace Solutions
{
    public class ThreeSum
    {
        public static void Run()
        {
            int[] nums = { 0, -1, 2, -3, 1 };
            // Call your solution method here
            FindTriplets(nums);
        }
        // Implement your solution method here
        //a function that finds triplets that sums to zero
        public static void FindTriplets(int[] nums)
        {
            Queue<(int, int, int)> triplets = new Queue<(int, int, int)>();
            //find all possible pairs and their sums
            for (int i = 0; i < (nums.Length - 1); i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    int sumPair = nums[i] + nums[j];
                    //find if the negative of sum pair exist
                    if (Array.IndexOf(nums, -sumPair, j) != -1)
                    {
                        triplets.Enqueue((nums[i], nums[j], -sumPair));
                        Console.WriteLine("Found Pairs: [" + string.Join(",", triplets) + "]");
                    }

                }
            }
        }
    }
}
