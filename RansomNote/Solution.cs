namespace RansomNote
{
    /// <summary>
    /// LeetCode problem: https://leetcode.com/problems/ransom-note/description/
    /// </summary>
    public class Solution
    {
        public static bool CanConstruct(string ransomNote, string magazine)
        {
            foreach (var letter in ransomNote)
            {
                if (!magazine.Contains(letter))
                {
                    return false;
                }
                else
                {
                    magazine = magazine.Remove(magazine.IndexOf(letter), 1);
                }
            }
            
            return true;
        }
    }
}
