public class Solution {
    public int ThreeSumClosest(int[] nums, int target) 
    {
        int sdiff=int.MaxValue;
        int res=0;
        int n=nums.Length;
        for(int i=0;i<n-2;i++)
        {
            for(int j=i+1;j<n-1;j++)
            {
                for(int k=j+1;k<n;k++)
                {
                    int sum=nums[i]+nums[j]+nums[k];
                    int diff=sum-target;
                   diff= Math.Abs(diff);
                    if(diff<sdiff)
                    {
                        sdiff=diff; 
                        res=sum;
                    }
                    
                }
            }
        }
        return res;
    }
}