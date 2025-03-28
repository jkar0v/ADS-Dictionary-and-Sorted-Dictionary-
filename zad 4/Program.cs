namespace zad_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            
            Console.WriteLine("Write a target sum:");
            int target = int.Parse(Console.ReadLine());
            int[] result = TwoSum(array, target);
            Console.WriteLine($"The result is: index: {string.Join(' ', result)}, numbers: {array[result[0]]} {array[result[1]]}");

            Console.WriteLine("Without dictionary, it is:");
            int[] result2 = WithoutDictionary(array, target);
            Console.WriteLine($"The result is: index: {string.Join(' ', result2)}, numbers: {array[result2[0]]} {array[result2[1]]}");
        }

        static public int[] TwoSum(int[] nums, int target)
        {
            Dictionary<int, int> dictionary = new Dictionary<int, int>();
            for (int i = 0; i < nums.Length; i++)
            {
                int complement = target - nums[i];
                if (dictionary.ContainsKey(complement) && dictionary[complement] != i)
                {
                    return new int[] { dictionary[complement], i };
                }
                dictionary.Add(nums[i], i);
            }
            return null;
        }
        static public int[] WithoutDictionary(int[] nums, int target)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (nums[i] + nums[j] == target)
                    {
                        return new int[] { i, j };
                    }
                }
            }
            return null;
        }
    }
}
