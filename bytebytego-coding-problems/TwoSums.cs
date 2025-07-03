// Problem:
// Given an array of unique integers sorted in ascending order and a target value,
// return the indexes of any pair of numbers in the array that sum to the target.
// The order of the indexes in the result doesn't matter. If no pair is found, return an empty array.
//
// Example 1:
// Input: nums = [-5, -2, 1, 3, 4, 6, 9, 12], target = 7
// Output: [(0, 6), (1, 5), (2, 3), (4, 7)]
// Explanation: nums[0] + nums[6] = -5 + 12 = 7
//
//solution: **need optimization**
//since we need to append pairs indexes dynamically
//it makes more sense to use a list instead of array to store the pairs
namespace Solutions
{
    public class TwoSums
    {
        public static void Run()
        {
            int[] numbers = [-5, -2, 3, 4, 6, 9, 12, 1];
            int target = 7;
            FindTwoSums(numbers, target);
        }
        public static Queue<(int, int)> FindTwoSums(int[] numbers, int target)
        {
            //take every element by order
            //test for index+1 if it achieves the target until you reach for the end
            //if yes return the indexes of both elements
            Queue<(int, int)> result = new Queue<(int, int)>();
            //print the array to console
            Console.WriteLine("Input Array: [" + string.Join(", ", numbers) + "]");
            for (int outer = 0; outer < numbers.Length; outer++)
            {
                for (int inner = outer + 1; inner < numbers.Length; inner++)
                {
                    if (target - numbers[outer] == numbers[inner])
                    {
                        result.Enqueue((outer, inner));
                    }
                }
            }
            // If no pair is found, return an empty result
            if (result.Count == 0)
            {
                Console.WriteLine("No pairs found that sum to the target.");
                return result;
            }
            Console.WriteLine("Found pairs:");
            // write the whole queue to console
            Console.WriteLine("Found pairs: [" + string.Join(", ", result) + "]");
            return result;
        }
    }
}