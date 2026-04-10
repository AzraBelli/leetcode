using System.Text.RegularExpressions;
public class Solution {
    public bool IsMatch(string s, string p) {
        
        return Regex.Match(s, p).Value.Equals(s);
        
    }
}