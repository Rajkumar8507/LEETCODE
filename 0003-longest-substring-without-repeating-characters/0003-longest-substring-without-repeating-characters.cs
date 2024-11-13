public class Solution {
    public int LengthOfLongestSubstring(string s) 
    {
        Hashtable ht = new Hashtable(); 
        string L1word = ""; 
        string L2word = ""; 
        int start = 0; 

        for (int i = 0; i < s.Length; i++)
        {
            if (!ht.ContainsKey(s[i]))
            {
                L1word += s[i];
                ht[s[i]] = i; 
            }
            else
            {
                if (L1word.Length > L2word.Length)
                {
                    L2word = L1word;
                }
                start = (int)ht[s[i]] + 1; 
                L1word = s.Substring(start, i - start + 1);       
                ht.Clear();
                for (int j = start; j <= i; j++)
                {
                    ht[s[j]] = j; 
                }
            }
        }
        if (L1word.Length > L2word.Length)
        {
            L2word = L1word;
        }
       return L2word.Length;
    }
}

        
    
