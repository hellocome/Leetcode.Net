public class Solution {
    public int MaxArea(int[] height) {
		
		if(height == null || height.Length < 2)
		{
			return 0;
		}
		
		int maxArea = 0;
        int left = 0;
		int right = height.Length - 1;
		
		
		while(left < right)
		{
			maxArea = Math.Max(maxArea, Math.Min(height[left], height[right]) * (right - left));
			
			if( height[left] > height[right])
			{
				right --;
			}
			else
			{
				left++;
			}
		}
		
		return maxArea;
    }
}