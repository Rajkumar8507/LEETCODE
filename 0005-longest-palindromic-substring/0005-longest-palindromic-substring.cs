public class Solution
{
    public string LongestPalindrome(string s)
    {
        int maxlength = 1; // Tracks the length of the longest palindrome found
        int n = s.Length;  // Length of the input string
        int st = 0, end = 0; // Start and end indices of the longest palindrome

        // Loop to consider each index as the center of the palindrome
        for (int i = 0; i < n; ++i)
        {
            // Odd-length palindrome (centered at a single character)
            int l = i, r = i;
            while (l >= 0 && r < n && s[l] == s[r])
            {
                int len = r - l + 1;
                if (len > maxlength)
                {
                    maxlength = len;
                    st = l;
                    end = r;
                }
                l--;
                r++;
            }

            // Even-length palindrome (centered between two characters)
            l = i;
            r = i + 1;
            while (l >= 0 && r < n && s[l] == s[r])
            {
                int len = r - l + 1;
                if (len > maxlength)
                {
                    maxlength = len;
                    st = l;
                    end = r;
                }
                l--;
                r++;
            }
        }

        // Extract and return the longest palindromic substring
        return s.Substring(st, maxlength);
    }
}
