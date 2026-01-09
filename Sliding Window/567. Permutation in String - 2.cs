public class Solution {
    public bool CheckInclusion(string s1, string s2) {
        if (s1.Length > s2.Length)
            return false;
        else if (string.Compare(s1, s2) == 0)
            return true;
        
        var set1 = new int[26];

        var set2 = new int[26];

        foreach (var c in s1)
        {
            set1[c - 97]++;
        }

        int left = 0;
        int right = 0;

        while (right != s1.Length)
        {
            set2[s2[right] - 97]++;

            right++;
        }

        int counter = 0;
        int matchCount = 0;

        for (; right < s2.Length; right++)
        {
            counter = 0;
            matchCount = 0;
            while (counter < 26)
            {
                if (set1[counter] == set2[counter])
                    matchCount++;
                counter++;
            }
            if (matchCount == 26)
                return true;


            set2[s2[left++] - 97]--;
            set2[s2[right] - 97]++;
        }

        counter = 0;
        matchCount = 0;
        while (counter < 26)
        {
            if (set1[counter] == set2[counter])
                matchCount++;
            counter++;
        }
        if (matchCount == 26)
            return true;

        return false;
    }
}