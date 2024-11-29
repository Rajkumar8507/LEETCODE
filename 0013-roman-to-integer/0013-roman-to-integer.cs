public class Solution {
    public int RomanToInt(string s) {
        Dictionary<char,int> val=new Dictionary<char,int>
        {
            {'I',1},
            {'V',5},
            {'X',10},
            {'L',50},
            {'C',100},
            {'D',500},
            {'M',1000}   
        };
        int result=0;
        int previousvalue=0;
        for(int i=s.Length-1;i>=0;i--)
        {
            int currentvalue=val[s[i]];
            if(currentvalue>=previousvalue)
            {
                result=result+currentvalue;
                previousvalue=currentvalue;
            }
            else{
                result=result-currentvalue;
            }
        }
        return result;
    }}
