public class Solution {
    public string MinWindow(string s, string t) {
            if (t.Length > s.Length)
                return "";
            else if (string.Compare(s, t) == 0)
                return s;

            int left = 0;
            int right = 0;

            int minLength = int.MaxValue;
            (int, int) minLengthStringIndices = (0, 0);

            var set1 = new int[52];
            var set2 = new int[52];

            foreach (var c in t)
            {
                if(c >= 65 && c < 92)
                    set1[c - 65]++;
                else
                    set1[c - 97 + 26]++;
            }

            while (left < s.Length)
            {
                if (isWindowValid())
                {
                    if (right - left < minLength)
                    {
                        minLength = right - left;
                        minLengthStringIndices = (left, right);
                    }
                    if (s[left] >= 65 && s[left] < 92)
                        set2[s[left] - 65]--;
                    else
                        set2[s[left] - 97 + 26]--;

                    left++;
                }
                else
                {
                    if (right >= s.Length)
                        break;

                    if (s[right] >= 65 && s[right] < 92)
                        set2[s[right] - 65]++;
                    else
                        set2[s[right] - 97 + 26]++;

                    right++;
                }
            }

            bool isWindowValid()
            {
                int counter = 0;
                while (counter < 52)
                {
                    if (!(set1[counter] == set2[counter] || set1[counter] <= set2[counter]))
                        return false;
                    counter++;
                }
                return true;
            }

            return s[minLengthStringIndices.Item1..minLengthStringIndices.Item2];
    }
}