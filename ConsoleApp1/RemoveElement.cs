namespace ConsoleApp1
{
    public class RemoveElement
    {
        public static int Remove(int[] nums, int val)
        {
            int sum = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == val)
                {
                    sum++;
                }
            }

            int n = nums.Length - sum;
            int j = nums.Length - 1;
            for (int i = 0; i < n; i++)
            {
                if (nums[i] == val)
                {
                    while (nums[j] == val && j > 0)
                    {
                        j = j - 1;
                    }

                    int temp = nums[j];
                    nums[j] = nums[i];
                    nums[i] = temp;

                }
            }

            return n;
        }
    }
}