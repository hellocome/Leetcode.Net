public class Solution {
    public bool ContainsNearbyAlmostDuplicate(int[] nums, int k, int t) {
        Dictionary<int, int> map = new Dictionary<int, int>();
        
        if(nums == null || nums.Length < 2)
        {
            return false;
        }
        else
        {
            for(int i=0; i < nums.Length; i++)
            {
                for(int j = i+1; j < nums.Length && j <= i+k; j++)
                {
                    long res = Math.Abs((long)nums[i] - nums[j]);
                    
                    if(res <= t)
                    {
                        return true;
                    }
                }
                
            }
            
            return false;
        }
    }
}