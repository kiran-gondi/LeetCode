//#217-Contains Duplicate-DS-Array

public class Solution {
    public bool ContainsDuplicate(int[] nums) {
        
		//Dictionary approach
        Dictionary<int, int> dict = new Dictionary<int, int>();
        
        for(int i = 0; i < nums.Length; i++)
        {
            if(!dict.ContainsKey(nums[i]))
            {
                dict.Add(nums[i], i);
            }
            else
            {
                return true;
            }
        }
        return false;
    }
}



//C# simple approach
public bool ContainsDuplicate(int[] nums)
{
	Array.Sort();
	
	for(int i = 0; i < nums.Length; i++)
	{
		if(nums[i] == nums[i+1])
		{
			return true;
		}
	}
	return false;
}


//LINQ Approach
public bool ContainsDuplicate(int[] nums)	
{
		return nums.Distinct().Count() != nums.Length;
}

//HashSet Approach
public bool ContainsDuplicate(int[] nums) 
{
	var hashSet = new HashSet<int>();
	
	for(int i = 0; i < nums.Length; ++i)
	{
		if(hashSet.Contains(nums[i]))
		{
			return true;
		}
		else
		{
			hashSet.Add(nums[i]);
		}
	}
	return false;
}