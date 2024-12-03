public class Solution {

    Dictionary<int, string> dictionary = new Dictionary<int, string>
            {
                {2, "abc"},
                {3, "def"},
                {4, "ghi"},
                {5, "jkl"},
                {6, "mno"},
                {7, "pqrs"},
                {8, "tuv"},
                {9, "wxyz"}
            };

    public IList<string> LetterCombinations(string digits) {
        
        if(string.IsNullOrEmpty(digits))
            return Array.Empty<string>();

        var prev = ToStringArray(digits, 0);

        if(digits.Length == 1)
        {
            return prev.ToList();
        }

        for(int i = 1; i < digits.Length; i++)
        {
            prev = Combine(prev, ToStringArray(digits, i));
        }

        return prev.ToList();
    }

    private IEnumerable<string> ToStringArray(string digits, int p)
    {
        return dictionary[digits[p] - '0'].Select(x => x.ToString());
    }

    private IEnumerable<string> Combine(IEnumerable<string> str1, IEnumerable<string> str2)
    {
    	var arr1 = str1.ToArray();
	    var arr2 = str2.ToArray();
	    for (int i = 0; i < arr1.Length; i++)
		    for (int j = 0; j < arr2.Length; j++)
			    yield return arr1[i] + arr2[j];
    }
}