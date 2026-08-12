namespace ControlWork1;

public class Task1
{
    public static void Sort(int[] nums)
    {
        if (nums == null)
        {
            throw new ArgumentNullException(nameof(nums) , "массив не должен принимать значение null");
        }

        if (nums.Length == 0)
        {
            throw new ArgumentException("массив не должен быть пустым", nameof(nums));
        }
        
        for(int i = 0; i < nums.Length; i++)
        {
            for(int j = i + 1; j < nums.Length; j++)
            {
                if (nums[i] > nums[j])
                {
                    int temp = nums[i];
                    nums[i] = nums[j];
                    nums[j] = temp;
                }
            }
        }
    }
}