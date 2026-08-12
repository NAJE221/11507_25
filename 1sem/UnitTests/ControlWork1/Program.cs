namespace ControlWork1;

public class Program
{
    public static void Main(string[] args)
    {
        int[] nums = new int[] {-1, -3, -5, -6};
        int[] nums2 = RunningSum(nums);
        for (int i = 0; i < nums2.Length; i++)
        {
            Console.WriteLine(nums2[i]);
        }
        
    }
    public static int[] RunningSum(int[] nums)
    {
        if (nums == null)
        {
            throw new ArgumentNullException("nums" + "не должно принимать значение null");
        }
        if (nums.Length == 0)
        {
            throw new ArgumentNullException("nums" + "не должен быть пустым");
        }
        int[] result = new int[nums.Length];
        int sum = 0;
        for(int i = 0; i < nums.Length; i++)
        {
            for( int j = 0; j < i; j ++)
            {
                result[i] += nums[j];
            }
        }
        return result;    
    }
}