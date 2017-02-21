public class Solution {

        public IList<IList<int>> PalindromePairs(string[] words)
		{
		
			Dictionary<string, int> StringMap = new Dictionary<string, int>();
            IList<IList<int>> list = new List<IList<int>>();

            SortedSet<int> set = new SortedSet<int>();

            if (words == null || words.Length < 2)
            {
                return list;
            }

            for (int i = 0; i < words.Length; i++)
            {
                StringMap.Add(words[i], i);
                set.Add(words[i].Length);
            }


            for (int i = 0; i < words.Length - 1; i++)
            {
                string reverseStr = new string(words[i].ToArray().Reverse().ToArray());
                int lengthOfStr = reverseStr.Length;

                if (StringMap.ContainsKey(reverseStr) && StringMap[reverseStr] != i)
                {
                    list.Add(new List<int>() { i, StringMap[reverseStr] });
                }

                foreach (int len in set)
                {
                    if (len > lengthOfStr)
                    {
                        break;
                    }

                    string subLeft = reverseStr.Substring(0, lengthOfStr - len);
                    string subRight = reverseStr.Substring(lengthOfStr - len);

                    if (IsStringPalindrome(subLeft) && StringMap.ContainsKey(subRight))
                    {
                        list.Add(new List<int>() { i, StringMap[subRight] });
                    }

                    if (IsStringPalindrome(subRight) && StringMap.ContainsKey(subLeft))
                    {
                        list.Add(new List<int>() { StringMap[subRight], i });
                    }
                }
            }

            return list;
        }

        private bool IsStringPalindrome(String str)
        {
            int left = 0;
            int right = str.Length - 1;

            while (right - left > 0)
            {
                if (str[left] != str[right])
                {
                    return false;
                }

                left++;
                right--;
            }

            return true;
        }
}