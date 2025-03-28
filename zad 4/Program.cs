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
        }

        static public int[] TwoSum(int[] nums, int target)
        {
            Dictionary<int, int> dictionary = new Dictionary<int, int>();
            for (int i = 0; i < nums.Length; i++)
            {
                int complement = target - nums[i];
                if (dictionary.ContainsKey(complement) && dictionary[complement] != i)
                {
                    return new int[] { i, dictionary[complement] };
                }
                dictionary.Add(nums[i], i);
            }
            return null;
        }
    }
}
