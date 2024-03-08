namespace Coding_Exercise___Two_Sum
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Greetings, and Welcome to the Coding Exercise!\n");

            Console.Write("Please enter the quantity of integers you intend to input: ");
            int lengthOfArray = Convert.ToInt32(Console.ReadLine());

            int[] nums = new int[lengthOfArray];
            Console.Write("Please enter the target integer: ");
            int target = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < nums.Length; i++)
            {
                Console.Write($"Enter the integer for #{i + 1}: ");
                nums[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (nums[i] + nums[j] == target)
                    {
                        Console.WriteLine($"The output is: [{i},{j}]");
                    }
                }
            }
        }
    }
}
