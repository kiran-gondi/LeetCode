//#704 Binary Search-Algorithm

//Approach-1
public int Search(int[] nums, int target) 
{
        int min = 0;
        int max = nums.Length -1;
        int mid = 0;
        
        while(min <= max)
        {
            
            mid = (min + max)/2;
            
            if(nums[mid] == target)
                return mid;
            
            if(nums[mid] < target)
            {
                min = mid + 1;
            }else{
                max = mid - 1;
            }
        }
        return -1;
}
	


//Approach-2
public class Solution 
{
    public int Search(int[] nums, int target) {
        int min = 0;
        int max = nums.Length - 1;
        int mid = 0;
        
        while(min <= max){
            mid = min + (max - min) / 2;
            
            if(nums[mid] == target)
                return mid;
            
            if(nums[mid] < target)
            {
                min = mid + 1;
            }else{
                max = mid - 1;
            }
        }
        return -1;
    }
}